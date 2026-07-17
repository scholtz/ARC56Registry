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

namespace Arc56.Generated.joe_p.arc84_poc.ARC84TransferHook_2b785a08
{


    public class ARC84TransferHookProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ARC84TransferHookProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ApprovedArgTransfers : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public Algorand.Address Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static ApprovedArgTransfers Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ApprovedArgTransfers();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ApprovedArgTransfers);
                }
                public bool Equals(ApprovedArgTransfers? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ApprovedArgTransfers left, ApprovedArgTransfers right)
                {
                    return EqualityComparer<ApprovedArgTransfers>.Default.Equals(left, right);
                }
                public static bool operator !=(ApprovedArgTransfers left, ApprovedArgTransfers right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Determines whether a transfer is approved or not. This implementation always returns true, but
        ///there are other possibilities such as ERC20-style approvals, whitelists, blacklists, enforced royalties, etc.
        ///</summary>
        /// <param name="caller"> </param>
        /// <param name="transfers"> ApprovedArgTransfers</param>
        /// <param name="idx"> </param>
        public async Task<bool> Approved(Algorand.Address caller, Structs.ApprovedArgTransfers[] transfers, ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 185, 189, 69 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var transfersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ApprovedArgTransfers>(x => Structs.ApprovedArgTransfers.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; transfersAbi.From(transfers);
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            var result = await base.CallApp(new List<object> { abiHandle, callerAbi, transfersAbi, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Approved_Transactions(Algorand.Address caller, Structs.ApprovedArgTransfers[] transfers, ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 185, 189, 69 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var transfersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ApprovedArgTransfers>(x => Structs.ApprovedArgTransfers.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; transfersAbi.From(transfers);
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            return await base.MakeTransactionList(new List<object> { abiHandle, callerAbi, transfersAbi, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBUkM4NFRyYW5zZmVySG9vayIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQXBwcm92ZWRBcmdUcmFuc2ZlcnMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYXBwcm92ZWQiLCJkZXNjIjoiRGV0ZXJtaW5lcyB3aGV0aGVyIGEgdHJhbnNmZXIgaXMgYXBwcm92ZWQgb3Igbm90LiBUaGlzIGltcGxlbWVudGF0aW9uIGFsd2F5cyByZXR1cm5zIHRydWUsIGJ1dFxudGhlcmUgYXJlIG90aGVyIHBvc3NpYmlsaXRpZXMgc3VjaCBhcyBFUkMyMC1zdHlsZSBhcHByb3ZhbHMsIHdoaXRlbGlzdHMsIGJsYWNrbGlzdHMsIGVuZm9yY2VkIHJveWFsdGllcywgZXRjLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LGFkZHJlc3MsYWRkcmVzcyx1aW50NjQpW10iLCJzdHJ1Y3QiOiJBcHByb3ZlZEFyZ1RyYW5zZmVycyIsIm5hbWUiOiJ0cmFuc2ZlcnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkeCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo0In0seyJwYyI6WzEsMiwzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJjb250cmFjdHMvQVJDODRUcmFuc2Zlci5hbGdvLnRzOjQifSx7InBjIjpbNCw1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNCwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo0In0seyJwYyI6WzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJjb250cmFjdHMvQVJDODRUcmFuc2Zlci5hbGdvLnRzOjQifSx7InBjIjpbNyw4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNiwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo0In0seyJwYyI6WzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJjb250cmFjdHMvQVJDODRUcmFuc2Zlci5hbGdvLnRzOjQifSx7InBjIjpbMTAsMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJjb250cmFjdHMvQVJDODRUcmFuc2Zlci5hbGdvLnRzOjQifSx7InBjIjpbMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5LCJzb3VyY2UiOiJjb250cmFjdHMvQVJDODRUcmFuc2Zlci5hbGdvLnRzOjQifSx7InBjIjpbMTMsMTQsMTUsMTYsMTcsMTgsMTksMjAsMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJjb250cmFjdHMvQVJDODRUcmFuc2Zlci5hbGdvLnRzOjQifSx7InBjIjpbMzldLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNCwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo0In0seyJwYyI6WzQwLDQxLDQyLDQzLDQ0LDQ1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyOSwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzQ2LDQ3LDQ4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMiwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzQ5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzUwLDUxLDUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzUzLDU0LDU1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNywic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzU2LDU3LDU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MCwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MSwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzYwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Miwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzYxLDYyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Mywic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzYzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0NCwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzY0XSwiZXJyb3JNZXNzYWdlIjoiYXJndW1lbnQgMiAoY2FsbGVyKSBmb3IgYXBwcm92ZWQgbXVzdCBiZSBhIGFkZHJlc3MiLCJ0ZWFsIjo0Nywic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzY1LDY2LDY3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MCwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzY4LDY5LDcwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MSwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzcxLDcyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Miwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzczLDc0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Mywic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6Wzc1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6Wzc2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NSwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6Wzc3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Niwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6Wzc4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Nywic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6Wzc5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OCwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzgwLDgxLDgyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NSwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6WzgzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OSwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo5In0seyJwYyI6Wzg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MCwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo4In0seyJwYyI6Wzg1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Mywic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo0In0seyJwYyI6Wzg2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3NCwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo0In0seyJwYyI6Wzg3LDg4LDg5LDkwLDkxLDkyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Nywic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo0In0seyJwYyI6WzkzLDk0LDk1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3OCwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo0In0seyJwYyI6Wzk2LDk3LDk4LDk5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3OSwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo0In0seyJwYyI6WzEwMF0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjgyLCJzb3VyY2UiOiJjb250cmFjdHMvQVJDODRUcmFuc2Zlci5hbGdvLnRzOjQifSx7InBjIjpbMTAxLDEwMiwxMDMsMTA0LDEwNSwxMDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg1LCJzb3VyY2UiOiJjb250cmFjdHMvQVJDODRUcmFuc2Zlci5hbGdvLnRzOjQifSx7InBjIjpbMTA3LDEwOCwxMDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg2LCJzb3VyY2UiOiJjb250cmFjdHMvQVJDODRUcmFuc2Zlci5hbGdvLnRzOjQifSx7InBjIjpbMTEwLDExMSwxMTIsMTEzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Nywic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo0In0seyJwYyI6WzExNF0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjYWxsIE5vT3AiLCJ0ZWFsIjo5MCwic291cmNlIjoiY29udHJhY3RzL0FSQzg0VHJhbnNmZXIuYWxnby50czo0In1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeENnb3ZMeUJVYUdseklGUkZRVXdnZDJGeklHZGxibVZ5WVhSbFpDQmllU0JVUlVGTVUyTnlhWEIwSUhZd0xqRXdOaTR6Q2k4dklHaDBkSEJ6T2k4dloybDBhSFZpTG1OdmJTOWhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZWRVZCVEZOamNtbHdkQW9LTHk4Z1ZHaHBjeUJqYjI1MGNtRmpkQ0JwY3lCamIyMXdiR2xoYm5RZ2QybDBhQ0JoYm1RdmIzSWdhVzF3YkdWdFpXNTBjeUIwYUdVZ1ptOXNiRzkzYVc1bklFRlNRM002SUZzZ1FWSkROQ0JkQ2dvdkx5QlVhR1VnWm05c2JHOTNhVzVuSUhSbGJpQnNhVzVsY3lCdlppQlVSVUZNSUdoaGJtUnNaU0JwYm1sMGFXRnNJSEJ5YjJkeVlXMGdabXh2ZHdvdkx5QlVhR2x6SUhCaGRIUmxjbTRnYVhNZ2RYTmxaQ0IwYnlCdFlXdGxJR2wwSUdWaGMza2dabTl5SUdGdWVXOXVaU0IwYnlCd1lYSnpaU0IwYUdVZ2MzUmhjblFnYjJZZ2RHaGxJSEJ5YjJkeVlXMGdZVzVrSUdSbGRHVnliV2x1WlNCcFppQmhJSE53WldOcFptbGpJR0ZqZEdsdmJpQnBjeUJoYkd4dmQyVmtDaTh2SUVobGNtVXNJR0ZqZEdsdmJpQnlaV1psY25NZ2RHOGdkR2hsSUU5dVEyOXRjR3hsZEdVZ2FXNGdZMjl0WW1sdVlYUnBiMjRnZDJsMGFDQjNhR1YwYUdWeUlIUm9aU0JoY0hBZ2FYTWdZbVZwYm1jZ1kzSmxZWFJsWkNCdmNpQmpZV3hzWldRS0x5OGdSWFpsY25rZ2NHOXpjMmxpYkdVZ1lXTjBhVzl1SUdadmNpQjBhR2x6SUdOdmJuUnlZV04wSUdseklISmxjSEpsYzJWdWRHVmtJR2x1SUhSb1pTQnpkMmwwWTJnZ2MzUmhkR1Z0Wlc1MENpOHZJRWxtSUhSb1pTQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvWlNCamIyNTBjbUZqZEN3Z2FYUnpJSEpsYzNCbFkzUnBkbVVnWW5KaGJtTm9JSGRwYkd3Z1ltVWdJaXBPVDFSZlNVMVFURVZOUlU1VVJVUWlJSGRvYVdOb0lHcDFjM1FnWTI5dWRHRnBibk1nSW1WeWNpSUtkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJUXB3ZFhOb2FXNTBJRFlLS2dwMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lzS2MzZHBkR05vSUNwallXeHNYMDV2VDNBZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BqY21WaGRHVmZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUUtDaXBPVDFSZlNVMVFURVZOUlU1VVJVUTZDZ2t2THlCVWFHVWdjbVZ4ZFdWemRHVmtJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdocGN5QmpiMjUwY21GamRDNGdRWEpsSUhsdmRTQjFjMmx1WnlCMGFHVWdZMjl5Y21WamRDQlBia052YlhCc1pYUmxQeUJFYVdRZ2VXOTFJSE5sZENCNWIzVnlJR0Z3Y0NCSlJEOEtDV1Z5Y2dvS0x5OGdZWEJ3Y205MlpXUW9ZV1JrY21WemN5d29kV2x1ZERZMExHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBOalFwVzEwc2RXbHVkRFkwS1dKdmIyd0tLbUZpYVY5eWIzVjBaVjloY0hCeWIzWmxaRG9LQ1M4dklGUm9aU0JCUWtrZ2NtVjBkWEp1SUhCeVpXWnBlQW9KY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0Nna3ZMeUJwWkhnNklIVnBiblEyTkFvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29KWW5SdmFRb0tDUzh2SUhSeVlXNXpabVZ5Y3pvZ0tIVnBiblEyTkN4aFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWREWTBLVnRkQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDZ2xsZUhSeVlXTjBJRElnTUFvS0NTOHZJR05oYkd4bGNqb2dZV1JrY21WemN3b0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvSlpIVndDZ2xzWlc0S0NYQjFjMmhwYm5RZ016SUtDVDA5Q2dvSkx5OGdZWEpuZFcxbGJuUWdNaUFvWTJGc2JHVnlLU0JtYjNJZ1lYQndjbTkyWldRZ2JYVnpkQ0JpWlNCaElHRmtaSEpsYzNNS0NXRnpjMlZ5ZEFvS0NTOHZJR1Y0WldOMWRHVWdZWEJ3Y205MlpXUW9ZV1JrY21WemN5d29kV2x1ZERZMExHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBOalFwVzEwc2RXbHVkRFkwS1dKdmIyd0tDV05oYkd4emRXSWdZWEJ3Y205MlpXUUtDWEIxYzJoaWVYUmxjeUF3ZURBd0NnbHdkWE5vYVc1MElEQUtDWFZ1WTI5MlpYSWdNZ29KYzJWMFltbDBDZ2xqYjI1allYUUtDV3h2WndvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnWVhCd2NtOTJaV1FvWTJGc2JHVnlPaUJCWkdSeVpYTnpMQ0IwY21GdWMyWmxjbk02SUZSeVlXNXpabVZ5VzEwc0lHbGtlRG9nZFdsdWREWTBLVG9nWW05dmJHVmhiZ292THdvdkx5QkVaWFJsY20xcGJtVnpJSGRvWlhSb1pYSWdZU0IwY21GdWMyWmxjaUJwY3lCaGNIQnliM1psWkNCdmNpQnViM1F1SUZSb2FYTWdhVzF3YkdWdFpXNTBZWFJwYjI0Z1lXeDNZWGx6SUhKbGRIVnlibk1nZEhKMVpTd2dZblYwQ2k4dklIUm9aWEpsSUdGeVpTQnZkR2hsY2lCd2IzTnphV0pwYkdsMGFXVnpJSE4xWTJnZ1lYTWdSVkpETWpBdGMzUjViR1VnWVhCd2NtOTJZV3h6TENCM2FHbDBaV3hwYzNSekxDQmliR0ZqYTJ4cGMzUnpMQ0JsYm1admNtTmxaQ0J5YjNsaGJIUnBaWE1zSUdWMFl5NEtZWEJ3Y205MlpXUTZDZ2x3Y205MGJ5QXpJREVLQ2drdkx5QmpiMjUwY21GamRITXZRVkpET0RSVWNtRnVjMlpsY2k1aGJHZHZMblJ6T2prS0NTOHZJSEpsZEhWeWJpQjBjblZsT3dvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhOMVlnb0tLbUZpYVY5eWIzVjBaVjlqY21WaGRHVkJjSEJzYVdOaGRHbHZiam9LQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpcGpjbVZoZEdWZlRtOVBjRG9LQ1hCMWMyaGllWFJsY3lBd2VHSTRORFEzWWpNMklDOHZJRzFsZEdodlpDQWlZM0psWVhSbFFYQndiR2xqWVhScGIyNG9LWFp2YVdRaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1Q2dvSkx5OGdkR2hwY3lCamIyNTBjbUZqZENCa2IyVnpJRzV2ZENCcGJYQnNaVzFsYm5RZ2RHaGxJR2RwZG1WdUlFRkNTU0J0WlhSb2IyUWdabTl5SUdOeVpXRjBaU0JPYjA5d0NnbGxjbklLQ2lwallXeHNYMDV2VDNBNkNnbHdkWE5vWW5sMFpYTWdNSGcyTkdJNVltUTBOU0F2THlCdFpYUm9iMlFnSW1Gd2NISnZkbVZrS0dGa1pISmxjM01zS0hWcGJuUTJOQ3hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERZMEtWdGRMSFZwYm5RMk5DbGliMjlzSWdvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9KYldGMFkyZ2dLbUZpYVY5eWIzVjBaVjloY0hCeWIzWmxaQW9LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqWVd4c0lFNXZUM0FLQ1dWeWNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUJBVEVZRklFR0N6RVpDSTBNQUQ0QUFBQUFBQUFBQUFBQUFEQUFBQUFBQUFBQUFBQUFBSUFFRlI5OGRUWWFBeGMyR2dKWEFnQTJHZ0ZKRllFZ0VrU0lBQXlBQVFDQkFFOENWRkN3SWtPS0F3RWlpU0pEZ0FTNFJIczJOaG9BamdILzhRQ0FCR1M1dlVVMkdnQ09BZisyQUE9PSIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiN2I2MDdjZTQifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
