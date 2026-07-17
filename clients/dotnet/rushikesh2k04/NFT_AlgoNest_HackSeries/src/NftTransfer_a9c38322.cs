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

namespace Arc56.Generated.rushikesh2k04.NFT_AlgoNest_HackSeries.NftTransfer_a9c38322
{


    public class NftTransferProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NftTransferProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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
        public async Task AssetOptIn(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 182, 194, 177, 72 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetOptIn_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 182, 194, 177, 72 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="receiver"> </param>
        /// <param name="amount"> </param>
        public async Task AssetTransfer(Address receiver, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
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
            byte[] abiHandle = { 75, 25, 223, 221 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex, receiverRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetTransfer_Transactions(Address receiver, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
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
            byte[] abiHandle = { 75, 25, 223, 221 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex, receiverRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmZ0VHJhbnNmZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2FwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXNzZXRfb3B0X2luIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXNzZXRfdHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1NCw4MiwxMDBdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDRdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1Nyw4NV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzAsMTYxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hc3NldGlkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTkFvZ0lDQWdZbmwwWldOaWJHOWpheUFpWVhOelpYUnBaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaV1JwWDI1bWRDOWpiMjUwY21GamRDNXdlVG8xQ2lBZ0lDQXZMeUJqYkdGemN5Qk9ablJVY21GdWMyWmxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTVDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNMk5tTXpGaU16RWdNSGhpTm1NeVlqRTBPQ0F3ZURSaU1UbGtabVJrSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsWDJGd2NHeHBZMkYwYVc5dUtHRnpjMlYwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ6YzJWMFgyOXdkRjlwYmloaGMzTmxkQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmhjM05sZEY5MGNtRnVjMlpsY2loaGMzTmxkQ3hoWTJOdmRXNTBMSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlqY21WaGRHVmZZWEJ3YkdsallYUnBiMjVmY205MWRHVkFNeUJ0WVdsdVgyRnpjMlYwWDI5d2RGOXBibDl5YjNWMFpVQTBJRzFoYVc1ZllYTnpaWFJmZEhKaGJuTm1aWEpmY205MWRHVkFOUW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWa2FWOXVablF2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nVG1aMFZISmhibk5tWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWE56WlhSZmRISmhibk5tWlhKZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WldScFgyNW1kQzlqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWa2FWOXVablF2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nVG1aMFZISmhibk5tWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGemMyVjBjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaV1JwWDI1bWRDOWpiMjUwY21GamRDNXdlVG95TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQmhjM05sZEY5MGNtRnVjMlpsY2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloYzNObGRGOXZjSFJmYVc1ZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WldScFgyNW1kQzlqYjI1MGNtRmpkQzV3ZVRveE1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWa2FWOXVablF2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nVG1aMFZISmhibk5tWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGemMyVjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxaR2xmYm1aMEwyTnZiblJ5WVdOMExuQjVPakV5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHRnpjMlYwWDI5d2RGOXBiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWZllYQndiR2xqWVhScGIyNWZjbTkxZEdWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpXUnBYMjVtZEM5amIyNTBjbUZqZEM1d2VUbzRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwc0lHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxbFpHbGZibVowTDJOdmJuUnlZV04wTG5CNU9qVUtJQ0FnSUM4dklHTnNZWE56SUU1bWRGUnlZVzV6Wm1WeUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQmMzTmxkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaV1JwWDI1bWRDOWpiMjUwY21GamRDNXdlVG80Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHNJR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaVjloY0hCc2FXTmhkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXRaV1JwWDI1bWRDNWpiMjUwY21GamRDNU9ablJVY21GdWMyWmxjaTVqY21WaGRHVmZZWEJ3YkdsallYUnBiMjRvWVhOelpYUmZhV1E2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxYMkZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsWkdsZmJtWjBMMk52Ym5SeVlXTjBMbkI1T2pndE9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkTENCamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdMeThnWkdWbUlHTnlaV0YwWlY5aGNIQnNhV05oZEdsdmJpaHpaV3htTENCaGMzTmxkRjlwWkRvZ1FYTnpaWFFnS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVmthVjl1Wm5RdlkyOXVkSEpoWTNRdWNIazZNVEFLSUNBZ0lDOHZJSE5sYkdZdVlYTnpaWFJwWkNBOUlHRnpjMlYwWDJsa0xtbGtDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhjM05sZEdsa0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG0xbFpHbGZibVowTG1OdmJuUnlZV04wTGs1bWRGUnlZVzV6Wm1WeUxtRnpjMlYwWDI5d2RGOXBiaWhoYzNObGREb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGhjM05sZEY5dmNIUmZhVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1ZrYVY5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRJdE1UTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJoYzNObGRGOXZjSFJmYVc0b2MyVnNaaXdnWVhOelpYUTZJRUZ6YzJWMEtTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1ZrYVY5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRRS0lDQWdJQzh2SUdGemMyVnlkQ0JoYzNObGRDNXBaQ0E5UFNCelpXeG1MbUZ6YzJWMGFXUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGMzTmxkR2xrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnpjMlYwYVdRZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaV1JwWDI1bWRDOWpiMjUwY21GamRDNXdlVG94TmkweU1Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROU1Dd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WldScFgyNW1kQzlqYjI1MGNtRmpkQzV3ZVRveE53b2dJQ0FnTHk4Z1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1ZrYVY5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRrS0lDQWdJQzh2SUdGemMyVjBYMkZ0YjNWdWREMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxbFpHbGZibVowTDJOdmJuUnlZV04wTG5CNU9qRTJDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCcGJuUmpYeklnTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpXUnBYMjVtZEM5amIyNTBjbUZqZEM1d2VUb3lNQW9nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WldScFgyNW1kQzlqYjI1MGNtRmpkQzV3ZVRveE5pMHlNUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlNQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJXVmthVjl1Wm5RdVkyOXVkSEpoWTNRdVRtWjBWSEpoYm5ObVpYSXVZWE56WlhSZmRISmhibk5tWlhJb1lYTnpaWFE2SUhWcGJuUTJOQ3dnY21WalpXbDJaWEk2SUdKNWRHVnpMQ0JoYlc5MWJuUTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZWE56WlhSZmRISmhibk5tWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWa2FWOXVablF2WTI5dWRISmhZM1F1Y0hrNk1qTXRNalFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCaGMzTmxkRjkwY21GdWMyWmxjaWh6Wld4bUxDQmhjM05sZERvZ1FYTnpaWFFzSUhKbFkyVnBkbVZ5T2lCQlkyTnZkVzUwTENCaGJXOTFiblE2SUZWSmJuUTJOQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURNZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxbFpHbGZibVowTDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QmhjM05sY25RZ1lYTnpaWFF1YVdRZ1BUMGdjMlZzWmk1aGMzTmxkR2xrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZWE56WlhScFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoYzNObGRHbGtJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWa2FWOXVablF2WTI5dWRISmhZM1F1Y0hrNk1qY3RNekVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajF5WldObGFYWmxjaXdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFoYlc5MWJuUUtJQ0FnSUM4dklDQWdJQ0FwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWa2FWOXVablF2WTI5dWRISmhZM1F1Y0hrNk1qY0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUdsdWRHTmZNaUF2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWa2FWOXVablF2WTI5dWRISmhZM1F1Y0hrNk1qY3RNekVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajF5WldObGFYWmxjaXdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFoYlc5MWJuUUtJQ0FnSUM4dklDQWdJQ0FwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQUFFRUpnRUhZWE56WlhScFpERWJRUUFjZ2dNRVBQTWJNUVMyd3JGSUJFc1ozOTAyR2dDT0F3QXdBQjRBQWlKRE1Sa1VSREVZUkRZYUFSZkFNRFlhQWhmQUhEWWFBeGVJQUU0alF6RVpGRVF4R0VRMkdnRVh3RENJQUIwalF6RVpGRVF4R0JSRU5ob0JGOEF3aUFBQ0kwT0tBUUFvaS85bmlZb0JBQ0lvWlVTTC94SkVzVElLSXJJU2kvK3lFYklVSkxJUUlySUJzNG1LQXdBaUtHVkVpLzBTUkxHTC83SVNpLzJ5RVl2K3NoUWtzaEFpc2dHemlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
