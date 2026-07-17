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

namespace Arc56.Generated.rushikesh2k04.medialgo.NFTRevoke_5ee058fe
{


    public class NFTRevokeProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NFTRevokeProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetStatusReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

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

                public static GetStatusReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetStatusReturn();
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
                    return Equals(obj as GetStatusReturn);
                }
                public bool Equals(GetStatusReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetStatusReturn left, GetStatusReturn right)
                {
                    return EqualityComparer<GetStatusReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetStatusReturn left, GetStatusReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_id"> </param>
        public async Task CreateApplication(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset_id });
            byte asset_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 60, 243, 27, 49 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); asset_idAbi.From(asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, asset_idRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset_id });
            byte asset_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 60, 243, 27, 49 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task AssetConfigClawback(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 85, 212, 196, 195 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetConfigClawback_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 85, 212, 196, 195 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrpay"> </param>
        public async Task OptInToAsset(PaymentTransaction mbrpay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrpay });
            byte[] abiHandle = { 21, 116, 83, 90 };

            var result = await base.CallApp(new List<object> { abiHandle, mbrpay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(PaymentTransaction mbrpay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrpay });
            byte[] abiHandle = { 21, 116, 83, 90 };

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrpay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="holder"> </param>
        /// <param name="ends_at"> </param>
        public async Task GrantAccess(Address holder, ulong ends_at, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { holder });
            byte holderRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 106, 254, 121, 168 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var ends_atAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ends_atAbi.From(ends_at);

            var result = await base.CallApp(new List<object> { abiHandle, holderRefIndex, ends_atAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantAccess_Transactions(Address holder, ulong ends_at, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { holder });
            byte holderRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 106, 254, 121, 168 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var ends_atAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ends_atAbi.From(ends_at);

            return await base.MakeTransactionList(new List<object> { abiHandle, holderRefIndex, ends_atAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RevokeAccess(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 195, 42, 234 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeAccess_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 195, 42, 234 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allow immediate revocation before expiry (e.g., if the prescription was misused)
        ///</summary>
        public async Task EmergencyRevoke(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 15, 195, 92 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> EmergencyRevoke_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 15, 195, 92 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns (current holder, expiry time, active flag)
        ///</summary>
        public async Task<Structs.GetStatusReturn> GetStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 223, 54, 26 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetStatusReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 223, 54, 26 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="receiver"> </param>
        public async Task AssetTransferFromApp(Address receiver, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { receiver });
            byte receiverRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 235, 124, 99, 255 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex, receiverRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetTransferFromApp_Transactions(Address receiver, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { receiver });
            byte receiverRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 235, 124, 99, 255 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex, receiverRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTkZUUmV2b2tlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFN0YXR1c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2FwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXNzZXRfY29uZmlnX2NsYXdiYWNrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luX3RvX2Fzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1icnBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJncmFudF9hY2Nlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhvbGRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kc19hdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VfYWNjZXNzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVtZXJnZW5jeV9yZXZva2UiLCJkZXNjIjoiQWxsb3cgaW1tZWRpYXRlIHJldm9jYXRpb24gYmVmb3JlIGV4cGlyeSAoZS5nLiwgaWYgdGhlIHByZXNjcmlwdGlvbiB3YXMgbWlzdXNlZCkiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3N0YXR1cyIsImRlc2MiOiJSZXR1cm5zIChjdXJyZW50IGhvbGRlciwgZXhwaXJ5IHRpbWUsIGFjdGl2ZSBmbGFnKSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFN0YXR1c1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFzc2V0X3RyYW5zZmVyX2Zyb21fYXBwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQxMl0sImVycm9yTWVzc2FnZSI6IkFjY2VzcyBhbHJlYWR5IGFjdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2MF0sImVycm9yTWVzc2FnZSI6IkFjY2VzcyBub3QgeWV0IGV4cGlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTIsNTA1XSwiZXJyb3JNZXNzYWdlIjoiTm8gYWN0aXZlIGFjY2VzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNSwxNTksMTg5LDIwMSwyMTMsMjM1LDI1NywyNzVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTYsNTY0XSwiZXJyb3JNZXNzYWdlIjoiYXNzZXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc5XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM4LDE2MiwxOTIsMjA0LDIxNiwyMzgsMjYwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxMCw0NDksNTAyLDU1NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWNjZXNzX2FjdGl2ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTgsNTUxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hY2Nlc3NfZXhwaXJlc19hdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzEsNTE2LDU0N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWNjZXNzX2hvbGRlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTcsNDI4LDQ2Nyw1MTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFzc2V0aWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ4XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ05Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVlXTmpaWE56WDJGamRHbDJaU0lnSW1GalkyVnpjMTlvYjJ4a1pYSWlJQ0poWTJObGMzTmZaWGh3YVhKbGMxOWhkQ0lnSW1GemMyVjBhV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qRXpNUW9nSUNBZ0x5OGdZMnhoYzNNZ1RrWlVVbVYyYjJ0bEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE0yTm1NekZpTXpFZ01IZzFOV1EwWXpSak15QXdlREUxTnpRMU16VmhJREI0Tm1GbVpUYzVZVGdnTUhobU5HTXpNbUZsWVNBd2VHVmlNR1pqTXpWaklEQjRNelprWmpNMk1XRWdNSGhsWWpkak5qTm1aaUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVjloY0hCc2FXTmhkR2x2YmloaGMzTmxkQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmhjM05sZEY5amIyNW1hV2RmWTJ4aGQySmhZMnNvWVhOelpYUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWIzQjBYMmx1WDNSdlgyRnpjMlYwS0hCaGVTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKbmNtRnVkRjloWTJObGMzTW9ZV05qYjNWdWRDeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WMmIydGxYMkZqWTJWemN5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaVpXMWxjbWRsYm1ONVgzSmxkbTlyWlNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzTjBZWFIxY3lncEtHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1GemMyVjBYM1J5WVc1elptVnlYMlp5YjIxZllYQndLR0Z6YzJWMExHRmpZMjkxYm5RcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFgyRndjR3hwWTJGMGFXOXVYM0p2ZFhSbFFETWdiV0ZwYmw5aGMzTmxkRjlqYjI1bWFXZGZZMnhoZDJKaFkydGZjbTkxZEdWQU5DQnRZV2x1WDI5d2RGOXBibDkwYjE5aGMzTmxkRjl5YjNWMFpVQTFJRzFoYVc1ZlozSmhiblJmWVdOalpYTnpYM0p2ZFhSbFFEWWdiV0ZwYmw5eVpYWnZhMlZmWVdOalpYTnpYM0p2ZFhSbFFEY2diV0ZwYmw5bGJXVnlaMlZ1WTNsZmNtVjJiMnRsWDNKdmRYUmxRRGdnYldGcGJsOW5aWFJmYzNSaGRIVnpYM0p2ZFhSbFFEa2diV0ZwYmw5aGMzTmxkRjkwY21GdWMyWmxjbDltY205dFgyRndjRjl5YjNWMFpVQXhNQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG94TXpFS0lDQWdJQzh2SUdOc1lYTnpJRTVHVkZKbGRtOXJaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGMzTmxkRjkwY21GdWMyWmxjbDltY205dFgyRndjRjl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablF2WTI5dWRISmhZM1F1Y0hrNk1qSTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRNeENpQWdJQ0F2THlCamJHRnpjeUJPUmxSU1pYWnZhMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZ6YzJWMGN3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TWpJMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR0Z6YzJWMFgzUnlZVzV6Wm1WeVgyWnliMjFmWVhCd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXpkR0YwZFhOZmNtOTFkR1ZBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZNakl4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmYzNSaGRIVnpDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJWdFpYSm5aVzVqZVY5eVpYWnZhMlZmY205MWRHVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablF2WTI5dWRISmhZM1F1Y0hrNk1qQTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCbGJXVnlaMlZ1WTNsZmNtVjJiMnRsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM0psZG05clpWOWhZMk5sYzNOZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZNVGcyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQnlaWFp2YTJWZllXTmpaWE56Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmR5WVc1MFgyRmpZMlZ6YzE5eWIzVjBaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3hOekFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qRXpNUW9nSUNBZ0x5OGdZMnhoYzNNZ1RrWlVVbVYyYjJ0bEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQlkyTnZkVzUwY3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3hOekFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQm5jbUZ1ZEY5aFkyTmxjM01LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZiM0IwWDJsdVgzUnZYMkZ6YzJWMFgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakUxTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZNVE14Q2lBZ0lDQXZMeUJqYkdGemN5Qk9SbFJTWlhadmEyVW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kQzlqYjI1MGNtRmpkQzV3ZVRveE5UUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCdmNIUmZhVzVmZEc5ZllYTnpaWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWE56WlhSZlkyOXVabWxuWDJOc1lYZGlZV05yWDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qRTBOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBMMk52Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z1kyeGhjM01nVGtaVVVtVjJiMnRsS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCYzNObGRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRRMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR0Z6YzJWMFgyTnZibVpwWjE5amJHRjNZbUZqYXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZZWEJ3YkdsallYUnBiMjVmY205MWRHVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablF2WTI5dWRISmhZM1F1Y0hrNk1UTTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwc0lHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG94TXpFS0lDQWdJQzh2SUdOc1lYTnpJRTVHVkZKbGRtOXJaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRWE56WlhSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakV6TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRMQ0JqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ1kyRnNiSE4xWWlCamNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVibVowTG1OdmJuUnlZV04wTGs1R1ZGSmxkbTlyWlM1amNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI0b1lYTnpaWFJmYVdRNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDJGd2NHeHBZMkYwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG94TXpjdE1UTTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwc0lHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0F2THlCa1pXWWdZM0psWVhSbFgyRndjR3hwWTJGMGFXOXVLSE5sYkdZc0lHRnpjMlYwWDJsa09pQkJjM05sZENrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kQzlqYjI1MGNtRmpkQzV3ZVRveE16a0tJQ0FnSUM4dklITmxiR1l1WVhOelpYUnBaQ0E5SUdGemMyVjBYMmxrTG1sa0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaGMzTmxkR2xrSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3hOREFLSUNBZ0lDOHZJSE5sYkdZdVlXTmpaWE56WDJodmJHUmxjaUE5SUVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GalkyVnpjMTlvYjJ4a1pYSWlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakUwTVFvZ0lDQWdMeThnYzJWc1ppNWhZMk5sYzNOZlpYaHdhWEpsYzE5aGRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZV05qWlhOelgyVjRjR2x5WlhOZllYUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRReUNpQWdJQ0F2THlCelpXeG1MbUZqWTJWemMxOWhZM1JwZG1VZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRmpZMlZ6YzE5aFkzUnBkbVVpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXVablF1WTI5dWRISmhZM1F1VGtaVVVtVjJiMnRsTG1GemMyVjBYMk52Ym1acFoxOWpiR0YzWW1GamF5aGhjM05sZERvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwaGMzTmxkRjlqYjI1bWFXZGZZMnhoZDJKaFkyczZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBMMk52Ym5SeVlXTjBMbkI1T2pFME5DMHhORFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCaGMzTmxkRjlqYjI1bWFXZGZZMnhoZDJKaFkyc29jMlZzWml3Z1lYTnpaWFE2SUVGemMyVjBLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakUwTmdvZ0lDQWdMeThnWVhOelpYSjBJR0Z6YzJWMExtMWhibUZuWlhJZ1BUMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBUV0Z1WVdkbGNnb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBJR1Y0YVhOMGN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3hORGN0TVRVeUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lHTnZibVpwWjE5aGMzTmxkRDFoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQU0JVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHTnNZWGRpWVdOclBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lDTWdVMlYwSUdOc1lYZGlZV05ySUhSdklHRndjQ0JoWkdSeVpYTnpDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakUwT1FvZ0lDQWdMeThnYldGdVlXZGxjajBnVkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablF2WTI5dWRISmhZM1F1Y0hrNk1UVXdDaUFnSUNBdkx5QmpiR0YzWW1GamF6MUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWpJRk5sZENCamJHRjNZbUZqYXlCMGJ5QmhjSEFnWVdSa2NtVnpjd29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJEYkdGM1ltRmphd29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTFoYm1GblpYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG94TkRjS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQndkWE5vYVc1MElETWdMeThnWVdObVp3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3hOVEVLSUNBZ0lDOHZJR1psWlQwd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakUwTnkweE5USUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdZMjl1Wm1sblgyRnpjMlYwUFdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUcxaGJtRm5aWEk5SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZMnhoZDJKaFkyczlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d2dJeUJUWlhRZ1kyeGhkMkpoWTJzZ2RHOGdZWEJ3SUdGa1pISmxjM01LSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJtWjBMbU52Ym5SeVlXTjBMazVHVkZKbGRtOXJaUzV2Y0hSZmFXNWZkRzlmWVhOelpYUW9iV0p5Y0dGNU9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNtOXdkRjlwYmw5MGIxOWhjM05sZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZNVFUwTFRFMU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnYjNCMFgybHVYM1J2WDJGemMyVjBLSE5sYkdZc0lHMWljbkJoZVRvZ1ozUjRiaTVRWVhsdFpXNTBWSEpoYm5OaFkzUnBiMjRwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRVMkNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRVM0NpQWdJQ0F2THlCaGMzTmxjblFnYm05MElFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNdWFYTmZiM0IwWldSZmFXNG9RWE56WlhRb2MyVnNaaTVoYzNObGRHbGtLU2tLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZWE56WlhScFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoYzNObGRHbGtJR1Y0YVhOMGN3b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdGemMyVjBYMmh2YkdScGJtZGZaMlYwSUVGemMyVjBRbUZzWVc1alpRb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRVNUNpQWdJQ0F2THlCaGMzTmxjblFnYldKeWNHRjVMbkpsWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qRTJNUW9nSUNBZ0x5OGdZWE56WlhKMElHMWljbkJoZVM1aGJXOTFiblFnUFQwZ1IyeHZZbUZzTG0xcGJsOWlZV3hoYm1ObElDc2dSMnh2WW1Gc0xtRnpjMlYwWDI5d2RGOXBibDl0YVc1ZlltRnNZVzVqWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHZHNiMkpoYkNCTmFXNUNZV3hoYm1ObENpQWdJQ0JuYkc5aVlXd2dRWE56WlhSUGNIUkpiazFwYmtKaGJHRnVZMlVLSUNBZ0lDc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRZekxURTJPQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROUlITmxiR1l1WVhOelpYUnBaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlJREFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBMMk52Ym5SeVlXTjBMbkI1T2pFMk5Rb2dJQ0FnTHk4Z1lYTnpaWFJmY21WalpXbDJaWEk5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3hOallLSUNBZ0lDOHZJR0Z6YzJWMFgyRnRiM1Z1ZEQwZ01Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakUyTXdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdhVzUwWTE4eUlDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qRTJOd29nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZNVFl6TFRFMk9Bb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5SUhObGJHWXVZWE56WlhScFpDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROUlEQXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG01bWRDNWpiMjUwY21GamRDNU9SbFJTWlhadmEyVXVaM0poYm5SZllXTmpaWE56S0dodmJHUmxjam9nWW5sMFpYTXNJR1Z1WkhOZllYUTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0taM0poYm5SZllXTmpaWE56T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3hOekF0TVRjeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJuY21GdWRGOWhZMk5sYzNNb2MyVnNaaXdnYUc5c1pHVnlPaUJCWTJOdmRXNTBMQ0JsYm1SelgyRjBPaUJWU1c1ME5qUXBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZNVGN5Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aFkyTmxjM05mWVdOMGFYWmxJRDA5SURBc0lDSkJZMk5sYzNNZ1lXeHlaV0ZrZVNCaFkzUnBkbVVpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV05qWlhOelgyRmpkR2wyWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhZMk5sYzNOZllXTjBhWFpsSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyVnpjeUJoYkhKbFlXUjVJR0ZqZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG94TnpRS0lDQWdJQzh2SUhObGJHWXVZV05qWlhOelgyaHZiR1JsY2lBOUlHaHZiR1JsY2dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdOalpYTnpYMmh2YkdSbGNpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRjMUNpQWdJQ0F2THlCelpXeG1MbUZqWTJWemMxOWxlSEJwY21WelgyRjBJRDBnWlc1a2MxOWhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZV05qWlhOelgyVjRjR2x5WlhOZllYUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBMMk52Ym5SeVlXTjBMbkI1T2pFM05nb2dJQ0FnTHk4Z2MyVnNaaTVoWTJObGMzTmZZV04wYVhabElEMGdWVWx1ZERZMEtERXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhZMk5sYzNOZllXTjBhWFpsSWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qRTNPQzB4T0RRS0lDQWdJQzh2SUNNZ1UyVnVaQ0IwYUdVZ1RrWlVJSFJ2SUhSb1pTQm9iMnhrWlhJS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxb2IyeGtaWElzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMXpaV3htTG1GemMyVjBhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVEVzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRneENpQWdJQ0F2THlCNFptVnlYMkZ6YzJWMFBYTmxiR1l1WVhOelpYUnBaQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmhjM05sZEdsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZ6YzJWMGFXUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakU0TWdvZ0lDQWdMeThnWVhOelpYUmZZVzF2ZFc1MFBURXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakUzT0MweE56a0tJQ0FnSUM4dklDTWdVMlZ1WkNCMGFHVWdUa1pVSUhSdklIUm9aU0JvYjJ4a1pYSUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUdsdWRHTmZNaUF2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG94T0RNS0lDQWdJQzh2SUdabFpUMHdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRjNExURTROQW9nSUNBZ0x5OGdJeUJUWlc1a0lIUm9aU0JPUmxRZ2RHOGdkR2hsSUdodmJHUmxjZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQV2h2YkdSbGNpd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFhObGJHWXVZWE56WlhScFpDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROU1Td0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Bb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV1Wm5RdVkyOXVkSEpoWTNRdVRrWlVVbVYyYjJ0bExuSmxkbTlyWlY5aFkyTmxjM01vS1NBdFBpQjJiMmxrT2dweVpYWnZhMlZmWVdOalpYTnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kQzlqYjI1MGNtRmpkQzV3ZVRveE9EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUZqWTJWemMxOWhZM1JwZG1VZ1BUMGdNU3dnSWs1dklHRmpkR2wyWlNCaFkyTmxjM01pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV05qWlhOelgyRmpkR2wyWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhZMk5sYzNOZllXTjBhWFpsSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVG04Z1lXTjBhWFpsSUdGalkyVnpjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kQzlqYjI1MGNtRmpkQzV3ZVRveE9Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0ErSUhObGJHWXVZV05qWlhOelgyVjRjR2x5WlhOZllYUXNJQ0pCWTJObGMzTWdibTkwSUhsbGRDQmxlSEJwY21Wa0lnb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GalkyVnpjMTlsZUhCcGNtVnpYMkYwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmpZMlZ6YzE5bGVIQnBjbVZ6WDJGMElHVjRhWE4wY3dvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklFRmpZMlZ6Y3lCdWIzUWdlV1YwSUdWNGNHbHlaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablF2WTI5dWRISmhZM1F1Y0hrNk1Ua3hMVEU1T0FvZ0lDQWdMeThnSXlCRGJHRjNZbUZqYXlCMGFHVWdUa1pVSUdaeWIyMGdkR2hsSUdodmJHUmxjZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxelpXeG1MbUZ6YzJWMGFXUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjMlZ1WkdWeVBYTmxiR1l1WVdOalpYTnpYMmh2YkdSbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROU1Td0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Bb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3hPVE1LSUNBZ0lDOHZJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG94T1RRS0lDQWdJQzh2SUhobVpYSmZZWE56WlhROWMyVnNaaTVoYzNObGRHbGtMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRnpjMlYwYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWE56WlhScFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZNVGsxQ2lBZ0lDQXZMeUJoYzNObGRGOXpaVzVrWlhJOWMyVnNaaTVoWTJObGMzTmZhRzlzWkdWeUxBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GalkyVnpjMTlvYjJ4a1pYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdOalpYTnpYMmh2YkdSbGNpQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZNVGsyQ2lBZ0lDQXZMeUJoYzNObGRGOWhiVzkxYm5ROU1Td0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVMlZ1WkdWeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakU1TVMweE9USUtJQ0FnSUM4dklDTWdRMnhoZDJKaFkyc2dkR2hsSUU1R1ZDQm1jbTl0SUhSb1pTQm9iMnhrWlhJS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJR2x1ZEdOZk1pQXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3hPVGNLSUNBZ0lDOHZJR1psWlQwd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZNVGt4TFRFNU9Bb2dJQ0FnTHk4Z0l5QkRiR0YzWW1GamF5QjBhR1VnVGtaVUlHWnliMjBnZEdobElHaHZiR1JsY2dvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMXpaV3htTG1GemMyVjBhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYzJWdVpHVnlQWE5sYkdZdVlXTmpaWE56WDJodmJHUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlNU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TWpBd0NpQWdJQ0F2THlCelpXeG1MbUZqWTJWemMxOWhZM1JwZG1VZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRmpZMlZ6YzE5aFkzUnBkbVVpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablF2WTI5dWRISmhZM1F1Y0hrNk1qQXhDaUFnSUNBdkx5QnpaV3htTG1GalkyVnpjMTlvYjJ4a1pYSWdQU0JIYkc5aVlXd3VlbVZ5YjE5aFpHUnlaWE56Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWTJObGMzTmZhRzlzWkdWeUlnb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3lNRElLSUNBZ0lDOHZJSE5sYkdZdVlXTmpaWE56WDJWNGNHbHlaWE5mWVhRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltRmpZMlZ6YzE5bGVIQnBjbVZ6WDJGMElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Ym1aMExtTnZiblJ5WVdOMExrNUdWRkpsZG05clpTNWxiV1Z5WjJWdVkzbGZjbVYyYjJ0bEtDa2dMVDRnZG05cFpEb0taVzFsY21kbGJtTjVYM0psZG05clpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TWpBM0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWhZMk5sYzNOZllXTjBhWFpsSUQwOUlERXNJQ0pPYnlCaFkzUnBkbVVnWVdOalpYTnpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRmpZMlZ6YzE5aFkzUnBkbVVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXTmpaWE56WDJGamRHbDJaU0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTV2SUdGamRHbDJaU0JoWTJObGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TWpBNUxUSXhOUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxelpXeG1MbUZ6YzJWMGFXUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjMlZ1WkdWeVBYTmxiR1l1WVdOalpYTnpYMmh2YkdSbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROU1Td0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Bb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3lNVEFLSUNBZ0lDOHZJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG95TVRFS0lDQWdJQzh2SUhobVpYSmZZWE56WlhROWMyVnNaaTVoYzNObGRHbGtMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRnpjMlYwYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWE56WlhScFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZNakV5Q2lBZ0lDQXZMeUJoYzNObGRGOXpaVzVrWlhJOWMyVnNaaTVoWTJObGMzTmZhRzlzWkdWeUxBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GalkyVnpjMTlvYjJ4a1pYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdOalpYTnpYMmh2YkdSbGNpQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZNakV6Q2lBZ0lDQXZMeUJoYzNObGRGOWhiVzkxYm5ROU1Td0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVMlZ1WkdWeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakl3T1FvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdhVzUwWTE4eUlDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qSXhOQW9nSUNBZ0x5OGdabVZsUFRBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3lNRGt0TWpFMUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQWE5sYkdZdVlYTnpaWFJwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5elpXNWtaWEk5YzJWc1ppNWhZMk5sYzNOZmFHOXNaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDB4TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3Q2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kQzlqYjI1MGNtRmpkQzV3ZVRveU1UY0tJQ0FnSUM4dklITmxiR1l1WVdOalpYTnpYMkZqZEdsMlpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV05qWlhOelgyRmpkR2wyWlNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3lNVGdLSUNBZ0lDOHZJSE5sYkdZdVlXTmpaWE56WDJodmJHUmxjaUE5SUVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GalkyVnpjMTlvYjJ4a1pYSWlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakl4T1FvZ0lDQWdMeThnYzJWc1ppNWhZMk5sYzNOZlpYaHdhWEpsYzE5aGRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZV05qWlhOelgyVjRjR2x5WlhOZllYUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1dVpuUXVZMjl1ZEhKaFkzUXVUa1pVVW1WMmIydGxMbWRsZEY5emRHRjBkWE1vS1NBdFBpQmllWFJsY3l3Z2RXbHVkRFkwTENCMWFXNTBOalE2Q21kbGRGOXpkR0YwZFhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakl5TkFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVlXTmpaWE56WDJodmJHUmxjaXdnYzJWc1ppNWhZMk5sYzNOZlpYaHdhWEpsYzE5aGRDd2djMlZzWmk1aFkyTmxjM05mWVdOMGFYWmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXTmpaWE56WDJodmJHUmxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFkyTmxjM05mYUc5c1pHVnlJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GalkyVnpjMTlsZUhCcGNtVnpYMkYwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmpZMlZ6YzE5bGVIQnBjbVZ6WDJGMElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZqWTJWemMxOWhZM1JwZG1VaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV05qWlhOelgyRmpkR2wyWlNCbGVHbHpkSE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXVablF1WTI5dWRISmhZM1F1VGtaVVVtVjJiMnRsTG1GemMyVjBYM1J5WVc1elptVnlYMlp5YjIxZllYQndLR0Z6YzJWME9pQjFhVzUwTmpRc0lISmxZMlZwZG1WeU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1lYTnpaWFJmZEhKaGJuTm1aWEpmWm5KdmJWOWhjSEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qSXlOUzB5TWpZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQmhjM05sZEY5MGNtRnVjMlpsY2w5bWNtOXRYMkZ3Y0NoelpXeG1MQ0JoYzNObGREb2dRWE56WlhRc0lISmxZMlZwZG1WeU9pQkJZMk52ZFc1MElDa2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3lNamNLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjM05sZEM1dFlXNWhaMlZ5SUQwOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRFMWhibUZuWlhJS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablF2WTI5dWRISmhZM1F1Y0hrNk1qSTRMVEl6TkFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2lBOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJZ1BTQnlaV05sYVhabGNpd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwSUQwZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBJRDBnTVN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablF2WTI5dWRISmhZM1F1Y0hrNk1qSTVDaUFnSUNBdkx5QnpaVzVrWlhJZ1BTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TWpNeUNpQWdJQ0F2THlCaGMzTmxkRjloYlc5MWJuUWdQU0F4TEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3lNamdLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lHbHVkR05mTWlBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kQzlqYjI1MGNtRmpkQzV3ZVRveU16TUtJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qSXlPQzB5TXpRS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJZ1BTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeUlEMGdjbVZqWldsMlpYSXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZENBOUlHRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkQ0E5SURFc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFBRUVKZ1FOWVdOalpYTnpYMkZqZEdsMlpRMWhZMk5sYzNOZmFHOXNaR1Z5RVdGalkyVnpjMTlsZUhCcGNtVnpYMkYwQjJGemMyVjBhV1F4RzBFQVA0SUlCRHp6R3pFRVZkVEV3d1FWZEZOYUJHcitlYWdFOU1NcTZnVHJEOE5jQkRiZk5ob0U2M3hqL3pZYUFJNElBSTRBZkFCbUFGQUFSQUE0QUJvQUFpSkRNUmtVUkRFWVJEWWFBUmZBTURZYUFoZkFISWdCa3lORE1Sa1VSREVZUklnQmVrd1dUQlpPQWxCTVVJQUVGUjk4ZFV4UXNDTkRNUmtVUkRFWVJJZ0JMeU5ETVJrVVJERVlSSWdBN2lORE1Sa1VSREVZUkRZYUFSZkFIRFlhQWhlSUFLNGpRekVaRkVReEdFUXhGaU1KU1RnUUl4SkVpQUJiSTBNeEdSUkVNUmhFTmhvQkY4QXdpQUFuSTBNeEdSUkVNUmdVUkRZYUFSZkFNSWdBQWlORGlnRUFLNHYvWnlreUEyY3FJbWNvSW1lSmlnRUFpLzl4QjBReEFCSkVzVEVBTWdxeUxMSXBpLyt5SVlFRHNoQWlzZ0d6aVlvQkFERUFNZ2tTUkRJS0lpdGxSRXhMQVhBQVJRRVVSSXYvT0FjeUNoSkVpLzg0Q0RJQk1oQUlFa1N4TWdvaXNoS3lGTElSSkxJUUlySUJzNG1LQWdBaUtHVkVGRVFwaS81bktvdi9aeWdqWjdFaUsyVkVJN0lTc2hHTC9ySVVKTElRSXJJQnM0a2lLR1ZFSXhKRU1nY2lLbVZFRFVTeE1nb2lLMlZFSWlsbFJDT3lFcklUc2hHeUZDU3lFQ0t5QWJNb0ltY3BNZ05uS2lKbmlTSW9aVVFqRWtTeE1nb2lLMlZFSWlsbFJDT3lFcklUc2hHeUZDU3lFQ0t5QWJNb0ltY3BNZ05uS2lKbmlTSXBaVVFpS21WRUlpaGxSSW1LQWdDTC9uRUhSREVBRWtTeE1nb2pzaEtML3JJUmkvK3lGTElBSkxJUUlySUJzNGs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
