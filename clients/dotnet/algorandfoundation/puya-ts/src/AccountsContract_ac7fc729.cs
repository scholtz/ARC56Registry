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

namespace Arc56.Generated.algorandfoundation.puya_ts.AccountsContract_ac7fc729
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWNjb3VudHNDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJPYmplY3QzQjEwMzZEOSI6W3sibmFtZSI6ImJ5dGVzIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoiYmFsYW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaW5CYWxhbmNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImF1dGhBZGRyZXNzIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoidG90YWxOdW1VaW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsTnVtQnl0ZVNsaWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsRXh0cmFBcHBQYWdlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbEFwcHNDcmVhdGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsQXBwc09wdGVkSW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxBc3NldHNDcmVhdGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsQXNzZXRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsQm94ZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxCb3hCeXRlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpc09wdEluQXBwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJpc09wdEluQXNzZXQiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRBY2NvdW50SW5mbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbMzJdLHVpbnQ2NCx1aW50NjQsYnl0ZVszMl0sdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCxib29sKSIsInN0cnVjdCI6Ik9iamVjdDNCMTAzNkQ5IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3RoZXJBY2NvdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTA5LDExNCwxMTksMTI0LDEyOSwxMzQsMTM5LDE0NCwxNDksMTU0LDE1OSwxNjRdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IGZ1bmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TURZNE1UQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdOamIzVnVkSE11WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXTmpiM1Z1ZEhORGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTVDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3dZV1JsWlRVNVppQXdlR1kyTWprME0yUXhJQzh2SUcxbGRHaHZaQ0FpWjJWMFFXTmpiM1Z1ZEVsdVptOG9ZV1JrY21WemN5eDFhVzUwTmpRcEtHSjVkR1ZiTXpKZExIVnBiblEyTkN4MWFXNTBOalFzWW5sMFpWc3pNbDBzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzWW05dmJDeGliMjlzS1NJc0lHMWxkR2h2WkNBaWIzUm9aWEpCWTJOdmRXNTBLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5blpYUkJZMk52ZFc1MFNXNW1iMTl5YjNWMFpVQTBJRzFoYVc1ZmIzUm9aWEpCWTJOdmRXNTBYM0p2ZFhSbFFEVUtJQ0FnSUdWeWNnb0tiV0ZwYmw5dmRHaGxja0ZqWTI5MWJuUmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFkyTnZkVzUwY3k1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCd2RXSnNhV01nYjNSb1pYSkJZMk52ZFc1MEtDa2dld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJCWTJOdmRXNTBTVzVtYjE5eWIzVjBaVUEwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZqWTI5MWJuUnpMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdjSFZpYkdsaklHZGxkRUZqWTI5MWJuUkpibVp2S0dGalkyOTFiblE2SUVGalkyOTFiblFzSUdGemMyVjBPaUJCYzNObGRDa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRE1LSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1luVnllU0F4Q2dwdFlXbHVYM2RvYVd4bFgzUnZjRUF4TVRvS0lDQWdJSEIxYzJocGJuUWdNVFF4TUFvZ0lDQWdaMnh2WW1Gc0lFOXdZMjlrWlVKMVpHZGxkQW9nSUNBZ1Bnb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOTNhR2xzWlVBeE5nb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJSEIxYzJocGJuUWdOU0F2THlCRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd05qZ3hNREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3Y205MllXeFFjbTluY21GdENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EWTRNVEF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JpSUcxaGFXNWZkMmhwYkdWZmRHOXdRREV4Q2dwdFlXbHVYMkZtZEdWeVgzZG9hV3hsUURFMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUdKaGJHRnVZMlU2SUdGalkyOTFiblF1WW1Gc1lXNWpaU3dLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBRbUZzWVc1alpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXTmpiM1Z1ZEhNdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z2JXbHVRbUZzWVc1alpUb2dZV05qYjNWdWRDNXRhVzVDWVd4aGJtTmxMQW9nSUNBZ1pHbG5JREVLSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBUV2x1UW1Gc1lXNWpaUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV05qYjNWdWRITXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdZWFYwYUVGa1pISmxjM002SUdGalkyOTFiblF1WVhWMGFFRmtaSEpsYzNNdVlubDBaWE1zQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JCZFhSb1FXUmtjZ29nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV05qYjNWdWRITXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdkRzkwWVd4T2RXMVZhVzUwT2lCaFkyTnZkVzUwTG5SdmRHRnNUblZ0VldsdWRDd0tJQ0FnSUdScFp5QXpDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRGUnZkR0ZzVG5WdFZXbHVkQW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV05qYjNWdWRITXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdkRzkwWVd4T2RXMUNlWFJsVTJ4cFkyVTZJR0ZqWTI5MWJuUXVkRzkwWVd4T2RXMUNlWFJsVTJ4cFkyVXNDaUFnSUNCa2FXY2dOQW9nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUlViM1JoYkU1MWJVSjVkR1ZUYkdsalpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXTmpiM1Z1ZEhNdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z2RHOTBZV3hGZUhSeVlVRndjRkJoWjJWek9pQmhZMk52ZFc1MExuUnZkR0ZzUlhoMGNtRkJjSEJRWVdkbGN5d0tJQ0FnSUdScFp5QTFDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRGUnZkR0ZzUlhoMGNtRkJjSEJRWVdkbGN3b2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXTmpiM1Z1ZEhNdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z2RHOTBZV3hCY0hCelEzSmxZWFJsWkRvZ1lXTmpiM1Z1ZEM1MGIzUmhiRUZ3Y0hORGNtVmhkR1ZrTEFvZ0lDQWdaR2xuSURZS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wVkc5MFlXeEJjSEJ6UTNKbFlYUmxaQW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV05qYjNWdWRITXVZV3huYnk1MGN6b3lNQW9nSUNBZ0x5OGdkRzkwWVd4QmNIQnpUM0IwWldSSmJqb2dZV05qYjNWdWRDNTBiM1JoYkVGd2NITlBjSFJsWkVsdUxBb2dJQ0FnWkdsbklEY0tJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFZHOTBZV3hCY0hCelQzQjBaV1JKYmdvZ0lDQWdZWE56WlhKMElDOHZJR0ZqWTI5MWJuUWdablZ1WkdWa0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdOamIzVnVkSE11WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnZEc5MFlXeEJjM05sZEhORGNtVmhkR1ZrT2lCaFkyTnZkVzUwTG5SdmRHRnNRWE56WlhSelEzSmxZWFJsWkN3S0lDQWdJR1JwWnlBNENpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEZSdmRHRnNRWE56WlhSelEzSmxZWFJsWkFvZ0lDQWdZWE56WlhKMElDOHZJR0ZqWTI5MWJuUWdablZ1WkdWa0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdOamIzVnVkSE11WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnZEc5MFlXeEJjM05sZEhNNklHRmpZMjkxYm5RdWRHOTBZV3hCYzNObGRITXNDaUFnSUNCa2FXY2dPUW9nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUlViM1JoYkVGemMyVjBjd29nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV05qYjNWdWRITXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdkRzkwWVd4Q2IzaGxjem9nWVdOamIzVnVkQzUwYjNSaGJFSnZlR1Z6TEFvZ0lDQWdaR2xuSURFd0NpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEZSdmRHRnNRbTk0WlhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUhSdmRHRnNRbTk0UW5sMFpYTTZJR0ZqWTI5MWJuUXVkRzkwWVd4Q2IzaENlWFJsY3l3S0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSVWIzUmhiRUp2ZUVKNWRHVnpDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZMk52ZFc1MGN5NWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QnBjMDl3ZEVsdVFYQndPaUJoWTJOdmRXNTBMbWx6VDNCMFpXUkpiaWhIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTV1FwTEFvZ0lDQWdaR2xuSURFeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRndjRjl2Y0hSbFpGOXBiZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmpZMjkxYm5SekxtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklHbHpUM0IwU1c1QmMzTmxkRG9nWVdOamIzVnVkQzVwYzA5d2RHVmtTVzRvWVhOelpYUXBMQW9nSUNBZ1pHbG5JREV6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR0Z6YzJWMFgyaHZiR1JwYm1kZloyVjBJRUZ6YzJWMFFtRnNZVzVqWlFvZ0lDQWdZMjkyWlhJZ01UVUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02TVRFdE1qY0tJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lHSjVkR1Z6T2lCaFkyTnZkVzUwTG1KNWRHVnpMQW9nSUNBZ0x5OGdJQ0JpWVd4aGJtTmxPaUJoWTJOdmRXNTBMbUpoYkdGdVkyVXNDaUFnSUNBdkx5QWdJRzFwYmtKaGJHRnVZMlU2SUdGalkyOTFiblF1YldsdVFtRnNZVzVqWlN3S0lDQWdJQzh2SUNBZ1lYVjBhRUZrWkhKbGMzTTZJR0ZqWTI5MWJuUXVZWFYwYUVGa1pISmxjM011WW5sMFpYTXNDaUFnSUNBdkx5QWdJSFJ2ZEdGc1RuVnRWV2x1ZERvZ1lXTmpiM1Z1ZEM1MGIzUmhiRTUxYlZWcGJuUXNDaUFnSUNBdkx5QWdJSFJ2ZEdGc1RuVnRRbmwwWlZOc2FXTmxPaUJoWTJOdmRXNTBMblJ2ZEdGc1RuVnRRbmwwWlZOc2FXTmxMQW9nSUNBZ0x5OGdJQ0IwYjNSaGJFVjRkSEpoUVhCd1VHRm5aWE02SUdGalkyOTFiblF1ZEc5MFlXeEZlSFJ5WVVGd2NGQmhaMlZ6TEFvZ0lDQWdMeThnSUNCMGIzUmhiRUZ3Y0hORGNtVmhkR1ZrT2lCaFkyTnZkVzUwTG5SdmRHRnNRWEJ3YzBOeVpXRjBaV1FzQ2lBZ0lDQXZMeUFnSUhSdmRHRnNRWEJ3YzA5d2RHVmtTVzQ2SUdGalkyOTFiblF1ZEc5MFlXeEJjSEJ6VDNCMFpXUkpiaXdLSUNBZ0lDOHZJQ0FnZEc5MFlXeEJjM05sZEhORGNtVmhkR1ZrT2lCaFkyTnZkVzUwTG5SdmRHRnNRWE56WlhSelEzSmxZWFJsWkN3S0lDQWdJQzh2SUNBZ2RHOTBZV3hCYzNObGRITTZJR0ZqWTI5MWJuUXVkRzkwWVd4QmMzTmxkSE1zQ2lBZ0lDQXZMeUFnSUhSdmRHRnNRbTk0WlhNNklHRmpZMjkxYm5RdWRHOTBZV3hDYjNobGN5d0tJQ0FnSUM4dklDQWdkRzkwWVd4Q2IzaENlWFJsY3pvZ1lXTmpiM1Z1ZEM1MGIzUmhiRUp2ZUVKNWRHVnpMQW9nSUNBZ0x5OGdJQ0JwYzA5d2RFbHVRWEJ3T2lCaFkyTnZkVzUwTG1selQzQjBaV1JKYmloSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1dRcExBb2dJQ0FnTHk4Z0lDQnBjMDl3ZEVsdVFYTnpaWFE2SUdGalkyOTFiblF1YVhOUGNIUmxaRWx1S0dGemMyVjBLU3dLSUNBZ0lDOHZJSDBLSUNBZ0lIVnVZMjkyWlhJZ01USUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTVRNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREV4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmpZMjkxYm5SekxtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRFRmpZMjkxYm5SSmJtWnZLR0ZqWTI5MWJuUTZJRUZqWTI5MWJuUXNJR0Z6YzJWME9pQkJjM05sZENrZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUE1T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZqWTI5MWJuUnpMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGalkyOTFiblJ6UTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBQUVtQVFNR2dRRWlnQUF4RzBFQTZURVpGRVF4R0VTQ0FnUUszdVdmQlBZcFE5RTJHZ0NPQWdBREFBRUFJME0yR2dGSlJRTVZnU0FTUkRZYUFra1ZnUWdTUkJkRkFZR0NDeklNRFVFQUZyR0JCcklRZ1FXeUdTaXlIaWl5SHlLeUFiTkMvK0ZMQVVsekFFUkxBWE1CUkVzQ2N3SkVTd056QTBSTEJITUVSRXNGY3dWRVN3WnpCa1JMQjNNSFJFc0ljd2hFU3dsekNVUkxDbk1LUkVzTGN3dEVTd3d5Q0dGTERVc1BjQUJPRDBoUERCWlBEVXhRVHd3V1VFOExVRThLRmxCUENSWlFUd2dXVUU4SEZsQlBCaFpRVHdVV1VFOEVGbEJQQXhaUVR3SVdVSUFCQUNKUEExUWpUd05VVUlBRUZSOThkVXhRc0NORE1Sa1VNUmdVRUVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
