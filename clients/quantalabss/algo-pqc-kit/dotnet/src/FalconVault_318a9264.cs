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

namespace Arc56.Generated.quantalabss.algo_pqc_kit.FalconVault_318a9264
{


    //
    // 
    //    M-of-N Post-Quantum Threshold Vault
    //
    //    A treasury that releases ALGO or ASAs only when M-of-N Falcon-1024
    //    signatures are verified on-chain via the AVM falcon_verify opcode.
    //
    //    Security properties
    //    -------------------
    //    - Quantum-resistant: all verification uses falcon_verify (NIST FN-DSA)
    //    - No single point of failure: M < N means one key loss doesn't freeze funds
    //    - Replay protection: message includes nonce + recipient + amount
    //    - No admin backdoor: committee is fixed at deployment
    //    
    //
    public class FalconVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FalconVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetConfigReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetConfigReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetConfigReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetConfigReturn);
                }
                public bool Equals(GetConfigReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetConfigReturn left, GetConfigReturn right)
                {
                    return EqualityComparer<GetConfigReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetConfigReturn left, GetConfigReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Deploy the vault with an immutable M-of-N Falcon committee.
        ///</summary>
        /// <param name="threshold"> </param>
        /// <param name="public_keys"> </param>
        /// <param name="asset_id"> </param>
        public async Task Create(ulong threshold, byte[][] public_keys, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 251, 36, 147 };
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var public_keysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); public_keysAbi.From(public_keys);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, thresholdAbi, public_keysAbi, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong threshold, byte[][] public_keys, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 251, 36, 147 };
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var public_keysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); public_keysAbi.From(public_keys);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, thresholdAbi, public_keysAbi, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allocate boxes for the public keys.
        ///Requires the app to be funded first.
        ///</summary>
        /// <param name="public_keys"> </param>
        public async Task Bootstrap(byte[][] public_keys, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 103, 229, 176 };
            var public_keysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); public_keysAbi.From(public_keys);

            var result = await base.CallApp(new List<object> { abiHandle, public_keysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(byte[][] public_keys, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 103, 229, 176 };
            var public_keysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); public_keysAbi.From(public_keys);

            return await base.MakeTransactionList(new List<object> { abiHandle, public_keysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Release funds after M-of-N Falcon-1024 verification.
        ///The signed message is: itob(nonce) || recipient_bytes || itob(amount) This prevents replay attacks across different release calls.
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="amount"> </param>
        /// <param name="signatures"> </param>
        /// <param name="signer_indices"> </param>
        public async Task Release(Algorand.Address recipient, ulong amount, byte[][] signatures, ulong[] signer_indices, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 105, 254, 165 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var signaturesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); signaturesAbi.From(signatures);
            var signer_indicesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); signer_indicesAbi.From(signer_indices);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, amountAbi, signaturesAbi, signer_indicesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Release_Transactions(Algorand.Address recipient, ulong amount, byte[][] signatures, ulong[] signer_indices, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 105, 254, 165 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var signaturesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); signaturesAbi.From(signatures);
            var signer_indicesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); signer_indicesAbi.From(signer_indices);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, amountAbi, signaturesAbi, signer_indicesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return (threshold, num_signers, nonce) — read-only.
        ///</summary>
        public async Task<Structs.GetConfigReturn> GetConfig(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 236, 146, 215 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetConfigReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetConfig_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 236, 146, 215 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRmFsY29uVmF1bHQiLCJkZXNjIjoiXG4gICAgTS1vZi1OIFBvc3QtUXVhbnR1bSBUaHJlc2hvbGQgVmF1bHRcblxuICAgIEEgdHJlYXN1cnkgdGhhdCByZWxlYXNlcyBBTEdPIG9yIEFTQXMgb25seSB3aGVuIE0tb2YtTiBGYWxjb24tMTAyNFxuICAgIHNpZ25hdHVyZXMgYXJlIHZlcmlmaWVkIG9uLWNoYWluIHZpYSB0aGUgQVZNIGZhbGNvbl92ZXJpZnkgb3Bjb2RlLlxuXG4gICAgU2VjdXJpdHkgcHJvcGVydGllc1xuICAgIC0tLS0tLS0tLS0tLS0tLS0tLS1cbiAgICAtIFF1YW50dW0tcmVzaXN0YW50OiBhbGwgdmVyaWZpY2F0aW9uIHVzZXMgZmFsY29uX3ZlcmlmeSAoTklTVCBGTi1EU0EpXG4gICAgLSBObyBzaW5nbGUgcG9pbnQgb2YgZmFpbHVyZTogTSA8IE4gbWVhbnMgb25lIGtleSBsb3NzIGRvZXNuJ3QgZnJlZXplIGZ1bmRzXG4gICAgLSBSZXBsYXkgcHJvdGVjdGlvbjogbWVzc2FnZSBpbmNsdWRlcyBub25jZSArIHJlY2lwaWVudCArIGFtb3VudFxuICAgIC0gTm8gYWRtaW4gYmFja2Rvb3I6IGNvbW1pdHRlZSBpcyBmaXhlZCBhdCBkZXBsb3ltZW50XG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldENvbmZpZ1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjoiRGVwbG95IHRoZSB2YXVsdCB3aXRoIGFuIGltbXV0YWJsZSBNLW9mLU4gRmFsY29uIGNvbW1pdHRlZS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGhyZXNob2xkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1YmxpY19rZXlzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib290c3RyYXAiLCJkZXNjIjoiQWxsb2NhdGUgYm94ZXMgZm9yIHRoZSBwdWJsaWMga2V5cy5cblJlcXVpcmVzIHRoZSBhcHAgdG8gYmUgZnVuZGVkIGZpcnN0LiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1YmxpY19rZXlzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbGVhc2UiLCJkZXNjIjoiUmVsZWFzZSBmdW5kcyBhZnRlciBNLW9mLU4gRmFsY29uLTEwMjQgdmVyaWZpY2F0aW9uLlxuVGhlIHNpZ25lZCBtZXNzYWdlIGlzOiBpdG9iKG5vbmNlKSB8fCByZWNpcGllbnRfYnl0ZXMgfHwgaXRvYihhbW91bnQpIFRoaXMgcHJldmVudHMgcmVwbGF5IGF0dGFja3MgYWNyb3NzIGRpZmZlcmVudCByZWxlYXNlIGNhbGxzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmF0dXJlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduZXJfaW5kaWNlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY29uZmlnIiwiZGVzYyI6IlJldHVybiAodGhyZXNob2xkLCBudW1fc2lnbmVycywgbm9uY2UpIOKAlCByZWFkLW9ubHkuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRDb25maWdSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo0LCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDg4XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IHNpZ25hdHVyZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjhdLCJlcnJvck1lc3NhZ2UiOiJNYXggMTYgc2lnbmVycyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0OV0sImVycm9yTWVzc2FnZSI6IlB1YmxpYyBrZXkgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTkxXSwiZXJyb3JNZXNzYWdlIjoiUXVvcnVtIG5vdCByZWFjaGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDgyXSwiZXJyb3JNZXNzYWdlIjoiU2lnL2luZGV4IG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQwXSwiZXJyb3JNZXNzYWdlIjoiU2lnbmVyIGluZGV4IG91dCBvZiByYW5nZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxN10sImVycm9yTWVzc2FnZSI6IlRocmVzaG9sZCA+IHNpZ25lciBjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxOV0sImVycm9yTWVzc2FnZSI6IlRocmVzaG9sZCBtdXN0IGJlID49IDEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjJdLCJlcnJvck1lc3NhZ2UiOiJWYXVsdCByZXF1aXJlcyBhdCBsZWFzdCAxIG1lbWJlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwNCw2MzNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFzc2V0X2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5Miw1OTUsNjY3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ub25jZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzYsNjYyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5udW1fc2lnbmVycyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODYsNTg3LDY1N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGhyZXNob2xkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0NCw1NTJdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY0LDI4Miw0MjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM0LDE3OCwyNTIsMjk2LDM5Miw0MzYsNDY1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk4LDMxNiw0NTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjcsMjA2LDM4NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MiwyOTAsNDMwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKGxlbit1aW50OFtdKVtdKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV5Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJRElnTVNBNENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKdWIyNWpaU0lnSW5Sb2NtVnphRzlzWkNJZ0ltNTFiVjl6YVdkdVpYSnpJaUFpWVhOelpYUmZhV1FpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wm1Gc1kyOXVYM1poZFd4MExuQjVPakk0Q2lBZ0lDQXZMeUJqYkdGemN5QkdZV3hqYjI1V1lYVnNkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUE1Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TWpjMk4yVTFZakFnTUhoaU1qWTVabVZoTlNBd2VHVmxaV001TW1RM0lDOHZJRzFsZEdodlpDQWlZbTl2ZEhOMGNtRndLR0o1ZEdWYlhWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxiR1ZoYzJVb1lXUmtjbVZ6Y3l4MWFXNTBOalFzWW5sMFpWdGRXMTBzZFdsdWREWTBXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwWDJOdmJtWnBaeWdwS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR0p2YjNSemRISmhjQ0J5Wld4bFlYTmxJR2RsZEY5amIyNW1hV2NLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUE1T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJaaGJHTnZibDkyWVhWc2RDNXdlVG95T0FvZ0lDQWdMeThnWTJ4aGMzTWdSbUZzWTI5dVZtRjFiSFFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHUXhabUl5TkRreklDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtIVnBiblEyTkN4aWVYUmxXMTFiWFN4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR055WldGMFpRb2dJQ0FnWlhKeUNnb0tMeThnWDNCMWVXRmZiR2xpTG1GeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVY5eVpXRmtYMko1ZEdWZmJHVnVaM1JvWDJWc1pXMWxiblFvWVhKeVlYazZJR0o1ZEdWekxDQnBibVJsZURvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1pIbHVZVzFwWTE5aGNuSmhlVjl5WldGa1gySjVkR1ZmYkdWdVozUm9YMlZzWlcxbGJuUTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNvS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkhWd01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1ptRnNZMjl1WDNaaGRXeDBMa1poYkdOdmJsWmhkV3gwTG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTltWVd4amIyNWZkbUYxYkhRdWNIazZORGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkTENCamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWTNKbFlYUmxYMlp2Y2w5b1pXRmtaWEpBTVRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bVlXeGpiMjVmZG1GMWJIUXVjSGs2TkRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUbTlQY0NKZExDQmpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnUEFvZ0lDQWdZbm9nWTNKbFlYUmxYMkZtZEdWeVgyWnZja0EwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCa2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBM0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1ptOXlJQ2hzWlc0cktHeGxiaXQxYVc1ME9GdGRLVnRkS1FvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNBckNpQWdJQ0JpZFhKNUlEVUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnWTNKbFlYUmxYMlp2Y2w5b1pXRmtaWEpBTVFvS1kzSmxZWFJsWDJGbWRHVnlYMlp2Y2tBME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyWmhiR052Ymw5MllYVnNkQzV3ZVRvME9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHNJR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK1Bnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlpoYkdOdmJsOTJZWFZzZEM1d2VUbzJOZ29nSUNBZ0x5OGdZWE56WlhKMElIUm9jbVZ6YUc5c1pDQThQU0J1TENBaVZHaHlaWE5vYjJ4a0lENGdjMmxuYm1WeUlHTnZkVzUwSWdvZ0lDQWdaR2xuSURZS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURjS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJVYUhKbGMyaHZiR1FnUGlCemFXZHVaWElnWTI5MWJuUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW1ZV3hqYjI1ZmRtRjFiSFF1Y0hrNk5qY0tJQ0FnSUM4dklHRnpjMlZ5ZENCMGFISmxjMmh2YkdRZ1BqMGdWVWx1ZERZMEtERXBMQ0FpVkdoeVpYTm9iMnhrSUcxMWMzUWdZbVVnUGowZ01TSUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUZSb2NtVnphRzlzWkNCdGRYTjBJR0psSUQ0OUlERUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW1ZV3hqYjI1ZmRtRjFiSFF1Y0hrNk5qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCdUlENDlJRlZKYm5RMk5DZ3hLU3dnSWxaaGRXeDBJSEpsY1hWcGNtVnpJR0YwSUd4bFlYTjBJREVnYldWdFltVnlJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QldZWFZzZENCeVpYRjFhWEpsY3lCaGRDQnNaV0Z6ZENBeElHMWxiV0psY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJaaGJHTnZibDkyWVhWc2RDNXdlVG8yT1FvZ0lDQWdMeThnWVhOelpYSjBJRzRnUEQwZ1ZVbHVkRFkwS0RFMktTd2dJazFoZUNBeE5pQnphV2R1WlhKeklnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUV0Y0SURFMklITnBaMjVsY25NS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bVlXeGpiMjVmZG1GMWJIUXVjSGs2TnpFS0lDQWdJQzh2SUhObGJHWXVkR2h5WlhOb2IyeGtMblpoYkhWbElEMGdkR2h5WlhOb2IyeGtDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBhSEpsYzJodmJHUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlpoYkdOdmJsOTJZWFZzZEM1d2VUbzNNZ29nSUNBZ0x5OGdjMlZzWmk1dWRXMWZjMmxuYm1WeWN5NTJZV3gxWlNBOUlHNEtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltNTFiVjl6YVdkdVpYSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTltWVd4amIyNWZkbUYxYkhRdWNIazZOek1LSUNBZ0lDOHZJSE5sYkdZdWJtOXVZMlV1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTV2Ym1ObElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlptRnNZMjl1WDNaaGRXeDBMbkI1T2pjMENpQWdJQ0F2THlCelpXeG1MbUZ6YzJWMFgybGtMblpoYkhWbElEMGdZWE56WlhSZmFXUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRnpjMlYwWDJsa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW1ZV3hqYjI1ZmRtRjFiSFF1Y0hrNk5Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRMQ0JqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHWmhiR052Ymw5MllYVnNkQzVHWVd4amIyNVdZWFZzZEM1aWIyOTBjM1J5WVhCYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGliMjkwYzNSeVlYQTZDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyWmhiR052Ymw5MllYVnNkQzV3ZVRvM05nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBcUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3BpYjI5MGMzUnlZWEJmWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyWmhiR052Ymw5MllYVnNkQzV3ZVRvM05nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUExQ2lBZ0lDQThDaUFnSUNCaWVpQmliMjkwYzNSeVlYQmZZV1owWlhKZlptOXlRRFFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDb0tJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURjS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCbWIzSWdLR3hsYmlzb2JHVnVLM1ZwYm5RNFcxMHBXMTBwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUNzS0lDQWdJR0oxY25rZ05Rb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUJpYjI5MGMzUnlZWEJmWm05eVgyaGxZV1JsY2tBeENncGliMjkwYzNSeVlYQmZZV1owWlhKZlptOXlRRFE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wm1Gc1kyOXVYM1poZFd4MExuQjVPamMyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0K0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlptRnNZMjl1WDNaaGRXeDBMbkI1T2pneUNpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvY0hWaWJHbGpYMnRsZVhNdWJHVnVaM1JvS1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlkWEo1SURjS0NtSnZiM1J6ZEhKaGNGOW1iM0pmYUdWaFpHVnlRRFk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wm1Gc1kyOXVYM1poZFd4MExuQjVPamd5Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9jSFZpYkdsalgydGxlWE11YkdWdVozUm9LVG9LSUNBZ0lHUnBaeUEyQ2lBZ0lDQmthV2NnTlFvZ0lDQWdQQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRGtLSUNBZ0lHSjZJR0p2YjNSemRISmhjRjloWm5SbGNsOW1iM0pBT1FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJaaGJHTnZibDkyWVhWc2RDNXdlVG80TXdvZ0lDQWdMeThnWW05NFgydGxlU0E5SUdJaWNHdGZJaUFySUc5d0xtbDBiMklvYVNrS0lDQWdJR1JwWnlBMkNpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURjd05tSTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnT1FvZ0lDQWdZWE56WlhKMElDOHZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTltWVd4amIyNWZkbUYxYkhRdWNIazZPRFFLSUNBZ0lDOHZJRzl3TGtKdmVDNXdkWFFvWW05NFgydGxlU3dnY0hWaWJHbGpYMnRsZVhOYmFWMHVZbmwwWlhNcENpQWdJQ0JrYVdjZ053b2dJQ0FnWkdsbklESUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOXlaV0ZrWDJKNWRHVmZiR1Z1WjNSb1gyVnNaVzFsYm5RS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW1ZV3hqYjI1ZmRtRjFiSFF1Y0hrNk9ESUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNod2RXSnNhV05mYTJWNWN5NXNaVzVuZEdncE9nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTndvZ0lDQWdZaUJpYjI5MGMzUnlZWEJmWm05eVgyaGxZV1JsY2tBMkNncGliMjkwYzNSeVlYQmZZV1owWlhKZlptOXlRRGs2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wm1Gc1kyOXVYM1poZFd4MExuQjVPamMyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCbVlXeGpiMjVmZG1GMWJIUXVSbUZzWTI5dVZtRjFiSFF1Y21Wc1pXRnpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGJHVmhjMlU2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlpoYkdOdmJsOTJZWFZzZEM1d2VUbzROZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dweVpXeGxZWE5sWDJadmNsOW9aV0ZrWlhKQU1Ub0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW1ZV3hqYjI1ZmRtRjFiSFF1Y0hrNk9EWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdQQW9nSUNBZ1lub2djbVZzWldGelpWOWhablJsY2w5bWIzSkFOQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTndvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdadmNpQW9iR1Z1S3loc1pXNHJkV2x1ZERoYlhTbGJYU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJSEpsYkdWaGMyVmZabTl5WDJobFlXUmxja0F4Q2dweVpXeGxZWE5sWDJGbWRHVnlYMlp2Y2tBME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyWmhiR052Ymw5MllYVnNkQzV3ZVRvNE5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmthV2NnTXdvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RMk5ENEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW1ZV3hqYjI1ZmRtRjFiSFF1Y0hrNk1UQXdDaUFnSUNBdkx5QmhjM05sY25RZ2MybG5ibUYwZFhKbGN5NXNaVzVuZEdnZ1BUMGdjMmxuYm1WeVgybHVaR2xqWlhNdWJHVnVaM1JvTENBaVUybG5MMmx1WkdWNElHMXBjMjFoZEdOb0lnb2dJQ0FnWkdsbklEVUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGTnBaeTlwYm1SbGVDQnRhWE50WVhSamFBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyWmhiR052Ymw5MllYVnNkQzV3ZVRveE1ERUtJQ0FnSUM4dklHRnpjMlZ5ZENCemFXZHVZWFIxY21WekxteGxibWQwYUNBK1BTQnpaV3htTG5Sb2NtVnphRzlzWkM1MllXeDFaU3dnSWtsdWMzVm1abWxqYVdWdWRDQnphV2R1WVhSMWNtVnpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUm9jbVZ6YUc5c1pDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYUhKbGMyaHZiR1FnWlhocGMzUnpDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWMzVm1abWxqYVdWdWRDQnphV2R1WVhSMWNtVnpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZabUZzWTI5dVgzWmhkV3gwTG5CNU9qRXdOUW9nSUNBZ0x5OGdiM0F1YVhSdllpaHpaV3htTG01dmJtTmxMblpoYkhWbEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW01dmJtTmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG01dmJtTmxJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyWmhiR052Ymw5MllYVnNkQzV3ZVRveE1EVXRNVEEyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLSE5sYkdZdWJtOXVZMlV1ZG1Gc2RXVXBDaUFnSUNBdkx5QXJJSEpsWTJsd2FXVnVkQzVpZVhSbGN3b2dJQ0FnWkdsbklEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlpoYkdOdmJsOTJZWFZzZEM1d2VUb3hNRGNLSUNBZ0lDOHZJQ3NnYjNBdWFYUnZZaWhoYlc5MWJuUXBDaUFnSUNCa2FXY2dOd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlpoYkdOdmJsOTJZWFZzZEM1d2VUb3hNRFV0TVRBM0NpQWdJQ0F2THlCdmNDNXBkRzlpS0hObGJHWXVibTl1WTJVdWRtRnNkV1VwQ2lBZ0lDQXZMeUFySUhKbFkybHdhV1Z1ZEM1aWVYUmxjd29nSUNBZ0x5OGdLeUJ2Y0M1cGRHOWlLR0Z0YjNWdWRDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1luVnllU0F4TXdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJaaGJHTnZibDkyWVhWc2RDNXdlVG94TVRBdE1URXhDaUFnSUNBdkx5QWpJRlpsY21sbWVTQmxZV05vSUVaaGJHTnZiaTB4TURJMElITnBaMjVoZEhWeVpTQnZiaTFqYUdGcGJpQW9RVlpOSUdaaGJHTnZibDkyWlhKcFpua3BDaUFnSUNBdkx5QjJaWEpwWm1sbFpDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKMWNua2dPUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlpoYkdOdmJsOTJZWFZzZEM1d2VUb3hNVElLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaHphV2R1WVhSMWNtVnpMbXhsYm1kMGFDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQXhNQW9LY21Wc1pXRnpaVjltYjNKZmFHVmhaR1Z5UURZNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlptRnNZMjl1WDNaaGRXeDBMbkI1T2pFeE1nb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hOcFoyNWhkSFZ5WlhNdWJHVnVaM1JvS1RvS0lDQWdJR1JwWnlBNUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnUEFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFeUNpQWdJQ0JpZWlCeVpXeGxZWE5sWDJGbWRHVnlYMlp2Y2tBeE1Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyWmhiR052Ymw5MllYVnNkQzV3ZVRveE1UTUtJQ0FnSUM4dklHbGtlQ0E5SUhOcFoyNWxjbDlwYm1ScFkyVnpXMmxkTG01aGRHbDJaUW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREV3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlpoYkdOdmJsOTJZWFZzZEM1d2VUb3hNVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnBaSGdnUENCelpXeG1MbTUxYlY5emFXZHVaWEp6TG5aaGJIVmxMQ0FpVTJsbmJtVnlJR2x1WkdWNElHOTFkQ0J2WmlCeVlXNW5aU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnVkVzFmYzJsbmJtVnljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dWRXMWZjMmxuYm1WeWN5QmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdVMmxuYm1WeUlHbHVaR1Y0SUc5MWRDQnZaaUJ5WVc1blpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyWmhiR052Ymw5MllYVnNkQzV3ZVRveE1UWUtJQ0FnSUM4dklHSnZlRjl1WVcxbElEMGdZaUp3YXlJZ0t5QnZjQzVwZEc5aUtHbGtlQ2tLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGN3Tm1JS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyWmhiR052Ymw5MllYVnNkQzV3ZVRveE1UY0tJQ0FnSUM4dklIQjFZbXRsZVN3Z1pYaHBjM1J6SUQwZ2IzQXVRbTk0TG1kbGRDaGliM2hmYm1GdFpTa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTltWVd4amIyNWZkbUYxYkhRdWNIazZNVEU0Q2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlVSFZpYkdsaklHdGxlU0J1YjNRZ1ptOTFibVFpQ2lBZ0lDQmhjM05sY25RZ0x5OGdVSFZpYkdsaklHdGxlU0J1YjNRZ1ptOTFibVFLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdZWE56WlhKMElDOHZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTltWVd4amIyNWZkbUYxYkhRdWNIazZNVEl3Q2lBZ0lDQXZMeUJwWmlCdmNDNW1ZV3hqYjI1ZmRtVnlhV1o1S0cxbGMzTmhaMlVzSUhOcFoyNWhkSFZ5WlhOYmFWMHVZbmwwWlhNc0lIQjFZbXRsZVNrNkNpQWdJQ0JrYVdjZ053b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlHUjVibUZ0YVdOZllYSnlZWGxmY21WaFpGOWllWFJsWDJ4bGJtZDBhRjlsYkdWdFpXNTBDaUFnSUNCa2FXY2dNVFFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWm1Gc1kyOXVYM1psY21sbWVRb2dJQ0FnWW5vZ2NtVnNaV0Z6WlY5aFpuUmxjbDlwWmw5bGJITmxRRGtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTltWVd4amIyNWZkbUYxYkhRdWNIazZNVEl4Q2lBZ0lDQXZMeUIyWlhKcFptbGxaQ0FyUFNCVlNXNTBOalFvTVNrS0lDQWdJR1JwWnlBNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0E1Q2dweVpXeGxZWE5sWDJGbWRHVnlYMmxtWDJWc2MyVkFPVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTltWVd4amIyNWZkbUYxYkhRdWNIazZNVEV5Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9jMmxuYm1GMGRYSmxjeTVzWlc1bmRHZ3BPZ29nSUNBZ1pHbG5JRGtLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERXdDaUFnSUNCaUlISmxiR1ZoYzJWZlptOXlYMmhsWVdSbGNrQTJDZ3B5Wld4bFlYTmxYMkZtZEdWeVgyWnZja0F4TVRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bVlXeGpiMjVmZG1GMWJIUXVjSGs2TVRJekNpQWdJQ0F2THlCaGMzTmxjblFnZG1WeWFXWnBaV1FnUGowZ2MyVnNaaTUwYUhKbGMyaHZiR1F1ZG1Gc2RXVXNJQ0pSZFc5eWRXMGdibTkwSUhKbFlXTm9aV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkR2h5WlhOb2IyeGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5Sb2NtVnphRzlzWkNCbGVHbHpkSE1LSUNBZ0lHUnBaeUE1Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklGRjFiM0oxYlNCdWIzUWdjbVZoWTJobFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyWmhiR052Ymw5MllYVnNkQzV3ZVRveE1qVXRNVEkyQ2lBZ0lDQXZMeUFqSUVsdVkzSmxiV1Z1ZENCdWIyNWpaU0JpWldadmNtVWdjbVZzWldGemFXNW5JQ2h3Y21WMlpXNTBjeUJ5WlhCc1lYa2dkMmwwYUdsdUlITmhiV1VnWW14dlkyc3BDaUFnSUNBdkx5QnpaV3htTG01dmJtTmxMblpoYkhWbElDczlJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltNXZibU5sSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtNXZibU5sSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW01dmJtTmxJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTltWVd4amIyNWZkbUYxYkhRdWNIazZNVEk0TFRFeU9Rb2dJQ0FnTHk4Z0l5QkZlR1ZqZFhSbElIQmhlVzFsYm5RS0lDQWdJQzh2SUdsbUlITmxiR1l1WVhOelpYUmZhV1F1ZG1Gc2RXVWdQVDBnVlVsdWREWTBLREFwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZ6YzJWMFgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GemMyVjBYMmxrSUdWNGFYTjBjd29nSUNBZ1ltNTZJSEpsYkdWaGMyVmZaV3h6WlY5aWIyUjVRREUwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wm1Gc1kyOXVYM1poZFd4MExuQjVPakV6TUMweE16UUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxeVpXTnBjR2xsYm5RdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVWRzYjJKaGJDNXRhVzVmZEhodVgyWmxaU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW1ZV3hqYjI1ZmRtRjFiSFF1Y0hrNk1UTXpDaUFnSUNBdkx5Qm1aV1U5UjJ4dlltRnNMbTFwYmw5MGVHNWZabVZsTEFvZ0lDQWdaMnh2WW1Gc0lFMXBibFI0YmtabFpRb2dJQ0FnWkdsbklEY0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQmthV2NnT0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlpoYkdOdmJsOTJZWFZzZEM1d2VUb3hNekFLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJR2x1ZEdOZk1pQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wm1Gc1kyOXVYM1poZFd4MExuQjVPakV6TUMweE16UUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxeVpXTnBjR2xsYm5RdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVWRzYjJKaGJDNXRhVzVmZEhodVgyWmxaU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDZ3B5Wld4bFlYTmxYMkZtZEdWeVgybG1YMlZzYzJWQU1UWTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZabUZzWTI5dVgzWmhkV3gwTG5CNU9qZzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuSmxiR1ZoYzJWZlpXeHpaVjlpYjJSNVFERTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlpoYkdOdmJsOTJZWFZzZEM1d2VUb3hNell0TVRReENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWNtVmphWEJwWlc1MExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVFYTnpaWFFvYzJWc1ppNWhjM05sZEY5cFpDNTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFVkc2IySmhiQzV0YVc1ZmRIaHVYMlpsWlN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTltWVd4amIyNWZkbUYxYkhRdWNIazZNVFF3Q2lBZ0lDQXZMeUJtWldVOVIyeHZZbUZzTG0xcGJsOTBlRzVmWm1WbExBb2dJQ0FnWjJ4dlltRnNJRTFwYmxSNGJrWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlpoYkdOdmJsOTJZWFZzZEM1d2VUb3hNemtLSUNBZ0lDOHZJSGhtWlhKZllYTnpaWFE5UVhOelpYUW9jMlZzWmk1aGMzTmxkRjlwWkM1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZWE56WlhSZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhOelpYUmZhV1FnWlhocGMzUnpDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnWkdsbklEY0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdScFp5QTRDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTltWVd4amIyNWZkbUYxYkhRdWNIazZNVE0yQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlptRnNZMjl1WDNaaGRXeDBMbkI1T2pFek5pMHhOREVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajF5WldOcGNHbGxiblF1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFCYzNObGRDaHpaV3htTG1GemMyVjBYMmxrTG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlSMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdJZ2NtVnNaV0Z6WlY5aFpuUmxjbDlwWmw5bGJITmxRREUyQ2dvS0x5OGdabUZzWTI5dVgzWmhkV3gwTGtaaGJHTnZibFpoZFd4MExtZGxkRjlqYjI1bWFXZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZlkyOXVabWxuT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJaaGJHTnZibDkyWVhWc2RDNXdlVG94TkRjS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEdoeVpYTm9iMnhrTG5aaGJIVmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBhSEpsYzJodmJHUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEdoeVpYTm9iMnhrSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlpoYkdOdmJsOTJZWFZzZEM1d2VUb3hORGdLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXViblZ0WDNOcFoyNWxjbk11ZG1Gc2RXVXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltNTFiVjl6YVdkdVpYSnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG01MWJWOXphV2R1WlhKeklHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJaaGJHTnZibDkyWVhWc2RDNXdlVG94TkRrS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Ym05dVkyVXVkbUZzZFdVcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW01dmJtTmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG01dmJtTmxJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyWmhiR052Ymw5MllYVnNkQzV3ZVRveE5EWXRNVFV3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VWRYQnNaU2dvQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGFISmxjMmh2YkdRdWRtRnNkV1VwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLSE5sYkdZdWJuVnRYM05wWjI1bGNuTXVkbUZzZFdVcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVibTl1WTJVdWRtRnNkV1VwTEFvZ0lDQWdMeThnS1NrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wm1Gc1kyOXVYM1poZFd4MExuQjVPakUwTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV5Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkRDQUVBQUlCQ0NZRUJXNXZibU5sQ1hSb2NtVnphRzlzWkF0dWRXMWZjMmxuYm1WeWN3aGhjM05sZEY5cFpERVpGRVF4R0VFQUhZSURCQ2RuNWJBRXNtbitwUVR1N0pMWE5ob0FqZ01Bb0FFWEFqc0FnQVRSK3lTVE5ob0FqZ0VBRndDS0FnR0wvbGNDQUl2L0l3dExBVXhaU2xrakNGaUpOaG9CU1JVbEVrUVhOaG9DU1NKWlNVNENJd3RNU1JWTVZ3SUFJa2xMQlF4QkFDUkhBaU1MU3dOSlR3SlpTVXNIU1U0RUVrUkxBUlZTSWxrakNBaEZCU1FJUlFGQy85VkxBeU1JU3dNU1JEWWFBMGtWSlJKRUYwc0dTVXNIU1U0RERrUkpSRXNCUkVzQmdSQU9SQ2xNWnlwTVp5Z2laeXRNWnlSRGdBQkpOaG9CUndJaVdVbE9BaU1MVEVrVlRGY0NBQ0pKU3dVTVFRQWtSd0lqQzBzRFNVOENXVWxMQjBsT0JCSkVTd0VWVWlKWkl3Z0lSUVVrQ0VVQlF2L1ZTd01qQ0VzREVrUWlSUWRMQmtzRkRFbEZDVUVBSFVzR1NSYUFBM0JyWDB4UVN3bEVTd2RMQW9qL0FyOGtDRVVIUXYvWUpFTWlTWUFBUndJMkdnRkpGWUVnRWtRMkdnSkpGU1VTUkJjMkdnTkhBaUpaU1U0Q0l3dE1TUlZNVndJQUlrbExCUXhCQUNSSEFpTUxTd05KVHdKWlNVc0hTVTRFRWtSTEFSVlNJbGtqQ0FoRkJTUUlSUUZDLzlWTEF5TUlTd01TUkRZYUJFbEZEVWtpV1VrbEN5TUlUd0lWRWtSTEJVbFBBaEpFSWlsbFJBOUVJaWhsUkJaTENGQkxCeFpRUlEwaVJRa2lSUXBMQ1VzRkRFbEZERUVBUUVzTFZ3SUFTd3BKVGdJbEMxc2lLbVZFU3dFTlJCYUFBbkJyVEZDK1JFc01SRXNIVHdLSS9qSkxEa3hQQW9WQkFBWkxDQ1FJUlFsTENTUUlSUXBDLzdVaUtXVkVTd2tPUkNJb1pVUWtDQ2hNWnlJclpVUkFBQk94TWdCTEI3SUlTd2l5QnlTeUVMSUJzeVJEc1RJQUlpdGxSTElSU3dleUVrc0lzaFNCQkxJUXNnR3pRdi9qSWlsbFJCWWlLbVZFRmlJb1pVUVdUZ0pRVEZDQUJCVWZmSFZNVUxBa1F3PT0iLCJjbGVhciI6IkRJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
