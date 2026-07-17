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

namespace Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.SavingsVault_edb5affc
{


    public class SavingsVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SavingsVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetUserStatsReturn : AVMObjectType
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

                public static GetUserStatsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetUserStatsReturn();
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
                    return Equals(obj as GetUserStatsReturn);
                }
                public bool Equals(GetUserStatsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetUserStatsReturn left, GetUserStatsReturn right)
                {
                    return EqualityComparer<GetUserStatsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetUserStatsReturn left, GetUserStatsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetGlobalStatsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetGlobalStatsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetGlobalStatsReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetGlobalStatsReturn);
                }
                public bool Equals(GetGlobalStatsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetGlobalStatsReturn left, GetGlobalStatsReturn right)
                {
                    return EqualityComparer<GetGlobalStatsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetGlobalStatsReturn left, GetGlobalStatsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetPactConfigReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

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

                public static GetPactConfigReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetPactConfigReturn();
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
                    return Equals(obj as GetPactConfigReturn);
                }
                public bool Equals(GetPactConfigReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPactConfigReturn left, GetPactConfigReturn right)
                {
                    return EqualityComparer<GetPactConfigReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPactConfigReturn left, GetPactConfigReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task<ulong> Deposit(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 50, 152, 231, 192 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 50, 152, 231, 192 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///One-time (or admin-updatable) configuration for:
        ///- which ASA is treated as the stablecoin deposit rail - who the beneficiary is for agentic release - when time-based release becomes valid - which address is authorized as an on-chain agent trigger
        ///SECURITY: restricted to the application creator.
        ///</summary>
        /// <param name="stablecoin_asset_id"> </param>
        /// <param name="beneficiary"> </param>
        /// <param name="release_ts"> </param>
        /// <param name="agent"> </param>
        public async Task ConfigureStablecoinAndRelease(ulong stablecoin_asset_id, Algorand.Address beneficiary, ulong release_ts, Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 24, 152, 144 };
            var stablecoin_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stablecoin_asset_idAbi.From(stablecoin_asset_id);
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);
            var release_tsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); release_tsAbi.From(release_ts);
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, stablecoin_asset_idAbi, beneficiaryAbi, release_tsAbi, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConfigureStablecoinAndRelease_Transactions(ulong stablecoin_asset_id, Algorand.Address beneficiary, ulong release_ts, Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 24, 152, 144 };
            var stablecoin_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stablecoin_asset_idAbi.From(stablecoin_asset_id);
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);
            var release_tsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); release_tsAbi.From(release_ts);
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, stablecoin_asset_idAbi, beneficiaryAbi, release_tsAbi, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Stablecoin deposit rail (ASA):
        ///- expects an AssetTransfer (grouped with this app call) into the app account - records balances in local state and global totals
        ///</summary>
        /// <param name="axfer"> </param>
        /// <param name="asset_id"> </param>
        public async Task<ulong> DepositStablecoin(AssetTransferTransaction axfer, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axfer });
            byte[] abiHandle = { 140, 177, 90, 30 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, axfer, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DepositStablecoin_Transactions(AssetTransferTransaction axfer, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axfer });
            byte[] abiHandle = { 140, 177, 90, 30 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, axfer, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Agentic release trigger:
        ///- can be invoked only by the authorized agent address - releases the configured stablecoin pool to the configured beneficiary
        ///</summary>
        public async Task AgenticRelease(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 145, 248, 30 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AgenticRelease_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 145, 248, 30 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="milestone_level"> </param>
        public async Task<ulong> ClaimBadge(ulong milestone_level, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 235, 183, 218 };
            var milestone_levelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); milestone_levelAbi.From(milestone_level);

            var result = await base.CallApp(new List<object> { abiHandle, milestone_levelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ClaimBadge_Transactions(ulong milestone_level, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 235, 183, 218 };
            var milestone_levelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); milestone_levelAbi.From(milestone_level);

            return await base.MakeTransactionList(new List<object> { abiHandle, milestone_levelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="penalty_sink"> </param>
        public async Task Withdraw(ulong amount, Algorand.Address penalty_sink, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 129, 41, 122 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var penalty_sinkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); penalty_sinkAbi.From(penalty_sink);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, penalty_sinkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong amount, Algorand.Address penalty_sink, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 129, 41, 122 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var penalty_sinkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); penalty_sinkAbi.From(penalty_sink);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, penalty_sinkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="partner"> </param>
        /// <param name="required_amount"> </param>
        /// <param name="cadence_seconds"> </param>
        /// <param name="penalty_amount"> </param>
        public async Task SetupSavingsPact(Algorand.Address partner, ulong required_amount, ulong cadence_seconds, ulong penalty_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 61, 114, 172 };
            var partnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partnerAbi.From(partner);
            var required_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); required_amountAbi.From(required_amount);
            var cadence_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cadence_secondsAbi.From(cadence_seconds);
            var penalty_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); penalty_amountAbi.From(penalty_amount);

            var result = await base.CallApp(new List<object> { abiHandle, partnerAbi, required_amountAbi, cadence_secondsAbi, penalty_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetupSavingsPact_Transactions(Algorand.Address partner, ulong required_amount, ulong cadence_seconds, ulong penalty_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 61, 114, 172 };
            var partnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partnerAbi.From(partner);
            var required_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); required_amountAbi.From(required_amount);
            var cadence_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cadence_secondsAbi.From(cadence_seconds);
            var penalty_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); penalty_amountAbi.From(penalty_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, partnerAbi, required_amountAbi, cadence_secondsAbi, penalty_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="partner"> </param>
        /// <param name="penalty_payment"> </param>
        public async Task<ulong> ApplyPactPenalty(PaymentTransaction penalty_payment, Algorand.Address partner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { penalty_payment });
            byte[] abiHandle = { 242, 39, 150, 153 };
            var partnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partnerAbi.From(partner);

            var result = await base.CallApp(new List<object> { abiHandle, partnerAbi, penalty_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ApplyPactPenalty_Transactions(PaymentTransaction penalty_payment, Algorand.Address partner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { penalty_payment });
            byte[] abiHandle = { 242, 39, 150, 153 };
            var partnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); partnerAbi.From(partner);

            return await base.MakeTransactionList(new List<object> { abiHandle, partnerAbi, penalty_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="goal_amount"> </param>
        /// <param name="penalty_bps"> </param>
        /// <param name="penalty_sink"> </param>
        public async Task SetTemptationLock(ulong goal_amount, ulong penalty_bps, Algorand.Address penalty_sink, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 62, 44, 18 };
            var goal_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); goal_amountAbi.From(goal_amount);
            var penalty_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); penalty_bpsAbi.From(penalty_bps);
            var penalty_sinkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); penalty_sinkAbi.From(penalty_sink);

            var result = await base.CallApp(new List<object> { abiHandle, goal_amountAbi, penalty_bpsAbi, penalty_sinkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetTemptationLock_Transactions(ulong goal_amount, ulong penalty_bps, Algorand.Address penalty_sink, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 62, 44, 18 };
            var goal_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); goal_amountAbi.From(goal_amount);
            var penalty_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); penalty_bpsAbi.From(penalty_bps);
            var penalty_sinkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); penalty_sinkAbi.From(penalty_sink);

            return await base.MakeTransactionList(new List<object> { abiHandle, goal_amountAbi, penalty_bpsAbi, penalty_sinkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DisableTemptationLock(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 208, 236, 203 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DisableTemptationLock_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 208, 236, 203 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="dream_uri"> </param>
        /// <param name="dream_title"> </param>
        public async Task SetDreamBoard(byte[] dream_uri, byte[] dream_title, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 81, 17, 27 };
            var dream_uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dream_uriAbi.From(dream_uri);
            var dream_titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dream_titleAbi.From(dream_title);

            var result = await base.CallApp(new List<object> { abiHandle, dream_uriAbi, dream_titleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetDreamBoard_Transactions(byte[] dream_uri, byte[] dream_title, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 81, 17, 27 };
            var dream_uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dream_uriAbi.From(dream_uri);
            var dream_titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dream_titleAbi.From(dream_title);

            return await base.MakeTransactionList(new List<object> { abiHandle, dream_uriAbi, dream_titleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task<Structs.GetUserStatsReturn> GetUserStats(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 134, 83, 118 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserStats_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 134, 83, 118 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetGlobalStatsReturn> GetGlobalStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 254, 229, 58 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetGlobalStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetGlobalStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 254, 229, 58 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetPactConfigReturn> GetPactConfig(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 218, 240, 7 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPactConfigReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPactConfig_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 218, 240, 7 };

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2F2aW5nc1ZhdWx0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFVzZXJTdGF0c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0R2xvYmFsU3RhdHNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0UGFjdENvbmZpZ1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoib3B0X2luIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiT3B0SW4iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBvc2l0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb25maWd1cmVfc3RhYmxlY29pbl9hbmRfcmVsZWFzZSIsImRlc2MiOiJPbmUtdGltZSAob3IgYWRtaW4tdXBkYXRhYmxlKSBjb25maWd1cmF0aW9uIGZvcjpcbi0gd2hpY2ggQVNBIGlzIHRyZWF0ZWQgYXMgdGhlIHN0YWJsZWNvaW4gZGVwb3NpdCByYWlsIC0gd2hvIHRoZSBiZW5lZmljaWFyeSBpcyBmb3IgYWdlbnRpYyByZWxlYXNlIC0gd2hlbiB0aW1lLWJhc2VkIHJlbGVhc2UgYmVjb21lcyB2YWxpZCAtIHdoaWNoIGFkZHJlc3MgaXMgYXV0aG9yaXplZCBhcyBhbiBvbi1jaGFpbiBhZ2VudCB0cmlnZ2VyXG5TRUNVUklUWTogcmVzdHJpY3RlZCB0byB0aGUgYXBwbGljYXRpb24gY3JlYXRvci4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhYmxlY29pbl9hc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJlbmVmaWNpYXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWxlYXNlX3RzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVwb3NpdF9zdGFibGVjb2luIiwiZGVzYyI6IlN0YWJsZWNvaW4gZGVwb3NpdCByYWlsIChBU0EpOlxuLSBleHBlY3RzIGFuIEFzc2V0VHJhbnNmZXIgKGdyb3VwZWQgd2l0aCB0aGlzIGFwcCBjYWxsKSBpbnRvIHRoZSBhcHAgYWNjb3VudCAtIHJlY29yZHMgYmFsYW5jZXMgaW4gbG9jYWwgc3RhdGUgYW5kIGdsb2JhbCB0b3RhbHMiLCJhcmdzIjpbeyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJheGZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZ2VudGljX3JlbGVhc2UiLCJkZXNjIjoiQWdlbnRpYyByZWxlYXNlIHRyaWdnZXI6XG4tIGNhbiBiZSBpbnZva2VkIG9ubHkgYnkgdGhlIGF1dGhvcml6ZWQgYWdlbnQgYWRkcmVzcyAtIHJlbGVhc2VzIHRoZSBjb25maWd1cmVkIHN0YWJsZWNvaW4gcG9vbCB0byB0aGUgY29uZmlndXJlZCBiZW5lZmljaWFyeSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbV9iYWRnZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaWxlc3RvbmVfbGV2ZWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZW5hbHR5X3NpbmsiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0dXBfc2F2aW5nc19wYWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1aXJlZF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhZGVuY2Vfc2Vjb25kcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVuYWx0eV9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXBwbHlfcGFjdF9wZW5hbHR5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZW5hbHR5X3BheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfdGVtcHRhdGlvbl9sb2NrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImdvYWxfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZW5hbHR5X2JwcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlbmFsdHlfc2luayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkaXNhYmxlX3RlbXB0YXRpb25fbG9jayIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfZHJlYW1fYm9hcmQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHJlYW1fdXJpIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkcmVhbV90aXRsZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9zdGF0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0VXNlclN0YXRzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZ2xvYmFsX3N0YXRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldEdsb2JhbFN0YXRzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcGFjdF9jb25maWciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRQYWN0Q29uZmlnUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MTYsImJ5dGVzIjo0fSwibG9jYWwiOnsiaW50cyI6OCwiYnl0ZXMiOjN9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMjI5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZ2VudF9hZGRyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNDldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJlbmVmaWNpYXJ5X2FkZHIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODg5LDE4OTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxhc3RfZGVwb3NpdCBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTk0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5sb2NrX2VuYWJsZWQgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTg4LDEzNThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1pbGVzdG9uZV8xIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2NSwxNDM3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5taWxlc3RvbmVfMiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MzksMTUwMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubWlsZXN0b25lXzMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkwNCwyMTc4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wYWN0X2NhZGVuY2Vfc2Vjb25kcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODM2LDIxNjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBhY3RfZW5hYmxlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODYxLDIxODRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBhY3RfcGVuYWx0eV9hbW91bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE3Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucGFjdF9yZXF1aXJlZF9hbW91bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg3MSwxOTYzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wYWN0X3VzZXJfYSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODgwLDE5NTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBhY3RfdXNlcl9iIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MjNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBlbmFsdHlfc2luayBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTIwLDEyNDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnN0YWJsZWNvaW5fYXNzZXRfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE5NCwxMjU4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdGFibGVjb2luX3RvdGFsIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg2OCwxNjkwLDE5MjcsMjE0Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfZGVwb3NpdGVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwOSwyMTUyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF91c2VycyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjEyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi51c2VyX2dvYWxfYW1vdW50IGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzNCwxMzE5LDIxMjFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnVzZXJfbWlsZXN0b25lIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MzRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnVzZXJfcGVuYWx0eV9icHMgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4MiwxMjE2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi51c2VyX3N0YWJsZWNvaW5fdG90YWwgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTAwLDIxMjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnVzZXJfc3RyZWFrIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1OCw5MjYsMTM0NCwxNTg0LDE2MDUsMTY3NywxOTE0LDIxMTNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnVzZXJfdG90YWwgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODc4LDEyMDUsMTI5MywxNzAwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi52YXVsdF9iYWxhbmNlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNTYsMjA3M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNjQsMjA4MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDI1LDEwNDIsMTU3OCwxNzM0LDE4MjEsMjAwMywyMTA4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMTYsMTAzMywxMTE0LDEzMTAsMTU2NiwxNzQyLDE3NTEsMTc2MCwxOTg1LDE5OTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTA2XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyOSwxODMxXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXpNaUF4TURBd01EQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSjFjMlZ5WDNSdmRHRnNJaUF3ZUNBaWRtRjFiSFJmWW1Gc1lXNWpaU0lnSW5SdmRHRnNYMlJsY0c5emFYUmxaQ0lnTUhneE5URm1OMk0zTlNBaWMzUmhZbXhsWTI5cGJsOTBiM1JoYkNJZ0luVnpaWEpmYldsc1pYTjBiMjVsSWlBaWRYTmxjbDl6ZEhKbFlXc2lJQ0owYjNSaGJGOTFjMlZ5Y3lJZ0luQmhZM1JmWlc1aFlteGxaQ0lnSW5CaFkzUmZZMkZrWlc1alpWOXpaV052Ym1SeklpQWljR0ZqZEY5d1pXNWhiSFI1WDJGdGIzVnVkQ0lnSW5CaFkzUmZkWE5sY2w5aElpQWljR0ZqZEY5MWMyVnlYMklpSUNKemRHRmliR1ZqYjJsdVgyRnpjMlYwWDJsa0lpQWliR0Z6ZEY5a1pYQnZjMmwwSWlBaWJHOWphMTlsYm1GaWJHVmtJaUFpZFhObGNsOXpkR0ZpYkdWamIybHVYM1J2ZEdGc0lpQWliV2xzWlhOMGIyNWxYekVpSUNKdGFXeGxjM1J2Ym1WZk1pSWdJbTFwYkdWemRHOXVaVjh6SWlBaWNHRmpkRjl5WlhGMWFYSmxaRjloYlc5MWJuUWlJQ0ppWlc1bFptbGphV0Z5ZVY5aFpHUnlJaUFpWVdkbGJuUmZZV1JrY2lJZ0luVnpaWEpmWjI5aGJGOWhiVzkxYm5RaUlDSjFjMlZ5WDNCbGJtRnNkSGxmWW5CeklpQWljR1Z1WVd4MGVWOXphVzVySWlBaVltRmtaMlZmWVhOelpYUmZNU0lnSW1KaFpHZGxYMkZ6YzJWMFh6SWlJQ0ppWVdSblpWOWhjM05sZEY4eklpQWlZbVZ1WldacFkybGhjbmxmY21Wc1pXRnpaVjkwYVcxbGMzUmhiWEFpSUNKa2NtVmhiVjkxY21raUlDSmtjbVZoYlY5MGFYUnNaU0lLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pRNENpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyUmxjRzl6YVhSbFpDQTlJRWRzYjJKaGJGTjBZWFJsS0ZWSmJuUTJOQ2d3S1NrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYMlJsY0c5emFYUmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZkWE5sY25NZ1BTQkhiRzlpWVd4VGRHRjBaU2hWU1c1ME5qUW9NQ2twQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0owYjNSaGJGOTFjMlZ5Y3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJSE5sYkdZdWRtRjFiSFJmWW1Gc1lXNWpaU0E5SUVkc2IySmhiRk4wWVhSbEtGVkpiblEyTkNnd0tTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luWmhkV3gwWDJKaGJHRnVZMlVpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qVXhDaUFnSUNBdkx5QnpaV3htTG0xcGJHVnpkRzl1WlY4eElEMGdSMnh2WW1Gc1UzUmhkR1VvVlVsdWREWTBLREV3WHpBd01GOHdNREFwS1FvZ0lDQWdZbmwwWldNZ01UZ2dMeThnSW0xcGJHVnpkRzl1WlY4eElnb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qVXlDaUFnSUNBdkx5QnpaV3htTG0xcGJHVnpkRzl1WlY4eUlEMGdSMnh2WW1Gc1UzUmhkR1VvVlVsdWREWTBLRFV3WHpBd01GOHdNREFwS1FvZ0lDQWdZbmwwWldNZ01Ua2dMeThnSW0xcGJHVnpkRzl1WlY4eUlnb2dJQ0FnY0hWemFHbHVkQ0ExTURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QnpaV3htTG0xcGJHVnpkRzl1WlY4eklEMGdSMnh2WW1Gc1UzUmhkR1VvVlVsdWREWTBLREV3TUY4d01EQmZNREF3S1NrS0lDQWdJR0o1ZEdWaklESXdJQzh2SUNKdGFXeGxjM1J2Ym1WZk15SUtJQ0FnSUhCMWMyaHBiblFnTVRBd01EQXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOVFFLSUNBZ0lDOHZJSE5sYkdZdVltRmtaMlZmWVhOelpYUmZNU0E5SUVkc2IySmhiRk4wWVhSbEtGVkpiblEyTkNnd0tTa0tJQ0FnSUdKNWRHVmpJREkzSUM4dklDSmlZV1JuWlY5aGMzTmxkRjh4SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUbzFOUW9nSUNBZ0x5OGdjMlZzWmk1aVlXUm5aVjloYzNObGRGOHlJRDBnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwS0RBcEtRb2dJQ0FnWW5sMFpXTWdNamdnTHk4Z0ltSmhaR2RsWDJGemMyVjBYeklpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qVTJDaUFnSUNBdkx5QnpaV3htTG1KaFpHZGxYMkZ6YzJWMFh6TWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFl5QXlPU0F2THlBaVltRmtaMlZmWVhOelpYUmZNeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk5UY0tJQ0FnSUM4dklITmxiR1l1Y0dGamRGOWxibUZpYkdWa0lEMGdSMnh2WW1Gc1UzUmhkR1VvVlVsdWREWTBLREFwS1FvZ0lDQWdZbmwwWldNZ09TQXZMeUFpY0dGamRGOWxibUZpYkdWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8xT0FvZ0lDQWdMeThnYzJWc1ppNXdZV04wWDNKbGNYVnBjbVZrWDJGdGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbEtGVkpiblEyTkNneFh6QXdNRjh3TURBcEtRb2dJQ0FnWW5sMFpXTWdNakVnTHk4Z0luQmhZM1JmY21WeGRXbHlaV1JmWVcxdmRXNTBJZ29nSUNBZ2FXNTBZeUEwSUM4dklERXdNREF3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8xT1FvZ0lDQWdMeThnYzJWc1ppNXdZV04wWDJOaFpHVnVZMlZmYzJWamIyNWtjeUE5SUVkc2IySmhiRk4wWVhSbEtGVkpiblEyTkNnMk1EUmZPREF3S1NrS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKd1lXTjBYMk5oWkdWdVkyVmZjMlZqYjI1a2N5SUtJQ0FnSUhCMWMyaHBiblFnTmpBME9EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk5qQUtJQ0FnSUM4dklITmxiR1l1Y0dGamRGOXdaVzVoYkhSNVgyRnRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxLRlZKYm5RMk5DZ3hNREJmTURBd0tTa0tJQ0FnSUdKNWRHVmpJREV4SUM4dklDSndZV04wWDNCbGJtRnNkSGxmWVcxdmRXNTBJZ29nSUNBZ2NIVnphR2x1ZENBeE1EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUbzJNUW9nSUNBZ0x5OGdjMlZzWmk1d1lXTjBYM1Z6WlhKZllTQTlJRWRzYjJKaGJGTjBZWFJsS0VKNWRHVnpLR0lpSWlrcENpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaWNHRmpkRjkxYzJWeVgyRWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk5qSUtJQ0FnSUM4dklITmxiR1l1Y0dGamRGOTFjMlZ5WDJJZ1BTQkhiRzlpWVd4VGRHRjBaU2hDZVhSbGN5aGlJaUlwS1FvZ0lDQWdZbmwwWldNZ01UTWdMeThnSW5CaFkzUmZkWE5sY2w5aUlnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCelpXeG1Mbk4wWVdKc1pXTnZhVzVmWVhOelpYUmZhV1FnUFNCSGJHOWlZV3hUZEdGMFpTaFZTVzUwTmpRb01Da3BDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QWljM1JoWW14bFkyOXBibDloYzNObGRGOXBaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk5qUUtJQ0FnSUM4dklITmxiR1l1YzNSaFlteGxZMjlwYmw5MGIzUmhiQ0E5SUVkc2IySmhiRk4wWVhSbEtGVkpiblEyTkNnd0tTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luTjBZV0pzWldOdmFXNWZkRzkwWVd3aUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPalkxQ2lBZ0lDQXZMeUJ6Wld4bUxtSmxibVZtYVdOcFlYSjVYMkZrWkhJZ1BTQkhiRzlpWVd4VGRHRjBaU2hDZVhSbGN5aGlJaUlwS1FvZ0lDQWdZbmwwWldNZ01qSWdMeThnSW1KbGJtVm1hV05wWVhKNVgyRmtaSElpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOallLSUNBZ0lDOHZJSE5sYkdZdVltVnVaV1pwWTJsaGNubGZjbVZzWldGelpWOTBhVzFsYzNSaGJYQWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFl5QXpNQ0F2THlBaVltVnVaV1pwWTJsaGNubGZjbVZzWldGelpWOTBhVzFsYzNSaGJYQWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pZM0NpQWdJQ0F2THlCelpXeG1MbUZuWlc1MFgyRmtaSElnUFNCSGJHOWlZV3hUZEdGMFpTaENlWFJsY3loaUlpSXBLUW9nSUNBZ1lubDBaV01nTWpNZ0x5OGdJbUZuWlc1MFgyRmtaSElpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvNUNpQWdJQ0F2THlCamJHRnpjeUJUWVhacGJtZHpWbUYxYkhRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURJMUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnek1HTTJaRFU0WVNBdkx5QnRaWFJvYjJRZ0ltOXdkRjlwYmlncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZiM0IwWDJsdVgzSnZkWFJsUURVS0NtMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZPUW9nSUNBZ0x5OGdZMnhoYzNNZ1UyRjJhVzVuYzFaaGRXeDBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnek1qazRaVGRqTUNBd2VEZzBNVGc1T0Rrd0lEQjRPR05pTVRWaE1XVWdNSGhqT0RreFpqZ3haU0F3ZURNM1pXSmlOMlJoSURCNFlUTTRNVEk1TjJFZ01IZ3lZak5rTnpKaFl5QXdlR1l5TWpjNU5qazVJREI0TWpnelpUSmpNVElnTUhnNFkyUXdaV05qWWlBd2VEUXhOVEV4TVRGaUlEQjRPVGs0TmpVek56WWdNSGhsTTJabFpUVXpZU0F3ZUdFM1pHRm1NREEzSUM4dklHMWxkR2h2WkNBaVpHVndiM05wZENod1lYa3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSmpiMjVtYVdkMWNtVmZjM1JoWW14bFkyOXBibDloYm1SZmNtVnNaV0Z6WlNoMWFXNTBOalFzWVdSa2NtVnpjeXgxYVc1ME5qUXNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKa1pYQnZjMmwwWDNOMFlXSnNaV052YVc0b1lYaG1aWElzZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZV2RsYm5ScFkxOXlaV3hsWVhObEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamJHRnBiVjlpWVdSblpTaDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKM2FYUm9aSEpoZHloMWFXNTBOalFzWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFIxY0Y5ellYWnBibWR6WDNCaFkzUW9ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmhjSEJzZVY5d1lXTjBYM0JsYm1Gc2RIa29ZV1JrY21WemN5eHdZWGtwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p6WlhSZmRHVnRjSFJoZEdsdmJsOXNiMk5yS0hWcGJuUTJOQ3gxYVc1ME5qUXNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKa2FYTmhZbXhsWDNSbGJYQjBZWFJwYjI1ZmJHOWpheWdwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDJSeVpXRnRYMkp2WVhKa0tHSjVkR1ZiWFN4aWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwWDNWelpYSmZjM1JoZEhNb1lXUmtjbVZ6Y3lrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZloyeHZZbUZzWDNOMFlYUnpLQ2tvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEY5d1lXTjBYMk52Ym1acFp5Z3BLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCa1pYQnZjMmwwSUdOdmJtWnBaM1Z5WlY5emRHRmliR1ZqYjJsdVgyRnVaRjl5Wld4bFlYTmxJR1JsY0c5emFYUmZjM1JoWW14bFkyOXBiaUJoWjJWdWRHbGpYM0psYkdWaGMyVWdZMnhoYVcxZlltRmtaMlVnZDJsMGFHUnlZWGNnYzJWMGRYQmZjMkYyYVc1bmMxOXdZV04wSUdGd2NHeDVYM0JoWTNSZmNHVnVZV3gwZVNCelpYUmZkR1Z0Y0hSaGRHbHZibDlzYjJOcklHUnBjMkZpYkdWZmRHVnRjSFJoZEdsdmJsOXNiMk5ySUhObGRGOWtjbVZoYlY5aWIyRnlaQ0JuWlhSZmRYTmxjbDl6ZEdGMGN5Qm5aWFJmWjJ4dlltRnNYM04wWVhSeklHZGxkRjl3WVdOMFgyTnZibVpwWndvZ0lDQWdaWEp5Q2dwdFlXbHVYMjl3ZEY5cGJsOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T0RBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUM0IwU1c0aVhTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTVNBdkx5QlBjSFJKYmdvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JpSUc5d2RGOXBiZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeU5Ub0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5OaGRtbHVaM05mZG1GMWJIUXVZMjl1ZEhKaFkzUXVVMkYyYVc1bmMxWmhkV3gwTG05d2RGOXBibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q205d2RGOXBiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qZ3lDaUFnSUNBdkx5QnpaV3htTG5WelpYSmZkRzkwWVd4YlZIaHVMbk5sYm1SbGNsMGdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luVnpaWEpmZEc5MFlXd2lDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T0RNS0lDQWdJQzh2SUhObGJHWXVkWE5sY2w5dGFXeGxjM1J2Ym1WYlZIaHVMbk5sYm1SbGNsMGdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luVnpaWEpmYldsc1pYTjBiMjVsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qZzBDaUFnSUNBdkx5QnpaV3htTG5WelpYSmZjM1J5WldGclcxUjRiaTV6Wlc1a1pYSmRJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjFjMlZ5WDNOMGNtVmhheUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z2MyVnNaaTVzWVhOMFgyUmxjRzl6YVhSYlZIaHVMbk5sYm1SbGNsMGdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJREUxSUM4dklDSnNZWE4wWDJSbGNHOXphWFFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk9EWUtJQ0FnSUM4dklITmxiR1l1Ykc5amExOWxibUZpYkdWa1cxUjRiaTV6Wlc1a1pYSmRJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWliRzlqYTE5bGJtRmliR1ZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qZzNDaUFnSUNBdkx5QnpaV3htTG5WelpYSmZaMjloYkY5aGJXOTFiblJiVkhodUxuTmxibVJsY2wwZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklESTBJQzh2SUNKMWMyVnlYMmR2WVd4ZllXMXZkVzUwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QnpaV3htTG5WelpYSmZjR1Z1WVd4MGVWOWljSE5iVkhodUxuTmxibVJsY2wwZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklESTFJQzh2SUNKMWMyVnlYM0JsYm1Gc2RIbGZZbkJ6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qZzVDaUFnSUNBdkx5QnpaV3htTG5CbGJtRnNkSGxmYzJsdWExdFVlRzR1YzJWdVpHVnlYU0E5SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJREkySUM4dklDSndaVzVoYkhSNVgzTnBibXNpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z2MyVnNaaTVrY21WaGJWOTFjbWxiVkhodUxuTmxibVJsY2wwZ1BTQkNlWFJsY3loaUlpSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QXpNU0F2THlBaVpISmxZVzFmZFhKcElnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T1RFS0lDQWdJQzh2SUhObGJHWXVaSEpsWVcxZmRHbDBiR1ZiVkhodUxuTmxibVJsY2wwZ1BTQkNlWFJsY3loaUlpSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QXpNaUF2THlBaVpISmxZVzFmZEdsMGJHVWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z2MyVnNaaTUxYzJWeVgzTjBZV0pzWldOdmFXNWZkRzkwWVd4YlZIaHVMbk5sYm1SbGNsMGdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJREUzSUM4dklDSjFjMlZ5WDNOMFlXSnNaV052YVc1ZmRHOTBZV3dpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk9UTUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZkWE5sY25NdWRtRnNkV1VnS3owZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09DQXZMeUFpZEc5MFlXeGZkWE5sY25NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmRYTmxjbk1nWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldNZ09DQXZMeUFpZEc5MFlXeGZkWE5sY25NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T0RBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUM0IwU1c0aVhTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YzJGMmFXNW5jMTkyWVhWc2RDNWpiMjUwY21GamRDNVRZWFpwYm1kelZtRjFiSFF1WkdWd2IzTnBkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbGNHOXphWFE2Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0lpQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qazFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk9UY0tJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG81T0FvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVZVzF2ZFc1MElENDlJRlZKYm5RMk5DZ3hYekF3TUY4d01EQXBDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNQW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk9Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG5ObGJtUmxjaUE5UFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXdNQW9nSUNBZ0x5OGdjMlZzWmk1MWMyVnlYM1J2ZEdGc1cxUjRiaTV6Wlc1a1pYSmRJQ3M5SUhCaGVXMWxiblF1WVcxdmRXNTBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oxYzJWeVgzUnZkR0ZzSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRYTmxjbDkwYjNSaGJDQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUdScFp5QXlDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMWMyVnlYM1J2ZEdGc0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRBeENpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyUmxjRzl6YVhSbFpDNTJZV3gxWlNBclBTQndZWGx0Wlc1MExtRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJ2ZEdGc1gyUmxjRzl6YVhSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOWtaWEJ2YzJsMFpXUWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZaR1Z3YjNOcGRHVmtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXdNZ29nSUNBZ0x5OGdjMlZzWmk1MllYVnNkRjlpWVd4aGJtTmxMblpoYkhWbElDczlJSEJoZVcxbGJuUXVZVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZG1GMWJIUmZZbUZzWVc1alpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUyWVhWc2RGOWlZV3hoYm1ObElHVjRhWE4wY3dvZ0lDQWdLd29nSUNBZ1lubDBaV05mTWlBdkx5QWlkbUYxYkhSZlltRnNZVzVqWlNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TURNS0lDQWdJQzh2SUdsbUlITmxiR1l1YkdGemRGOWtaWEJ2YzJsMFcxUjRiaTV6Wlc1a1pYSmRJRDRnVlVsdWREWTBLREFwT2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUxSUM4dklDSnNZWE4wWDJSbGNHOXphWFFpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1c1lYTjBYMlJsY0c5emFYUWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNCaWVpQmtaWEJ2YzJsMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVEEwQ2lBZ0lDQXZMeUJ6Wld4bUxuVnpaWEpmYzNSeVpXRnJXMVI0Ymk1elpXNWtaWEpkSUNzOUlGVkpiblEyTkNneEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkWE5sY2w5emRISmxZV3NpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MWMyVnlYM04wY21WaGF5QmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0oxYzJWeVgzTjBjbVZoYXlJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0NtUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVEExQ2lBZ0lDQXZMeUJ6Wld4bUxteGhjM1JmWkdWd2IzTnBkRnRVZUc0dWMyVnVaR1Z5WFNBOUlFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUF4TlNBdkx5QWliR0Z6ZEY5a1pYQnZjMmwwSWdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVEEyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1ZlkyaGxZMnRmYldsc1pYTjBiMjVsS0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3pNVElLSUNBZ0lDOHZJR0poYkNBOUlITmxiR1l1ZFhObGNsOTBiM1JoYkZ0MWMyVnlYUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRYTmxjbDkwYjNSaGJDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MWMyVnlYM1J2ZEdGc0lHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TXpFekNpQWdJQ0F2THlCamRYSnlaVzUwSUQwZ2MyVnNaaTUxYzJWeVgyMXBiR1Z6ZEc5dVpWdDFjMlZ5WFFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblZ6WlhKZmJXbHNaWE4wYjI1bElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1luVnllU0F6Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUxYzJWeVgyMXBiR1Z6ZEc5dVpTQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pNeE5Bb2dJQ0FnTHk4Z2FXWWdZbUZzSUQ0OUlITmxiR1l1Yldsc1pYTjBiMjVsWHpNdWRtRnNkV1VnWVc1a0lHTjFjbkpsYm5RZ1BDQlZTVzUwTmpRb015azZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNakFnTHk4Z0ltMXBiR1Z6ZEc5dVpWOHpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xcGJHVnpkRzl1WlY4eklHVjRhWE4wY3dvZ0lDQWdQajBLSUNBZ0lHSjZJR1JsY0c5emFYUmZaV3h6WlY5aWIyUjVRRGNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0E4Q2lBZ0lDQmllaUJrWlhCdmMybDBYMlZzYzJWZlltOWtlVUEzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3pNVFVLSUNBZ0lDOHZJSEpsZEhWeWJpQlZTVzUwTmpRb015a0tJQ0FnSUhCMWMyaHBiblFnTXdvS1pHVndiM05wZEY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NXpZWFpwYm1kelgzWmhkV3gwTG1OdmJuUnlZV04wTGxOaGRtbHVaM05XWVhWc2RDNWZZMmhsWTJ0ZmJXbHNaWE4wYjI1bFFERTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk9UVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1pHVndiM05wZEY5bGJITmxYMkp2WkhsQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pNeE5nb2dJQ0FnTHk4Z1pXeHBaaUJpWVd3Z1BqMGdjMlZzWmk1dGFXeGxjM1J2Ym1WZk1pNTJZV3gxWlNCaGJtUWdZM1Z5Y21WdWRDQThJRlZKYm5RMk5DZ3lLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QWliV2xzWlhOMGIyNWxYeklpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXbHNaWE4wYjI1bFh6SWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01nb2dJQ0FnUEQwS0lDQWdJR0o2SUdSbGNHOXphWFJmWld4elpWOWliMlI1UURFd0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1BBb2dJQ0FnWW5vZ1pHVndiM05wZEY5bGJITmxYMkp2WkhsQU1UQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pNeE53b2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d5S1FvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE1EWUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbDlqYUdWamExOXRhV3hsYzNSdmJtVW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lHSWdaR1Z3YjNOcGRGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTV6WVhacGJtZHpYM1poZFd4MExtTnZiblJ5WVdOMExsTmhkbWx1WjNOV1lYVnNkQzVmWTJobFkydGZiV2xzWlhOMGIyNWxRREUwQ2dwa1pYQnZjMmwwWDJWc2MyVmZZbTlrZVVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pNeE9Bb2dJQ0FnTHk4Z1pXeHBaaUJpWVd3Z1BqMGdjMlZzWmk1dGFXeGxjM1J2Ym1WZk1TNTJZV3gxWlNCaGJtUWdZM1Z5Y21WdWRDQThJRlZKYm5RMk5DZ3hLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4T0NBdkx5QWliV2xzWlhOMGIyNWxYekVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXbHNaWE4wYjI1bFh6RWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01nb2dJQ0FnUEQwS0lDQWdJR0o2SUdSbGNHOXphWFJmWVdaMFpYSmZhV1pmWld4elpVQXhNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUEFvZ0lDQWdZbm9nWkdWd2IzTnBkRjloWm5SbGNsOXBabDlsYkhObFFERXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvek1Ua0tJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNRFlLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTGw5amFHVmphMTl0YVd4bGMzUnZibVVvVkhodUxuTmxibVJsY2lrS0lDQWdJR0lnWkdWd2IzTnBkRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1ellYWnBibWR6WDNaaGRXeDBMbU52Ym5SeVlXTjBMbE5oZG1sdVozTldZWFZzZEM1ZlkyaGxZMnRmYldsc1pYTjBiMjVsUURFMENncGtaWEJ2YzJsMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG96TWpBS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE1EWUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbDlqYUdWamExOXRhV3hsYzNSdmJtVW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lHSWdaR1Z3YjNOcGRGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTV6WVhacGJtZHpYM1poZFd4MExtTnZiblJ5WVdOMExsTmhkbWx1WjNOV1lYVnNkQzVmWTJobFkydGZiV2xzWlhOMGIyNWxRREUwQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTmhkbWx1WjNOZmRtRjFiSFF1WTI5dWRISmhZM1F1VTJGMmFXNW5jMVpoZFd4MExtTnZibVpwWjNWeVpWOXpkR0ZpYkdWamIybHVYMkZ1WkY5eVpXeGxZWE5sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyOXVabWxuZFhKbFgzTjBZV0pzWldOdmFXNWZZVzVrWDNKbGJHVmhjMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNRGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXlOUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNallLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpkR0ZpYkdWamIybHVYMkZ6YzJWMFgybGtJRDRnVlVsdWREWTBLREFwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TWpjS0lDQWdJQzh2SUhObGJHWXVjM1JoWW14bFkyOXBibDloYzNObGRGOXBaQzUyWVd4MVpTQTlJSE4wWVdKc1pXTnZhVzVmWVhOelpYUmZhV1FLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0p6ZEdGaWJHVmpiMmx1WDJGemMyVjBYMmxrSWdvZ0lDQWdaR2xuSURRS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TWpnS0lDQWdJQzh2SUhObGJHWXVZbVZ1WldacFkybGhjbmxmWVdSa2NpNTJZV3gxWlNBOUlHSmxibVZtYVdOcFlYSjVMbUo1ZEdWekNpQWdJQ0JpZVhSbFl5QXlNaUF2THlBaVltVnVaV1pwWTJsaGNubGZZV1JrY2lJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXlPUW9nSUNBZ0x5OGdjMlZzWmk1aVpXNWxabWxqYVdGeWVWOXlaV3hsWVhObFgzUnBiV1Z6ZEdGdGNDNTJZV3gxWlNBOUlISmxiR1ZoYzJWZmRITUtJQ0FnSUdKNWRHVmpJRE13SUM4dklDSmlaVzVsWm1samFXRnllVjl5Wld4bFlYTmxYM1JwYldWemRHRnRjQ0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFek1Bb2dJQ0FnTHk4Z2MyVnNaaTVoWjJWdWRGOWhaR1J5TG5aaGJIVmxJRDBnWVdkbGJuUXVZbmwwWlhNS0lDQWdJR0o1ZEdWaklESXpJQzh2SUNKaFoyVnVkRjloWkdSeUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFek1pMHhOREFLSUNBZ0lDOHZJQ01nUlc1emRYSmxJSFJvWlNCaGNIQWdZV05qYjNWdWRDQnBjeUJ2Y0hSbFpDQnBiblJ2SUhSb1pTQmpiMjVtYVdkMWNtVmtJSE4wWVdKc1pXTnZhVzRnUVZOQkxnb2dJQ0FnTHk4Z0l5QlBjSFF0YVc0Z2FYTWdZU0F3TFdGdGIzVnVkQ0JCYzNObGRGUnlZVzV6Wm1WeUlIUnZJSE5sYkdZZ1puSnZiU0IwYUdVZ1lYQndJR0ZqWTI5MWJuUXVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5YzNSaFlteGxZMjlwYmw5aGMzTmxkRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXpOUW9nSUNBZ0x5OGdjMlZ1WkdWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRNMkNpQWdJQ0F2THlCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNemNLSUNBZ0lDOHZJR0Z6YzJWMFgyRnRiM1Z1ZEQxVlNXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UTXlMVEV6TkFvZ0lDQWdMeThnSXlCRmJuTjFjbVVnZEdobElHRndjQ0JoWTJOdmRXNTBJR2x6SUc5d2RHVmtJR2x1ZEc4Z2RHaGxJR052Ym1acFozVnlaV1FnYzNSaFlteGxZMjlwYmlCQlUwRXVDaUFnSUNBdkx5QWpJRTl3ZEMxcGJpQnBjeUJoSURBdFlXMXZkVzUwSUVGemMyVjBWSEpoYm5ObVpYSWdkRzhnYzJWc1ppQm1jbTl0SUhSb1pTQmhjSEFnWVdOamIzVnVkQzRLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVE01Q2lBZ0lDQXZMeUJtWldVOU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRNeUxURTBNQW9nSUNBZ0x5OGdJeUJGYm5OMWNtVWdkR2hsSUdGd2NDQmhZMk52ZFc1MElHbHpJRzl3ZEdWa0lHbHVkRzhnZEdobElHTnZibVpwWjNWeVpXUWdjM1JoWW14bFkyOXBiaUJCVTBFdUNpQWdJQ0F2THlBaklFOXdkQzFwYmlCcGN5QmhJREF0WVcxdmRXNTBJRUZ6YzJWMFZISmhibk5tWlhJZ2RHOGdjMlZzWmlCbWNtOXRJSFJvWlNCaGNIQWdZV05qYjNWdWRDNEtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0J6Wlc1a1pYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDF6ZEdGaWJHVmpiMmx1WDJGemMyVjBYMmxrTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXdPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5oZG1sdVozTmZkbUYxYkhRdVkyOXVkSEpoWTNRdVUyRjJhVzVuYzFaaGRXeDBMbVJsY0c5emFYUmZjM1JoWW14bFkyOXBibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbGNHOXphWFJmYzNSaFlteGxZMjlwYmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakUwTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRjRabVZ5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TkRrS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjBZV0pzWldOdmFXNWZZWE56WlhSZmFXUXVkbUZzZFdVZ1BpQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaWMzUmhZbXhsWTI5cGJsOWhjM05sZEY5cFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEdGaWJHVmpiMmx1WDJGemMyVjBYMmxrSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTFNQW9nSUNBZ0x5OGdZWE56WlhKMElHRnpjMlYwWDJsa0lEMDlJSE5sYkdZdWMzUmhZbXhsWTI5cGJsOWhjM05sZEY5cFpDNTJZV3gxWlFvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakUxTWkweE5qQUtJQ0FnSUM4dklDTWdSbTl5WTJVZ2IzQjBMV2x1SUhOaFptVjBlVG9nWVNBd0xXRnRiM1Z1ZENCelpXeG1MWFJ5WVc1elptVnlJR1p5YjIwZ2RHaGxJR0Z3Y0NCaFkyTnZkVzUwSUc5d2RITXRhVzRnYVdZZ2JtVmxaR1ZrTGdvZ0lDQWdMeThnSXlCVWFHbHpJR2x6SUhOaFptVWdkRzhnY25WdUlHVjJaVzRnYVdZZ1lXeHlaV0ZrZVNCdmNIUmxaQzFwYmk0S0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEY5cFpDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakUxTlFvZ0lDQWdMeThnYzJWdVpHVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UVTJDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTFOd29nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE5USXRNVFUwQ2lBZ0lDQXZMeUFqSUVadmNtTmxJRzl3ZEMxcGJpQnpZV1psZEhrNklHRWdNQzFoYlc5MWJuUWdjMlZzWmkxMGNtRnVjMlpsY2lCbWNtOXRJSFJvWlNCaGNIQWdZV05qYjNWdWRDQnZjSFJ6TFdsdUlHbG1JRzVsWldSbFpDNEtJQ0FnSUM4dklDTWdWR2hwY3lCcGN5QnpZV1psSUhSdklISjFiaUJsZG1WdUlHbG1JR0ZzY21WaFpIa2diM0IwWldRdGFXNHVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTFPUW9nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakUxTWkweE5qQUtJQ0FnSUM4dklDTWdSbTl5WTJVZ2IzQjBMV2x1SUhOaFptVjBlVG9nWVNBd0xXRnRiM1Z1ZENCelpXeG1MWFJ5WVc1elptVnlJR1p5YjIwZ2RHaGxJR0Z3Y0NCaFkyTnZkVzUwSUc5d2RITXRhVzRnYVdZZ2JtVmxaR1ZrTGdvZ0lDQWdMeThnSXlCVWFHbHpJR2x6SUhOaFptVWdkRzhnY25WdUlHVjJaVzRnYVdZZ1lXeHlaV0ZrZVNCdmNIUmxaQzFwYmk0S0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEY5cFpDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TmpJS0lDQWdJQzh2SUdGemMyVnlkQ0JoZUdabGNpNWhjM05sZEY5eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakUyTXkweE5qUUtJQ0FnSUM4dklDTWdTVzRnVUhWNVlWQjVMQ0I0Wm1WeVgyRnpjMlYwSUdseklHRnVJRUZ6YzJWMElIUjVjR1U3SUdOdmJYQmhjbVVnWW5rZ2FXUUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGVHWmxjaTU0Wm1WeVgyRnpjMlYwTG1sa0lEMDlJR0Z6YzJWMFgybGtDaUFnSUNCa2FXY2dNUW9nSUNBZ1ozUjRibk1nV0dabGNrRnpjMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hOalVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhlR1psY2k1elpXNWtaWElnUFQwZ1ZIaHVMbk5sYm1SbGNnb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTJOZ29nSUNBZ0x5OGdZWE56WlhKMElHRjRabVZ5TG1GemMyVjBYMkZ0YjNWdWRDQStJRlZKYm5RMk5DZ3dLUW9nSUNBZ1ozUjRibk1nUVhOelpYUkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TmpjS0lDQWdJQzh2SUhObGJHWXVkWE5sY2w5emRHRmliR1ZqYjJsdVgzUnZkR0ZzVzFSNGJpNXpaVzVrWlhKZElDczlJR0Y0Wm1WeUxtRnpjMlYwWDJGdGIzVnVkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UY2dMeThnSW5WelpYSmZjM1JoWW14bFkyOXBibDkwYjNSaGJDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblZ6WlhKZmMzUmhZbXhsWTI5cGJsOTBiM1JoYkNCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJR1JwWnlBeUNpQWdJQ0FyQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUFpZFhObGNsOXpkR0ZpYkdWamIybHVYM1J2ZEdGc0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRZNENpQWdJQ0F2THlCelpXeG1Mbk4wWVdKc1pXTnZhVzVmZEc5MFlXd3VkbUZzZFdVZ0t6MGdZWGhtWlhJdVlYTnpaWFJmWVcxdmRXNTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWMzUmhZbXhsWTI5cGJsOTBiM1JoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpkR0ZpYkdWamIybHVYM1J2ZEdGc0lHVjRhWE4wY3dvZ0lDQWdaR2xuSURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbk4wWVdKc1pXTnZhVzVmZEc5MFlXd2lDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UWTVDaUFnSUNBdkx5QnpaV3htTG5aaGRXeDBYMkpoYkdGdVkyVXVkbUZzZFdVZ0t6MGdZWGhtWlhJdVlYTnpaWFJmWVcxdmRXNTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRtRjFiSFJmWW1Gc1lXNWpaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MllYVnNkRjlpWVd4aGJtTmxJR1Y0YVhOMGN3b2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZG1GMWJIUmZZbUZzWVc1alpTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE56QUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MblZ6WlhKZmMzUmhZbXhsWTI5cGJsOTBiM1JoYkZ0VWVHNHVjMlZ1WkdWeVhRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0oxYzJWeVgzTjBZV0pzWldOdmFXNWZkRzkwWVd3aUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTFjMlZ5WDNOMFlXSnNaV052YVc1ZmRHOTBZV3dnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hORElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6WVhacGJtZHpYM1poZFd4MExtTnZiblJ5WVdOMExsTmhkbWx1WjNOV1lYVnNkQzVoWjJWdWRHbGpYM0psYkdWaGMyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWjJWdWRHbGpYM0psYkdWaGMyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE56a3RNVGd3Q2lBZ0lDQXZMeUFqSUVGalkyVnpjeUJqYjI1MGNtOXNPaUJ2Ym14NUlIUm9aU0JqYjI1bWFXZDFjbVZrSUdGblpXNTBJR05oYmlCMGNtbG5aMlZ5SUhKbGJHVmhjMlV1Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aFoyVnVkRjloWkdSeUxuWmhiSFZsSUNFOUlFSjVkR1Z6S0dJaUlpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXlNeUF2THlBaVlXZGxiblJmWVdSa2NpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWjJWdWRGOWhaR1J5SUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE9ESUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJR0ZuWlc1MFgyRmtaSEpsYzNNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTROQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1YzNSaFlteGxZMjlwYmw5aGMzTmxkRjlwWkM1MllXeDFaU0ErSUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0p6ZEdGaWJHVmpiMmx1WDJGemMyVjBYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTjBZV0pzWldOdmFXNWZZWE56WlhSZmFXUWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRnMUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWlaVzVsWm1samFXRnllVjloWkdSeUxuWmhiSFZsSUNFOUlFSjVkR1Z6S0dJaUlpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXlNaUF2THlBaVltVnVaV1pwWTJsaGNubGZZV1JrY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWlaVzVsWm1samFXRnllVjloWkdSeUlHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hPRFlLSUNBZ0lDOHZJR0Z0YjNWdWRDQTlJSE5sYkdZdWMzUmhZbXhsWTI5cGJsOTBiM1JoYkM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luTjBZV0pzWldOdmFXNWZkRzkwWVd3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoWW14bFkyOXBibDkwYjNSaGJDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakU0TndvZ0lDQWdMeThnWVhOelpYSjBJR0Z0YjNWdWRDQStJRlZKYm5RMk5DZ3dLUW9nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTVNQzB4T1RZS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxaVpXNWxabWxqYVdGeWVWOWhZMk4wTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxelpXeG1Mbk4wWVdKc1pXTnZhVzVmWVhOelpYUmZhV1F1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94T1RFS0lDQWdJQzh2SUhObGJtUmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFNU1Bb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE9UVUtJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hPVEF0TVRrMkNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVltVnVaV1pwWTJsaGNubGZZV05qZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROWMyVnNaaTV6ZEdGaWJHVmpiMmx1WDJGemMyVjBYMmxrTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFNU53b2dJQ0FnTHk4Z2MyVnNaaTV6ZEdGaWJHVmpiMmx1WDNSdmRHRnNMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUExSUM4dklDSnpkR0ZpYkdWamIybHVYM1J2ZEdGc0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94T1RndE1UazVDaUFnSUNBdkx5QWpJRXRsWlhBZ1kyOXRZbWx1WldRZ2RtRjFiSFFnYldGeWEyVnlJR2x1SUhONWJtTUtJQ0FnSUM4dklITmxiR1l1ZG1GMWJIUmZZbUZzWVc1alpTNTJZV3gxWlNBdFBTQmhiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0oyWVhWc2RGOWlZV3hoYm1ObElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblpoZFd4MFgySmhiR0Z1WTJVZ1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjJZWFZzZEY5aVlXeGhibU5sSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakUzTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5OaGRtbHVaM05mZG1GMWJIUXVZMjl1ZEhKaFkzUXVVMkYyYVc1bmMxWmhkV3gwTG1Oc1lXbHRYMkpoWkdkbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMnhoYVcxZlltRmtaMlU2Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0lpQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSXdNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJd013b2dJQ0FnTHk4Z1kzVnljbVZ1ZENBOUlITmxiR1l1ZFhObGNsOXRhV3hsYzNSdmJtVmJWSGh1TG5ObGJtUmxjbDBLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMWMyVnlYMjFwYkdWemRHOXVaU0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5WelpYSmZiV2xzWlhOMGIyNWxJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qQTBDaUFnSUNBdkx5QmhjM05sY25RZ2JXbHNaWE4wYjI1bFgyeGxkbVZzSUQ0Z1kzVnljbVZ1ZEFvZ0lDQWdaR2xuSURFS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNakExTFRJd05nb2dJQ0FnTHk4Z0l5QlFjbVYyWlc1MElHbHVkbUZzYVdRZ2JHVjJaV3dnYVc1cVpXTjBhVzl1SUNobExtY3VJRFFyS1NCbWNtOXRJRzExZEdGMGFXNW5JR3h2WTJGc0lITjBZWFJsTGdvZ0lDQWdMeThnWVhOelpYSjBJRzFwYkdWemRHOXVaVjlzWlhabGJDQStQU0JWU1c1ME5qUW9NU2tnWVc1a0lHMXBiR1Z6ZEc5dVpWOXNaWFpsYkNBOFBTQlZTVzUwTmpRb015a0tJQ0FnSUdKNklHTnNZV2x0WDJKaFpHZGxYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUR3OUNpQWdJQ0JpZWlCamJHRnBiVjlpWVdSblpWOWliMjlzWDJaaGJITmxRRFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3BqYkdGcGJWOWlZV1JuWlY5aWIyOXNYMjFsY21kbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU1EVXRNakEyQ2lBZ0lDQXZMeUFqSUZCeVpYWmxiblFnYVc1MllXeHBaQ0JzWlhabGJDQnBibXBsWTNScGIyNGdLR1V1Wnk0Z05Dc3BJR1p5YjIwZ2JYVjBZWFJwYm1jZ2JHOWpZV3dnYzNSaGRHVXVDaUFnSUNBdkx5QmhjM05sY25RZ2JXbHNaWE4wYjI1bFgyeGxkbVZzSUQ0OUlGVkpiblEyTkNneEtTQmhibVFnYldsc1pYTjBiMjVsWDJ4bGRtVnNJRHc5SUZWSmJuUTJOQ2d6S1FvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95TURjS0lDQWdJQzh2SUhWelpYSmZZbUZzSUQwZ2MyVnNaaTUxYzJWeVgzUnZkR0ZzVzFSNGJpNXpaVzVrWlhKZENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkWE5sY2w5MGIzUmhiQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJSE4zWVhBS0lDQWdJR0oxY25rZ013b2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRYTmxjbDkwYjNSaGJDQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJd09Bb2dJQ0FnTHk4Z1ltRmtaMlZmYVdRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZFhKNUlETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJd09Rb2dJQ0FnTHk4Z2FXWWdiV2xzWlhOMGIyNWxYMnhsZG1Wc0lEMDlJRlZKYm5RMk5DZ3hLVG9LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JpZWlCamJHRnBiVjlpWVdSblpWOWxiSE5sWDJKdlpIbEFOd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qRXdDaUFnSUNBdkx5QmhjM05sY25RZ2RYTmxjbDlpWVd3Z1BqMGdjMlZzWmk1dGFXeGxjM1J2Ym1WZk1TNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFNElDOHZJQ0p0YVd4bGMzUnZibVZmTVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRhV3hsYzNSdmJtVmZNU0JsZUdsemRITUtJQ0FnSUdScFp5QXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU1URUtJQ0FnSUM4dklHSmhaR2RsWDJsa0lEMGdjMlZzWmk1ZmJXbHVkRjlpWVdSblpTaENlWFJsY3loaUlsWmhkV3gwSUZOMFlYSjBaWElpS1N3Z1FubDBaWE1vWWlKV1V6RWlLU3dnUW5sMFpYTW9ZaUpwY0daek9pOHZVVzFDWVdSblpURWlLU2tLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGcxTmpZeE56VTJZemMwTWpBMU16YzBOakUzTWpjME5qVTNNaUF3ZURVMk5UTXpNU0F3ZURZNU56QTJOamN6TTJFeVpqSm1OVEUyWkRReU5qRTJORFkzTmpVek1Rb2dJQ0FnWTJGc2JITjFZaUJmYldsdWRGOWlZV1JuWlFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakl4TWdvZ0lDQWdMeThnYzJWc1ppNWlZV1JuWlY5aGMzTmxkRjh4TG5aaGJIVmxJRDBnWW1Ga1oyVmZhV1FLSUNBZ0lHSjVkR1ZqSURJM0lDOHZJQ0ppWVdSblpWOWhjM05sZEY4eElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbU5zWVdsdFgySmhaR2RsWDJGbWRHVnlYMmxtWDJWc2MyVkFNVE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lNakVLSUNBZ0lDOHZJSE5sYkdZdWRYTmxjbDl0YVd4bGMzUnZibVZiVkhodUxuTmxibVJsY2wwZ1BTQnRhV3hsYzNSdmJtVmZiR1YyWld3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblZ6WlhKZmJXbHNaWE4wYjI1bElnb2dJQ0FnWkdsbklESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJd01Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1kyeGhhVzFmWW1Ga1oyVmZaV3h6WlY5aWIyUjVRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lNVE1LSUNBZ0lDOHZJR1ZzYVdZZ2JXbHNaWE4wYjI1bFgyeGxkbVZzSUQwOUlGVkpiblEyTkNneUtUb0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZMnhoYVcxZlltRmtaMlZmWld4elpWOWliMlI1UURrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakl4TkFvZ0lDQWdMeThnWVhOelpYSjBJSFZ6WlhKZlltRnNJRDQ5SUhObGJHWXViV2xzWlhOMGIyNWxYekl1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhPU0F2THlBaWJXbHNaWE4wYjI1bFh6SWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Yldsc1pYTjBiMjVsWHpJZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNakUxQ2lBZ0lDQXZMeUJpWVdSblpWOXBaQ0E5SUhObGJHWXVYMjFwYm5SZlltRmtaMlVvUW5sMFpYTW9ZaUpXWVhWc2RDQkNkV2xzWkdWeUlpa3NJRUo1ZEdWektHSWlWa0l5SWlrc0lFSjVkR1Z6S0dJaWFYQm1jem92TDFGdFFtRmtaMlV5SWlrcENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE5UWTJNVGMxTm1NM05ESXdOREkzTlRZNU5tTTJORFkxTnpJZ01IZzFOalF5TXpJZ01IZzJPVGN3TmpZM016TmhNbVl5WmpVeE5tUTBNall4TmpRMk56WTFNeklLSUNBZ0lHTmhiR3h6ZFdJZ1gyMXBiblJmWW1Ga1oyVUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU1UWUtJQ0FnSUM4dklITmxiR1l1WW1Ga1oyVmZZWE56WlhSZk1pNTJZV3gxWlNBOUlHSmhaR2RsWDJsa0NpQWdJQ0JpZVhSbFl5QXlPQ0F2THlBaVltRmtaMlZmWVhOelpYUmZNaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmlJR05zWVdsdFgySmhaR2RsWDJGbWRHVnlYMmxtWDJWc2MyVkFNVE1LQ21Oc1lXbHRYMkpoWkdkbFgyVnNjMlZmWW05a2VVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qRTNDaUFnSUNBdkx5QmxiR2xtSUcxcGJHVnpkRzl1WlY5c1pYWmxiQ0E5UFNCVlNXNTBOalFvTXlrNkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1BUMEtJQ0FnSUdKNklHTnNZV2x0WDJKaFpHZGxYMkZtZEdWeVgybG1YMlZzYzJWQU1UTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJeE9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhWelpYSmZZbUZzSUQ0OUlITmxiR1l1Yldsc1pYTjBiMjVsWHpNdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF5TUNBdkx5QWliV2xzWlhOMGIyNWxYek1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXbHNaWE4wYjI1bFh6TWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TWpFNUNpQWdJQ0F2THlCaVlXUm5aVjlwWkNBOUlITmxiR1l1WDIxcGJuUmZZbUZrWjJVb1FubDBaWE1vWWlKV1lYVnNkQ0JOWVhOMFpYSWlLU3dnUW5sMFpYTW9ZaUpXVFRNaUtTd2dRbmwwWlhNb1lpSnBjR1p6T2k4dlVXMUNZV1JuWlRNaUtTa0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzFOall4TnpVMll6YzBNakEwWkRZeE56TTNORFkxTnpJZ01IZzFOalJrTXpNZ01IZzJPVGN3TmpZM016TmhNbVl5WmpVeE5tUTBNall4TmpRMk56WTFNek1LSUNBZ0lHTmhiR3h6ZFdJZ1gyMXBiblJmWW1Ga1oyVUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU1qQUtJQ0FnSUM4dklITmxiR1l1WW1Ga1oyVmZZWE56WlhSZk15NTJZV3gxWlNBOUlHSmhaR2RsWDJsa0NpQWdJQ0JpZVhSbFl5QXlPU0F2THlBaVltRmtaMlZmWVhOelpYUmZNeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmlJR05zWVdsdFgySmhaR2RsWDJGbWRHVnlYMmxtWDJWc2MyVkFNVE1LQ21Oc1lXbHRYMkpoWkdkbFgySnZiMnhmWm1Gc2MyVkFORG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHTnNZV2x0WDJKaFpHZGxYMkp2YjJ4ZmJXVnlaMlZBTlFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpZWFpwYm1kelgzWmhkV3gwTG1OdmJuUnlZV04wTGxOaGRtbHVaM05XWVhWc2RDNTNhWFJvWkhKaGQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbmRwZEdoa2NtRjNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qSTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU1qWUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MblZ6WlhKZmRHOTBZV3hiVkhodUxuTmxibVJsY2wwZ1BqMGdZVzF2ZFc1MENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkWE5sY2w5MGIzUmhiQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5WelpYSmZkRzkwWVd3Z1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95TWpjS0lDQWdJQzh2SUhCbGJtRnNkSGtnUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lNamtLSUNBZ0lDOHZJSE5sYkdZdWJHOWphMTlsYm1GaWJHVmtXMVI0Ymk1elpXNWtaWEpkSUQwOUlGVkpiblEyTkNneEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0pzYjJOclgyVnVZV0pzWldRaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXNiMk5yWDJWdVlXSnNaV1FnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJeU9TMHlNekFLSUNBZ0lDOHZJSE5sYkdZdWJHOWphMTlsYm1GaWJHVmtXMVI0Ymk1elpXNWtaWEpkSUQwOUlGVkpiblEyTkNneEtRb2dJQ0FnTHk4Z1lXNWtJSE5sYkdZdWRYTmxjbDkwYjNSaGJGdFVlRzR1YzJWdVpHVnlYU0E4SUhObGJHWXVkWE5sY2w5bmIyRnNYMkZ0YjNWdWRGdFVlRzR1YzJWdVpHVnlYUW9nSUNBZ1lub2dkMmwwYUdSeVlYZGZZV1owWlhKZmFXWmZaV3h6WlVBM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95TXpBS0lDQWdJQzh2SUdGdVpDQnpaV3htTG5WelpYSmZkRzkwWVd4YlZIaHVMbk5sYm1SbGNsMGdQQ0J6Wld4bUxuVnpaWEpmWjI5aGJGOWhiVzkxYm5SYlZIaHVMbk5sYm1SbGNsMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oxYzJWeVgzUnZkR0ZzSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRYTmxjbDkwYjNSaGJDQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU5DQXZMeUFpZFhObGNsOW5iMkZzWDJGdGIzVnVkQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5WelpYSmZaMjloYkY5aGJXOTFiblFnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQThDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU1qa3RNak13Q2lBZ0lDQXZMeUJ6Wld4bUxteHZZMnRmWlc1aFlteGxaRnRVZUc0dWMyVnVaR1Z5WFNBOVBTQlZTVzUwTmpRb01Ta0tJQ0FnSUM4dklHRnVaQ0J6Wld4bUxuVnpaWEpmZEc5MFlXeGJWSGh1TG5ObGJtUmxjbDBnUENCelpXeG1MblZ6WlhKZloyOWhiRjloYlc5MWJuUmJWSGh1TG5ObGJtUmxjbDBLSUNBZ0lHSjZJSGRwZEdoa2NtRjNYMkZtZEdWeVgybG1YMlZzYzJWQU53b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TWpNeUNpQWdJQ0F2THlCaGMzTmxjblFnY0dWdVlXeDBlVjl6YVc1ckxtSjVkR1Z6SUQwOUlITmxiR1l1Y0dWdVlXeDBlVjl6YVc1clcxUjRiaTV6Wlc1a1pYSmRDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01qWWdMeThnSW5CbGJtRnNkSGxmYzJsdWF5SUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJsYm1Gc2RIbGZjMmx1YXlCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJR1JwWnlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95TXpNS0lDQWdJQzh2SUhCbGJtRnNkSGtnUFNBb1lXMXZkVzUwSUNvZ2MyVnNaaTUxYzJWeVgzQmxibUZzZEhsZlluQnpXMVI0Ymk1elpXNWtaWEpkS1NBdkx5QlZTVzUwTmpRb01UQmZNREF3S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREkxSUM4dklDSjFjMlZ5WDNCbGJtRnNkSGxmWW5Ceklnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkWE5sY2w5d1pXNWhiSFI1WDJKd2N5QmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUdScFp5QXpDaUFnSUNBcUNpQWdJQ0J3ZFhOb2FXNTBJREV3TURBd0NpQWdJQ0F2Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNak0wQ2lBZ0lDQXZMeUJwWmlCd1pXNWhiSFI1SUQ0Z1ZVbHVkRFkwS0RBcE9nb2dJQ0FnWW5vZ2QybDBhR1J5WVhkZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lNelVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhiVzkxYm5RZ1BpQndaVzVoYkhSNUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU16WUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2h5WldObGFYWmxjajF3Wlc1aGJIUjVYM05wYm1zc0lHRnRiM1Z1ZEQxd1pXNWhiSFI1TENCbVpXVTlNQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS2QybDBhR1J5WVhkZllXWjBaWEpmYVdaZlpXeHpaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNak00Q2lBZ0lDQXZMeUJ6Wld4bUxuVnpaWEpmZEc5MFlXeGJWSGh1TG5ObGJtUmxjbDBnTFQwZ1lXMXZkVzUwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMWMyVnlYM1J2ZEdGc0lnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkWE5sY2w5MGIzUmhiQ0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblZ6WlhKZmRHOTBZV3dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lNemtLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmWkdWd2IzTnBkR1ZrTG5aaGJIVmxJQzA5SUdGdGIzVnVkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzWDJSbGNHOXphWFJsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5a1pYQnZjMmwwWldRZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4ZlpHVndiM05wZEdWa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJME1Bb2dJQ0FnTHk4Z2MyVnNaaTUyWVhWc2RGOWlZV3hoYm1ObExuWmhiSFZsSUMwOUlHRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblpoZFd4MFgySmhiR0Z1WTJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkbUYxYkhSZlltRnNZVzVqWlNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjJZWFZzZEY5aVlXeGhibU5sSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakkwTVFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtISmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNJR0Z0YjNWdWREMWhiVzkxYm5RZ0xTQndaVzVoYkhSNUxDQm1aV1U5TUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXlDaUFnSUNBdENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qSTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMkYyYVc1bmMxOTJZWFZzZEM1amIyNTBjbUZqZEM1VFlYWnBibWR6Vm1GMWJIUXVjMlYwZFhCZmMyRjJhVzVuYzE5d1lXTjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMGRYQmZjMkYyYVc1bmMxOXdZV04wT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNalF6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TWpVeENpQWdJQ0F2THlCaGMzTmxjblFnY0dGeWRHNWxjaTVpZVhSbGN5QWhQU0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpDaUFnSUNCa2FXY2dNd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TWpVeUNpQWdJQ0F2THlCaGMzTmxjblFnY21WeGRXbHlaV1JmWVcxdmRXNTBJRDQ5SUZWSmJuUTJOQ2d4WHpBd01GOHdNREFwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWXlBMElDOHZJREV3TURBd01EQUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJMU13b2dJQ0FnTHk4Z1lYTnpaWEowSUdOaFpHVnVZMlZmYzJWamIyNWtjeUErUFNCVlNXNTBOalFvT0RaZk5EQXdLUW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ09EWTBNREFLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSTFOQW9nSUNBZ0x5OGdZWE56WlhKMElIQmxibUZzZEhsZllXMXZkVzUwSUQ0Z1ZVbHVkRFkwS0RBcENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TWpVMUNpQWdJQ0F2THlCelpXeG1MbkJoWTNSZmRYTmxjbDloTG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2k1aWVYUmxjd29nSUNBZ1lubDBaV01nTVRJZ0x5OGdJbkJoWTNSZmRYTmxjbDloSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSTFOZ29nSUNBZ0x5OGdjMlZzWmk1d1lXTjBYM1Z6WlhKZllpNTJZV3gxWlNBOUlIQmhjblJ1WlhJdVlubDBaWE1LSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0p3WVdOMFgzVnpaWEpmWWlJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSTFOd29nSUNBZ0x5OGdjMlZzWmk1d1lXTjBYM0psY1hWcGNtVmtYMkZ0YjNWdWRDNTJZV3gxWlNBOUlISmxjWFZwY21Wa1gyRnRiM1Z1ZEFvZ0lDQWdZbmwwWldNZ01qRWdMeThnSW5CaFkzUmZjbVZ4ZFdseVpXUmZZVzF2ZFc1MElnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNalU0Q2lBZ0lDQXZMeUJ6Wld4bUxuQmhZM1JmWTJGa1pXNWpaVjl6WldOdmJtUnpMblpoYkhWbElEMGdZMkZrWlc1alpWOXpaV052Ym1SekNpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaWNHRmpkRjlqWVdSbGJtTmxYM05sWTI5dVpITWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95TlRrS0lDQWdJQzh2SUhObGJHWXVjR0ZqZEY5d1pXNWhiSFI1WDJGdGIzVnVkQzUyWVd4MVpTQTlJSEJsYm1Gc2RIbGZZVzF2ZFc1MENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaWNHRmpkRjl3Wlc1aGJIUjVYMkZ0YjNWdWRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU5qQUtJQ0FnSUM4dklITmxiR1l1Y0dGamRGOWxibUZpYkdWa0xuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKd1lXTjBYMlZ1WVdKc1pXUWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJME13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTmhkbWx1WjNOZmRtRjFiSFF1WTI5dWRISmhZM1F1VTJGMmFXNW5jMVpoZFd4MExtRndjR3g1WDNCaFkzUmZjR1Z1WVd4MGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ3Y0d4NVgzQmhZM1JmY0dWdVlXeDBlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSTJNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qWTBDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTV3WVdOMFgyVnVZV0pzWldRdWRtRnNkV1VnUFQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpY0dGamRGOWxibUZpYkdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJoWTNSZlpXNWhZbXhsWkNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU5qVUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1pXNWhiSFI1WDNCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakkyTmdvZ0lDQWdMeThnWVhOelpYSjBJSEJsYm1Gc2RIbGZjR0Y1YldWdWRDNXpaVzVrWlhJZ1BUMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakkyTndvZ0lDQWdMeThnWVhOelpYSjBJSEJsYm1Gc2RIbGZjR0Y1YldWdWRDNWhiVzkxYm5RZ1BqMGdjMlZzWmk1d1lXTjBYM0JsYm1Gc2RIbGZZVzF2ZFc1MExuWmhiSFZsQ2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSndZV04wWDNCbGJtRnNkSGxmWVcxdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CaFkzUmZjR1Z1WVd4MGVWOWhiVzkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lOamdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTGw5cGMxOTJZV3hwWkY5d1lXTjBYM0JoYVhJb1ZIaHVMbk5sYm1SbGNpd2djR0Z5ZEc1bGNpa2dQVDBnVlVsdWREWTBLREVwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pNeU5Bb2dJQ0FnTHk4Z2FXWWdjMlZ1WkdWeUxtSjVkR1Z6SUQwOUlITmxiR1l1Y0dGamRGOTFjMlZ5WDJFdWRtRnNkV1VnWVc1a0lIQmhjblJ1WlhJdVlubDBaWE1nUFQwZ2MyVnNaaTV3WVdOMFgzVnpaWEpmWWk1MllXeDFaVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWljR0ZqZEY5MWMyVnlYMkVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHRmpkRjkxYzJWeVgyRWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbm9nWVhCd2JIbGZjR0ZqZEY5d1pXNWhiSFI1WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSndZV04wWDNWelpYSmZZaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d1lXTjBYM1Z6WlhKZllpQmxlR2x6ZEhNS0lDQWdJR1JwWnlBekNpQWdJQ0E5UFFvZ0lDQWdZbm9nWVhCd2JIbGZjR0ZqZEY5d1pXNWhiSFI1WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk16STFDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvS1lYQndiSGxmY0dGamRGOXdaVzVoYkhSNVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5oZG1sdVozTmZkbUYxYkhRdVkyOXVkSEpoWTNRdVUyRjJhVzVuYzFaaGRXeDBMbDlwYzE5MllXeHBaRjl3WVdOMFgzQmhhWEpBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakkyT0FvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVgybHpYM1poYkdsa1gzQmhZM1JmY0dGcGNpaFVlRzR1YzJWdVpHVnlMQ0J3WVhKMGJtVnlLU0E5UFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lOamtLSUNBZ0lDOHZJR0Z6YzJWeWRDQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBK0lITmxiR1l1YkdGemRGOWtaWEJ2YzJsMFcxUjRiaTV6Wlc1a1pYSmRJQ3NnYzJWc1ppNXdZV04wWDJOaFpHVnVZMlZmYzJWamIyNWtjeTUyWVd4MVpRb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJQ0pzWVhOMFgyUmxjRzl6YVhRaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXNZWE4wWDJSbGNHOXphWFFnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbkJoWTNSZlkyRmtaVzVqWlY5elpXTnZibVJ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQmhZM1JmWTJGa1pXNWpaVjl6WldOdmJtUnpJR1Y0YVhOMGN3b2dJQ0FnS3dvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lOekFLSUNBZ0lDOHZJSE5sYkdZdWRYTmxjbDkwYjNSaGJGdHdZWEowYm1WeVhTQXJQU0J3Wlc1aGJIUjVYM0JoZVcxbGJuUXVZVzF2ZFc1MENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZFhObGNsOTBiM1JoYkNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuVnpaWEpmZEc5MFlXd2daWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNCa2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjFjMlZ5WDNSdmRHRnNJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qY3hDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMlJsY0c5emFYUmxaQzUyWVd4MVpTQXJQU0J3Wlc1aGJIUjVYM0JoZVcxbGJuUXVZVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZaR1Z3YjNOcGRHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMlJsY0c5emFYUmxaQ0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGIzUmhiRjlrWlhCdmMybDBaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNamN5Q2lBZ0lDQXZMeUJ6Wld4bUxuVnpaWEpmYzNSeVpXRnJXMVI0Ymk1elpXNWtaWEpkSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0oxYzJWeVgzTjBjbVZoYXlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lOaklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tZWEJ3YkhsZmNHRmpkRjl3Wlc1aGJIUjVYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pNeU5nb2dJQ0FnTHk4Z2FXWWdjMlZ1WkdWeUxtSjVkR1Z6SUQwOUlITmxiR1l1Y0dGamRGOTFjMlZ5WDJJdWRtRnNkV1VnWVc1a0lIQmhjblJ1WlhJdVlubDBaWE1nUFQwZ2MyVnNaaTV3WVdOMFgzVnpaWEpmWVM1MllXeDFaVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWljR0ZqZEY5MWMyVnlYMklpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHRmpkRjkxYzJWeVgySWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUdGd2NHeDVYM0JoWTNSZmNHVnVZV3gwZVY5aFpuUmxjbDlwWmw5bGJITmxRRGNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWljR0ZqZEY5MWMyVnlYMkVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHRmpkRjkxYzJWeVgyRWdaWGhwYzNSekNpQWdJQ0JrYVdjZ013b2dJQ0FnUFQwS0lDQWdJR0o2SUdGd2NHeDVYM0JoWTNSZmNHVnVZV3gwZVY5aFpuUmxjbDlwWmw5bGJITmxRRGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qTXlOd29nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakkyT0FvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVgybHpYM1poYkdsa1gzQmhZM1JmY0dGcGNpaFVlRzR1YzJWdVpHVnlMQ0J3WVhKMGJtVnlLU0E5UFNCVlNXNTBOalFvTVNrS0lDQWdJR0lnWVhCd2JIbGZjR0ZqZEY5d1pXNWhiSFI1WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxuTmhkbWx1WjNOZmRtRjFiSFF1WTI5dWRISmhZM1F1VTJGMmFXNW5jMVpoZFd4MExsOXBjMTkyWVd4cFpGOXdZV04wWDNCaGFYSkFPQW9LWVhCd2JIbGZjR0ZqZEY5d1pXNWhiSFI1WDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qTXlPQW9nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakkyT0FvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVgybHpYM1poYkdsa1gzQmhZM1JmY0dGcGNpaFVlRzR1YzJWdVpHVnlMQ0J3WVhKMGJtVnlLU0E5UFNCVlNXNTBOalFvTVNrS0lDQWdJR0lnWVhCd2JIbGZjR0ZqZEY5d1pXNWhiSFI1WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxuTmhkbWx1WjNOZmRtRjFiSFF1WTI5dWRISmhZM1F1VTJGMmFXNW5jMVpoZFd4MExsOXBjMTkyWVd4cFpGOXdZV04wWDNCaGFYSkFPQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1ellYWnBibWR6WDNaaGRXeDBMbU52Ym5SeVlXTjBMbE5oZG1sdVozTldZWFZzZEM1elpYUmZkR1Z0Y0hSaGRHbHZibDlzYjJOclczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwWDNSbGJYQjBZWFJwYjI1ZmJHOWphem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSTNOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSTNOd29nSUNBZ0x5OGdZWE56WlhKMElHZHZZV3hmWVcxdmRXNTBJRDRnVlVsdWREWTBLREFwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95TnpnS0lDQWdJQzh2SUdGemMyVnlkQ0J3Wlc1aGJIUjVYMkp3Y3lBOFBTQlZTVzUwTmpRb05UQXdNQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEVXdNREFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSTNPUW9nSUNBZ0x5OGdjMlZzWmk1c2IyTnJYMlZ1WVdKc1pXUmJWSGh1TG5ObGJtUmxjbDBnUFNCVlNXNTBOalFvTVNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0pzYjJOclgyVnVZV0pzWldRaUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNamd3Q2lBZ0lDQXZMeUJ6Wld4bUxuVnpaWEpmWjI5aGJGOWhiVzkxYm5SYlZIaHVMbk5sYm1SbGNsMGdQU0JuYjJGc1gyRnRiM1Z1ZEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTWpRZ0x5OGdJblZ6WlhKZloyOWhiRjloYlc5MWJuUWlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakk0TVFvZ0lDQWdMeThnYzJWc1ppNTFjMlZ5WDNCbGJtRnNkSGxmWW5CelcxUjRiaTV6Wlc1a1pYSmRJRDBnY0dWdVlXeDBlVjlpY0hNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURJMUlDOHZJQ0oxYzJWeVgzQmxibUZzZEhsZlluQnpJZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95T0RJS0lDQWdJQzh2SUhObGJHWXVjR1Z1WVd4MGVWOXphVzVyVzFSNGJpNXpaVzVrWlhKZElEMGdjR1Z1WVd4MGVWOXphVzVyTG1KNWRHVnpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QXlOaUF2THlBaWNHVnVZV3gwZVY5emFXNXJJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95TnpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1ellYWnBibWR6WDNaaGRXeDBMbU52Ym5SeVlXTjBMbE5oZG1sdVozTldZWFZzZEM1a2FYTmhZbXhsWDNSbGJYQjBZWFJwYjI1ZmJHOWphMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21ScGMyRmliR1ZmZEdWdGNIUmhkR2x2Ymw5c2IyTnJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qZzJDaUFnSUNBdkx5QnpaV3htTG14dlkydGZaVzVoWW14bFpGdFVlRzR1YzJWdVpHVnlYU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTVRZZ0x5OGdJbXh2WTJ0ZlpXNWhZbXhsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lPRFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6WVhacGJtZHpYM1poZFd4MExtTnZiblJ5WVdOMExsTmhkbWx1WjNOV1lYVnNkQzV6WlhSZlpISmxZVzFmWW05aGNtUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZlpISmxZVzFmWW05aGNtUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU9EZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJNU1Bb2dJQ0FnTHk4Z2MyVnNaaTVrY21WaGJWOTFjbWxiVkhodUxuTmxibVJsY2wwZ1BTQmtjbVZoYlY5MWNta0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklETXhJQzh2SUNKa2NtVmhiVjkxY21raUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSTVNUW9nSUNBZ0x5OGdjMlZzWmk1a2NtVmhiVjkwYVhSc1pWdFVlRzR1YzJWdVpHVnlYU0E5SUdSeVpXRnRYM1JwZEd4bENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWXlBek1pQXZMeUFpWkhKbFlXMWZkR2wwYkdVaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSTRPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5oZG1sdVozTmZkbUYxYkhRdVkyOXVkSEpoWTNRdVUyRjJhVzVuYzFaaGRXeDBMbWRsZEY5MWMyVnlYM04wWVhSelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNWelpYSmZjM1JoZEhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95T1RNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95T1RVS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NoaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5WelpYSmZkRzkwWVd4YmRYTmxjbDBwTENCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5WelpYSmZiV2xzWlhOMGIyNWxXM1Z6WlhKZEtTd2dZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTFjMlZ5WDNOMGNtVmhhMXQxYzJWeVhTa3BLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRYTmxjbDkwYjNSaGJDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblZ6WlhKZmRHOTBZV3dnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblZ6WlhKZmJXbHNaWE4wYjI1bElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkWE5sY2w5dGFXeGxjM1J2Ym1VZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjFjMlZ5WDNOMGNtVmhheUlLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5WelpYSmZjM1J5WldGcklHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakk1TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5oZG1sdVozTmZkbUYxYkhRdVkyOXVkSEpoWTNRdVUyRjJhVzVuYzFaaGRXeDBMbWRsZEY5bmJHOWlZV3hmYzNSaGRITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZloyeHZZbUZzWDNOMFlYUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qazVDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVVZFhCc1pTZ29ZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBiM1JoYkY5a1pYQnZjMmwwWldRdWRtRnNkV1VwTENCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmRHRnNYM1Z6WlhKekxuWmhiSFZsS1NrcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZaR1Z3YjNOcGRHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMlJsY0c5emFYUmxaQ0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKMGIzUmhiRjkxYzJWeWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOTFjMlZ5Y3lCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNamszQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMkYyYVc1bmMxOTJZWFZzZEM1amIyNTBjbUZqZEM1VFlYWnBibWR6Vm1GMWJIUXVaMlYwWDNCaFkzUmZZMjl1Wm1sblczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNCaFkzUmZZMjl1Wm1sbk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TXpBMENpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5CaFkzUmZaVzVoWW14bFpDNTJZV3gxWlNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpY0dGamRGOWxibUZpYkdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJoWTNSZlpXNWhZbXhsWkNCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qTXdOUW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXdZV04wWDNKbGNYVnBjbVZrWDJGdGIzVnVkQzUyWVd4MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNakVnTHk4Z0luQmhZM1JmY21WeGRXbHlaV1JmWVcxdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CaFkzUmZjbVZ4ZFdseVpXUmZZVzF2ZFc1MElHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNekEyQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MbkJoWTNSZlkyRmtaVzVqWlY5elpXTnZibVJ6TG5aaGJIVmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWljR0ZqZEY5allXUmxibU5sWDNObFkyOXVaSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHRmpkRjlqWVdSbGJtTmxYM05sWTI5dVpITWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG96TURjS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Y0dGamRGOXdaVzVoYkhSNVgyRnRiM1Z1ZEM1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbkJoWTNSZmNHVnVZV3gwZVY5aGJXOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHRmpkRjl3Wlc1aGJIUjVYMkZ0YjNWdWRDQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPak13TXkwek1EZ0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFIxY0d4bEtDZ0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MbkJoWTNSZlpXNWhZbXhsWkM1MllXeDFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1d1lXTjBYM0psY1hWcGNtVmtYMkZ0YjNWdWRDNTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXdZV04wWDJOaFpHVnVZMlZmYzJWamIyNWtjeTUyWVd4MVpTa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTV3WVdOMFgzQmxibUZzZEhsZllXMXZkVzUwTG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ2twQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG96TURFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6WVhacGJtZHpYM1poZFd4MExtTnZiblJ5WVdOMExsTmhkbWx1WjNOV1lYVnNkQzVmYldsdWRGOWlZV1JuWlNodVlXMWxPaUJpZVhSbGN5d2dkVzVwZERvZ1lubDBaWE1zSUhWeWJEb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tYMjFwYm5SZlltRmtaMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3pNekF0TXpNeENpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpRb2dJQ0FnTHk4Z1pHVm1JRjl0YVc1MFgySmhaR2RsS0hObGJHWXNJRzVoYldVNklFSjVkR1Z6TENCMWJtbDBPaUJDZVhSbGN5d2dkWEpzT2lCQ2VYUmxjeWtnTFQ0Z1ZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvek16SUtJQ0FnSUM4dklISmxjM1ZzZENBOUlHbDBlRzR1UVhOelpYUkRiMjVtYVdjb2RHOTBZV3c5TVN3Z1pHVmphVzFoYkhNOU1Dd2dZWE56WlhSZmJtRnRaVDF1WVcxbExDQjFibWwwWDI1aGJXVTlkVzVwZEN3Z2RYSnNQWFZ5YkN3Z2JXRnVZV2RsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TENCbVpXVTlNQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUV0Z1WVdkbGNnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZWSk1DaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRtRnRaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVWIzUmhiQW9nSUNBZ2NIVnphR2x1ZENBeklDOHZJR0ZqWm1jS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdRM0psWVhSbFpFRnpjMlYwU1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPak16TXdvZ0lDQWdMeThnY21WMGRYSnVJSEpsYzNWc2RDNWpjbVZoZEdWa1gyRnpjMlYwTG1sa0NpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQUFFSUlNQ0VQU1loQ25WelpYSmZkRzkwWVd3QURYWmhkV3gwWDJKaGJHRnVZMlVQZEc5MFlXeGZaR1Z3YjNOcGRHVmtCQlVmZkhVUWMzUmhZbXhsWTI5cGJsOTBiM1JoYkE1MWMyVnlYMjFwYkdWemRHOXVaUXQxYzJWeVgzTjBjbVZoYXd0MGIzUmhiRjkxYzJWeWN3eHdZV04wWDJWdVlXSnNaV1FVY0dGamRGOWpZV1JsYm1ObFgzTmxZMjl1WkhNVGNHRmpkRjl3Wlc1aGJIUjVYMkZ0YjNWdWRBdHdZV04wWDNWelpYSmZZUXR3WVdOMFgzVnpaWEpmWWhOemRHRmliR1ZqYjJsdVgyRnpjMlYwWDJsa0RHeGhjM1JmWkdWd2IzTnBkQXhzYjJOclgyVnVZV0pzWldRVmRYTmxjbDl6ZEdGaWJHVmpiMmx1WDNSdmRHRnNDMjFwYkdWemRHOXVaVjh4QzIxcGJHVnpkRzl1WlY4eUMyMXBiR1Z6ZEc5dVpWOHpGSEJoWTNSZmNtVnhkV2x5WldSZllXMXZkVzUwRUdKbGJtVm1hV05wWVhKNVgyRmtaSElLWVdkbGJuUmZZV1JrY2hCMWMyVnlYMmR2WVd4ZllXMXZkVzUwRUhWelpYSmZjR1Z1WVd4MGVWOWljSE1NY0dWdVlXeDBlVjl6YVc1ckRXSmhaR2RsWDJGemMyVjBYekVOWW1Ga1oyVmZZWE56WlhSZk1nMWlZV1JuWlY5aGMzTmxkRjh6SFdKbGJtVm1hV05wWVhKNVgzSmxiR1ZoYzJWZmRHbHRaWE4wWVcxd0NXUnlaV0Z0WDNWeWFRdGtjbVZoYlY5MGFYUnNaVEVZUUFCaEt5Sm5Kd2dpWnlvaVp5Y1NnWUN0NGdSbkp4T0JnT0hyRjJjbkZJR0F3dGN2WnljYkltY25IQ0puSngwaVp5Y0pJbWNuRlNFRVp5Y0tnWUQxSkdjbkM0R2dqUVpuSnd3cFp5Y05LV2NuRGlKbkp3VWlaeWNXS1djbkhpSm5KeGNwWnpFYlFRQ0pnQVF3eHRXS05ob0FqZ0VBY1RFWkZFUXhHRVNDRGdReW1PZkFCSVFZbUpBRWpMRmFIZ1RJa2ZnZUJEZnJ0OW9FbzRFcGVnUXJQWEtzQlBJbmxwa0VLRDRzRWdTTTBPekxCRUZSRVJzRW1ZWlRkZ1RqL3VVNkJLZmE4QWMyR2dDT0RnQmpBU0lCZVFINkFrWURTQVB3QkVjRTZ3VXNCVFFGWmdXUUJhTUFNUmtqRWpFWUVFUkNBQWd4R1JReEdCUVFRekVBS0NKbU1RQW5CaUptTVFBbkJ5Sm1NUUFuRHlKbU1RQW5FQ0ptTVFBbkdDSm1NUUFuR1NKbU1RQW5HakVBWmpFQUp4OHBaakVBSnlBcFpqRUFKeEVpWmlJbkNHVkVJd2duQ0V4bkkwTXBTVEVXSXdsSk9CQWpFa1JKT0FjeUNoSkVTVGdJU1NFRUQwUk1PQUF4QUJKRU1RQkpJaWhqUkVzQ0NDaE1aaUlyWlVSTEFRZ3JUR2NpS21WRUNDcE1aekVBSWljUFkwUkJBQTR4QUVraUp3ZGpSQ01JSndkTVpqRUFKdzh5QjJZeEFFa2lLR05NU1U0RFJRVkVJaWNHWTB4RkEwUWlKeFJsUkE5QkFCRkpnUU1NUVFBS2dRTVdKd1JNVUxBalF5SW5FMlZFU3dJT1FRQU1TWUVDREVFQUJZRUNRdi9oSWljU1pVUkxBZzVCQUFwSkl3eEJBQVFqUXYvTUlrTC95RFlhQVVrVkpCSkVGellhQWtrVkpSSkVOaG9EU1JVa0VrUVhOaG9FU1JVbEVrUXhBRElKRWtSTEEwUW5Ea3NFWnljV1R3Tm5KeDVQQW1jbkYweG5zVElLU1U4Q3NoRWlzaEt5RkxJQWdRU3lFQ0t5QWJNalF6RVdJd2xKT0JDQkJCSkVOaG9CU1JVa0VrUVhJaWNPWlVSSlJFc0JFa1N4TWdwSlN3S3lFU0t5RXJJVXNnQ0JCTElRSXJJQnMwc0JPQlF5Q2hKRVN3RTRFUkpFU1RnQU1RQVNSRGdTU1VReEFFa2lKeEZqUkVzQ0NDY1JUR1lpSndWbFJFc0JDQ2NGVEdjaUttVkVDQ3BNWnpFQUlpY1JZMFFXSndSTVVMQWpReUluRjJWRVNTa1RSREVBRWtRaUp3NWxSRWxFSWljV1pVUkpLUk5FSWljRlpVUkpSTEV5Q2s4RHNoRkxBYklTVHdLeUZMSUFnUVN5RUNLeUFiTW5CU0puSWlwbFJFd0pLa3huSTBNcFNUWWFBVWtWSkJKRUYwa3hBQ0luQm1ORVN3RU1SRUVBNUVtQkF3NUJBTjBqUkRFQUlpaGpURVVEUkNKRkEwa2pFa0VBU0NJbkVtVkVTd0lPUklJRERWWmhkV3gwSUZOMFlYSjBaWElEVmxNeEQybHdabk02THk5UmJVSmhaR2RsTVlnRElVbEZCQ2NiVEdjeEFDY0dTd0ptU3dJV0p3Uk1VTEFqUTBtQkFoSkJBRG9pSnhObFJFc0NEa1NDQXcxV1lYVnNkQ0JDZFdsc1pHVnlBMVpDTWc5cGNHWnpPaTh2VVcxQ1lXUm5aVEtJQXRKSlJRUW5IRXhuUXYrdVNZRURFa0gvcHlJbkZHVkVTd0lPUklJRERGWmhkV3gwSUUxaGMzUmxjZ05XVFRNUGFYQm1jem92TDFGdFFtRmtaMlV6aUFLU1NVVUVKeDFNWjBML2JpSkMveUEyR2dGSkZTUVNSQmRKTmhvQ1NVNENGU1VTUkRFQUlpaGpSQTVFSWpFQUlpY1FZMFFqRWtFQVJ6RUFJaWhqUkRFQUlpY1lZMFFNUVFBMk1RQWlKeHBqUkVzQ0VrUXhBQ0luR1dORVN3TUxnWkJPQ2tsRkFrRUFGMHNDU3dGSlRnSU5STEd5Q0VzQnNnY2pzaEFpc2dHek1RQkpJaWhqUkVzRVNVNERDU2hNWmlJclpVUkxBUWtyVEdjaUttVkVTd0VKS2t4bnNURUFURXNDQ2JJSXNnY2pzaEFpc2dHekkwTTJHZ0ZKRlNVU1JEWWFBa2tWSkJKRUZ6WWFBMGtWSkJKRUZ6WWFCRWtWSkJKRUYwc0RNUUFUUkVzQ0lRUVBSRXNCZ1lDakJROUVTVVFuRERFQVp5Y05Ud1JuSnhWUEEyY25DazhDWnljTFRHY25DU05uSTBNMkdnRkpGU1VTUkRFV0l3bEpPQkFqRWtRaUp3bGxSQ01TUkVrNEJ6SUtFa1JKT0FBeEFCSkVPQWhKSWljTFpVUVBSREVBU1NJbkRHVkVFa0VBU0NJbkRXVkVTd01TUVFBOUl5TVNSRElITVFBaUp3OWpSQ0luQ21WRUNBMUVTd0pKSWloalJFc0RTVTREQ0NoTVppSXJaVVJMQVFnclRHY3hBQ2NISW1ZV0p3Uk1VTEFqUXlJbkRXVkVTd0VTUVFBUElpY01aVVJMQXhKQkFBUWpRditxSWtML3BqWWFBVWtWSkJKRUZ6WWFBa2tWSkJKRUZ6WWFBMGtWSlJKRVN3SkVTd0dCaUNjT1JERUFKeEFqWmpFQUp4aFBCR1l4QUNjWlR3Tm1NUUFuR2s4Q1ppTkRNUUFuRUNKbUkwTTJHZ0ZKSWxtQkFnaExBUlVTUkZjQ0FEWWFBa2tpV1lFQ0NFc0JGUkpFVndJQU1RQW5IMDhEWmpFQUp5QlBBbVlqUXpZYUFVa1ZKUkpFU1NJb1kwUVdTd0VpSndaalJCWlBBaUluQjJORUZrNENVRXhRSndSTVVMQWpReUlyWlVRV0lpY0laVVFXVUNjRVRGQ3dJME1pSndsbFJCWWlKeFZsUkJZaUp3cGxSQllpSnd0bFJCWlBBMDhEVUU4Q1VFeFFKd1JNVUxBalE0b0RBYkV5Q3JJcGkvK3lKNHYrc2lXTC9iSW1JcklqSTdJaWdRT3lFQ0t5QWJPMFBJaz0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
