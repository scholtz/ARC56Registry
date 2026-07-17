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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.ReferenceAccountAsset_a7d7be9f
{


    //
    // A contract that demonstrates how to reference both accounts and assets in a smart contract
    //
    public class ReferenceAccountAssetProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReferenceAccountAssetProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Returns the balance of a specific asset in a hardcoded account
        ///</summary>
        public async Task<ulong> GetAssetBalance(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 104, 229, 77 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAssetBalance_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 104, 229, 77 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the balance of a specific asset in a provided account
        ///</summary>
        /// <param name="account">The account to check the asset balance for </param>
        /// <param name="asset">The asset to check the balance of </param>
        public async Task<ulong> GetAssetBalanceWithArg(Algorand.Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 205, 12, 226 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAssetBalanceWithArg_Transactions(Algorand.Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 205, 12, 226 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVmZXJlbmNlQWNjb3VudEFzc2V0IiwiZGVzYyI6IkEgY29udHJhY3QgdGhhdCBkZW1vbnN0cmF0ZXMgaG93IHRvIHJlZmVyZW5jZSBib3RoIGFjY291bnRzIGFuZCBhc3NldHMgaW4gYSBzbWFydCBjb250cmFjdCIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRBc3NldEJhbGFuY2UiLCJkZXNjIjoiUmV0dXJucyB0aGUgYmFsYW5jZSBvZiBhIHNwZWNpZmljIGFzc2V0IGluIGEgaGFyZGNvZGVkIGFjY291bnQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGFzc2V0IGJhbGFuY2Ugb2YgdGhlIGFjY291bnQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEFzc2V0QmFsYW5jZVdpdGhBcmciLCJkZXNjIjoiUmV0dXJucyB0aGUgYmFsYW5jZSBvZiBhIHNwZWNpZmljIGFzc2V0IGluIGEgcHJvdmlkZWQgYWNjb3VudCIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOiJUaGUgYWNjb3VudCB0byBjaGVjayB0aGUgYXNzZXQgYmFsYW5jZSBmb3IiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IlRoZSBhc3NldCB0byBjaGVjayB0aGUgYmFsYW5jZSBvZiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgYXNzZXQgYmFsYW5jZSBvZiB0aGUgYWNjb3VudCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls5NCwxMTldLCJlcnJvck1lc3NhZ2UiOiJBY2NvdW50IGlzIG5vdCBvcHRlZCBpbiB0byB0aGUgYXNzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4N10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTksMTIyXSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBvcHRlZCBpbnRvIGFzc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNVFEzTWlBeENpQWdJQ0JpZVhSbFkySnNiMk5ySUdKaGMyVXpNaWhTTTBvM05rMUVVRVZZVVVWWFFsWXlURkUyUmt4Uk5GQlpRelJSV0U1SVNGQkpUREpDV0RKTFUwWlZORmRWVGtwS1RVUkJLU0F3ZURFMU1XWTNZemMxQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVdOamIzVnVkRUZ6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdSbFptRjFiSFFnWTJ4aGMzTWdVbVZtWlhKbGJtTmxRV05qYjNWdWRFRnpjMlYwSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRObVEyT0dVMU5HUWdNSGcyWVdOa01HTmxNaUF2THlCdFpYUm9iMlFnSW1kbGRFRnpjMlYwUW1Gc1lXNWpaU2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSQmMzTmxkRUpoYkdGdVkyVlhhWFJvUVhKbktHRmtaSEpsYzNNc2RXbHVkRFkwS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdkbGRFRnpjMlYwUW1Gc1lXNWpaU0JuWlhSQmMzTmxkRUpoYkdGdVkyVlhhWFJvUVhKbkNpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRGs2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVdOamIzVnVkRUZ6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdSbFptRjFiSFFnWTJ4aGMzTWdVbVZtWlhKbGJtTmxRV05qYjNWdWRFRnpjMlYwSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200Z0x5OGdiMjRnWlhKeWIzSTZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQWdKaVlnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2dvS0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZqWTI5MWJuUkJjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwU1pXWmxjbVZ1WTJWQlkyTnZkVzUwUVhOelpYUXVaMlYwUVhOelpYUkNZV3hoYm1ObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwUVhOelpYUkNZV3hoYm1ObE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRmpZMjkxYm5SQmMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJqYjI1emRDQmhaR1J5WlhOelFubDBaWE1nUFNCaFpHUnlaWE56TG1KNWRHVnpDaUFnSUNCaWVYUmxZMTh3SUM4dklHRmtaSElnVWpOS056Wk5SRkJGV0ZGRlYwSldNa3hSTmtaTVVUUlFXVU0wVVZoT1NFaFFTVXd5UWxneVMxTkdWVFJYVlU1S1NrMUVRbFJNVWs1RlRRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRmpZMjkxYm5SQmMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJqYjI1emRDQmhjM05sZENBOUlFRnpjMlYwS0RFME56SXBJQzh2SUZKbGNHeGhZMlVnZDJsMGFDQjViM1Z5SUdGemMyVjBJRWxFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNVFEzTWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGalkyOTFiblJCYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QmhjM05sY25Rb1lXTmpiM1Z1ZEM1cGMwOXdkR1ZrU1c0b1lYTnpaWFFwTENBblFXTmpiM1Z1ZENCcGN5QnViM1FnYjNCMFpXUWdhVzRnZEc4Z2RHaGxJR0Z6YzJWMEp5a0tJQ0FnSUdGemMyVjBYMmh2YkdScGJtZGZaMlYwSUVGemMyVjBRbUZzWVc1alpRb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXTmpiM1Z1ZENCcGN5QnViM1FnYjNCMFpXUWdhVzRnZEc4Z2RHaGxJR0Z6YzJWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVtVm1aWEpsYm1ObFFXTmpiM1Z1ZEVGemMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJR052Ym5OMElHRmtaSEpsYzNOQ2VYUmxjeUE5SUdGa1pISmxjM011WW5sMFpYTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z1lXUmtjaUJTTTBvM05rMUVVRVZZVVVWWFFsWXlURkUyUmt4Uk5GQlpRelJSV0U1SVNGQkpUREpDV0RKTFUwWlZORmRWVGtwS1RVUkNWRXhTVGtWTkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVtVm1aWEpsYm1ObFFXTmpiM1Z1ZEVGemMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJR052Ym5OMElHRnpjMlYwSUQwZ1FYTnpaWFFvTVRRM01pa2dMeThnVW1Wd2JHRmpaU0IzYVhSb0lIbHZkWElnWVhOelpYUWdTVVFLSUNBZ0lHbHVkR05mTUNBdkx5QXhORGN5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVdOamIzVnVkRUZ6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTUtJQ0FnSUM4dklISmxkSFZ5YmlCaGMzTmxkQzVpWVd4aGJtTmxLR0ZqWTI5MWJuUXBDaUFnSUNCaGMzTmxkRjlvYjJ4a2FXNW5YMmRsZENCQmMzTmxkRUpoYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUc5d2RHVmtJR2x1ZEc4Z1lYTnpaWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlTWldabGNtVnVZMlZCWTJOdmRXNTBRWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5DMHhOUW9nSUNBZ0x5OGdRSEpsWVdSdmJteDVDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBRWE56WlhSQ1lXeGhibU5sS0NrZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQlkyTnZkVzUwUVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVbVZtWlhKbGJtTmxRV05qYjNWdWRFRnpjMlYwTG1kbGRFRnpjMlYwUW1Gc1lXNWpaVmRwZEdoQmNtZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSQmMzTmxkRUpoYkdGdVkyVlhhWFJvUVhKbk9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRmpZMjkxYm5SQmMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15TFRNekNpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSQmMzTmxkRUpoYkdGdVkyVlhhWFJvUVhKbktHRmpZMjkxYm5RNklFRmpZMjkxYm5Rc0lHRnpjMlYwT2lCQmMzTmxkQ2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGalkyOTFiblJCYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QmhjM05sY25Rb1lXTmpiM1Z1ZEM1cGMwOXdkR1ZrU1c0b1lYTnpaWFFwTENBblFXTmpiM1Z1ZENCcGN5QnViM1FnYjNCMFpXUWdhVzRnZEc4Z2RHaGxJR0Z6YzJWMEp5a0tJQ0FnSUdSMWNESUtJQ0FnSUdGemMyVjBYMmh2YkdScGJtZGZaMlYwSUVGemMyVjBRbUZzWVc1alpRb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXTmpiM1Z1ZENCcGN5QnViM1FnYjNCMFpXUWdhVzRnZEc4Z2RHaGxJR0Z6YzJWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVtVm1aWEpsYm1ObFFXTmpiM1Z1ZEVGemMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNellLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjM05sZEM1aVlXeGhibU5sS0dGalkyOTFiblFwQ2lBZ0lDQmhjM05sZEY5b2IyeGthVzVuWDJkbGRDQkJjM05sZEVKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHOXdkR1ZrSUdsdWRHOGdZWE56WlhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQlkyTnZkVzUwUVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNaTB6TXdvZ0lDQWdMeThnUUhKbFlXUnZibXg1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMlYwUVhOelpYUkNZV3hoYm1ObFYybDBhRUZ5WnloaFkyTnZkVzUwT2lCQlkyTnZkVzUwTENCaGMzTmxkRG9nUVhOelpYUXBJSHNLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDd0FzQkpnSWdqdFAvTUc4bDRFc0d1bHc4VmNPUHdMa0x0T2Q2RjZEZlNwRnB5MUdwU3dZRUZSOThkVEViUVFBZE1Sa1VSREVZUklJQ0JHMW81VTBFYXMwTTRqWWFBSTRDQUFrQUhBQXhHUlF4R0JRUVF5Z2ljQUJGQVVRb0luQUFSQllwVEZDd0kwTTJHZ0UyR2dJWFNuQUFSUUZFY0FCRUZpbE1VTEFqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
