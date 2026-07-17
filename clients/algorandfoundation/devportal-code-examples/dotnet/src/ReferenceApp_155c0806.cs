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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.ReferenceApp_155c0806
{


    //
    // 
    //    Calls the increment method on another Counter app with a hardcoded app ID
    //    @returns The incremented counter value from the inner call
    //    
    //
    public class ReferenceAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReferenceAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> IncrementViaInner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 104, 70, 169 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IncrementViaInner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 104, 70, 169 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="app"> </param>
        public async Task<ulong> IncrementViaInnerWithArg(ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 246, 178, 53 };
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IncrementViaInnerWithArg_Transactions(ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 246, 178, 53 };
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVmZXJlbmNlQXBwIiwiZGVzYyI6IlxuICAgIENhbGxzIHRoZSBpbmNyZW1lbnQgbWV0aG9kIG9uIGFub3RoZXIgQ291bnRlciBhcHAgd2l0aCBhIGhhcmRjb2RlZCBhcHAgSURcbiAgICBAcmV0dXJucyBUaGUgaW5jcmVtZW50ZWQgY291bnRlciB2YWx1ZSBmcm9tIHRoZSBpbm5lciBjYWxsXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImluY3JlbWVudF92aWFfaW5uZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbmNyZW1lbnRfdmlhX2lubmVyX3dpdGhfYXJnIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4LDEyNF0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGxvZyB2YWx1ZSBpcyBub3QgdGhlIHJlc3VsdCBvZiBhbiBBQkkgcmV0dXJuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBMklEQWdNUW9nSUNBZ1lubDBaV05pYkc5amF5QXdlREUxTVdZM1l6YzFJREI0TkdFek1qVTVNREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV1psY21WdVkyVmZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qTXhDaUFnSUNBdkx5QmpiR0Z6Y3lCU1pXWmxjbVZ1WTJWQmNIQW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFEa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaREEyT0RRMllUa2dNSGhoTVdZMllqSXpOU0F2THlCdFpYUm9iMlFnSW1sdVkzSmxiV1Z1ZEY5MmFXRmZhVzV1WlhJb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWFXNWpjbVZ0Wlc1MFgzWnBZVjlwYm01bGNsOTNhWFJvWDJGeVp5aDFhVzUwTmpRcGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2FXNWpjbVZ0Wlc1MFgzWnBZVjlwYm01bGNpQnBibU55WlcxbGJuUmZkbWxoWDJsdWJtVnlYM2RwZEdoZllYSm5DaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBT1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUlDOHZJRzl1SUdWeWNtOXlPaUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdJQ1ltSUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaV1psY21WdVkyVmZZWEJ3TG1OdmJuUnlZV04wTGxKbFptVnlaVzVqWlVGd2NDNXBibU55WlcxbGJuUmZkbWxoWDJsdWJtVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYVc1amNtVnRaVzUwWDNacFlWOXBibTVsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVhCd0wyTnZiblJ5WVdOMExuQjVPalF4TFRRMUNpQWdJQ0F2THlCamIzVnVkR1Z5WDNKbGMzVnNkQ3dnWTJGc2JGOTBlRzRnUFNCaGNtTTBMbUZpYVY5allXeHNLQW9nSUNBZ0x5OGdJQ0FnSUVOdmRXNTBaWEl1YVc1amNtVnRaVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxaGNIQXNDaUFnSUNBdkx5QXBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sWDJGd2NDOWpiMjUwY21GamRDNXdlVG96T1FvZ0lDQWdMeThnWVhCd0lEMGdRWEJ3YkdsallYUnBiMjRvTVRjeE55a2dJQ01nVW1Wd2JHRmpaU0IzYVhSb0lIbHZkWElnWVhCd2JHbGpZWFJwYjI0Z2FXUUtJQ0FnSUhCMWMyaHBiblFnTVRjeE55QXZMeUF4TnpFM0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJWZllYQndMMk52Ym5SeVlXTjBMbkI1T2pReExUUTFDaUFnSUNBdkx5QmpiM1Z1ZEdWeVgzSmxjM1ZzZEN3Z1kyRnNiRjkwZUc0Z1BTQmhjbU0wTG1GaWFWOWpZV3hzS0FvZ0lDQWdMeThnSUNBZ0lFTnZkVzUwWlhJdWFXNWpjbVZ0Wlc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5cFpEMWhjSEFzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmllWFJsWTE4eElDOHZJRzFsZEdodlpDQWlhVzVqY21WdFpXNTBLQ2wxYVc1ME5qUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhVzUwWTE4d0lDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV1psY21WdVkyVmZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qUXpDaUFnSUNBdkx5Qm1aV1U5TUN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWm1WeVpXNWpaVjloY0hBdlkyOXVkSEpoWTNRdWNIazZOREV0TkRVS0lDQWdJQzh2SUdOdmRXNTBaWEpmY21WemRXeDBMQ0JqWVd4c1gzUjRiaUE5SUdGeVl6UXVZV0pwWDJOaGJHd29DaUFnSUNBdkx5QWdJQ0FnUTI5MWJuUmxjaTVwYm1OeVpXMWxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFdGd2NDd0tJQ0FnSUM4dklDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z2JHOW5JSFpoYkhWbElHbHpJRzV2ZENCMGFHVWdjbVZ6ZFd4MElHOW1JR0Z1SUVGQ1NTQnlaWFIxY200S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVhCd0wyTnZiblJ5WVdOMExuQjVPak0zQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxabVZ5Wlc1alpWOWhjSEF1WTI5dWRISmhZM1F1VW1WbVpYSmxibU5sUVhCd0xtbHVZM0psYldWdWRGOTJhV0ZmYVc1dVpYSmZkMmwwYUY5aGNtZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYm1OeVpXMWxiblJmZG1saFgybHVibVZ5WDNkcGRHaGZZWEpuT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWm1WeVpXNWpaVjloY0hBdlkyOXVkSEpoWTNRdWNIazZOVFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV1psY21WdVkyVmZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qVTJMVFUzQ2lBZ0lDQXZMeUFqSUVOaGJHd2dkR2hsSUdsdVkzSmxiV1Z1ZENCdFpYUm9iMlFnYjI0Z2RHaGxJSEJ5YjNacFpHVmtJRU52ZFc1MFpYSWdZWEJ3YkdsallYUnBiMjRLSUNBZ0lDOHZJR052ZFc1MFpYSmZjbVZ6ZFd4MExDQmpZV3hzWDNSNGJpQTlJR0Z5WXpRdVlXSnBYMk5oYkd3b1EyOTFiblJsY2k1cGJtTnlaVzFsYm5Rc0lHWmxaVDB3TENCaGNIQmZhV1E5WVhCd0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUcxbGRHaHZaQ0FpYVc1amNtVnRaVzUwS0NsMWFXNTBOalFpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVc1MFkxOHdJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJzYjJjZ2RtRnNkV1VnYVhNZ2JtOTBJSFJvWlNCeVpYTjFiSFFnYjJZZ1lXNGdRVUpKSUhKbGRIVnliZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxabVZ5Wlc1alpWOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREJnQUJKZ0lFRlI5OGRRUktNbGtCTVJ0QkFCMHhHUlJFTVJoRWdnSUUwR2hHcVFTaDlySTFOaG9BamdJQUNRQXNBREVaRkRFWUZCQkRzWUcxRGJJWUtiSWFJcklRSTdJQnM3UStTVmNFQUV4WEFBUW9Fa1FvVEZDd0pFTTJHZ0VYc2JJWUtiSWFJcklRSTdJQnM3UStTVmNFQUV4WEFBUW9Fa1FvVEZDd0pFTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjowLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
