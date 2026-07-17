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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3Vuc2V0UGx1Z2luIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkNsb3NlT3V0QXJnQ2xvc2VzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImRlbGV0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xvc2VSZW1haW5kZXJUbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJveGVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsb3NlT3V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJla2V5QmFjayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NClbXSIsInN0cnVjdCI6IkNsb3NlT3V0QXJnQ2xvc2VzIiwibmFtZSI6ImNsb3NlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVBc3NldHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVrZXlCYWNrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls5N10sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTcsMjYxLDM1OSw0NDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTUsMTk5LDM0Miw0MjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhc3NldD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGJ5dGVzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8c21hcnRfY29udHJhY3RzL3N1bnNldC90eXBlcy50czo6QXNzZXRDbG9zZVBhcmFtcz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2LDEyNSwxOTAsMjA5LDMzMywzNTIsNDIwLDQzOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAobGVuKyhsZW4rdWludDhbXSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQTRJREVnTWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpYzNCbGJtUnBibWRmWVdSa2NtVnpjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVGRXNXpaWFJRYkhWbmFXNGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRFS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURSbFl6UmpNRGs1SURCNE9XWmtOMlkxWVRZZ01IaGlOVEZtT0dOa1lTQXdlRFF3T1RKbU5XWm1JQzh2SUcxbGRHaHZaQ0FpWkdWc1pYUmxLSFZwYm5RMk5DeGliMjlzTEhWcGJuUTJOQ3hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUmxiR1YwWlVKdmVHVnpLSFZwYm5RMk5DeGliMjlzTEhWcGJuUTJOQ3hpZVhSbFcxMWJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSmpiRzl6WlU5MWRDaDFhVzUwTmpRc1ltOXZiQ3gxYVc1ME5qUXNLR0ZrWkhKbGMzTXNkV2x1ZERZMEtWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUmxiR1YwWlVGemMyVjBjeWgxYVc1ME5qUXNZbTl2YkN4MWFXNTBOalFzZFdsdWREWTBXMTBwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR1JsYkdWMFpTQmtaV3hsZEdWQ2IzaGxjeUJqYkc5elpVOTFkQ0JrWld4bGRHVkJjM05sZEhNS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVEU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1UzVnVjMlYwVUd4MVoybHVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qcHlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yT2lCMWFXNTBOalFzSUhkaGJHeGxkRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LY21WclpYbEJaR1J5WlhOek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvek1qVUtJQ0FnSUM4dklHVjRjRzl5ZENCbWRXNWpkR2x2YmlCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQ0IzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1S1RvZ1FXTmpiM1Z1ZENCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNekkyQ2lBZ0lDQXZMeUJwWmlBb0lYSmxhMlY1UW1GamF5a2dld29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWJub2djbVZyWlhsQlpHUnlaWE56WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3pNamNLSUNBZ0lDOHZJSEpsZEhWeWJpQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdjbVYwYzNWaUNncHlaV3RsZVVGa1pISmxjM05mWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3pNekFLSUNBZ0lDOHZJSEpsZEhWeWJpQjNZV3hzWlhRdVlXUmtjbVZ6Y3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTNWdWMyVjBVR3gxWjJsdUxtUmxiR1YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxiR1YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prdE1UUUtJQ0FnSUM4dklHUmxiR1YwWlNnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdjbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQW9nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUdOc2IzTmxVbVZ0WVdsdVpHVnlWRzg2SUVGalkyOTFiblFLSUNBZ0lDOHZJQ2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qY3dMVEkzTXdvZ0lDQWdMeThnWTI5dWMzUWdXM053Wlc1a2FXNW5RV1JrY21WemMwSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUVKNWRHVnpLRUZpYzNSeVlXTjBRV05qYjNWdWRFZHNiMkpoYkZOMFlYUmxTMlY1YzFOd1pXNWthVzVuUVdSa2NtVnpjeWtLSUNBZ0lDOHZJQ2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakkzTWdvZ0lDQWdMeThnUW5sMFpYTW9RV0p6ZEhKaFkzUkJZMk52ZFc1MFIyeHZZbUZzVTNSaGRHVkxaWGx6VTNCbGJtUnBibWRCWkdSeVpYTnpLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM0JsYm1ScGJtZGZZV1JrY21WemN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qY3dMVEkzTXdvZ0lDQWdMeThnWTI5dWMzUWdXM053Wlc1a2FXNW5RV1JrY21WemMwSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUVKNWRHVnpLRUZpYzNSeVlXTjBRV05qYjNWdWRFZHNiMkpoYkZOMFlYUmxTMlY1YzFOd1pXNWthVzVuUVdSa2NtVnpjeWtLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMkxUSXlDaUFnSUNBdkx5QmhZbWxEWVd4c1BIUjVjR1Z2WmlCVGRXNXpaWFJEYjI1MGNtRmpkQzV3Y205MGIzUjVjR1V1WkdWc1pYUmxQaWg3Q2lBZ0lDQXZMeUFnSUhObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnWVhCd1NXUXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdGpiRzl6WlZKbGJXRnBibVJsY2xSdlhTd0tJQ0FnSUM4dklDQWdjbVZyWlhsVWJ6b2djbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXl3Z2QyRnNiR1YwS1N3S0lDQWdJQzh2SUNBZ2IyNURiMjF3YkdWMGFXOXVPaUJQYmtOdmJYQnNaWFJsUVdOMGFXOXVMa1JsYkdWMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNBdkx5QjlLUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklISmxhMlY1Vkc4NklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tzQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMkZzYkhOMVlpQnlaV3RsZVVGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJ2YmtOdmJYQnNaWFJwYjI0NklFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZyWlhsVWJ3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOaTB5TWdvZ0lDQWdMeThnWVdKcFEyRnNiRHgwZVhCbGIyWWdVM1Z1YzJWMFEyOXVkSEpoWTNRdWNISnZkRzkwZVhCbExtUmxiR1YwWlQ0b2V3b2dJQ0FnTHk4Z0lDQnpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lHRndjRWxrTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiWTJ4dmMyVlNaVzFoYVc1a1pYSlViMTBzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVWRzg2SUhKbGEyVjVRV1JrY21WemN5aHlaV3RsZVVKaFkyc3NJSGRoYkd4bGRDa3NDaUFnSUNBdkx5QWdJRzl1UTI5dGNHeGxkR2x2YmpvZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1RVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmdvZ0lDQWdMeThnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdGaU9HSXlNVE5oSUM4dklHMWxkR2h2WkNBaVpHVnNaWFJsS0dGa1pISmxjM01wZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prdE1UUUtJQ0FnSUM4dklHUmxiR1YwWlNnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdjbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQW9nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUdOc2IzTmxVbVZ0WVdsdVpHVnlWRzg2SUVGalkyOTFiblFLSUNBZ0lDOHZJQ2tnZXdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUZFc1elpYUlFiSFZuYVc0dVpHVnNaWFJsUW05NFpYTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWld4bGRHVkNiM2hsY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMUxUTXdDaUFnSUNBdkx5QmtaV3hsZEdWQ2IzaGxjeWdLSUNBZ0lDOHZJQ0FnZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2Yml3S0lDQWdJQzh2SUNBZ2NtVnJaWGxDWVdOck9pQmliMjlzWldGdUxBb2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ1FYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJR0p2ZUdWek9pQmllWFJsYzF0ZENpQWdJQ0F2THlBcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXFDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwa1pXeGxkR1ZDYjNobGMxOW1iM0pmYUdWaFpHVnlRREU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlMwek1Bb2dJQ0FnTHk4Z1pHVnNaWFJsUW05NFpYTW9DaUFnSUNBdkx5QWdJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1lYQndTV1E2SUVGd2NHeHBZMkYwYVc5dUxBb2dJQ0FnTHk4Z0lDQmliM2hsY3pvZ1lubDBaWE5iWFFvZ0lDQWdMeThnS1NCN0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMUNpQWdJQ0E4Q2lBZ0lDQmllaUJrWld4bGRHVkNiM2hsYzE5aFpuUmxjbDltYjNKQU5Bb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR1p2Y2lBb2JHVnVLeWhzWlc0cmRXbHVkRGhiWFNsYlhTa0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1luVnllU0ExQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlHUmxiR1YwWlVKdmVHVnpYMlp2Y2w5b1pXRmtaWEpBTVFvS1pHVnNaWFJsUW05NFpYTmZZV1owWlhKZlptOXlRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlMwek1Bb2dJQ0FnTHk4Z1pHVnNaWFJsUW05NFpYTW9DaUFnSUNBdkx5QWdJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1lYQndTV1E2SUVGd2NHeHBZMkYwYVc5dUxBb2dJQ0FnTHk4Z0lDQmliM2hsY3pvZ1lubDBaWE5iWFFvZ0lDQWdMeThnS1NCN0NpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZbmwwWlhNK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pJM01DMHlOek1LSUNBZ0lDOHZJR052Ym5OMElGdHpjR1Z1WkdsdVowRmtaSEpsYzNOQ2VYUmxjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWdLSUNBZ0lDOHZJQ0FnZDJGc2JHVjBMQW9nSUNBZ0x5OGdJQ0JDZVhSbGN5aEJZbk4wY21GamRFRmpZMjkxYm5SSGJHOWlZV3hUZEdGMFpVdGxlWE5UY0dWdVpHbHVaMEZrWkhKbGMzTXBDaUFnSUNBdkx5QXBDaUFnSUNCa2FXY2dPQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qSTNNZ29nSUNBZ0x5OGdRbmwwWlhNb1FXSnpkSEpoWTNSQlkyTnZkVzUwUjJ4dlltRnNVM1JoZEdWTFpYbHpVM0JsYm1ScGJtZEJaR1J5WlhOektRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMzQmxibVJwYm1kZllXUmtjbVZ6Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TWpjd0xUSTNNd29nSUNBZ0x5OGdZMjl1YzNRZ1czTndaVzVrYVc1blFXUmtjbVZ6YzBKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLQW9nSUNBZ0x5OGdJQ0IzWVd4c1pYUXNDaUFnSUNBdkx5QWdJRUo1ZEdWektFRmljM1J5WVdOMFFXTmpiM1Z1ZEVkc2IySmhiRk4wWVhSbFMyVjVjMU53Wlc1a2FXNW5RV1JrY21WemN5a0tJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15TFRNM0NpQWdJQ0F2THlCaFltbERZV3hzUEhSNWNHVnZaaUJUZFc1elpYUkRiMjUwY21GamRDNXdjbTkwYjNSNWNHVXVaR1ZzWlhSbFFtOTRaWE0rS0hzS0lDQWdJQzh2SUNBZ2MyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCaGNIQkpaQ3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMkp2ZUdWelhTd0tJQ0FnSUM4dklDQWdjbVZyWlhsVWJ6b2djbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXl3Z2QyRnNiR1YwS1FvZ0lDQWdMeThnZlNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUJ5Wld0bGVWUnZPaUJ5Wld0bGVVRmtaSEpsYzNNb2NtVnJaWGxDWVdOckxDQjNZV3hzWlhRcENpQWdJQ0JrYVdjZ09Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJ5Wld0bGVVRmtaSEpsYzNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WclpYbFVid29nSUNBZ1pHbG5JRGNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlMVE0zQ2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQlRkVzV6WlhSRGIyNTBjbUZqZEM1d2NtOTBiM1I1Y0dVdVpHVnNaWFJsUW05NFpYTStLSHNLSUNBZ0lDOHZJQ0FnYzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0JoY0hCSlpDd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cySnZlR1Z6WFN3S0lDQWdJQzh2SUNBZ2NtVnJaWGxVYnpvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLUW9nSUNBZ0x5OGdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGs0Wm1RMk5XRTNJQzh2SUcxbGRHaHZaQ0FpWkdWc1pYUmxRbTk0WlhNb1lubDBaVnRkVzEwcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOUzB6TUFvZ0lDQWdMeThnWkdWc1pYUmxRbTk0WlhNb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJSEpsYTJWNVFtRmphem9nWW05dmJHVmhiaXdLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCaWIzaGxjem9nWW5sMFpYTmJYUW9nSUNBZ0x5OGdLU0I3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE4xYm5ObGRGQnNkV2RwYmk1amJHOXpaVTkxZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnNiM05sVDNWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EQXRORFVLSUNBZ0lDOHZJR05zYjNObFQzVjBLQW9nSUNBZ0x5OGdJQ0IzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCeVpXdGxlVUpoWTJzNklHSnZiMnhsWVc0c0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdZMnh2YzJWek9pQkJjM05sZEVOc2IzTmxVR0Z5WVcxelcxMEtJQ0FnSUM4dklDa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ05EQUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOGMyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzkwZVhCbGN5NTBjem82UVhOelpYUkRiRzl6WlZCaGNtRnRjejRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNamN3TFRJM013b2dJQ0FnTHk4Z1kyOXVjM1FnVzNOd1pXNWthVzVuUVdSa2NtVnpjMEo1ZEdWelhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRUo1ZEdWektBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhRc0NpQWdJQ0F2THlBZ0lFSjVkR1Z6S0VGaWMzUnlZV04wUVdOamIzVnVkRWRzYjJKaGJGTjBZWFJsUzJWNWMxTndaVzVrYVc1blFXUmtjbVZ6Y3lrS0lDQWdJQzh2SUNrS0lDQWdJR1JwWnlBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pJM01nb2dJQ0FnTHk4Z1FubDBaWE1vUVdKemRISmhZM1JCWTJOdmRXNTBSMnh2WW1Gc1UzUmhkR1ZMWlhselUzQmxibVJwYm1kQlpHUnlaWE56S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNCbGJtUnBibWRmWVdSa2NtVnpjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNamN3TFRJM013b2dJQ0FnTHk4Z1kyOXVjM1FnVzNOd1pXNWthVzVuUVdSa2NtVnpjMEo1ZEdWelhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRUo1ZEdWektBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhRc0NpQWdJQ0F2THlBZ0lFSjVkR1Z6S0VGaWMzUnlZV04wUVdOamIzVnVkRWRzYjJKaGJGTjBZWFJsUzJWNWMxTndaVzVrYVc1blFXUmtjbVZ6Y3lrS0lDQWdJQzh2SUNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNMVFV5Q2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQlRkVzV6WlhSRGIyNTBjbUZqZEM1d2NtOTBiM1I1Y0dVdVkyeHZjMlZQZFhRK0tIc0tJQ0FnSUM4dklDQWdjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQmhjSEJKWkN3S0lDQWdJQzh2SUNBZ1lYSm5jem9nVzJOc2IzTmxjMTBzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVWRzg2SUhKbGEyVjVRV1JrY21WemN5aHlaV3RsZVVKaFkyc3NJSGRoYkd4bGRDa0tJQ0FnSUM4dklIMHBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2NtVnJaWGxVYnpvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTmhiR3h6ZFdJZ2NtVnJaWGxCWkdSeVpYTnpDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxhMlY1Vkc4S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EY3ROVElLSUNBZ0lDOHZJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlGTjFibk5sZEVOdmJuUnlZV04wTG5CeWIzUnZkSGx3WlM1amJHOXpaVTkxZEQ0b2V3b2dJQ0FnTHk4Z0lDQnpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lHRndjRWxrTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiWTJ4dmMyVnpYU3dLSUNBZ0lDOHZJQ0FnY21WclpYbFViem9nY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF5d2dkMkZzYkdWMEtRb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEazJNalZsWVdRNUlDOHZJRzFsZEdodlpDQWlZMnh2YzJWUGRYUW9LR0ZrWkhKbGMzTXNkV2x1ZERZMEtWdGRLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTUMwME5Rb2dJQ0FnTHk4Z1kyeHZjMlZQZFhRb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJSEpsYTJWNVFtRmphem9nWW05dmJHVmhiaXdLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCamJHOXpaWE02SUVGemMyVjBRMnh2YzJWUVlYSmhiWE5iWFFvZ0lDQWdMeThnS1NCN0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOMWJuTmxkRkJzZFdkcGJpNWtaV3hsZEdWQmMzTmxkSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pXeGxkR1ZCYzNObGRITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUzAyTUFvZ0lDQWdMeThnWkdWc1pYUmxRWE56WlhSektBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVMQW9nSUNBZ0x5OGdJQ0J5Wld0bGVVSmhZMnM2SUdKdmIyeGxZVzRzQ2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJCY0hCc2FXTmhkR2x2Yml3S0lDQWdJQzh2SUNBZ1lYTnpaWFJ6T2lCQmMzTmxkRnRkQ2lBZ0lDQXZMeUFwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoYzNObGRENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qY3dMVEkzTXdvZ0lDQWdMeThnWTI5dWMzUWdXM053Wlc1a2FXNW5RV1JrY21WemMwSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUVKNWRHVnpLRUZpYzNSeVlXTjBRV05qYjNWdWRFZHNiMkpoYkZOMFlYUmxTMlY1YzFOd1pXNWthVzVuUVdSa2NtVnpjeWtLSUNBZ0lDOHZJQ2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakkzTWdvZ0lDQWdMeThnUW5sMFpYTW9RV0p6ZEhKaFkzUkJZMk52ZFc1MFIyeHZZbUZzVTNSaGRHVkxaWGx6VTNCbGJtUnBibWRCWkdSeVpYTnpLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM0JsYm1ScGJtZGZZV1JrY21WemN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qY3dMVEkzTXdvZ0lDQWdMeThnWTI5dWMzUWdXM053Wlc1a2FXNW5RV1JrY21WemMwSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUVKNWRHVnpLRUZpYzNSeVlXTjBRV05qYjNWdWRFZHNiMkpoYkZOMFlYUmxTMlY1YzFOd1pXNWthVzVuUVdSa2NtVnpjeWtLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeUxUWTNDaUFnSUNBdkx5QmhZbWxEWVd4c1BIUjVjR1Z2WmlCVGRXNXpaWFJEYjI1MGNtRmpkQzV3Y205MGIzUjVjR1V1WkdWc1pYUmxRWE56WlhSelBpaDdDaUFnSUNBdkx5QWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdZWEJ3U1dRc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0aGMzTmxkSE5kTEFvZ0lDQWdMeThnSUNCeVpXdGxlVlJ2T2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBDaUFnSUNBdkx5QjlLUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklISmxhMlY1Vkc4NklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpZV3hzYzNWaUlISmxhMlY1UVdSa2NtVnpjd29nSUNBZ2FYUjRibDltYVdWc1pDQlNaV3RsZVZSdkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXlMVFkzQ2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQlRkVzV6WlhSRGIyNTBjbUZqZEM1d2NtOTBiM1I1Y0dVdVpHVnNaWFJsUVhOelpYUnpQaWg3Q2lBZ0lDQXZMeUFnSUhObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnWVhCd1NXUXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdGhjM05sZEhOZExBb2dJQ0FnTHk4Z0lDQnlaV3RsZVZSdk9pQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yTENCM1lXeHNaWFFwQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WXpka09ERXdNVFFnTHk4Z2JXVjBhRzlrSUNKa1pXeGxkR1ZCYzNObGRITW9kV2x1ZERZMFcxMHBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUxTFRZd0NpQWdJQ0F2THlCa1pXeGxkR1ZCYzNObGRITW9DaUFnSUNBdkx5QWdJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1lYQndTV1E2SUVGd2NHeHBZMkYwYVc5dUxBb2dJQ0FnTHk4Z0lDQmhjM05sZEhNNklFRnpjMlYwVzEwS0lDQWdJQzh2SUNrZ2V3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFnQkFpWUJFSE53Wlc1a2FXNW5YMkZrWkhKbGMzTXhHMEVBS3pFWkZFUXhHRVNDQkFST3hNQ1pCSi9YOWFZRXRSK00yZ1JBa3ZYL05ob0FqZ1FBR2dCdUFQMEJWQUF4R1JReEdCUVFRNG9DQVl2K1FBQURNZ09KaS85eUNFU0pOaG9CU1JVakVrUVhOaG9DU1JVa0VrUWlVellhQTBrVkl4SkVGellhQkVrVmdTQVNSRXNES0dWSVRMRlBBMDhFaVArOGdRV3lHYklnVHdLeUdFeXlBSUFFcTRzaE9ySWFzaHFCQnJJUUlySUJzeVJETmhvQlNSVWpFa1FYTmhvQ1NSVWtFa1FpVXpZYUEwa1ZJeEpFRnpZYUJFY0NJbGxKVGdJbEMweEpGVXhYQWdBaVNVc0ZERUVBSkVjQ0pRdExBMGxQQWxsSlN3ZEpUZ1FTUkVzQkZWSWlXU1VJQ0VVRkpBaEZBVUwvMVVzREpRaExBeEpFU3doSktHVklUTEZMQ1V5SS95cXlJRXNIc2hpeUFJQUVtUDFscDdJYVN3V3lHb0VHc2hBaXNnR3pKRU0yR2dGSkZTTVNSQmMyR2dKSkZTUVNSQ0pUTmhvRFNSVWpFa1FYTmhvRVNTSlpnU2dMSlFoTEFSVVNSRXNES0dWSVRMRlBBMDhFaVA3U3NpQlBBcklZVExJQWdBU1dKZXJac2hxeUdvRUdzaEFpc2dHekpFTTJHZ0ZKRlNNU1JCYzJHZ0pKRlNRU1JDSlROaG9EU1JVakVrUVhOaG9FU1NKWkl3c2xDRXNCRlJKRVN3TW9aVWhNc1U4RFR3U0kvbnl5SUU4Q3NoaE1zZ0NBQk1mWUVCU3lHcklhZ1FheUVDS3lBYk1rUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
