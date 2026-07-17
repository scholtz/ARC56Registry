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

namespace Arc56.Generated.ansu555.Algorand_prototype_v0_0_1.TinymanPoolAdapter_c8774542
{


    //
    // 
    //    Adapter for interacting with Tinyman V2 pools
    //    
    //    Handles the specific ABI and transaction structure for Tinyman
    //    
    //
    public class TinymanPoolAdapterProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TinymanPoolAdapterProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Execute a fixed-input swap on Tinyman pool
        ///Tinyman V2 uses ARC4 ABI methods
        ///</summary>
        /// <param name="pool_app_id"> </param>
        /// <param name="asset_in"> </param>
        /// <param name="asset_out"> </param>
        /// <param name="amount_in"> </param>
        /// <param name="min_amount_out"> </param>
        public async Task<ulong> SwapFixedInput(ulong pool_app_id, ulong asset_in, ulong asset_out, ulong amount_in, ulong min_amount_out, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 177, 102, 206 };
            var pool_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pool_app_idAbi.From(pool_app_id);
            var asset_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_inAbi.From(asset_in);
            var asset_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_outAbi.From(asset_out);
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);
            var min_amount_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_amount_outAbi.From(min_amount_out);

            var result = await base.CallApp(new List<object> { abiHandle, pool_app_idAbi, asset_inAbi, asset_outAbi, amount_inAbi, min_amount_outAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SwapFixedInput_Transactions(ulong pool_app_id, ulong asset_in, ulong asset_out, ulong amount_in, ulong min_amount_out, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 177, 102, 206 };
            var pool_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pool_app_idAbi.From(pool_app_id);
            var asset_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_inAbi.From(asset_in);
            var asset_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_outAbi.From(asset_out);
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);
            var min_amount_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_amount_outAbi.From(min_amount_out);

            return await base.MakeTransactionList(new List<object> { abiHandle, pool_app_idAbi, asset_inAbi, asset_outAbi, amount_inAbi, min_amount_outAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGlueW1hblBvb2xBZGFwdGVyIiwiZGVzYyI6IlxuICAgIEFkYXB0ZXIgZm9yIGludGVyYWN0aW5nIHdpdGggVGlueW1hbiBWMiBwb29sc1xuICAgIFxuICAgIEhhbmRsZXMgdGhlIHNwZWNpZmljIEFCSSBhbmQgdHJhbnNhY3Rpb24gc3RydWN0dXJlIGZvciBUaW55bWFuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InN3YXBfZml4ZWRfaW5wdXQiLCJkZXNjIjoiRXhlY3V0ZSBhIGZpeGVkLWlucHV0IHN3YXAgb24gVGlueW1hbiBwb29sXG5UaW55bWFuIFYyIHVzZXMgQVJDNCBBQkkgbWV0aG9kcyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sX2FwcF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X291dCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50X2luIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW5fYW1vdW50X291dCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDJdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTVdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1Miw2MSw3MCw3OSw4OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QTRJREVnTUFvZ0lDQWdMeThnZEdsdWVXMWhibDloWkdGd2RHVnlMbkI1T2pFM0NpQWdJQ0F2THlCamJHRnpjeUJVYVc1NWJXRnVVRzl2YkVGa1lYQjBaWElvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR015WWpFMk5tTmxJQzh2SUcxbGRHaHZaQ0FpYzNkaGNGOW1hWGhsWkY5cGJuQjFkQ2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmMzZGhjRjltYVhobFpGOXBibkIxZEY5eWIzVjBaVUF6Q2lBZ0lDQmxjbklLQ20xaGFXNWZjM2RoY0Y5bWFYaGxaRjlwYm5CMWRGOXliM1YwWlVBek9nb2dJQ0FnTHk4Z2RHbHVlVzFoYmw5aFpHRndkR1Z5TG5CNU9qSTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0lDWW1JR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR0lnYzNkaGNGOW1hWGhsWkY5cGJuQjFkQW9LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBMU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQ0FtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwYVc1NWJXRnVYMkZrWVhCMFpYSXVWR2x1ZVcxaGJsQnZiMnhCWkdGd2RHVnlMbk4zWVhCZlptbDRaV1JmYVc1d2RYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZDJGd1gyWnBlR1ZrWDJsdWNIVjBPZ29nSUNBZ0x5OGdkR2x1ZVcxaGJsOWhaR0Z3ZEdWeUxuQjVPakkwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBhVzU1YldGdVgyRmtZWEIwWlhJdWNIazZNemt0TkRVS0lDQWdJQzh2SUNNZ1ZISmhibk5tWlhJZ2FXNXdkWFFnWVhOelpYUWdkRzhnY0c5dmJBb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5WVhOelpYUmZhVzRzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5Y0c5dmJGOWhjSEJmYVdRdVlXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5WVcxdmRXNTBYMmx1TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QjBhVzU1YldGdVgyRmtZWEIwWlhJdWNIazZORElLSUNBZ0lDOHZJR0Z6YzJWMFgzSmxZMlZwZG1WeVBYQnZiMnhmWVhCd1gybGtMbUZrWkhKbGMzTXNDaUFnSUNCa2FXY2dOQW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1FXUmtjbVZ6Y3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29nSUNBZ1pHbG5JRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2RHbHVlVzFoYmw5aFpHRndkR1Z5TG5CNU9qTTVMVFF3Q2lBZ0lDQXZMeUFqSUZSeVlXNXpabVZ5SUdsdWNIVjBJR0Z6YzJWMElIUnZJSEJ2YjJ3S0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2RHbHVlVzFoYmw5aFpHRndkR1Z5TG5CNU9qUTBDaUFnSUNBdkx5Qm1aV1U5VlVsdWREWTBLREFwTEFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUIwYVc1NWJXRnVYMkZrWVhCMFpYSXVjSGs2TXprdE5EVUtJQ0FnSUM4dklDTWdWSEpoYm5ObVpYSWdhVzV3ZFhRZ1lYTnpaWFFnZEc4Z2NHOXZiQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFJmYVc0c0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWNHOXZiRjloY0hCZmFXUXVZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROVlXMXZkVzUwWDJsdUxBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnZEdsdWVXMWhibDloWkdGd2RHVnlMbkI1T2pRNUNpQWdJQ0F2THlCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TENCaGMzTmxkRjl2ZFhRS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCMGFXNTViV0Z1WDJGa1lYQjBaWEl1Y0hrNk5EY3ROVEFLSUNBZ0lDOHZJQ01nUjJWMElHSmhiR0Z1WTJVZ1ltVm1iM0psQ2lBZ0lDQXZMeUJpWVd4aGJtTmxYMkpsWm05eVpTd2daWGhwYzNSelgySmxabTl5WlNBOUlHOXdMa0Z6YzJWMFNHOXNaR2x1WjBkbGRDNWhjM05sZEY5aVlXeGhibU5sS0FvZ0lDQWdMeThnSUNBZ0lFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lHRnpjMlYwWDI5MWRBb2dJQ0FnTHk4Z0tRb2dJQ0FnWkdsbklETUtJQ0FnSUdGemMyVjBYMmh2YkdScGJtZGZaMlYwSUVGemMyVjBRbUZzWVc1alpRb2dJQ0FnY0c5d0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QjBhVzU1YldGdVgyRmtZWEIwWlhJdWNIazZOVEl0TmpRS0lDQWdJQzh2SUNNZ1EyRnNiQ0JVYVc1NWJXRnVKM01nYzNkaGNDQnRaWFJvYjJRZ2RtbGhJR2x1Ym1WeUlHRndjR3hwWTJGMGFXOXVJR05oYkd3S0lDQWdJQzh2SUNNZ1RXVjBhRzlrSUhOcFoyNWhkSFZ5WlRvZ0luTjNZWEFvZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUNpQWdJQ0F2THlBaklFMWxkR2h2WkNCelpXeGxZM1J2Y2lCamIyMXdkWFJsWkNCaGN5QlRTRUV0TlRFeUx6STFOaUJvWVhOb0lDaG1hWEp6ZENBMElHSjVkR1Z6S1FvZ0lDQWdMeThnSXlCemQyRndLSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwSUMwK0lEQjRaRGN4WkRFME5tUUtJQ0FnSUM4dklHbDBlRzR1UVhCd2JHbGpZWFJwYjI1RFlXeHNLQW9nSUNBZ0x5OGdJQ0FnSUdGd2NGOXBaRDF3YjI5c1gyRndjRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmWVhKbmN6MG9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lFSjVkR1Z6TG1aeWIyMWZhR1Y0S0NKa056RmtNVFEyWkNJcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCdmNDNXBkRzlpS0dGdGIzVnVkRjlwYmlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUc5d0xtbDBiMklvYldsdVgyRnRiM1Z1ZEY5dmRYUXBMQW9nSUNBZ0x5OGdJQ0FnSUNrc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSFJwYm5sdFlXNWZZV1JoY0hSbGNpNXdlVG8yTUFvZ0lDQWdMeThnYjNBdWFYUnZZaWhoYlc5MWJuUmZhVzRwTEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnZEdsdWVXMWhibDloWkdGd2RHVnlMbkI1T2pZeENpQWdJQ0F2THlCdmNDNXBkRzlpS0cxcGJsOWhiVzkxYm5SZmIzVjBLU3dLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSFJwYm5sdFlXNWZZV1JoY0hSbGNpNXdlVG8xT1FvZ0lDQWdMeThnUW5sMFpYTXVabkp2YlY5b1pYZ29JbVEzTVdReE5EWmtJaWtzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhrTnpGa01UUTJaQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSFJwYm5sdFlXNWZZV1JoY0hSbGNpNXdlVG8xTWkwMU5nb2dJQ0FnTHk4Z0l5QkRZV3hzSUZScGJubHRZVzRuY3lCemQyRndJRzFsZEdodlpDQjJhV0VnYVc1dVpYSWdZWEJ3YkdsallYUnBiMjRnWTJGc2JBb2dJQ0FnTHk4Z0l5Qk5aWFJvYjJRZ2MybG5ibUYwZFhKbE9pQWljM2RoY0NoMWFXNTBOalFzZFdsdWREWTBLWFZwYm5RMk5DSUtJQ0FnSUM4dklDTWdUV1YwYUc5a0lITmxiR1ZqZEc5eUlHTnZiWEIxZEdWa0lHRnpJRk5JUVMwMU1USXZNalUySUdoaGMyZ2dLR1pwY25OMElEUWdZbmwwWlhNcENpQWdJQ0F2THlBaklITjNZWEFvZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRZ0xUNGdNSGhrTnpGa01UUTJaQW9nSUNBZ0x5OGdhWFI0Ymk1QmNIQnNhV05oZEdsdmJrTmhiR3dvQ2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnZEdsdWVXMWhibDloWkdGd2RHVnlMbkI1T2pZekNpQWdJQ0F2THlCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QjBhVzU1YldGdVgyRmtZWEIwWlhJdWNIazZOVEl0TmpRS0lDQWdJQzh2SUNNZ1EyRnNiQ0JVYVc1NWJXRnVKM01nYzNkaGNDQnRaWFJvYjJRZ2RtbGhJR2x1Ym1WeUlHRndjR3hwWTJGMGFXOXVJR05oYkd3S0lDQWdJQzh2SUNNZ1RXVjBhRzlrSUhOcFoyNWhkSFZ5WlRvZ0luTjNZWEFvZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUNpQWdJQ0F2THlBaklFMWxkR2h2WkNCelpXeGxZM1J2Y2lCamIyMXdkWFJsWkNCaGN5QlRTRUV0TlRFeUx6STFOaUJvWVhOb0lDaG1hWEp6ZENBMElHSjVkR1Z6S1FvZ0lDQWdMeThnSXlCemQyRndLSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwSUMwK0lEQjRaRGN4WkRFME5tUUtJQ0FnSUM4dklHbDBlRzR1UVhCd2JHbGpZWFJwYjI1RFlXeHNLQW9nSUNBZ0x5OGdJQ0FnSUdGd2NGOXBaRDF3YjI5c1gyRndjRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmWVhKbmN6MG9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lFSjVkR1Z6TG1aeWIyMWZhR1Y0S0NKa056RmtNVFEyWkNJcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCdmNDNXBkRzlpS0dGdGIzVnVkRjlwYmlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUc5d0xtbDBiMklvYldsdVgyRnRiM1Z1ZEY5dmRYUXBMQW9nSUNBZ0x5OGdJQ0FnSUNrc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUIwYVc1NWJXRnVYMkZrWVhCMFpYSXVjSGs2TmpnS0lDQWdJQzh2SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zSUdGemMyVjBYMjkxZEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhScGJubHRZVzVmWVdSaGNIUmxjaTV3ZVRvMk5pMDJPUW9nSUNBZ0x5OGdJeUJIWlhRZ1ltRnNZVzVqWlNCaFpuUmxjZ29nSUNBZ0x5OGdZbUZzWVc1alpWOWhablJsY2l3Z1pYaHBjM1J6WDJGbWRHVnlJRDBnYjNBdVFYTnpaWFJJYjJ4a2FXNW5SMlYwTG1GemMyVjBYMkpoYkdGdVkyVW9DaUFnSUNBdkx5QWdJQ0FnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnWVhOelpYUmZiM1YwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGemMyVjBYMmh2YkdScGJtZGZaMlYwSUVGemMyVjBRbUZzWVc1alpRb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMGFXNTViV0Z1WDJGa1lYQjBaWEl1Y0hrNk56RUtJQ0FnSUM4dklHOTFkSEIxZEY5aGJXOTFiblFnUFNCaVlXeGhibU5sWDJGbWRHVnlJQzBnWW1Gc1lXNWpaVjlpWldadmNtVUtJQ0FnSUhOM1lYQUtJQ0FnSUMwS0lDQWdJQzh2SUhScGJubHRZVzVmWVdSaGNIUmxjaTV3ZVRvM013b2dJQ0FnTHk4Z2NtVjBkWEp1SUVGU1F6UlZTVzUwTmpRb2IzVjBjSFYwWDJGdGIzVnVkQ2tLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSFJwYm5sdFlXNWZZV1JoY0hSbGNpNXdlVG95TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQ0FFQU1SdEJBQmlBQk1LeFpzNDJHZ0NPQVFBQkFERVpGREVZRUVSQ0FBb3hHUlF4R0JRUVJDTkROaG9CU1JVaUVrUVhOaG9DU1JVaUVrUVhOaG9EU1JVaUVrUVhOaG9FU1JVaUVrUVhOaG9GU1JVaUVrUVhzVXNFY2doRVN3S3lFcklVVHdPeUVZRUVzaEFrc2dHek1ncExBM0FBU0U0Q3NVd1dUQmFBQk5jZEZHMnlHa3l5R3JJYVR3S3lHSUVHc2hBa3NnR3pNZ3BQQW5BQVNFd0pGb0FFRlI5OGRVeFFzQ05EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
