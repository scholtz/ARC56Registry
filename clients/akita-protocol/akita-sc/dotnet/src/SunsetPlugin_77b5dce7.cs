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

namespace Arc56.Generated.akita_protocol.akita_sc.SunsetPlugin_77b5dce7
{


    public class SunsetPluginProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SunsetPluginProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CloseOutArgCloses : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
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

                public static CloseOutArgCloses Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CloseOutArgCloses();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as CloseOutArgCloses);
                }
                public bool Equals(CloseOutArgCloses? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CloseOutArgCloses left, CloseOutArgCloses right)
                {
                    return EqualityComparer<CloseOutArgCloses>.Default.Equals(left, right);
                }
                public static bool operator !=(CloseOutArgCloses left, CloseOutArgCloses right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="appId"> </param>
        /// <param name="closeRemainderTo"> </param>
        public async Task Delete(ulong wallet, bool rekeyBack, ulong appId, Algorand.Address closeRemainderTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 196, 192, 153 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var closeRemainderToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); closeRemainderToAbi.From(closeRemainderTo);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, appIdAbi, closeRemainderToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Delete_Transactions(ulong wallet, bool rekeyBack, ulong appId, Algorand.Address closeRemainderTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 196, 192, 153 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var closeRemainderToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); closeRemainderToAbi.From(closeRemainderTo);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, appIdAbi, closeRemainderToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="appId"> </param>
        /// <param name="boxes"> </param>
        public async Task DeleteBoxes(ulong wallet, bool rekeyBack, ulong appId, byte[][] boxes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 215, 245, 166 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var boxesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); boxesAbi.From(boxes);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, appIdAbi, boxesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteBoxes_Transactions(ulong wallet, bool rekeyBack, ulong appId, byte[][] boxes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 215, 245, 166 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var boxesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); boxesAbi.From(boxes);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, appIdAbi, boxesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="appId"> </param>
        /// <param name="closes"> CloseOutArgCloses</param>
        public async Task CloseOut(ulong wallet, bool rekeyBack, ulong appId, Structs.CloseOutArgCloses[] closes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 31, 140, 218 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var closesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CloseOutArgCloses>(x => Structs.CloseOutArgCloses.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; closesAbi.From(closes);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, appIdAbi, closesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CloseOut_Transactions(ulong wallet, bool rekeyBack, ulong appId, Structs.CloseOutArgCloses[] closes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 31, 140, 218 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var closesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CloseOutArgCloses>(x => Structs.CloseOutArgCloses.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; closesAbi.From(closes);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, appIdAbi, closesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="appId"> </param>
        /// <param name="assets"> </param>
        public async Task DeleteAssets(ulong wallet, bool rekeyBack, ulong appId, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 146, 245, 255 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, appIdAbi, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteAssets_Transactions(ulong wallet, bool rekeyBack, ulong appId, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 146, 245, 255 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, appIdAbi, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3Vuc2V0UGx1Z2luIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkNsb3NlT3V0QXJnQ2xvc2VzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImRlbGV0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xvc2VSZW1haW5kZXJUbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJveGVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsb3NlT3V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJla2V5QmFjayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NClbXSIsInN0cnVjdCI6IkNsb3NlT3V0QXJnQ2xvc2VzIiwibmFtZSI6ImNsb3NlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVBc3NldHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVrZXlCYWNrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMTJdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTmF0aCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkxXSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjldLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ3LDI5MSwzODYsNDcxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ3LDIyOSwzNjksNDU0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXNzZXQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxieXRlcz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHNtYXJ0X2NvbnRyYWN0cy9zdW5zZXQvdHlwZXMudHM6OkFzc2V0Q2xvc2VQYXJhbXM+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOCwxNTcsMjIwLDIzOSwzNjAsMzc5LDQ0NSw0NjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisobGVuK3VpbnQ4W10pW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0E0SURFZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRk4xYm5ObGRGQnNkV2RwYmlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjROR1ZqTkdNd09Ua2dNSGc1Wm1RM1pqVmhOaUF3ZUdJMU1XWTRZMlJoSURCNE5EQTVNbVkxWm1ZZ0x5OGdiV1YwYUc5a0lDSmtaV3hsZEdVb2RXbHVkRFkwTEdKdmIyd3NkV2x1ZERZMExHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWkdWc1pYUmxRbTk0WlhNb2RXbHVkRFkwTEdKdmIyd3NkV2x1ZERZMExHSjVkR1ZiWFZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1Oc2IzTmxUM1YwS0hWcGJuUTJOQ3hpYjI5c0xIVnBiblEyTkN3b1lXUmtjbVZ6Y3l4MWFXNTBOalFwVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWkdWc1pYUmxRWE56WlhSektIVnBiblEyTkN4aWIyOXNMSFZwYm5RMk5DeDFhVzUwTmpSYlhTbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1pHVnNaWFJsSUdSbGJHVjBaVUp2ZUdWeklHTnNiM05sVDNWMElHUmxiR1YwWlVGemMyVjBjd29nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJUZFc1elpYUlFiSFZuYVc0Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUVCaGEybDBZUzF3Y205MGIyTnZiQzl3YkhWbmFXNHZablZ1WTNScGIyNXpMblJ6T2pwblpYUkRiMjUwY205c2JHVmtVM0JsYm1ScGJtZEJZMk52ZFc1MEtIZGhiR3hsZERvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBRMjl1ZEhKdmJHeGxaRk53Wlc1a2FXNW5RV05qYjNWdWREb0tJQ0FnSUM4dklDNHVMeTR1TDI1dlpHVmZiVzlrZFd4bGN5OUFZV3RwZEdFdGNISnZkRzlqYjJ3dmNHeDFaMmx1TDJaMWJtTjBhVzl1Y3k1MGN6b3pOd29nSUNBZ0x5OGdaWGh3YjNKMElHWjFibU4wYVc5dUlHZGxkRU52Ym5SeWIyeHNaV1JUY0dWdVpHbHVaMEZqWTI5MWJuUW9kMkZzYkdWME9pQkJjSEJzYVdOaGRHbHZiaWs2SUVGalkyOTFiblFnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QXVMaTh1TGk5dWIyUmxYMjF2WkhWc1pYTXZRR0ZyYVhSaExYQnliM1J2WTI5c0wzQnNkV2RwYmk5bWRXNWpkR2x2Ym5NdWRITTZNVGt0TWpJS0lDQWdJQzh2SUdOdmJuTjBJRnR6Y0dWdVpHbHVaMEZrWkhKbGMzTkNlWFJsYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3lnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwTEFvZ0lDQWdMeThnSUNCQ2VYUmxjeWhCVWtNMU9GOVRVRVZPUkVsT1IxOUJSRVJTUlZOVFgwdEZXU2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0x5OGdMaTR2TGk0dmJtOWtaVjl0YjJSMWJHVnpMMEJoYTJsMFlTMXdjbTkwYjJOdmJDOXdiSFZuYVc0dlpuVnVZM1JwYjI1ekxuUnpPakl4Q2lBZ0lDQXZMeUJDZVhSbGN5aEJVa00xT0Y5VFVFVk9SRWxPUjE5QlJFUlNSVk5UWDB0RldTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWMzQmxibVJwYm1kZllXUmtjbVZ6Y3lJS0lDQWdJQzh2SUM0dUx5NHVMMjV2WkdWZmJXOWtkV3hsY3k5QVlXdHBkR0V0Y0hKdmRHOWpiMnd2Y0d4MVoybHVMMloxYm1OMGFXOXVjeTUwY3pveE9TMHlNZ29nSUNBZ0x5OGdZMjl1YzNRZ1czTndaVzVrYVc1blFXUmtjbVZ6YzBKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLQW9nSUNBZ0x5OGdJQ0IzWVd4c1pYUXNDaUFnSUNBdkx5QWdJRUo1ZEdWektFRlNRelU0WDFOUVJVNUVTVTVIWDBGRVJGSkZVMU5mUzBWWktRb2dJQ0FnTHk4Z0tRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ1pIVndDaUFnSUNBdkx5QXVMaTh1TGk5dWIyUmxYMjF2WkhWc1pYTXZRR0ZyYVhSaExYQnliM1J2WTI5c0wzQnNkV2RwYmk5bWRXNWpkR2x2Ym5NdWRITTZNemtLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoelpXNWtaWEl1WVhWMGFFRmtaSEpsYzNNZ1BUMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxDQkJVa00xT0Y5RlVsSmZVRXhWUjBsT1gwNVBWRjlCVlZSSVgwRkVSRklwQ2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRUYxZEdoQlpHUnlDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJR2RsZEVOdmJuUnliMnhzWldSVGNHVnVaR2x1WjBGalkyOTFiblJmWVdaMFpYSmZZWE56WlhKMFFESUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPbVZ5Y2s1aGRHZ2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlUbUYwYUFvS1oyVjBRMjl1ZEhKdmJHeGxaRk53Wlc1a2FXNW5RV05qYjNWdWRGOWhablJsY2w5aGMzTmxjblJBTWpvS0lDQWdJQzh2SUM0dUx5NHVMMjV2WkdWZmJXOWtkV3hsY3k5QVlXdHBkR0V0Y0hKdmRHOWpiMnd2Y0d4MVoybHVMMloxYm1OMGFXOXVjeTUwY3pvME1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJtUmxjZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdRR0ZyYVhSaExYQnliM1J2WTI5c0wzQnNkV2RwYmk5bWRXNWpkR2x2Ym5NdWRITTZPbkpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzNklIVnBiblEyTkN3Z2QyRnNiR1YwT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dweVpXdGxlVUZrWkhKbGMzTTZDaUFnSUNBdkx5QXVMaTh1TGk5dWIyUmxYMjF2WkhWc1pYTXZRR0ZyYVhSaExYQnliM1J2WTI5c0wzQnNkV2RwYmk5bWRXNWpkR2x2Ym5NdWRITTZNVFF6Q2lBZ0lDQXZMeUJsZUhCdmNuUWdablZ1WTNScGIyNGdjbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3Z2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpazZJRUZqWTI5MWJuUWdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlBdUxpOHVMaTl1YjJSbFgyMXZaSFZzWlhNdlFHRnJhWFJoTFhCeWIzUnZZMjlzTDNCc2RXZHBiaTltZFc1amRHbHZibk11ZEhNNk1UUTBDaUFnSUNBdkx5QnBaaUFvSVhKbGEyVjVRbUZqYXlrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpYm5vZ2NtVnJaWGxCWkdSeVpYTnpYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z0xpNHZMaTR2Ym05a1pWOXRiMlIxYkdWekwwQmhhMmwwWVMxd2NtOTBiMk52YkM5d2JIVm5hVzR2Wm5WdVkzUnBiMjV6TG5Sek9qRTBOUW9nSUNBZ0x5OGdjbVYwZFhKdUlFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQnlaWFJ6ZFdJS0NuSmxhMlY1UVdSa2NtVnpjMTloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QXVMaTh1TGk5dWIyUmxYMjF2WkhWc1pYTXZRR0ZyYVhSaExYQnliM1J2WTI5c0wzQnNkV2RwYmk5bWRXNWpkR2x2Ym5NdWRITTZNVFEzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkMkZzYkdWMExtRmtaSEpsYzNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndRV1JrY21WemN3b2dJQ0FnWVhOelpYSjBJQzh2SUdGd2NHeHBZMkYwYVc5dUlHVjRhWE4wY3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOMWJuTmxkRkJzZFdkcGJpNWtaV3hsZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaV3hsZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNUxURTBDaUFnSUNBdkx5QmtaV3hsZEdVb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJSEpsYTJWNVFtRmphem9nWW05dmJHVmhiaXdLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCamJHOXpaVkpsYldGcGJtUmxjbFJ2T2lCQlkyTnZkVzUwQ2lBZ0lDQXZMeUFwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdZMjl1YzNRZ2MyVnVaR1Z5SUQwZ1oyVjBRMjl1ZEhKdmJHeGxaRk53Wlc1a2FXNW5RV05qYjNWdWRDaDNZV3hzWlhRcENpQWdJQ0JrYVdjZ013b2dJQ0FnWTJGc2JITjFZaUJuWlhSRGIyNTBjbTlzYkdWa1UzQmxibVJwYm1kQlkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmkweU1nb2dJQ0FnTHk4Z1lXSnBRMkZzYkR4MGVYQmxiMllnVTNWdWMyVjBRMjl1ZEhKaFkzUXVjSEp2ZEc5MGVYQmxMbVJsYkdWMFpUNG9ld29nSUNBZ0x5OGdJQ0J6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJR0Z3Y0Vsa0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYlkyeHZjMlZTWlcxaGFXNWtaWEpVYjEwc0NpQWdJQ0F2THlBZ0lISmxhMlY1Vkc4NklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tzQ2lBZ0lDQXZMeUFnSUc5dVEyOXRjR3hsZEdsdmJqb2dUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNUVaV3hsZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd0NpQWdJQ0F2THlCeVpXdGxlVlJ2T2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBMQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTmhiR3h6ZFdJZ2NtVnJaWGxCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdiMjVEYjIxd2JHVjBhVzl1T2lCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQndkWE5vYVc1MElEVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxhMlY1Vkc4S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWXRNaklLSUNBZ0lDOHZJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlGTjFibk5sZEVOdmJuUnlZV04wTG5CeWIzUnZkSGx3WlM1a1pXeGxkR1UrS0hzS0lDQWdJQzh2SUNBZ2MyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCaGNIQkpaQ3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMk5zYjNObFVtVnRZV2x1WkdWeVZHOWRMQW9nSUNBZ0x5OGdJQ0J5Wld0bGVWUnZPaUJ5Wld0bGVVRmtaSEpsYzNNb2NtVnJaWGxDWVdOckxDQjNZV3hzWlhRcExBb2dJQ0FnTHk4Z0lDQnZia052YlhCc1pYUnBiMjQ2SUU5dVEyOXRjR3hsZEdWQlkzUnBiMjR1UkdWc1pYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lDOHZJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhoWWpoaU1qRXpZU0F2THlCdFpYUm9iMlFnSW1SbGJHVjBaU2hoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TFRFMENpQWdJQ0F2THlCa1pXeGxkR1VvQ2lBZ0lDQXZMeUFnSUhkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklFRndjR3hwWTJGMGFXOXVMQW9nSUNBZ0x5OGdJQ0JqYkc5elpWSmxiV0ZwYm1SbGNsUnZPaUJCWTJOdmRXNTBDaUFnSUNBdkx5QXBJSHNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVM1Z1YzJWMFVHeDFaMmx1TG1SbGJHVjBaVUp2ZUdWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1ZzWlhSbFFtOTRaWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlMwek1Bb2dJQ0FnTHk4Z1pHVnNaWFJsUW05NFpYTW9DaUFnSUNBdkx5QWdJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1lYQndTV1E2SUVGd2NHeHBZMkYwYVc5dUxBb2dJQ0FnTHk4Z0lDQmliM2hsY3pvZ1lubDBaWE5iWFFvZ0lDQWdMeThnS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVltOXZiQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR052ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1pHVnNaWFJsUW05NFpYTmZabTl5WDJobFlXUmxja0F4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVdE16QUtJQ0FnSUM4dklHUmxiR1YwWlVKdmVHVnpLQW9nSUNBZ0x5OGdJQ0IzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCeVpXdGxlVUpoWTJzNklHSnZiMnhsWVc0c0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdZbTk0WlhNNklHSjVkR1Z6VzEwS0lDQWdJQzh2SUNrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnUEFvZ0lDQWdZbm9nWkdWc1pYUmxRbTk0WlhOZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2daVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWm05eUlDaHNaVzRyS0d4bGJpdDFhVzUwT0Z0ZEtWdGRLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0FyQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQmtaV3hsZEdWQ2IzaGxjMTltYjNKZmFHVmhaR1Z5UURFS0NtUmxiR1YwWlVKdmVHVnpYMkZtZEdWeVgyWnZja0EwT2dvZ0lDQWdjRzl3YmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalV0TXpBS0lDQWdJQzh2SUdSbGJHVjBaVUp2ZUdWektBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVMQW9nSUNBZ0x5OGdJQ0J5Wld0bGVVSmhZMnM2SUdKdmIyeGxZVzRzQ2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJCY0hCc2FXTmhkR2x2Yml3S0lDQWdJQzh2SUNBZ1ltOTRaWE02SUdKNWRHVnpXMTBLSUNBZ0lDOHZJQ2tnZXdvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aWVYUmxjejRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhJZ1BTQm5aWFJEYjI1MGNtOXNiR1ZrVTNCbGJtUnBibWRCWTJOdmRXNTBLSGRoYkd4bGRDa0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRU52Ym5SeWIyeHNaV1JUY0dWdVpHbHVaMEZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlMVE0zQ2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQlRkVzV6WlhSRGIyNTBjbUZqZEM1d2NtOTBiM1I1Y0dVdVpHVnNaWFJsUW05NFpYTStLSHNLSUNBZ0lDOHZJQ0FnYzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0JoY0hCSlpDd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cySnZlR1Z6WFN3S0lDQWdJQzh2SUNBZ2NtVnJaWGxVYnpvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLUW9nSUNBZ0x5OGdmU2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QnlaV3RsZVZSdk9pQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yTENCM1lXeHNaWFFwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQnlaV3RsZVVGa1pISmxjM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZyWlhsVWJ3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2wwZUc1ZlptbGxiR1FnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNaTB6TndvZ0lDQWdMeThnWVdKcFEyRnNiRHgwZVhCbGIyWWdVM1Z1YzJWMFEyOXVkSEpoWTNRdWNISnZkRzkwZVhCbExtUmxiR1YwWlVKdmVHVnpQaWg3Q2lBZ0lDQXZMeUFnSUhObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnWVhCd1NXUXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdGliM2hsYzEwc0NpQWdJQ0F2THlBZ0lISmxhMlY1Vkc4NklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tLSUNBZ0lDOHZJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc1T0daa05qVmhOeUF2THlCdFpYUm9iMlFnSW1SbGJHVjBaVUp2ZUdWektHSjVkR1ZiWFZ0ZEtYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOUzB6TUFvZ0lDQWdMeThnWkdWc1pYUmxRbTk0WlhNb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJSEpsYTJWNVFtRmphem9nWW05dmJHVmhiaXdLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCaWIzaGxjem9nWW5sMFpYTmJYUW9nSUNBZ0x5OGdLU0I3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE4xYm5ObGRGQnNkV2RwYmk1amJHOXpaVTkxZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnNiM05sVDNWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EQXRORFVLSUNBZ0lDOHZJR05zYjNObFQzVjBLQW9nSUNBZ0x5OGdJQ0IzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCeVpXdGxlVUpoWTJzNklHSnZiMnhsWVc0c0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdZMnh2YzJWek9pQkJjM05sZEVOc2IzTmxVR0Z5WVcxelcxMEtJQ0FnSUM4dklDa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ05EQUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOGMyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzkwZVhCbGN5NTBjem82UVhOelpYUkRiRzl6WlZCaGNtRnRjejRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhJZ1BTQm5aWFJEYjI1MGNtOXNiR1ZrVTNCbGJtUnBibWRCWTJOdmRXNTBLSGRoYkd4bGRDa0tJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUdkbGRFTnZiblJ5YjJ4c1pXUlRjR1Z1WkdsdVowRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRM0xUVXlDaUFnSUNBdkx5QmhZbWxEWVd4c1BIUjVjR1Z2WmlCVGRXNXpaWFJEYjI1MGNtRmpkQzV3Y205MGIzUjVjR1V1WTJ4dmMyVlBkWFErS0hzS0lDQWdJQzh2SUNBZ2MyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCaGNIQkpaQ3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMk5zYjNObGMxMHNDaUFnSUNBdkx5QWdJSEpsYTJWNVZHODZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrS0lDQWdJQzh2SUgwcENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnY21WclpYbFViem9nY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF5d2dkMkZzYkdWMEtRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOaGJHeHpkV0lnY21WclpYbEJaR1J5WlhOekNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbGEyVjVWRzhLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGRIaHVYMlpwWld4a0lGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjdE5USUtJQ0FnSUM4dklHRmlhVU5oYkd3OGRIbHdaVzltSUZOMWJuTmxkRU52Ym5SeVlXTjBMbkJ5YjNSdmRIbHdaUzVqYkc5elpVOTFkRDRvZXdvZ0lDQWdMeThnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUdGd2NFbGtMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJZMnh2YzJWelhTd0tJQ0FnSUM4dklDQWdjbVZyWlhsVWJ6b2djbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXl3Z2QyRnNiR1YwS1FvZ0lDQWdMeThnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURrMk1qVmxZV1E1SUM4dklHMWxkR2h2WkNBaVkyeHZjMlZQZFhRb0tHRmtaSEpsYzNNc2RXbHVkRFkwS1Z0ZEtYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNQzAwTlFvZ0lDQWdMeThnWTJ4dmMyVlBkWFFvQ2lBZ0lDQXZMeUFnSUhkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklFRndjR3hwWTJGMGFXOXVMQW9nSUNBZ0x5OGdJQ0JqYkc5elpYTTZJRUZ6YzJWMFEyeHZjMlZRWVhKaGJYTmJYUW9nSUNBZ0x5OGdLU0I3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE4xYm5ObGRGQnNkV2RwYmk1a1pXeGxkR1ZCYzNObGRITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWld4bGRHVkJjM05sZEhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5TMDJNQW9nSUNBZ0x5OGdaR1ZzWlhSbFFYTnpaWFJ6S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxBb2dJQ0FnTHk4Z0lDQnlaV3RsZVVKaFkyczZJR0p2YjJ4bFlXNHNDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQkJjSEJzYVdOaGRHbHZiaXdLSUNBZ0lDOHZJQ0FnWVhOelpYUnpPaUJCYzNObGRGdGRDaUFnSUNBdkx5QXBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjM05sZEQ0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCamIyNXpkQ0J6Wlc1a1pYSWdQU0JuWlhSRGIyNTBjbTlzYkdWa1UzQmxibVJwYm1kQlkyTnZkVzUwS0hkaGJHeGxkQ2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRU52Ym5SeWIyeHNaV1JUY0dWdVpHbHVaMEZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXlMVFkzQ2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQlRkVzV6WlhSRGIyNTBjbUZqZEM1d2NtOTBiM1I1Y0dVdVpHVnNaWFJsUVhOelpYUnpQaWg3Q2lBZ0lDQXZMeUFnSUhObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnWVhCd1NXUXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdGhjM05sZEhOZExBb2dJQ0FnTHk4Z0lDQnlaV3RsZVZSdk9pQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yTENCM1lXeHNaWFFwQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJSEpsYTJWNVZHODZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqWVd4c2MzVmlJSEpsYTJWNVFXUmtjbVZ6Y3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWld0bGVWUnZDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall5TFRZM0NpQWdJQ0F2THlCaFltbERZV3hzUEhSNWNHVnZaaUJUZFc1elpYUkRiMjUwY21GamRDNXdjbTkwYjNSNWNHVXVaR1ZzWlhSbFFYTnpaWFJ6UGloN0NpQWdJQ0F2THlBZ0lITmxibVJsY2l3S0lDQWdJQzh2SUNBZ1lYQndTV1FzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnRoYzNObGRITmRMQW9nSUNBZ0x5OGdJQ0J5Wld0bGVWUnZPaUJ5Wld0bGVVRmtaSEpsYzNNb2NtVnJaWGxDWVdOckxDQjNZV3hzWlhRcENpQWdJQ0F2THlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFl6ZGtPREV3TVRRZ0x5OGdiV1YwYUc5a0lDSmtaV3hsZEdWQmMzTmxkSE1vZFdsdWREWTBXMTBwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMUxUWXdDaUFnSUNBdkx5QmtaV3hsZEdWQmMzTmxkSE1vQ2lBZ0lDQXZMeUFnSUhkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklFRndjR3hwWTJGMGFXOXVMQW9nSUNBZ0x5OGdJQ0JoYzNObGRITTZJRUZ6YzJWMFcxMEtJQ0FnSUM4dklDa2dld29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBZ0JBakViUVFBck1Sa1VSREVZUklJRUJFN0V3SmtFbjlmMXBnUzFINHphQkVDUzlmODJHZ0NPQkFCTkFKOEJLd0dBQURFWkZERVlGQkJEaWdFQmkvK0FFSE53Wlc1a2FXNW5YMkZrWkhKbGMzTmxTRWx6QWtReUNoSkFBQStBQzBWU1VqcGxjbkpPWVhSb3NBQ0ppZ0lCaS81QUFBTXlBNG1MLzNJSVJJazJHZ0ZKRlNNU1JCYzJHZ0pKRlNRU1JDSlROaG9EU1JVakVrUVhOaG9FU1JXQklCSkVTd09JLzVLeFR3TlBCSWovdllFRnNobXlJRThDc2hpeUFJQUVxNHNoT3JJYXNocUJCcklRSXJJQnN5UkROaG9CU1JVakVrUVhOaG9DU1JVa0VrUWlVellhQTBrVkl4SkVGellhQkVjQ0lsbEpUZ0lsQzB4SkZVNENWd0lBSWtsTEJReEJBQ0ZKSlF0TEFrbFBBbGxKVHdWSlRnUVNSRXNCRlZJaVdTVUlDRTRDSkFoQy85aEdBazhDU0NVSUVrUlBBMG1JL3dLeFR3UlBBb2ovTGJJZ1R3S3lHTElBZ0FTWS9XV25zaHF5R29FR3NoQWlzZ0d6SkVNMkdnRkpGU01TUkJjMkdnSkpGU1FTUkNKVE5ob0RTUlVqRWtRWE5ob0VTU0paZ1NnTEpRaExBUlVTUkVzRGlQNnRzVThEVHdTSS90aXlJRThDc2hpeUFJQUVsaVhxMmJJYXNocUJCcklRSXJJQnN5UkROaG9CU1JVakVrUVhOaG9DU1JVa0VrUWlVellhQTBrVkl4SkVGellhQkVraVdTTUxKUWhMQVJVU1JFc0RpUDVac1U4RFR3U0kvb1N5SUU4Q3NoaXlBSUFFeDlnUUZMSWFzaHFCQnJJUUlySUJzeVJEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
