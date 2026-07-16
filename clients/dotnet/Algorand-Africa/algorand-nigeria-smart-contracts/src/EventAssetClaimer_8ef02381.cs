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

namespace Arc56.Generated.Algorand_Africa.algorand_nigeria_smart_contracts.EventAssetClaimer_8ef02381
{


    public class EventAssetClaimerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EventAssetClaimerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrTxn"> </param>
        /// <param name="ipfsUrl"> </param>
        /// <param name="numberOfUnits"> </param>
        /// <param name="assetName"> </param>
        /// <param name="assetUnitName"> </param>
        public async Task<ulong> Bootstrap(PaymentTransaction mbrTxn, string ipfsUrl, ulong numberOfUnits, string assetName, string assetUnitName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrTxn });
            byte[] abiHandle = { 149, 65, 62, 196 };
            var ipfsUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfsUrlAbi.From(ipfsUrl);
            var numberOfUnitsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numberOfUnitsAbi.From(numberOfUnits);
            var assetNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetNameAbi.From(assetName);
            var assetUnitNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetUnitNameAbi.From(assetUnitName);

            var result = await base.CallApp(new List<object> { abiHandle, mbrTxn, ipfsUrlAbi, numberOfUnitsAbi, assetNameAbi, assetUnitNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(PaymentTransaction mbrTxn, string ipfsUrl, ulong numberOfUnits, string assetName, string assetUnitName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrTxn });
            byte[] abiHandle = { 149, 65, 62, 196 };
            var ipfsUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfsUrlAbi.From(ipfsUrl);
            var numberOfUnitsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numberOfUnitsAbi.From(numberOfUnits);
            var assetNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetNameAbi.From(assetName);
            var assetUnitNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetUnitNameAbi.From(assetUnitName);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrTxn, ipfsUrlAbi, numberOfUnitsAbi, assetNameAbi, assetUnitNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assetId"> </param>
        public async Task ClaimAsset(ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 5, 8, 192 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            var result = await base.CallApp(new List<object> { abiHandle, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimAsset_Transactions(ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 5, 8, 192 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXZlbnRBc3NldENsYWltZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXBmc1VybCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibnVtYmVyT2ZVbml0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldFVuaXROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xhaW1Bc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTI4XSwiZXJyb3JNZXNzYWdlIjoiTWluaW11bSBiYWxhbmNlIG11c3QgYmUgYXQgbGVhc3QgMC4yIGFsZ29zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMsNTksMTEzXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg0LDE5MV0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgb3B0ZWQgaW50byBhc3NldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2LDYyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmWVhOelpYUmZZMnhoYVcxbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUlhabGJuUkJjM05sZEVOc1lXbHRaWElnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURrS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaU9EUTBOMkl6TmlBd2VEazFOREV6WldNMElEQjROakl3TlRBNFl6QWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSXNJRzFsZEdodlpDQWlZbTl2ZEhOMGNtRndLSEJoZVN4emRISnBibWNzZFdsdWREWTBMSE4wY21sdVp5eHpkSEpwYm1jcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKamJHRnBiVUZ6YzJWMEtIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBeklHMWhhVzVmWW05dmRITjBjbUZ3WDNKdmRYUmxRRFFnYldGcGJsOWpiR0ZwYlVGemMyVjBYM0p2ZFhSbFFEVUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgyRnpjMlYwWDJOc1lXbHRaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFVjJaVzUwUVhOelpYUkRiR0ZwYldWeUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amJHRnBiVUZ6YzJWMFgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZZWE56WlhSZlkyeGhhVzFsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYMkZ6YzJWMFgyTnNZV2x0WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVYyWlc1MFFYTnpaWFJEYkdGcGJXVnlJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDJGemMyVjBYMk5zWVdsdFpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHTnNZV2x0UVhOelpYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltOXZkSE4wY21Gd1gzSnZkWFJsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZZWE56WlhSZlkyeGhhVzFsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYMkZ6YzJWMFgyTnNZV2x0WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVYyWlc1MFFYTnpaWFJEYkdGcGJXVnlJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmWVhOelpYUmZZMnhoYVcxbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1ltOXZkSE4wY21Gd0NpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjVmY205MWRHVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5aGMzTmxkRjlqYkdGcGJXVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0oyRnNiRzkzSnlCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjloYzNObGRGOWpiR0ZwYldWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVjJaVzUwUVhOelpYUkRiR0ZwYldWeUxtSnZiM1J6ZEhKaGNDaHRZbkpVZUc0NklIVnBiblEyTkN3Z2FYQm1jMVZ5YkRvZ1lubDBaWE1zSUc1MWJXSmxjazltVlc1cGRITTZJSFZwYm5RMk5Dd2dZWE56WlhST1lXMWxPaUJpZVhSbGN5d2dZWE56WlhSVmJtbDBUbUZ0WlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1ltOXZkSE4wY21Gd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYMkZ6YzJWMFgyTnNZV2x0WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE55MHlOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZbTl2ZEhOMGNtRndLQW9nSUNBZ0x5OGdJQ0J0WW5KVWVHNDZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd0tJQ0FnSUM4dklDQWdhWEJtYzFWeWJEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQnVkVzFpWlhKUFpsVnVhWFJ6T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUdGemMyVjBUbUZ0WlRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNCaGMzTmxkRlZ1YVhST1lXMWxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QXBPaUIxYVc1ME5qUWdld29nSUNBZ2NISnZkRzhnTlNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZZWE56WlhSZlkyeGhhVzFsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCaGMzTmxjblFvYldKeVZIaHVMbUZ0YjNWdWRDQStQU0F5TURCZk1EQXdMQ0FuVFdsdWFXMTFiU0JpWVd4aGJtTmxJRzExYzNRZ1ltVWdZWFFnYkdWaGMzUWdNQzR5SUdGc1oyOXpKeWs3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ2NIVnphR2x1ZENBeU1EQXdNREFnTHk4Z01qQXdNREF3Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFMXBibWx0ZFcwZ1ltRnNZVzVqWlNCdGRYTjBJR0psSUdGMElHeGxZWE4wSURBdU1pQmhiR2R2Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgyRnpjMlYwWDJOc1lXbHRaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmdvZ0lDQWdMeThnWVhOelpYSjBLRzFpY2xSNGJpNXlaV05sYVhabGNpQTlQVDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXBPd29nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5aGMzTmxkRjlqYkdGcGJXVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVkVzFpWlhKUFpsVnVhWFJ6SUQ0Z01DazdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDJGemMyVjBYMk5zWVdsdFpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPUzB6TmdvZ0lDQWdMeThnWTI5dWMzUWdjbVZ6Y0c5dWMyVWdQU0JwZEhodUxtRnpjMlYwUTI5dVptbG5LSHNLSUNBZ0lDOHZJQ0FnWVhOelpYUk9ZVzFsTEFvZ0lDQWdMeThnSUNCMWJtbDBUbUZ0WlRvZ1lYTnpaWFJWYm1sMFRtRnRaU3dLSUNBZ0lDOHZJQ0FnZFhKc09pQnBjR1p6VlhKc0xBb2dJQ0FnTHk4Z0lDQmtaV05wYldGc2N6b2dNQ3dLSUNBZ0lDOHZJQ0FnZEc5MFlXdzZJRzUxYldKbGNrOW1WVzVwZEhNc0NpQWdJQ0F2THlBZ0lHMWhibUZuWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZllYTnpaWFJmWTJ4aGFXMWxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJ0WVc1aFoyVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUV0Z1WVdkbGNnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZHOTBZV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5aGMzTmxkRjlqYkdGcGJXVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJR1JsWTJsdFlXeHpPaUF3TEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJFWldOcGJXRnNjd29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWVkpNQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJWYm1sMFRtRnRaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUbUZ0WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgyRnpjMlYwWDJOc1lXbHRaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1Mwek5nb2dJQ0FnTHk4Z1kyOXVjM1FnY21WemNHOXVjMlVnUFNCcGRIaHVMbUZ6YzJWMFEyOXVabWxuS0hzS0lDQWdJQzh2SUNBZ1lYTnpaWFJPWVcxbExBb2dJQ0FnTHk4Z0lDQjFibWwwVG1GdFpUb2dZWE56WlhSVmJtbDBUbUZ0WlN3S0lDQWdJQzh2SUNBZ2RYSnNPaUJwY0daelZYSnNMQW9nSUNBZ0x5OGdJQ0JrWldOcGJXRnNjem9nTUN3S0lDQWdJQzh2SUNBZ2RHOTBZV3c2SUc1MWJXSmxjazltVlc1cGRITXNDaUFnSUNBdkx5QWdJRzFoYm1GblpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDazdDaUFnSUNCd2RYTm9hVzUwSURNZ0x5OGdNd29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCRGNtVmhkR1ZrUVhOelpYUkpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDJGemMyVjBYMk5zWVdsdFpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdjbVYwZFhKdUlISmxjM0J2Ym5ObExtTnlaV0YwWldSQmMzTmxkQzVwWkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgyRnpjMlYwWDJOc1lXbHRaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhabGJuUkJjM05sZEVOc1lXbHRaWEl1WTJ4aGFXMUJjM05sZENoaGMzTmxkRWxrT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q21Oc1lXbHRRWE56WlhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZZWE56WlhSZlkyeGhhVzFsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReExUUXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QmpiR0ZwYlVGemMyVjBLR0Z6YzJWMFNXUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZllYTnpaWFJmWTJ4aGFXMWxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUJqYjI1emRDQmhjM05sZEVKaGJHRnVZMlVnUFNCQmMzTmxkQ2hoYzNObGRFbGtLUzVpWVd4aGJtTmxLRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOektUc0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGemMyVjBYMmh2YkdScGJtZGZaMlYwSUVGemMyVjBRbUZzWVc1alpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnYjNCMFpXUWdhVzUwYnlCaGMzTmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDJGemMyVjBYMk5zWVdsdFpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdZMjl1YzNRZ2RYTmxja0Z6YzJWMFFtRnNZVzVqWlNBOUlFRnpjMlYwS0dGemMyVjBTV1FwTG1KaGJHRnVZMlVvVkhodUxuTmxibVJsY2lrN0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRnpjMlYwWDJodmJHUnBibWRmWjJWMElFRnpjMlYwUW1Gc1lXNWpaUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ2IzQjBaV1FnYVc1MGJ5QmhjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgyRnpjMlYwWDJOc1lXbHRaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnWVhOelpYSjBLR0Z6YzJWMFFtRnNZVzVqWlNBK0lEQXBPd29nSUNBZ2MzZGhjQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZllYTnpaWFJmWTJ4aGFXMWxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUJoYzNObGNuUW9kWE5sY2tGemMyVjBRbUZzWVc1alpTQTlQVDBnTUNrN0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOWhjM05sZEY5amJHRnBiV1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5TG1selQzQjBaV1JKYmloQmMzTmxkQ2hoYzNObGRFbGtLU2twT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjlvYjJ4a2FXNW5YMmRsZENCQmMzTmxkRUpoYkdGdVkyVUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZllYTnpaWFJmWTJ4aGFXMWxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1TFRVekNpQWdJQ0F2THlCcGRIaHVMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQjRabVZ5UVhOelpYUTZJR0Z6YzJWMFNXUXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lBeExBb2dJQ0FnTHk4Z0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDazdDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZZWE56WlhSZlkyeGhhVzFsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCaGMzTmxkRkpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZllYTnpaWFJmWTJ4aGFXMWxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJoYzNObGRFRnRiM1Z1ZERvZ01Td0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZllYTnpaWFJmWTJ4aGFXMWxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1TFRVekNpQWdJQ0F2THlCcGRIaHVMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQjRabVZ5UVhOelpYUTZJR0Z6YzJWMFNXUXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lBeExBb2dJQ0FnTHk4Z0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDazdDaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBUUF4RzBFQUhJSURCTGhFZXpZRWxVRSt4QVJpQlFqQU5ob0FqZ01BU0FBU0FBSWpRekVaRkVReEdFUTJHZ0VYaUFCNUlrTXhHUlJFTVJoRU1SWWlDVWs0RUNJU1JEWWFBVmNDQURZYUFoYzJHZ05YQWdBMkdnUlhBZ0NJQUJJV2dBUVZIM3gxVEZDd0lrTXhHUlJFSWtPS0JRR0wremdJZ2NDYURBOUVpL3M0QnpJS0VrU0wvVVN4TWdxeUtZdjlzaUlqc2lPTC9MSW5pLyt5Sll2K3NpYUJBN0lRSTdJQnM3UThpWW9CQURJS2kvOXdBRVF4QUl2L2NBQkVURVFVUkRFQWkvOXdBRVVCUkxFeEFMSVVJcklTaS8reUVZRUVzaEFqc2dHemlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo1LCJwYXRjaCI6MywiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
