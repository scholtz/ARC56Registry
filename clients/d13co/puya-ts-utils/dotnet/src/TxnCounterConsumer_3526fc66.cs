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

namespace Arc56.Generated.d13co.puya_ts_utils.TxnCounterConsumer_3526fc66
{


    //
    // Exercises the counter subroutine the way a real contract would.
    //
    //This exists to give the test suites something to call, and doubles as the
    //worked example for both of them.
    //
    public class TxnCounterConsumerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TxnCounterConsumerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Read the counter, leaving the caller to cover the inner transaction out of
        ///the fee pool.
        ///</summary>
        public async Task<ulong> Read(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 14, 55, 79 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Read_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 14, 55, 79 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read the counter, charging the inner transaction to `feePayer` — this
        ///application's escrow, or any account rekeyed to it.
        ///
        ///WARNING: this is unguarded, so anyone can call it to spend `feePayer`'s
        ///balance, one minimum fee per call. A real contract should check who is
        ///calling before letting them pick the fee payer.
        ///</summary>
        /// <param name="feePayer"> </param>
        public async Task<ulong> ReadPaidBy(Algorand.Address feePayer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 195, 225, 180 };
            var feePayerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); feePayerAbi.From(feePayer);

            var result = await base.CallApp(new List<object> { abiHandle, feePayerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ReadPaidBy_Transactions(Algorand.Address feePayer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 195, 225, 180 };
            var feePayerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); feePayerAbi.From(feePayer);

            return await base.MakeTransactionList(new List<object> { abiHandle, feePayerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHhuQ291bnRlckNvbnN1bWVyIiwiZGVzYyI6IkV4ZXJjaXNlcyB0aGUgY291bnRlciBzdWJyb3V0aW5lIHRoZSB3YXkgYSByZWFsIGNvbnRyYWN0IHdvdWxkLlxuXG5UaGlzIGV4aXN0cyB0byBnaXZlIHRoZSB0ZXN0IHN1aXRlcyBzb21ldGhpbmcgdG8gY2FsbCwgYW5kIGRvdWJsZXMgYXMgdGhlXG53b3JrZWQgZXhhbXBsZSBmb3IgYm90aCBvZiB0aGVtLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJyZWFkIiwiZGVzYyI6IlJlYWQgdGhlIGNvdW50ZXIsIGxlYXZpbmcgdGhlIGNhbGxlciB0byBjb3ZlciB0aGUgaW5uZXIgdHJhbnNhY3Rpb24gb3V0IG9mXG50aGUgZmVlIHBvb2wuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVhZFBhaWRCeSIsImRlc2MiOiJSZWFkIHRoZSBjb3VudGVyLCBjaGFyZ2luZyB0aGUgaW5uZXIgdHJhbnNhY3Rpb24gdG8gYGZlZVBheWVyYCDigJQgdGhpc1xuYXBwbGljYXRpb24ncyBlc2Nyb3csIG9yIGFueSBhY2NvdW50IHJla2V5ZWQgdG8gaXQuXG5cbldBUk5JTkc6IHRoaXMgaXMgdW5ndWFyZGVkLCBzbyBhbnlvbmUgY2FuIGNhbGwgaXQgdG8gc3BlbmQgYGZlZVBheWVyYCdzXG5iYWxhbmNlLCBvbmUgbWluaW11bSBmZWUgcGVyIGNhbGwuIEEgcmVhbCBjb250cmFjdCBzaG91bGQgY2hlY2sgd2hvIGlzXG5jYWxsaW5nIGJlZm9yZSBsZXR0aW5nIHRoZW0gcGljayB0aGUgZmVlIHBheWVyLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlUGF5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE0NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNR0U0TVRBeElDSmpiM1Z1ZEdWeUlpQXdlREUxTVdZM1l6YzFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIaHVYMk52ZFc1MFpYSXZZMjl1YzNWdFpYSXVZV3huYnk1MGN6b3hNQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZSNGJrTnZkVzUwWlhKRGIyNXpkVzFsY2lCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTVDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzBPVEJsTXpjMFppQXdlR0ZqWXpObE1XSTBJQzh2SUcxbGRHaHZaQ0FpY21WaFpDZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSnlaV0ZrVUdGcFpFSjVLR0ZrWkhKbGMzTXBkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2djbVZoWkNCeVpXRmtVR0ZwWkVKNUNpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSGh1WDJOdmRXNTBaWEl2WTI5dWMzVnRaWEl1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGUjRia052ZFc1MFpYSkRiMjV6ZFcxbGNpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MzSmpMMmRsZEZSNGJrTnZkVzUwWlhJdVlXeG5ieTUwY3pvNloyVjBWSGh1UTI5MWJuUmxjaWhtWldWUVlYbGxjam9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LWjJWMFZIaHVRMjkxYm5SbGNqb0tJQ0FnSUM4dklITnlZeTluWlhSVWVHNURiM1Z1ZEdWeUxtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklHVjRjRzl5ZENCbWRXNWpkR2x2YmlCblpYUlVlRzVEYjNWdWRHVnlLR1psWlZCaGVXVnlPaUJCWTJOdmRXNTBLVG9nZFdsdWREWTBJSHNLSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MzSmpMMmRsZEZSNGJrTnZkVzUwWlhJdVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z1kyOXVjM1FnYzJWc1prWjFibVJsWkNBOUlHWmxaVkJoZVdWeUlEMDlQU0JIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6Y21NdloyVjBWSGh1UTI5MWJuUmxjaTVoYkdkdkxuUnpPalExTFRVekNpQWdJQ0F2THlCamIyNXpkQ0J3Y205aVpTQTlJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRndjR3hwWTJGMGFXOXVRMkZzYkNoN0NpQWdJQ0F2THlBZ0lDQWdZWEJ3Y205MllXeFFjbTluY21GdE9pQlFVazlDUlY5UVVrOUhVa0ZOTEFvZ0lDQWdMeThnSUNBZ0lHTnNaV0Z5VTNSaGRHVlFjbTluY21GdE9pQlFVazlDUlY5UVVrOUhVa0ZOTEFvZ0lDQWdMeThnSUNBZ0lHOXVRMjl0Y0d4bGRHbHZiam9nVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVFWld4bGRHVkJjSEJzYVdOaGRHbHZiaXdLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWEk2SUhObGJHWkdkVzVrWldRZ1B5QkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3lBNklHWmxaVkJoZVdWeUxBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ2MyVnNaa1oxYm1SbFpDQS9JREFnT2lCSGJHOWlZV3d1YldsdVZIaHVSbVZsTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOeVl5OW5aWFJVZUc1RGIzVnVkR1Z5TG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUdabFpUb2djMlZzWmtaMWJtUmxaQ0EvSURBZ09pQkhiRzlpWVd3dWJXbHVWSGh1Um1WbExBb2dJQ0FnWW5vZ1oyVjBWSGh1UTI5MWJuUmxjbDkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUhCMWMyaHBiblFnTUFvZ0lDQWdjM2RoY0FvS1oyVjBWSGh1UTI5MWJuUmxjbDkwWlhKdVlYSjVYMjFsY21kbFFETTZDaUFnSUNBdkx5QnpjbU12WjJWMFZIaHVRMjkxYm5SbGNpNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QnpaVzVrWlhJNklITmxiR1pHZFc1a1pXUWdQeUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5QTZJR1psWlZCaGVXVnlMQW9nSUNBZ1lub2daMlYwVkhodVEyOTFiblJsY2w5MFpYSnVZWEo1WDJaaGJITmxRRFVLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2dwblpYUlVlRzVEYjNWdWRHVnlYM1JsY201aGNubGZiV1Z5WjJWQU5qb0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6Y21NdloyVjBWSGh1UTI5MWJuUmxjaTVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJ2YmtOdmJYQnNaWFJwYjI0NklFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQXZMeUJ6Y21NdloyVjBWSGh1UTI5MWJuUmxjaTVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUJqYkdWaGNsTjBZWFJsVUhKdlozSmhiVG9nVUZKUFFrVmZVRkpQUjFKQlRTd0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dZVGd4TURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzFRWVdkbGN3b2dJQ0FnTHk4Z2MzSmpMMmRsZEZSNGJrTnZkVzUwWlhJdVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z1lYQndjbTkyWVd4UWNtOW5jbUZ0T2lCUVVrOUNSVjlRVWs5SFVrRk5MQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREJoT0RFd01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnliM1poYkZCeWIyZHlZVzFRWVdkbGN3b2dJQ0FnTHk4Z2MzSmpMMmRsZEZSNGJrTnZkVzUwWlhJdVlXeG5ieTUwY3pvME5TMDFNZ29nSUNBZ0x5OGdZMjl1YzNRZ2NISnZZbVVnUFNCcGRIaHVDaUFnSUNBdkx5QWdJQzVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0FnSUdGd2NISnZkbUZzVUhKdlozSmhiVG9nVUZKUFFrVmZVRkpQUjFKQlRTd0tJQ0FnSUM4dklDQWdJQ0JqYkdWaGNsTjBZWFJsVUhKdlozSmhiVG9nVUZKUFFrVmZVRkpQUjFKQlRTd0tJQ0FnSUM4dklDQWdJQ0J2YmtOdmJYQnNaWFJwYjI0NklFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeU9pQnpaV3htUm5WdVpHVmtJRDhnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTWdPaUJtWldWUVlYbGxjaXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJSE5sYkdaR2RXNWtaV1FnUHlBd0lEb2dSMnh2WW1Gc0xtMXBibFI0YmtabFpTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOeVl5OW5aWFJVZUc1RGIzVnVkR1Z5TG1Gc1oyOHVkSE02TkRVdE5UTUtJQ0FnSUM4dklHTnZibk4wSUhCeWIySmxJRDBnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWEJ3YkdsallYUnBiMjVEWVd4c0tIc0tJQ0FnSUM4dklDQWdJQ0JoY0hCeWIzWmhiRkJ5YjJkeVlXMDZJRkJTVDBKRlgxQlNUMGRTUVUwc0NpQWdJQ0F2THlBZ0lDQWdZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMDZJRkJTVDBKRlgxQlNUMGRTUVUwc0NpQWdJQ0F2THlBZ0lDQWdiMjVEYjIxd2JHVjBhVzl1T2lCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2pvZ2MyVnNaa1oxYm1SbFpDQS9JRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOeklEb2dabVZsVUdGNVpYSXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQnpaV3htUm5WdVpHVmtJRDhnTUNBNklFZHNiMkpoYkM1dGFXNVVlRzVHWldVc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdRM0psWVhSbFpFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE55WXk5blpYUlVlRzVEYjNWdWRHVnlMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJSEpsZEhWeWJpQndjbTlpWlM1amNtVmhkR1ZrUVhCd0xtbGtJQ3NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNBckNpQWdJQ0J5WlhSemRXSUtDbWRsZEZSNGJrTnZkVzUwWlhKZmRHVnlibUZ5ZVY5bVlXeHpaVUExT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlJR2RsZEZSNGJrTnZkVzUwWlhKZmRHVnlibUZ5ZVY5dFpYSm5aVUEyQ2dwblpYUlVlRzVEYjNWdWRHVnlYM1JsY201aGNubGZabUZzYzJWQU1qb0tJQ0FnSUM4dklITnlZeTluWlhSVWVHNURiM1Z1ZEdWeUxtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklHWmxaVG9nYzJWc1prWjFibVJsWkNBL0lEQWdPaUJIYkc5aVlXd3ViV2x1VkhodVJtVmxMQW9nSUNBZ1oyeHZZbUZzSUUxcGJsUjRia1psWlFvZ0lDQWdjM2RoY0FvZ0lDQWdZaUJuWlhSVWVHNURiM1Z1ZEdWeVgzUmxjbTVoY25sZmJXVnlaMlZBTXdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlRzVmWTI5MWJuUmxjaTlqYjI1emRXMWxjaTVoYkdkdkxuUnpPanBVZUc1RGIzVnVkR1Z5UTI5dWMzVnRaWEl1Y21WaFpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWVdRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhodVgyTnZkVzUwWlhJdlkyOXVjM1Z0WlhJdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z1kyOXVjM1FnWTI5MWJuUmxjaUE5SUdkbGRGUjRia052ZFc1MFpYSW9SMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpLUW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0JqWVd4c2MzVmlJR2RsZEZSNGJrTnZkVzUwWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwZUc1ZlkyOTFiblJsY2k5amIyNXpkVzFsY2k1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCamIzVnVkR1Z5SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyTnZkVzUwWlhJbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmpiM1Z1ZEdWeUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSNGJsOWpiM1Z1ZEdWeUwyTnZibk4xYldWeUxtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklIUm9hWE11WTI5MWJuUmxjaTUyWVd4MVpTQTlJR052ZFc1MFpYSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUjRibDlqYjNWdWRHVnlMMk52Ym5OMWJXVnlMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSEIxWW14cFl5QnlaV0ZrS0NrNklIVnBiblEyTkNCN0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlRzVmWTI5MWJuUmxjaTlqYjI1emRXMWxjaTVoYkdkdkxuUnpPanBVZUc1RGIzVnVkR1Z5UTI5dWMzVnRaWEl1Y21WaFpGQmhhV1JDZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZV1JRWVdsa1FuazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIaHVYMk52ZFc1MFpYSXZZMjl1YzNWdFpYSXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdjSFZpYkdsaklISmxZV1JRWVdsa1Fua29abVZsVUdGNVpYSTZJRUZqWTI5MWJuUXBPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSNGJsOWpiM1Z1ZEdWeUwyTnZibk4xYldWeUxtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklHTnZibk4wSUdOdmRXNTBaWElnUFNCblpYUlVlRzVEYjNWdWRHVnlLR1psWlZCaGVXVnlLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUlVlRzVEYjNWdWRHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIaHVYMk52ZFc1MFpYSXZZMjl1YzNWdFpYSXVZV3huYnk1MGN6b3hNZ29nSUNBZ0x5OGdZMjkxYm5SbGNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RqYjNWdWRHVnlKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWTI5MWJuUmxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlRzVmWTI5MWJuUmxjaTlqYjI1emRXMWxjaTVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUIwYUdsekxtTnZkVzUwWlhJdWRtRnNkV1VnUFNCamIzVnVkR1Z5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwZUc1ZlkyOTFiblJsY2k5amIyNXpkVzFsY2k1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCd2RXSnNhV01nY21WaFpGQmhhV1JDZVNobVpXVlFZWGxsY2pvZ1FXTmpiM1Z1ZENrNklIVnBiblEyTkNCN0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5WURBd3FCQVFkamIzVnVkR1Z5QkJVZmZIVXhHMEVBSFRFWkZFUXhHRVNDQWdSSkRqZFBCS3pENGJRMkdnQ09BZ0JDQUZNQU1Sa1VNUmdVRUVPS0FRR0wveklERWtteFFRQW1nUUJNUVFBYk1ncXlBSUVGc2hrb3NrSW9za0NCQnJJUXNnR3p0RDJCQVFpSmkvOUMvK0l5QUV4Qy85Y3lBNGovd2lsTEFXY1dLa3hRc0lFQlF6WWFBVWtWZ1NBU1JJai9xaWxMQVdjV0treFFzSUVCUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
