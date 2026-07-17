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

namespace Arc56.Generated.algorandfoundation.puya_ts.AccountsContract_b296166a
{


    public class AccountsContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AccountsContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Object3B1036D9 : AVMObjectType
            {
                public byte[] Bytes { get; set; }

                public ulong Balance { get; set; }

                public ulong MinBalance { get; set; }

                public byte[] AuthAddress { get; set; }

                public ulong TotalNumUint { get; set; }

                public ulong TotalNumByteSlice { get; set; }

                public ulong TotalExtraAppPages { get; set; }

                public ulong TotalAppsCreated { get; set; }

                public ulong TotalAppsOptedIn { get; set; }

                public ulong TotalAssetsCreated { get; set; }

                public ulong TotalAssets { get; set; }

                public ulong TotalBoxes { get; set; }

                public ulong TotalBoxBytes { get; set; }

                public bool IsOptInApp { get; set; }

                public bool IsOptInAsset { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vBytes.From(Bytes);
                    ret.AddRange(vBytes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBalance.From(Balance);
                    ret.AddRange(vBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinBalance.From(MinBalance);
                    ret.AddRange(vMinBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuthAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vAuthAddress.From(AuthAddress);
                    ret.AddRange(vAuthAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalNumUint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalNumUint.From(TotalNumUint);
                    ret.AddRange(vTotalNumUint.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalNumByteSlice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalNumByteSlice.From(TotalNumByteSlice);
                    ret.AddRange(vTotalNumByteSlice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalExtraAppPages = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalExtraAppPages.From(TotalExtraAppPages);
                    ret.AddRange(vTotalExtraAppPages.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAppsCreated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalAppsCreated.From(TotalAppsCreated);
                    ret.AddRange(vTotalAppsCreated.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAppsOptedIn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalAppsOptedIn.From(TotalAppsOptedIn);
                    ret.AddRange(vTotalAppsOptedIn.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAssetsCreated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalAssetsCreated.From(TotalAssetsCreated);
                    ret.AddRange(vTotalAssetsCreated.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalAssets.From(TotalAssets);
                    ret.AddRange(vTotalAssets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBoxes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalBoxes.From(TotalBoxes);
                    ret.AddRange(vTotalBoxes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBoxBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalBoxBytes.From(TotalBoxBytes);
                    ret.AddRange(vTotalBoxBytes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsOptInApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsOptInApp.From(IsOptInApp);
                    ret.AddRange(vIsOptInApp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsOptInAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsOptInAsset.From(IsOptInAsset);
                    ret.AddRange(vIsOptInAsset.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Object3B1036D9 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Object3B1036D9();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vBytes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBytes = vBytes.ToValue();
                    if (valueBytes is byte[] vBytesValue) { ret.Bytes = vBytesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBalance = vBalance.ToValue();
                    if (valueBalance is ulong vBalanceValue) { ret.Balance = vBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinBalance = vMinBalance.ToValue();
                    if (valueMinBalance is ulong vMinBalanceValue) { ret.MinBalance = vMinBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuthAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vAuthAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAuthAddress = vAuthAddress.ToValue();
                    if (valueAuthAddress is byte[] vAuthAddressValue) { ret.AuthAddress = vAuthAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalNumUint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalNumUint.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalNumUint = vTotalNumUint.ToValue();
                    if (valueTotalNumUint is ulong vTotalNumUintValue) { ret.TotalNumUint = vTotalNumUintValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalNumByteSlice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalNumByteSlice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalNumByteSlice = vTotalNumByteSlice.ToValue();
                    if (valueTotalNumByteSlice is ulong vTotalNumByteSliceValue) { ret.TotalNumByteSlice = vTotalNumByteSliceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalExtraAppPages = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalExtraAppPages.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalExtraAppPages = vTotalExtraAppPages.ToValue();
                    if (valueTotalExtraAppPages is ulong vTotalExtraAppPagesValue) { ret.TotalExtraAppPages = vTotalExtraAppPagesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAppsCreated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalAppsCreated.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalAppsCreated = vTotalAppsCreated.ToValue();
                    if (valueTotalAppsCreated is ulong vTotalAppsCreatedValue) { ret.TotalAppsCreated = vTotalAppsCreatedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAppsOptedIn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalAppsOptedIn.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalAppsOptedIn = vTotalAppsOptedIn.ToValue();
                    if (valueTotalAppsOptedIn is ulong vTotalAppsOptedInValue) { ret.TotalAppsOptedIn = vTotalAppsOptedInValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAssetsCreated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalAssetsCreated.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalAssetsCreated = vTotalAssetsCreated.ToValue();
                    if (valueTotalAssetsCreated is ulong vTotalAssetsCreatedValue) { ret.TotalAssetsCreated = vTotalAssetsCreatedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalAssets = vTotalAssets.ToValue();
                    if (valueTotalAssets is ulong vTotalAssetsValue) { ret.TotalAssets = vTotalAssetsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBoxes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalBoxes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalBoxes = vTotalBoxes.ToValue();
                    if (valueTotalBoxes is ulong vTotalBoxesValue) { ret.TotalBoxes = vTotalBoxesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBoxBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalBoxBytes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalBoxBytes = vTotalBoxBytes.ToValue();
                    if (valueTotalBoxBytes is ulong vTotalBoxBytesValue) { ret.TotalBoxBytes = vTotalBoxBytesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsOptInApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsOptInApp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsOptInApp = vIsOptInApp.ToValue();
                    if (valueIsOptInApp is bool vIsOptInAppValue) { ret.IsOptInApp = vIsOptInAppValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsOptInAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsOptInAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsOptInAsset = vIsOptInAsset.ToValue();
                    if (valueIsOptInAsset is bool vIsOptInAssetValue) { ret.IsOptInAsset = vIsOptInAssetValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Object3B1036D9);
                }
                public bool Equals(Object3B1036D9? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Object3B1036D9 left, Object3B1036D9 right)
                {
                    return EqualityComparer<Object3B1036D9>.Default.Equals(left, right);
                }
                public static bool operator !=(Object3B1036D9 left, Object3B1036D9 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        /// <param name="asset"> </param>
        public async Task<Structs.Object3B1036D9> GetAccountInfo(Algorand.Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 222, 229, 159 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Object3B1036D9.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAccountInfo_Transactions(Algorand.Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 222, 229, 159 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OtherAccount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 41, 67, 209 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OtherAccount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 41, 67, 209 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWNjb3VudHNDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJPYmplY3QzQjEwMzZEOSI6W3sibmFtZSI6ImJ5dGVzIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoiYmFsYW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaW5CYWxhbmNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImF1dGhBZGRyZXNzIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoidG90YWxOdW1VaW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsTnVtQnl0ZVNsaWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsRXh0cmFBcHBQYWdlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbEFwcHNDcmVhdGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsQXBwc09wdGVkSW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxBc3NldHNDcmVhdGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsQXNzZXRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsQm94ZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxCb3hCeXRlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpc09wdEluQXBwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJpc09wdEluQXNzZXQiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRBY2NvdW50SW5mbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbMzJdLHVpbnQ2NCx1aW50NjQsYnl0ZVszMl0sdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCxib29sKSIsInN0cnVjdCI6Ik9iamVjdDNCMTAzNkQ5IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3RoZXJBY2NvdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjM4LDI0NywyNTYsMjY1LDI3NCwyODMsMjkyLDMwMSwzMTAsMzE5LDMyOCwzMzddLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IGZ1bmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNRFk0TVRBeENpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURFS0NtMWhhVzVmWW14dlkydEFNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZMk52ZFc1MGN5NWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCWTJOdmRXNTBjME52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFPUW9nSUNBZ1lpQnRZV2x1WDJGaWFWOXliM1YwYVc1blFESUtDbTFoYVc1ZllXSnBYM0p2ZFhScGJtZEFNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZMk52ZFc1MGN5NWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCWTJOdmRXNTBjME52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJRTV2VDNBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTndvZ0lDQWdZaUJ0WVdsdVgyTmhiR3hmVG05UGNFQXpDZ3B0WVdsdVgyTmhiR3hmVG05UGNFQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmpZMjkxYm5SekxtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZqWTI5MWJuUnpRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dZV1JsWlRVNVppQXZMeUJ0WlhSb2IyUWdJbWRsZEVGalkyOTFiblJKYm1adktHRmtaSEpsYzNNc2RXbHVkRFkwS1NoaWVYUmxXek15WFN4MWFXNTBOalFzZFdsdWREWTBMR0o1ZEdWYk16SmRMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3c1ltOXZiQ2tpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhtTmpJNU5ETmtNU0F2THlCdFpYUm9iMlFnSW05MGFHVnlRV05qYjNWdWRDZ3BkbTlwWkNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2JXRjBZMmdnYldGcGJsOW5aWFJCWTJOdmRXNTBTVzVtYjE5eWIzVjBaVUEwSUcxaGFXNWZiM1JvWlhKQlkyTnZkVzUwWDNKdmRYUmxRRFVLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURZS0NtMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUEyT2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRmpZMjkxYm5SelEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JsY25JS0NtMWhhVzVmYjNSb1pYSkJZMk52ZFc1MFgzSnZkWFJsUURVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdOamIzVnVkSE11WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnY0hWaWJHbGpJRzkwYUdWeVFXTmpiM1Z1ZENncElIc0tJQ0FnSUdOaGJHeHpkV0lnYjNSb1pYSkJZMk52ZFc1MENpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTJDZ3B0WVdsdVgyZGxkRUZqWTI5MWJuUkpibVp2WDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV05qYjNWdWRITXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBRV05qYjNWdWRFbHVabThvWVdOamIzVnVkRG9nUVdOamIzVnVkQ3dnWVhOelpYUTZJRUZ6YzJWMEtTQjdDaUFnSUNCallXeHNjM1ZpSUdkbGRFRmpZMjkxYm5SSmJtWnZDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUEyQ2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURjNkNpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBNENncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUE1T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZqWTI5MWJuUnpMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGalkyOTFiblJ6UTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR05oYkd4emRXSWdYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWDNCMWVXRmZiR2xpTG5WMGFXd3VaVzV6ZFhKbFgySjFaR2RsZENoeVpYRjFhWEpsWkY5aWRXUm5aWFE2SUhWcGJuUTJOQ3dnWm1WbFgzTnZkWEpqWlRvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwbGJuTjFjbVZmWW5Wa1oyVjBPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0JpSUdWdWMzVnlaVjlpZFdSblpYUmZZbXh2WTJ0QU1Bb0taVzV6ZFhKbFgySjFaR2RsZEY5aWJHOWphMEF3T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNBckNpQWdJQ0JpSUdWdWMzVnlaVjlpZFdSblpYUmZkMmhwYkdWZmRHOXdRREVLQ21WdWMzVnlaVjlpZFdSblpYUmZkMmhwYkdWZmRHOXdRREU2Q2lBZ0lDQm5iRzlpWVd3Z1QzQmpiMlJsUW5Wa1oyVjBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnUEFvZ0lDQWdZbm9nWlc1emRYSmxYMkoxWkdkbGRGOWhablJsY2w5M2FHbHNaVUEyQ2lBZ0lDQmlJR1Z1YzNWeVpWOWlkV1JuWlhSZmQyaHBiR1ZmWW05a2VVQXlDZ3BsYm5OMWNtVmZZblZrWjJWMFgzZG9hV3hsWDJKdlpIbEFNam9LSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNRFk0TVRBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NISnZkbUZzVUhKdlozSmhiUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREEyT0RFd01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGJHVmhjbE4wWVhSbFVISnZaM0poYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUcxaGRHTm9JR1Z1YzNWeVpWOWlkV1JuWlhSZmMzZHBkR05vWDJOaGMyVmZNRUF6SUdWdWMzVnlaVjlpZFdSblpYUmZjM2RwZEdOb1gyTmhjMlZmTVVBMENpQWdJQ0JpSUdWdWMzVnlaVjlpZFdSblpYUmZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTFDZ3BsYm5OMWNtVmZZblZrWjJWMFgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Ub0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JpSUdWdWMzVnlaVjlpZFdSblpYUmZkMmhwYkdWZmRHOXdRREVLQ21WdWMzVnlaVjlpZFdSblpYUmZjM2RwZEdOb1gyTmhjMlZmTVVBME9nb2dJQ0FnWjJ4dlltRnNJRTFwYmxSNGJrWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHSWdaVzV6ZFhKbFgySjFaR2RsZEY5emQybDBZMmhmWTJGelpWOXVaWGgwUURVS0NtVnVjM1Z5WlY5aWRXUm5aWFJmYzNkcGRHTm9YMk5oYzJWZk1FQXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCaUlHVnVjM1Z5WlY5aWRXUm5aWFJmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUExQ2dwbGJuTjFjbVZmWW5Wa1oyVjBYMkZtZEdWeVgzZG9hV3hsUURZNkNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdOamIzVnVkSE11WVd4bmJ5NTBjem82UVdOamIzVnVkSE5EYjI1MGNtRmpkQzVuWlhSQlkyTnZkVzUwU1c1bWIxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEVGalkyOTFiblJKYm1adk9nb2dJQ0FnWWlCblpYUkJZMk52ZFc1MFNXNW1iMTlpYkc5amEwQXdDZ3BuWlhSQlkyTnZkVzUwU1c1bWIxOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEVGalkyOTFiblJKYm1adktHRmpZMjkxYm5RNklFRmpZMjkxYm5Rc0lHRnpjMlYwT2lCQmMzTmxkQ2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02T2tGalkyOTFiblJ6UTI5dWRISmhZM1F1WjJWMFFXTmpiM1Z1ZEVsdVptOEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmpZMjkxYm5SekxtRnNaMjh1ZEhNNk9rRmpZMjkxYm5SelEyOXVkSEpoWTNRdWIzUm9aWEpCWTJOdmRXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYjNSb1pYSkJZMk52ZFc1ME9nb2dJQ0FnWWlCdmRHaGxja0ZqWTI5MWJuUmZZbXh2WTJ0QU1Bb0tiM1JvWlhKQlkyTnZkVzUwWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV05qYjNWdWRITXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdjSFZpYkdsaklHOTBhR1Z5UVdOamIzVnVkQ2dwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmpZMjkxYm5SekxtRnNaMjh1ZEhNNk9rRmpZMjkxYm5SelEyOXVkSEpoWTNRdWIzUm9aWEpCWTJOdmRXNTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02T2tGalkyOTFiblJ6UTI5dWRISmhZM1F1WjJWMFFXTmpiM1Z1ZEVsdVptOG9ZV05qYjNWdWREb2dZbmwwWlhNc0lHRnpjMlYwT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVdOamIzVnVkSE11WVd4bmJ5NTBjem82UVdOamIzVnVkSE5EYjI1MGNtRmpkQzVuWlhSQlkyTnZkVzUwU1c1bWJ6b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFkyTnZkVzUwY3k1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSQlkyTnZkVzUwU1c1bWJ5aGhZMk52ZFc1ME9pQkJZMk52ZFc1MExDQmhjM05sZERvZ1FYTnpaWFFwSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllXTmpiM1Z1ZEhNdVlXeG5ieTUwY3pvNlFXTmpiM1Z1ZEhORGIyNTBjbUZqZEM1blpYUkJZMk52ZFc1MFNXNW1iMTlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV05qYjNWdWRITXVZV3huYnk1MGN6bzZRV05qYjNWdWRITkRiMjUwY21GamRDNW5aWFJCWTJOdmRXNTBTVzVtYjE5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZqWTI5MWJuUnpMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJR1Z1YzNWeVpVSjFaR2RsZENneE5EQXdLUW9nSUNBZ2NIVnphR2x1ZENBeE5EQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJsYm5OMWNtVmZZblZrWjJWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdOamIzVnVkSE11WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWW1Gc1lXNWpaVG9nWVdOamIzVnVkQzVpWVd4aGJtTmxMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFSmhiR0Z1WTJVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUcxcGJrSmhiR0Z1WTJVNklHRmpZMjkxYm5RdWJXbHVRbUZzWVc1alpTd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSTmFXNUNZV3hoYm1ObENpQWdJQ0JqYjNabGNpQXhDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWTJOdmRXNTBjeTVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJoZFhSb1FXUmtjbVZ6Y3pvZ1lXTmpiM1Z1ZEM1aGRYUm9RV1JrY21WemN5NWllWFJsY3l3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JCZFhSb1FXUmtjZ29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXTmpiM1Z1ZEhNdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z2RHOTBZV3hPZFcxVmFXNTBPaUJoWTJOdmRXNTBMblJ2ZEdGc1RuVnRWV2x1ZEN3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JVYjNSaGJFNTFiVlZwYm5RS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZqWTI5MWJuUnpMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSFJ2ZEdGc1RuVnRRbmwwWlZOc2FXTmxPaUJoWTJOdmRXNTBMblJ2ZEdGc1RuVnRRbmwwWlZOc2FXTmxMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRGUnZkR0ZzVG5WdFFubDBaVk5zYVdObENpQWdJQ0JqYjNabGNpQXhDaUFnSUNCamIzWmxjaUExQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWTJOdmRXNTBjeTVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUIwYjNSaGJFVjRkSEpoUVhCd1VHRm5aWE02SUdGalkyOTFiblF1ZEc5MFlXeEZlSFJ5WVVGd2NGQmhaMlZ6TEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRlJ2ZEdGc1JYaDBjbUZCY0hCUVlXZGxjd29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdZMjkyWlhJZ05nb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXTmpiM1Z1ZEhNdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z2RHOTBZV3hCY0hCelEzSmxZWFJsWkRvZ1lXTmpiM1Z1ZEM1MGIzUmhiRUZ3Y0hORGNtVmhkR1ZrTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRlJ2ZEdGc1FYQndjME55WldGMFpXUUtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHTnZkbVZ5SURjS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02TWpBS0lDQWdJQzh2SUhSdmRHRnNRWEJ3YzA5d2RHVmtTVzQ2SUdGalkyOTFiblF1ZEc5MFlXeEJjSEJ6VDNCMFpXUkpiaXdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUlViM1JoYkVGd2NITlBjSFJsWkVsdUNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCamIzWmxjaUE0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWTJOdmRXNTBjeTVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUIwYjNSaGJFRnpjMlYwYzBOeVpXRjBaV1E2SUdGalkyOTFiblF1ZEc5MFlXeEJjM05sZEhORGNtVmhkR1ZrTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRlJ2ZEdGc1FYTnpaWFJ6UTNKbFlYUmxaQW9nSUNBZ1kyOTJaWElnTVFvZ0lDQWdZMjkyWlhJZ09Rb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXTmpiM1Z1ZEhNdVlXeG5ieTUwY3pveU1nb2dJQ0FnTHk4Z2RHOTBZV3hCYzNObGRITTZJR0ZqWTI5MWJuUXVkRzkwWVd4QmMzTmxkSE1zQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBWRzkwWVd4QmMzTmxkSE1LSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR052ZG1WeUlERXdDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZMk52ZFc1MGN5NWhiR2R2TG5Sek9qSXpDaUFnSUNBdkx5QjBiM1JoYkVKdmVHVnpPaUJoWTJOdmRXNTBMblJ2ZEdGc1FtOTRaWE1zQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBWRzkwWVd4Q2IzaGxjd29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdZMjkyWlhJZ01URUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmpZMjkxYm5SekxtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklIUnZkR0ZzUW05NFFubDBaWE02SUdGalkyOTFiblF1ZEc5MFlXeENiM2hDZVhSbGN5d0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSVWIzUmhiRUp2ZUVKNWRHVnpDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQmpiM1psY2lBeE1nb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXTmpiM1Z1ZEhNdVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z2FYTlBjSFJKYmtGd2NEb2dZV05qYjNWdWRDNXBjMDl3ZEdWa1NXNG9SMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbGtLU3dLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHRndjRjl2Y0hSbFpGOXBiZ29nSUNBZ1kyOTJaWElnTVRJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWTJOdmRXNTBjeTVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJwYzA5d2RFbHVRWE56WlhRNklHRmpZMjkxYm5RdWFYTlBjSFJsWkVsdUtHRnpjMlYwS1N3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sZEY5b2IyeGthVzVuWDJkbGRDQkJjM05sZEVKaGJHRnVZMlVLSUNBZ0lHTnZkbVZ5SURFMENpQWdJQ0JqYjNabGNpQXhOQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmpZMjkxYm5SekxtRnNaMjh1ZEhNNk1URXRNamNLSUNBZ0lDOHZJSEpsZEhWeWJpQjdDaUFnSUNBdkx5QWdJR0o1ZEdWek9pQmhZMk52ZFc1MExtSjVkR1Z6TEFvZ0lDQWdMeThnSUNCaVlXeGhibU5sT2lCaFkyTnZkVzUwTG1KaGJHRnVZMlVzQ2lBZ0lDQXZMeUFnSUcxcGJrSmhiR0Z1WTJVNklHRmpZMjkxYm5RdWJXbHVRbUZzWVc1alpTd0tJQ0FnSUM4dklDQWdZWFYwYUVGa1pISmxjM002SUdGalkyOTFiblF1WVhWMGFFRmtaSEpsYzNNdVlubDBaWE1zQ2lBZ0lDQXZMeUFnSUhSdmRHRnNUblZ0VldsdWREb2dZV05qYjNWdWRDNTBiM1JoYkU1MWJWVnBiblFzQ2lBZ0lDQXZMeUFnSUhSdmRHRnNUblZ0UW5sMFpWTnNhV05sT2lCaFkyTnZkVzUwTG5SdmRHRnNUblZ0UW5sMFpWTnNhV05sTEFvZ0lDQWdMeThnSUNCMGIzUmhiRVY0ZEhKaFFYQndVR0ZuWlhNNklHRmpZMjkxYm5RdWRHOTBZV3hGZUhSeVlVRndjRkJoWjJWekxBb2dJQ0FnTHk4Z0lDQjBiM1JoYkVGd2NITkRjbVZoZEdWa09pQmhZMk52ZFc1MExuUnZkR0ZzUVhCd2MwTnlaV0YwWldRc0NpQWdJQ0F2THlBZ0lIUnZkR0ZzUVhCd2MwOXdkR1ZrU1c0NklHRmpZMjkxYm5RdWRHOTBZV3hCY0hCelQzQjBaV1JKYml3S0lDQWdJQzh2SUNBZ2RHOTBZV3hCYzNObGRITkRjbVZoZEdWa09pQmhZMk52ZFc1MExuUnZkR0ZzUVhOelpYUnpRM0psWVhSbFpDd0tJQ0FnSUM4dklDQWdkRzkwWVd4QmMzTmxkSE02SUdGalkyOTFiblF1ZEc5MFlXeEJjM05sZEhNc0NpQWdJQ0F2THlBZ0lIUnZkR0ZzUW05NFpYTTZJR0ZqWTI5MWJuUXVkRzkwWVd4Q2IzaGxjeXdLSUNBZ0lDOHZJQ0FnZEc5MFlXeENiM2hDZVhSbGN6b2dZV05qYjNWdWRDNTBiM1JoYkVKdmVFSjVkR1Z6TEFvZ0lDQWdMeThnSUNCcGMwOXdkRWx1UVhCd09pQmhZMk52ZFc1MExtbHpUM0IwWldSSmJpaEhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVNXUXBMQW9nSUNBZ0x5OGdJQ0JwYzA5d2RFbHVRWE56WlhRNklHRmpZMjkxYm5RdWFYTlBjSFJsWkVsdUtHRnpjMlYwS1N3S0lDQWdJQzh2SUgwS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZqWTI5MWJuUnpMbUZzWjI4dWRITTZPa0ZqWTI5MWJuUnpRMjl1ZEhKaFkzUXViM1JvWlhKQlkyTnZkVzUwS0NrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02T2tGalkyOTFiblJ6UTI5dWRISmhZM1F1YjNSb1pYSkJZMk52ZFc1ME9nb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdOamIzVnVkSE11WVd4bmJ5NTBjem82UVdOamIzVnVkSE5EYjI1MGNtRmpkQzV2ZEdobGNrRmpZMjkxYm5SZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02T2tGalkyOTFiblJ6UTI5dWRISmhZM1F1YjNSb1pYSkJZMk52ZFc1MFgySnNiMk5yUURBNkNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdOamIzVnVkSE11WVd4bmJ5NTBjem82UVdOamIzVnVkSE5EYjI1MGNtRmpkQzVmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVW9LU0F0UGlCMmIybGtPZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVTZDaUFnSUNCaUlGOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlY5aWJHOWphMEF3Q2dwZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNRG9LSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FBRW1BUU1HZ1FGQ0FBQkNBQUF4R3lJVFFRQkNRZ0FBTVJraUVrUXhHQ0lUUVFBd1FnQUFOaG9BZ0FRSzN1V2ZnQVQyS1VQUlR3S09BZ0FRQUFwQ0FBQkNBQUJDQUFBQWlBQ0hRdi96aUFCY1F2L3RRdi90TVJraUVqRVlJaElRUklnQlJ5TkRpZ0lBUWdBQWkvNkJDZ2hDQUFBeURJc0FERUVBTUVJQUFMR0JCcklRZ1FXeUdTaXlIaWl5SHlJamkvK09BZ0FPQUFkQ0FBQ3pRdi9WTWdDeUFVTC85U0t5QVVMLzc0bENBQUEyR2dGSkZZRWdFa1EyR2dKSkZZRUlFa1FYaUFBVWdBUVZIM3gxVHdGUXNDTkRRZ0FBaUFEUEkwT0tBZ0ZDQUFDQitBb2lpUDkvaS81ekFFU0wvbk1CVGdGT0FrU0wvbk1DVGdGT0EwU0wvbk1EVGdGT0JFU0wvbk1FVGdGT0JVU0wvbk1GVGdGT0JrU0wvbk1HVGdGT0IwU0wvbk1IVGdGT0NFU0wvbk1JVGdGT0NVU0wvbk1KVGdGT0NrU0wvbk1LVGdGT0MwU0wvbk1MVGdGT0RFUXlDSXYrVHdGaFRneUwvb3YvY0FCT0RrNE9pLzZBQUU4QlVFOEJGbEJQQVJaUVR3RlFUd0VXVUU4QkZsQlBBUlpRVHdFV1VFOEJGbEJQQVJaUVR3RVdVRThCRmxCUEFSWlFnQUVBSWs4RFZDTlBBMVJRVHdHSlFnQUFpVUlBQUlrPSIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
