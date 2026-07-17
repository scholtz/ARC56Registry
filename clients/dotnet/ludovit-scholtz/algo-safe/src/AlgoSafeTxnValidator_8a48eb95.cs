using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.ludovit_scholtz.algo_safe.AlgoSafeTxnValidator_8a48eb95
{


    //
    // AlgoSafeTxnValidator — stateless, immutable payload-validation library for AlgoSafe.
    //
    //The AlgoSafe contract calls `validateTxn` via an inner application call for
    //every payment / asset-transfer / keyreg / asset-config / rekey entry in a
    //transaction-group proposal before staging the inner transactions. Moving this
    //pure validation logic out of the safe frees approval-program bytes there (the
    //safe sits against the AVM's 8 192-byte ceiling) and concentrates the
    //validation rules in one small contract that can be audited once and reused by
    //every safe on the network.
    //
    //Immutability: this contract declares no update or delete handlers, so the
    //ARC-4 router rejects UpdateApplication and DeleteApplication permanently.
    //The safe pins this contract by *bytecode hash* (sha256 of the compiled
    //approval program) at createApplication time — any app ID whose bytecode
    //matches the pinned hash is this exact program forever, which is why the safe
    //only needs to verify the hash once.
    //
    //Statelessness: no global/local/box state; app calls are the only surface.
    //The app account never needs funding.
    //
    //TX_APP entries are intentionally NOT handled here: an app-call payload can
    //legitimately carry up to 2 048 bytes of appArgs, which cannot fit through the
    //inner-app-call argument limit (2 048 bytes total including selector). The
    //safe validates TX_APP locally — it must enforce those same size limits anyway.
    //
    public class AlgoSafeTxnValidatorProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AlgoSafeTxnValidatorProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ValidateTxnReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public Algorand.Address Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ValidateTxnReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ValidateTxnReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is Algorand.Address vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ValidateTxnReturn);
                }
                public bool Equals(ValidateTxnReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ValidateTxnReturn left, ValidateTxnReturn right)
                {
                    return EqualityComparer<ValidateTxnReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(ValidateTxnReturn left, ValidateTxnReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///validateTxn — decode and validate one SafeTxn envelope entry.
        ///</summary>
        /// <param name="txType">TX_* tag of the entry (TX_APP is rejected — handled in the safe) </param>
        /// <param name="data">ARC4-encoded payload struct for that type </param>
        /// <param name="allowedActions">the executing group's ACT_* bitmask </param>
        /// <param name="adminPrivileges">the executing group's PRIV_* bitmask </param>
        /// <param name="groupType">the executing group's GT_* discriminator </param>
        public async Task<Structs.ValidateTxnReturn> ValidateTxn(ulong txType, byte[] data, ulong allowedActions, ulong adminPrivileges, ulong groupType, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 28, 213, 165 };
            var txTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); txTypeAbi.From(txType);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);
            var allowedActionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); allowedActionsAbi.From(allowedActions);
            var adminPrivilegesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); adminPrivilegesAbi.From(adminPrivileges);
            var groupTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); groupTypeAbi.From(groupType);

            var result = await base.SimApp(new List<object> { abiHandle, txTypeAbi, dataAbi, allowedActionsAbi, adminPrivilegesAbi, groupTypeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ValidateTxnReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ValidateTxn_Transactions(ulong txType, byte[] data, ulong allowedActions, ulong adminPrivileges, ulong groupType, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 28, 213, 165 };
            var txTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); txTypeAbi.From(txType);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);
            var allowedActionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); allowedActionsAbi.From(allowedActions);
            var adminPrivilegesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); adminPrivilegesAbi.From(adminPrivileges);
            var groupTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); groupTypeAbi.From(groupType);

            return await base.MakeTransactionList(new List<object> { abiHandle, txTypeAbi, dataAbi, allowedActionsAbi, adminPrivilegesAbi, groupTypeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWxnb1NhZmVUeG5WYWxpZGF0b3IiLCJkZXNjIjoiQWxnb1NhZmVUeG5WYWxpZGF0b3Ig4oCUIHN0YXRlbGVzcywgaW1tdXRhYmxlIHBheWxvYWQtdmFsaWRhdGlvbiBsaWJyYXJ5IGZvciBBbGdvU2FmZS5cblxuVGhlIEFsZ29TYWZlIGNvbnRyYWN0IGNhbGxzIGB2YWxpZGF0ZVR4bmAgdmlhIGFuIGlubmVyIGFwcGxpY2F0aW9uIGNhbGwgZm9yXG5ldmVyeSBwYXltZW50IC8gYXNzZXQtdHJhbnNmZXIgLyBrZXlyZWcgLyBhc3NldC1jb25maWcgLyByZWtleSBlbnRyeSBpbiBhXG50cmFuc2FjdGlvbi1ncm91cCBwcm9wb3NhbCBiZWZvcmUgc3RhZ2luZyB0aGUgaW5uZXIgdHJhbnNhY3Rpb25zLiBNb3ZpbmcgdGhpc1xucHVyZSB2YWxpZGF0aW9uIGxvZ2ljIG91dCBvZiB0aGUgc2FmZSBmcmVlcyBhcHByb3ZhbC1wcm9ncmFtIGJ5dGVzIHRoZXJlICh0aGVcbnNhZmUgc2l0cyBhZ2FpbnN0IHRoZSBBVk0ncyA4IDE5Mi1ieXRlIGNlaWxpbmcpIGFuZCBjb25jZW50cmF0ZXMgdGhlXG52YWxpZGF0aW9uIHJ1bGVzIGluIG9uZSBzbWFsbCBjb250cmFjdCB0aGF0IGNhbiBiZSBhdWRpdGVkIG9uY2UgYW5kIHJldXNlZCBieVxuZXZlcnkgc2FmZSBvbiB0aGUgbmV0d29yay5cblxuSW1tdXRhYmlsaXR5OiB0aGlzIGNvbnRyYWN0IGRlY2xhcmVzIG5vIHVwZGF0ZSBvciBkZWxldGUgaGFuZGxlcnMsIHNvIHRoZVxuQVJDLTQgcm91dGVyIHJlamVjdHMgVXBkYXRlQXBwbGljYXRpb24gYW5kIERlbGV0ZUFwcGxpY2F0aW9uIHBlcm1hbmVudGx5LlxuVGhlIHNhZmUgcGlucyB0aGlzIGNvbnRyYWN0IGJ5ICpieXRlY29kZSBoYXNoKiAoc2hhMjU2IG9mIHRoZSBjb21waWxlZFxuYXBwcm92YWwgcHJvZ3JhbSkgYXQgY3JlYXRlQXBwbGljYXRpb24gdGltZSDigJQgYW55IGFwcCBJRCB3aG9zZSBieXRlY29kZVxubWF0Y2hlcyB0aGUgcGlubmVkIGhhc2ggaXMgdGhpcyBleGFjdCBwcm9ncmFtIGZvcmV2ZXIsIHdoaWNoIGlzIHdoeSB0aGUgc2FmZVxub25seSBuZWVkcyB0byB2ZXJpZnkgdGhlIGhhc2ggb25jZS5cblxuU3RhdGVsZXNzbmVzczogbm8gZ2xvYmFsL2xvY2FsL2JveCBzdGF0ZTsgYXBwIGNhbGxzIGFyZSB0aGUgb25seSBzdXJmYWNlLlxuVGhlIGFwcCBhY2NvdW50IG5ldmVyIG5lZWRzIGZ1bmRpbmcuXG5cblRYX0FQUCBlbnRyaWVzIGFyZSBpbnRlbnRpb25hbGx5IE5PVCBoYW5kbGVkIGhlcmU6IGFuIGFwcC1jYWxsIHBheWxvYWQgY2FuXG5sZWdpdGltYXRlbHkgY2FycnkgdXAgdG8gMiAwNDggYnl0ZXMgb2YgYXBwQXJncywgd2hpY2ggY2Fubm90IGZpdCB0aHJvdWdoIHRoZVxuaW5uZXItYXBwLWNhbGwgYXJndW1lbnQgbGltaXQgKDIgMDQ4IGJ5dGVzIHRvdGFsIGluY2x1ZGluZyBzZWxlY3RvcikuIFRoZVxuc2FmZSB2YWxpZGF0ZXMgVFhfQVBQIGxvY2FsbHkg4oCUIGl0IG11c3QgZW5mb3JjZSB0aG9zZSBzYW1lIHNpemUgbGltaXRzIGFueXdheS4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVmFsaWRhdGVUeG5SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoiYWRkcmVzcyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ2YWxpZGF0ZVR4biIsImRlc2MiOiJ2YWxpZGF0ZVR4biDigJQgZGVjb2RlIGFuZCB2YWxpZGF0ZSBvbmUgU2FmZVR4biBlbnZlbG9wZSBlbnRyeS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhUeXBlIiwiZGVzYyI6IlRYXyogdGFnIG9mIHRoZSBlbnRyeSAoVFhfQVBQIGlzIHJlamVjdGVkIOKAlCBoYW5kbGVkIGluIHRoZSBzYWZlKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOiJBUkM0LWVuY29kZWQgcGF5bG9hZCBzdHJ1Y3QgZm9yIHRoYXQgdHlwZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWxsb3dlZEFjdGlvbnMiLCJkZXNjIjoidGhlIGV4ZWN1dGluZyBncm91cCdzIEFDVF8qIGJpdG1hc2siLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluUHJpdmlsZWdlcyIsImRlc2MiOiJ0aGUgZXhlY3V0aW5nIGdyb3VwJ3MgUFJJVl8qIGJpdG1hc2siLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imdyb3VwVHlwZSIsImRlc2MiOiJ0aGUgZXhlY3V0aW5nIGdyb3VwJ3MgR1RfKiBkaXNjcmltaW5hdG9yIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCxhZGRyZXNzKSIsInN0cnVjdCI6IlZhbGlkYXRlVHhuUmV0dXJuIiwiZGVzYyI6Ilthc3NldElkLCBhbW91bnQsIGhhc0Nsb3NlLCBzZW5kZXJdIOKAlCB0aGUgc3BlbmRpbmctYWNjb3VudGluZ1xuc3VtbWFyeSBmb3IgdGhlIHNhZmU6IGFzc2V0SWQgMCA9IEFMR087IGFtb3VudCBpcyB0aGUgZGVjbGFyZWQgYW1vdW50XG4oMCBmb3Igbm9uLXZhbHVlLW1vdmluZyB0eXBlcyk7IGhhc0Nsb3NlIG5vbnplcm8gbWVhbnMgdGhlIHNhZmUgbXVzdFxucmVhZCB0aGUgbGl2ZSBiYWxhbmNlIChjbG9zZS1vdXQgc3dlZXBzIGV2ZXJ5dGhpbmcpOyBzZW5kZXIgemVybyBhZGRyZXNzXG5tZWFucyB0aGUgc2FmZSdzIG93biBhcHAgYWNjb3VudC4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTAyXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0Ml0sImVycm9yTWVzc2FnZSI6ImFjZmcgbm90IGFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODZdLCJlcnJvck1lc3NhZ2UiOiJhc3NldCBjbG9zZSB0YXJnZXQgcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjBdLCJlcnJvck1lc3NhZ2UiOiJhc3NldCBpZCByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2OF0sImVycm9yTWVzc2FnZSI6ImFzc2V0IHJlY2VpdmVyIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUwXSwiZXJyb3JNZXNzYWdlIjoiYXhmZXIgbm90IGFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDZdLCJlcnJvck1lc3NhZ2UiOiJjbG9zZSB0YXJnZXQgcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDRdLCJlcnJvck1lc3NhZ2UiOiJjdXN0b2RpYW4gZ3JvdXBzIGNhbm5vdCByZWtleSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTYsMTQ2LDE1NiwxNjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjRdLCJlcnJvck1lc3NhZ2UiOiJrZXlyZWcgbm90IGFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzVdLCJlcnJvck1lc3NhZ2UiOiJtZXRhZGF0YUhhc2ggbXVzdCBiZSAwIG9yIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc4XSwiZXJyb3JNZXNzYWdlIjoicGF5IG5vdCBhbGxvd2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg4XSwiZXJyb3JNZXNzYWdlIjoicmVjZWl2ZXIgcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTVdLCJlcnJvck1lc3NhZ2UiOiJyZWtleSBub3QgYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMF0sImVycm9yTWVzc2FnZSI6InJla2V5IHJlcXVpcmVzIGdyb3VwIGFkbWluIHByaXZpbGVnZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxM10sImVycm9yTWVzc2FnZSI6InJla2V5IHRhcmdldCByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4OV0sImVycm9yTWVzc2FnZSI6InVua25vd24gdHggdHlwZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBNElEQWdNZ29nSUNBZ1lubDBaV05pYkc5amF5QmlZWE5sTXpJb1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQktRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMkZtWlY5MllXeHBaR0YwYjNJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZzWjI5VFlXWmxWSGh1Vm1Gc2FXUmhkRzl5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEVUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHVXpNV05rTldFMUlDOHZJRzFsZEdodlpDQWlkbUZzYVdSaGRHVlVlRzRvZFdsdWREWTBMR0o1ZEdWYlhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1lXUmtjbVZ6Y3lraUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNaaGJHbGtZWFJsVkhodVgzSnZkWFJsUURNS0lDQWdJR1Z5Y2dvS2JXRnBibDkyWVd4cFpHRjBaVlI0Ymw5eWIzVjBaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyRm1aVjkyWVd4cFpHRjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHSWdkbUZzYVdSaGRHVlVlRzRLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6WVdabFgzWmhiR2xrWVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTVDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVd4bmIxTmhabVZVZUc1V1lXeHBaR0YwYjNJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdJQ1ltSUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOaFptVmZkbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZzWjI5VFlXWmxWSGh1Vm1Gc2FXUmhkRzl5TG5aaGJHbGtZWFJsVkhodVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbUZzYVdSaGRHVlVlRzQ2Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHUjFjRzRnTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyRm1aVjkyWVd4cFpHRjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSE4zWVhBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTmhabVZmZG1Gc2FXUmhkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpJS0lDQWdJQzh2SUdsbUlDaDBlRlI1Y0dVZ1BUMDlJRlJZWDFCQldVMUZUbFFwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2dkbUZzYVdSaGRHVlVlRzVmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6WVdabFgzWmhiR2xrWVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QmhjM05sY25Rb0tHRnNiRzkzWldSQlkzUnBiMjV6SUNZZ1FVTlVYMUJCV1NrZ0lUMDlJRlZwYm5RMk5DZ3dLU3dnSjNCaGVTQnViM1FnWVd4c2IzZGxaQ2NwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDWUtJQ0FnSUdGemMyVnlkQ0F2THlCd1lYa2dibTkwSUdGc2JHOTNaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOaFptVmZkbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBlQzV5WldObGFYWmxjaUFoUFQwZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxDQW5jbVZqWldsMlpYSWdjbVZ4ZFdseVpXUW5LUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBek5DQXpNZ29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJSEpsWTJWcGRtVnlJSEpsY1hWcGNtVmtDaUFnSUNCd2RYTm9hVzUwSURjMElDOHZJRGMwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5ellXWmxYM1poYkdsa1lYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJwWmlBb2RIZ3VhR0Z6UTJ4dmMyVWdJVDA5SUZWcGJuUTJOQ2d3S1NrZ2V3b2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNQW9nSUNBZ1lub2dkbUZzYVdSaGRHVlVlRzVmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6WVdabFgzWmhiR2xrWVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzNDaUFnSUNBdkx5QmhjM05sY25Rb2RIZ3VZMnh2YzJWU1pXMWhhVzVrWlhKVWJ5QWhQVDBnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TENBblkyeHZjMlVnZEdGeVoyVjBJSEpsY1hWcGNtVmtKeWtLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmxlSFJ5WVdOMElEZ3lJRE15Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnWTJ4dmMyVWdkR0Z5WjJWMElISmxjWFZwY21Wa0NncDJZV3hwWkdGMFpWUjRibDloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6WVdabFgzWmhiR2xrWVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzVDaUFnSUNBdkx5QnlaWFIxY200Z1cxVnBiblEyTkNnd0tTd2dkSGd1WVcxdmRXNTBMQ0IwZUM1b1lYTkRiRzl6WlN3Z2RIZ3VjMlZ1WkdWeVhRb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EyTmlBNENpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRElnTXpJS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREV3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb0tkbUZzYVdSaGRHVlVlRzVmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6WVdabFgzWmhiR2xrWVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJiR2R2VTJGbVpWUjRibFpoYkdsa1lYUnZjaTUyWVd4cFpHRjBaVlI0YmtBeU1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM05oWm1WZmRtRnNhV1JoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3AyWVd4cFpHRjBaVlI0Ymw5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5ellXWmxYM1poYkdsa1lYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd4Q2lBZ0lDQXZMeUJwWmlBb2RIaFVlWEJsSUQwOVBTQlVXRjlCVTFORlZDa2dld29nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWW5vZ2RtRnNhV1JoZEdWVWVHNWZZV1owWlhKZmFXWmZaV3h6WlVBNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpZV1psWDNaaGJHbGtZWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCaGMzTmxjblFvS0dGc2JHOTNaV1JCWTNScGIyNXpJQ1lnUVVOVVgwRllSa1ZTS1NBaFBUMGdWV2x1ZERZMEtEQXBMQ0FuWVhobVpYSWdibTkwSUdGc2JHOTNaV1FuS1FvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQW1DaUFnSUNCaGMzTmxjblFnTHk4Z1lYaG1aWElnYm05MElHRnNiRzkzWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTmhabVZmZG1Gc2FXUmhkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUdGemMyVnlkQ2gwZUM1NFptVnlRWE56WlhRZ0lUMDlJRlZwYm5RMk5DZ3dLU3dnSjJGemMyVjBJR2xrSUhKbGNYVnBjbVZrSnlrS0lDQWdJR1JwWnlBMENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNelFnTHk4Z016UUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZENCcFpDQnlaWEYxYVhKbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMkZtWlY5MllXeHBaR0YwYjNJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSNExtRnpjMlYwVW1WalpXbDJaWElnSVQwOUlFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d2dKMkZ6YzJWMElISmxZMlZwZG1WeUlISmxjWFZwY21Wa0p5a0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwTWlBek1nb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlYwSUhKbFkyVnBkbVZ5SUhKbGNYVnBjbVZrQ2lBZ0lDQndkWE5vYVc1MElEZ3lJQzh2SURneUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpZV1psWDNaaGJHbGtZWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMkNpQWdJQ0F2THlCcFppQW9kSGd1YUdGelFYTnpaWFJEYkc5elpTQWhQVDBnVldsdWREWTBLREFwS1NCN0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEZ0tJQ0FnSUdKNklIWmhiR2xrWVhSbFZIaHVYMkZtZEdWeVgybG1YMlZzYzJWQU9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMkZtWlY5MllXeHBaR0YwYjNJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z1lYTnpaWEowS0hSNExtRnpjMlYwUTJ4dmMyVlVieUFoUFQwZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxDQW5ZWE56WlhRZ1kyeHZjMlVnZEdGeVoyVjBJSEpsY1hWcGNtVmtKeWtLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmxlSFJ5WVdOMElEa3dJRE15Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYUWdZMnh2YzJVZ2RHRnlaMlYwSUhKbGNYVnBjbVZrQ2dwMllXeHBaR0YwWlZSNGJsOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpZV1psWDNaaGJHbGtZWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnNUNpQWdJQ0F2THlCeVpYUjFjbTRnVzNSNExuaG1aWEpCYzNObGRDd2dkSGd1WVhOelpYUkJiVzkxYm5Rc0lIUjRMbWhoYzBGemMyVjBRMnh2YzJVc0lIUjRMbk5sYm1SbGNsMEtJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTnpRZ09Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURNeUNpQWdJQ0JrYVdjZ09Rb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBNENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzJGbVpWOTJZV3hwWkdGMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmlJSFpoYkdsa1lYUmxWSGh1WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzJGbVpWOTJZV3hwWkdGMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRV3huYjFOaFptVlVlRzVXWVd4cFpHRjBiM0l1ZG1Gc2FXUmhkR1ZVZUc1QU1qQUtDblpoYkdsa1lYUmxWSGh1WDJGbWRHVnlYMmxtWDJWc2MyVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOaFptVmZkbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVEVLSUNBZ0lDOHZJR2xtSUNoMGVGUjVjR1VnUFQwOUlGUllYMHRGV1ZKRlJ5a2dld29nSUNBZ1pHbG5JRFVLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUEwQ2lBZ0lDQTlQUW9nSUNBZ1lub2dkbUZzYVdSaGRHVlVlRzVmWVdaMFpYSmZhV1pmWld4elpVQXhNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzJGbVpWOTJZV3hwWkdGMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNd29nSUNBZ0x5OGdZWE56WlhKMEtDaGhiR3h2ZDJWa1FXTjBhVzl1Y3lBbUlFRkRWRjlMUlZsU1JVY3BJQ0U5UFNCVmFXNTBOalFvTUNrc0lDZHJaWGx5WldjZ2JtOTBJR0ZzYkc5M1pXUW5LUW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBbUNpQWdJQ0JoYzNObGNuUWdMeThnYTJWNWNtVm5JRzV2ZENCaGJHeHZkMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5ellXWmxYM1poYkdsa1lYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamswQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdXMVZwYm5RMk5DZ3dLU3dnVldsdWREWTBLREFwTENCVmFXNTBOalFvTUNrc0lFZHNiMkpoYkM1NlpYSnZRV1JrY21WemMxMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z1ltRnpaVE15S0VGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVNrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTmhabVZmZG1Gc2FXUmhkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWWlCMllXeHBaR0YwWlZSNGJsOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTmhabVZmZG1Gc2FXUmhkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGc1oyOVRZV1psVkhodVZtRnNhV1JoZEc5eUxuWmhiR2xrWVhSbFZIaHVRREl3Q2dwMllXeHBaR0YwWlZSNGJsOWhablJsY2w5cFpsOWxiSE5sUURFeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMkZtWlY5MllXeHBaR0YwYjNJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5nb2dJQ0FnTHk4Z2FXWWdLSFI0Vkhsd1pTQTlQVDBnVkZoZlFVTkdSeWtnZXdvZ0lDQWdaR2xuSURVS0lDQWdJSEIxYzJocGJuUWdOU0F2THlBMUNpQWdJQ0E5UFFvZ0lDQWdZbm9nZG1Gc2FXUmhkR1ZVZUc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyRm1aVjkyWVd4cFpHRjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81T0FvZ0lDQWdMeThnWVhOelpYSjBLQ2hoYkd4dmQyVmtRV04wYVc5dWN5QW1JRUZEVkY5QlEwWkhLU0FoUFQwZ1ZXbHVkRFkwS0RBcExDQW5ZV05tWnlCdWIzUWdZV3hzYjNkbFpDY3BDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBeE5pQXZMeUF4TmdvZ0lDQWdKZ29nSUNBZ1lYTnpaWEowSUM4dklHRmpabWNnYm05MElHRnNiRzkzWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTmhabVZmZG1Gc2FXUmhkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBd0NpQWdJQ0F2THlCMGVDNXRaWFJoWkdGMFlVaGhjMmd1YkdWdVozUm9JRDA5UFNCVmFXNTBOalFvTUNrZ2ZId2dkSGd1YldWMFlXUmhkR0ZJWVhOb0xteGxibWQwYUNBOVBUMGdWV2x1ZERZMEtETXlLU3dLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ016Z2dMeThnTXpnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4TmpnZ0x5OGdNVFk0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXhDaUFnSUNCaWVpQjJZV3hwWkdGMFpWUjRibDlpYjI5c1gzUnlkV1ZBTVRRS0lDQWdJR1JwWnlBNUNpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWW5vZ2RtRnNhV1JoZEdWVWVHNWZZbTl2YkY5bVlXeHpaVUF4TlFvS2RtRnNhV1JoZEdWVWVHNWZZbTl2YkY5MGNuVmxRREUwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLQ25aaGJHbGtZWFJsVkhodVgySnZiMnhmYldWeVoyVkFNVFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5ellXWmxYM1poYkdsa1lYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPams1TFRFd01nb2dJQ0FnTHk4Z1lYTnpaWEowS0FvZ0lDQWdMeThnSUNCMGVDNXRaWFJoWkdGMFlVaGhjMmd1YkdWdVozUm9JRDA5UFNCVmFXNTBOalFvTUNrZ2ZId2dkSGd1YldWMFlXUmhkR0ZJWVhOb0xteGxibWQwYUNBOVBUMGdWV2x1ZERZMEtETXlLU3dLSUNBZ0lDOHZJQ0FnSjIxbGRHRmtZWFJoU0dGemFDQnRkWE4wSUdKbElEQWdiM0lnTXpJZ1lubDBaWE1uTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWE56WlhKMElDOHZJRzFsZEdGa1lYUmhTR0Z6YUNCdGRYTjBJR0psSURBZ2IzSWdNeklnWW5sMFpYTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM05oWm1WZmRtRnNhV1JoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXpDaUFnSUNBdkx5QnlaWFIxY200Z1cxVnBiblEyTkNnd0tTd2dWV2x1ZERZMEtEQXBMQ0JWYVc1ME5qUW9NQ2tzSUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6YzEwS0lDQWdJR0o1ZEdWalh6QWdMeThnWW1GelpUTXlLRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRU2tLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOaFptVmZkbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZaUIyWVd4cFpHRjBaVlI0Ymw5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOaFptVmZkbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZzWjI5VFlXWmxWSGh1Vm1Gc2FXUmhkRzl5TG5aaGJHbGtZWFJsVkhodVFESXdDZ3AyWVd4cFpHRjBaVlI0Ymw5aWIyOXNYMlpoYkhObFFERTFPZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdJZ2RtRnNhV1JoZEdWVWVHNWZZbTl2YkY5dFpYSm5aVUF4TmdvS2RtRnNhV1JoZEdWVWVHNWZZV1owWlhKZmFXWmZaV3h6WlVBeE56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM05oWm1WZmRtRnNhV1JoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTFDaUFnSUNBdkx5QnBaaUFvZEhoVWVYQmxJRDA5UFNCVVdGOVNSVXRGV1NrZ2V3b2dJQ0FnWkdsbklEVUtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QTJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhWdWEyNXZkMjRnZEhnZ2RIbHdaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzJGbVpWOTJZV3hwWkdGMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDZ29ZV3hzYjNkbFpFRmpkR2x2Ym5NZ0ppQkJRMVJmVWtWTFJWa3BJQ0U5UFNCVmFXNTBOalFvTUNrc0lDZHlaV3RsZVNCdWIzUWdZV3hzYjNkbFpDY3BDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdKZ29nSUNBZ1lYTnpaWEowSUM4dklISmxhMlY1SUc1dmRDQmhiR3h2ZDJWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpZV1psWDNaaGJHbGtZWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0NoaFpHMXBibEJ5YVhacGJHVm5aWE1nSmlCUVVrbFdYMGRTVDFWUUtTQWhQVDBnVldsdWREWTBLREFwTENBbmNtVnJaWGtnY21WeGRXbHlaWE1nWjNKdmRYQWdZV1J0YVc0Z2NISnBkbWxzWldkbEp5a0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnSmdvZ0lDQWdZWE56WlhKMElDOHZJSEpsYTJWNUlISmxjWFZwY21WeklHZHliM1Z3SUdGa2JXbHVJSEJ5YVhacGJHVm5aUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzJGbVpWOTJZV3hwWkdGMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVElLSUNBZ0lDOHZJR0Z6YzJWeWRDaG5jbTkxY0ZSNWNHVWdJVDA5SUVkVVgwTlZVMVJQUkVsQlRpd2dKMk4xYzNSdlpHbGhiaUJuY205MWNITWdZMkZ1Ym05MElISmxhMlY1SnlrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1kzVnpkRzlrYVdGdUlHZHliM1Z3Y3lCallXNXViM1FnY21WclpYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM05oWm1WZmRtRnNhV1JoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXpDaUFnSUNBdkx5QmhjM05sY25Rb2RIZ3VjbVZyWlhsVWJ5QWhQVDBnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TENBbmNtVnJaWGtnZEdGeVoyVjBJSEpsY1hWcGNtVmtKeWtLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmxlSFJ5WVdOMElETTBJRE15Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnY21WclpYa2dkR0Z5WjJWMElISmxjWFZwY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpZV1psWDNaaGJHbGtZWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZ0VmFXNTBOalFvTUNrc0lGVnBiblEyTkNnd0tTd2dWV2x1ZERZMEtEQXBMQ0JIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM05kQ2lBZ0lDQmllWFJsWTE4d0lDOHZJR0poYzJVek1paEJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6WVdabFgzWmhiR2xrWVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSWdkbUZzYVdSaGRHVlVlRzVmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6WVdabFgzWmhiR2xrWVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJiR2R2VTJGbVpWUjRibFpoYkdsa1lYUnZjaTUyWVd4cFpHRjBaVlI0YmtBeU1Bbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUWdBQWlZQk9BQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFNUnRCQUJpQUJPTWMxYVUyR2dDT0FRQUJBREVaRkRFWUVFUkNBQW94R1JReEdCUVFSQ0pEZ0FCSEF6WWFBVWtWSXhKRUYwazJHZ0pKVGdKSkpGa2xDRXNCRlJKRVZ3SUFURFlhQTBrVkl4SkVGMHcyR2dSSkZTTVNSQmRNTmhvRlNSVWpFa1FYVENJU1FRQkJTd0lpR2tSTEJFbFhJaUF5QXhORWdVcGJTVVVLUVFBSlN3UlhVaUF5QXhORVN3UkpWMElJVEZjQ0lDUVdUd0pRU3dvV1VFeFFnQVFWSDN4MVRGQ3dJa05MQlNVU1FRQkNTd0lsR2tSTEJFbUJJbHRKUlFwRVNWY3FJRElERTBTQlVsdEpSUWhCQUFsTEJGZGFJRElERTBSTEJFbFhTZ2hNVndJZ1N3a1dUd0pRU3dnV1VFeFFRditzU3dXQkJCSkJBQWxMQWlNYVJDaEMvNXRMQllFRkVrRUFMMHNDZ1JBYVJFc0RTWUVtV1VzQmdhZ0JXVkpYQWdBVlNVVUxRUUFJU3dtQklCSkJBQVlpUkNoQy8yZ2tRdi8zU3dXQkJoSkVTd0tCSUJwRVN3RWlHa1JKSWhORVN3UlhJaUF5QXhORUtFTC9RZz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
