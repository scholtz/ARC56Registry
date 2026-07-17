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

namespace Arc56.Generated.algorandfoundation.puya.StateProxyContract_a4a1f56b
{


    public class StateProxyContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StateProxyContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Clear(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 151, 114, 70 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Clear_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 151, 114, 70 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OrderOfEvalGlobal(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 136, 104, 185 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OrderOfEvalGlobal_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 136, 104, 185 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OrderOfEvalLocal(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 226, 137, 176 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OrderOfEvalLocal_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 226, 137, 176 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OrderOfEvalBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 68, 87, 2 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OrderOfEvalBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 68, 87, 2 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RhdGVQcm94eUNvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiT3B0SW4iXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xlYXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3JkZXJfb2ZfZXZhbF9nbG9iYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3JkZXJfb2ZfZXZhbF9sb2NhbCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcmRlcl9vZl9ldmFsX2JveCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjoyLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURReUlEQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltY3hJaUFpYkRFaUlEQjRObU16TWlBaVltOTRYMjFoY0NJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE4wWVhSbFgzQnliM2hwWlhNdlkyOXVkSEpoWTNRdWNIazZNaklLSUNBZ0lDOHZJSE5sYkdZdVoyeHZZbUZzTWlBOUlFZHNiMkpoYkZOMFlYUmxXMVZKYm5RMk5GMG9WVWx1ZERZMEtEQXBMQ0JyWlhrOVlpSm5NaUlzSUdSbGMyTnlhWEIwYVc5dVBTSm5NaUJrWlhOamNtbHdkR2x2YmlJcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMk56TXlDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITjBZWFJsWDNCeWIzaHBaWE12WTI5dWRISmhZM1F1Y0hrNk1qWUtJQ0FnSUM4dklHVnNjMlVnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwTENCclpYazlJblJ2ZDI0aUtRb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBaWRHOTNiaUlnSW1aMWJtdDVJZ29nSUNBZ0x5OGdjM1JoZEdWZmNISnZlR2xsY3k5amIyNTBjbUZqZEM1d2VUb3lOUW9nSUNBZ0x5OGdhV1lnVkhodUxtNTFiVjloY0hCZllYSm5jd29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lDOHZJSE4wWVhSbFgzQnliM2hwWlhNdlkyOXVkSEpoWTNRdWNIazZNalF0TWpZS0lDQWdJQzh2SUVkc2IySmhiRk4wWVhSbEtGVkpiblEyTkN3Z2EyVjVQU0ptZFc1cmVTSXBDaUFnSUNBdkx5QnBaaUJVZUc0dWJuVnRYMkZ3Y0Y5aGNtZHpDaUFnSUNBdkx5QmxiSE5sSUVkc2IySmhiRk4wWVhSbEtGVkpiblEyTkN3Z2EyVjVQU0owYjNkdUlpa0tJQ0FnSUhObGJHVmpkQW9nSUNBZ0x5OGdjM1JoZEdWZmNISnZlR2xsY3k5amIyNTBjbUZqZEM1d2VUb3lPQW9nSUNBZ0x5OGdablZ1YTNsZmRHOTNiaTUyWVd4MVpTQTlJRlZKYm5RMk5DZ3hNak1wQ2lBZ0lDQndkWE5vYVc1MElERXlNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MzUmhkR1ZmY0hKdmVHbGxjeTlqYjI1MGNtRmpkQzV3ZVRveE53b2dJQ0FnTHk4Z1kyeGhjM01nVTNSaGRHVlFjbTk0ZVVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDd2djM1JoZEdWZmRHOTBZV3h6UFZOMFlYUmxWRzkwWVd4ektHZHNiMkpoYkY5MWFXNTBjejB6S1NrNkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMFl6VmpOakZpWVNBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFgzSnZkWFJsUURRS0NtMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUExT2dvZ0lDQWdMeThnYzNSaGRHVmZjSEp2ZUdsbGN5OWpiMjUwY21GamRDNXdlVG94TndvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoZEdWUWNtOTRlVU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZEN3Z2MzUmhkR1ZmZEc5MFlXeHpQVk4wWVhSbFZHOTBZV3h6S0dkc2IySmhiRjkxYVc1MGN6MHpLU2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGcwTkRrM056STBOaUF3ZUdKa09EZzJPR0k1SURCNFpEQmxNamc1WWpBZ01IZzNORFEwTlRjd01pQXZMeUJ0WlhSb2IyUWdJbU5zWldGeUtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdmNtUmxjbDl2Wmw5bGRtRnNYMmRzYjJKaGJDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWIzSmtaWEpmYjJaZlpYWmhiRjlzYjJOaGJDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWIzSmtaWEpmYjJaZlpYWmhiRjlpYjNnb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamJHVmhjaUJ2Y21SbGNsOXZabDlsZG1Gc1gyZHNiMkpoYkNCdmNtUmxjbDl2Wmw5bGRtRnNYMnh2WTJGc0lHOXlaR1Z5WDI5bVgyVjJZV3hmWW05NENpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYM0p2ZFhSbFFEUTZDaUFnSUNBdkx5QnpkR0YwWlY5d2NtOTRhV1Z6TDJOdmJuUnlZV04wTG5CNU9qTXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs5d2RFbHVJbDBzSUdOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnVDNCMFNXNEtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCamNtVmhkR1VLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbk4wWVhSbFgzQnliM2hwWlhNdVkyOXVkSEpoWTNRdVoyVjBYMnRsZVNncElDMCtJR0o1ZEdWek9ncG5aWFJmYTJWNU9nb2dJQ0FnTHk4Z2MzUmhkR1ZmY0hKdmVHbGxjeTlqYjI1MGNtRmpkQzV3ZVRvMk1nb2dJQ0FnTHk4Z2JHOW5LQ0pyWlhraUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKclpYa2lDaUFnSUNCc2IyY0tJQ0FnSUM4dklITjBZWFJsWDNCeWIzaHBaWE12WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklISmxkSFZ5YmlCQ2VYUmxjeWhpSW1KdmVDSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJNalptTnpnS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWMzUmhkR1ZmY0hKdmVHbGxjeTVqYjI1MGNtRmpkQzVuWlhSZllXTmpiM1Z1ZENncElDMCtJR0o1ZEdWek9ncG5aWFJmWVdOamIzVnVkRG9LSUNBZ0lDOHZJSE4wWVhSbFgzQnliM2hwWlhNdlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJR3h2WnlnaVlXTmpiM1Z1ZENJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW1GalkyOTFiblFpQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE4wWVhSbFgzQnliM2hwWlhNdlkyOXVkSEpoWTNRdWNIazZOamtLSUNBZ0lDOHZJSEpsZEhWeWJpQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBYMk5oYzJWekxuTjBZWFJsWDNCeWIzaHBaWE11WTI5dWRISmhZM1F1WkdWbVlYVnNkRjkyWVd4MVpTZ3BJQzArSUhWcGJuUTJORG9LWkdWbVlYVnNkRjkyWVd4MVpUb0tJQ0FnSUM4dklITjBZWFJsWDNCeWIzaHBaWE12WTI5dWRISmhZM1F1Y0hrNk56UUtJQ0FnSUM4dklHeHZaeWdpWkdWbVlYVnNkQ0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbVJsWm1GMWJIUWlDaUFnSUNCc2IyY0tJQ0FnSUM4dklITjBZWFJsWDNCeWIzaHBaWE12WTI5dWRISmhZM1F1Y0hrNk56VUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTkRJcENpQWdJQ0JwYm5Salh6RWdMeThnTkRJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWMzUmhkR1ZmY0hKdmVHbGxjeTVqYjI1MGNtRmpkQzVUZEdGMFpWQnliM2g1UTI5dWRISmhZM1F1WTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdjM1JoZEdWZmNISnZlR2xsY3k5amIyNTBjbUZqZEM1d2VUb3pNd29nSUNBZ0x5OGdjMlZzWmk1bmJHOWlZV3d4TG5aaGJIVmxJRDBnVlVsdWREWTBLREVwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0puTVNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzNSaGRHVmZjSEp2ZUdsbGN5OWpiMjUwY21GamRDNXdlVG96TkFvZ0lDQWdMeThnYzJWc1ppNXNiMk5oYkRGYlZIaHVMbk5sYm1SbGNsMGdQU0JWU1c1ME5qUW9NaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltd3hJZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemRHRjBaVjl3Y205NGFXVnpMMk52Ym5SeVlXTjBMbkI1T2pNMUNpQWdJQ0F2THlCelpXeG1MbXh2WTJGc01sdFVlRzR1YzJWdVpHVnlYU0E5SUZWSmJuUTJOQ2d6S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFpqTXpJS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjM1JoZEdWZmNISnZlR2xsY3k5amIyNTBjbUZqZEM1d2VUb3pNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKUGNIUkpiaUpkTENCamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YzNSaGRHVmZjSEp2ZUdsbGN5NWpiMjUwY21GamRDNVRkR0YwWlZCeWIzaDVRMjl1ZEhKaFkzUXVZMnhsWVhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiR1ZoY2pvS0lDQWdJQzh2SUhOMFlYUmxYM0J5YjNocFpYTXZZMjl1ZEhKaFkzUXVjSGs2TXprS0lDQWdJQzh2SUdSbGJDQnpaV3htTG1kc2IySmhiREV1ZG1Gc2RXVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltY3hJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOWtaV3dLSUNBZ0lDOHZJSE4wWVhSbFgzQnliM2hwWlhNdlkyOXVkSEpoWTNRdWNIazZOREFLSUNBZ0lDOHZJR1JsYkNCelpXeG1MbXh2WTJGc01WdFVlRzR1YzJWdVpHVnlYUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJERWlDaUFnSUNCaGNIQmZiRzlqWVd4ZlpHVnNDaUFnSUNBdkx5QnpkR0YwWlY5d2NtOTRhV1Z6TDJOdmJuUnlZV04wTG5CNU9qUXhDaUFnSUNBdkx5QmtaV3dnYzJWc1ppNXNiMk5oYkRKYlZIaHVMbk5sYm1SbGNsMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnMll6TXlDaUFnSUNCaGNIQmZiRzlqWVd4ZlpHVnNDaUFnSUNBdkx5QnpkR0YwWlY5d2NtOTRhV1Z6TDJOdmJuUnlZV04wTG5CNU9qUXlDaUFnSUNBdkx5QmtaV3dnYzJWc1ppNWliM2hmYldGd1cyZGxkRjlyWlhrb0tWMEtJQ0FnSUdOaGJHeHpkV0lnWjJWMFgydGxlUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZbTk0WDIxaGNDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6ZEdGMFpWOXdjbTk0YVdWekwyTnZiblJ5WVdOMExuQjVPak0zQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVjM1JoZEdWZmNISnZlR2xsY3k1amIyNTBjbUZqZEM1VGRHRjBaVkJ5YjNoNVEyOXVkSEpoWTNRdWIzSmtaWEpmYjJaZlpYWmhiRjluYkc5aVlXeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2Y21SbGNsOXZabDlsZG1Gc1gyZHNiMkpoYkRvS0lDQWdJQzh2SUhOMFlYUmxYM0J5YjNocFpYTXZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUhaaGJDQTlJSE5sYkdZdVoyeHZZbUZzTVM1blpYUW9aR1ZtWVhWc2REMWtaV1poZFd4MFgzWmhiSFZsS0NrcENpQWdJQ0JqWVd4c2MzVmlJR1JsWm1GMWJIUmZkbUZzZFdVS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0puTVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCelpXeGxZM1FLSUNBZ0lDOHZJSE4wWVhSbFgzQnliM2hwWlhNdlkyOXVkSEpoWTNRdWNIazZORGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQjJZV3dnUFQwZ05ESUtJQ0FnSUdsdWRHTmZNU0F2THlBME1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MzUmhkR1ZmY0hKdmVHbGxjeTlqYjI1MGNtRmpkQzV3ZVRvME5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG5OMFlYUmxYM0J5YjNocFpYTXVZMjl1ZEhKaFkzUXVVM1JoZEdWUWNtOTRlVU52Ym5SeVlXTjBMbTl5WkdWeVgyOW1YMlYyWVd4ZmJHOWpZV3hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdmNtUmxjbDl2Wmw5bGRtRnNYMnh2WTJGc09nb2dJQ0FnTHk4Z2MzUmhkR1ZmY0hKdmVHbGxjeTlqYjI1MGNtRmpkQzV3ZVRvMU1Rb2dJQ0FnTHk4Z2RtRnNJRDBnYzJWc1ppNXNiMk5oYkRFdVoyVjBLR2RsZEY5aFkyTnZkVzUwS0Nrc0lHUmxabUYxYkhROVpHVm1ZWFZzZEY5MllXeDFaU2dwS1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmWVdOamIzVnVkQW9nSUNBZ1kyRnNiSE4xWWlCa1pXWmhkV3gwWDNaaGJIVmxDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJERWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQzh2SUhOMFlYUmxYM0J5YjNocFpYTXZZMjl1ZEhKaFkzUXVjSGs2TlRJS0lDQWdJQzh2SUdGemMyVnlkQ0IyWVd3Z1BUMGdORElLSUNBZ0lHbHVkR05mTVNBdkx5QTBNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjM1JoZEdWZmNISnZlR2xsY3k5amIyNTBjbUZqZEM1d2VUbzBPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxuTjBZWFJsWDNCeWIzaHBaWE11WTI5dWRISmhZM1F1VTNSaGRHVlFjbTk0ZVVOdmJuUnlZV04wTG05eVpHVnlYMjltWDJWMllXeGZZbTk0VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2IzSmtaWEpmYjJaZlpYWmhiRjlpYjNnNkNpQWdJQ0F2THlCemRHRjBaVjl3Y205NGFXVnpMMk52Ym5SeVlXTjBMbkI1T2pVMkNpQWdJQ0F2THlCMllXd2dQU0J6Wld4bUxtSnZlRjl0WVhBdVoyVjBLR2RsZEY5clpYa29LU3dnWkdWbVlYVnNkRDFrWldaaGRXeDBYM1poYkhWbEtDa3BDaUFnSUNCallXeHNjM1ZpSUdkbGRGOXJaWGtLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUp2ZUY5dFlYQWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTmhiR3h6ZFdJZ1pHVm1ZWFZzZEY5MllXeDFaUW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdjM2RoY0FvZ0lDQWdjMlZzWldOMENpQWdJQ0F2THlCemRHRjBaVjl3Y205NGFXVnpMMk52Ym5SeVlXTjBMbkI1T2pVM0NpQWdJQ0F2THlCaGMzTmxjblFnZG1Gc0lEMDlJRFF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdORElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE4wWVhSbFgzQnliM2hwWlhNdlkyOXVkSEpoWTNRdWNIazZOVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFTb0FKZ1FDWnpFQ2JERUNiRElIWW05NFgyMWhjREVZUUFBWmdBSm5NaVJuZ2dJRWRHOTNiZ1ZtZFc1cmVURWJUWUY3WjRBRVRGeGh1allhQUk0QkFDc3hHUlJFTVJoRWdnUUVSSmR5UmdTOWlHaTVCTkRpaWJBRWRFUlhBallhQUk0RUFFTUFWd0JqQUhNQU1Sa2lFakVZRkJCRVFnQWxnQU5yWlhtd2dBTmliM2lKZ0FkaFkyTnZkVzUwc0RFQWlZQUhaR1ZtWVhWc2RMQWppU2dpWnpFQUtZRUNaakVBS29FRFppSkRLR2t4QUNsb01RQXFhSWovdlN0TVVMeElJa09JLzh3a0tHVk5JeEpFSWtPSS83T0kvNzFNSkNsalRTTVNSQ0pEaVArWEsweFFpUCtxVEw1TUYweE5JeEpFSWtNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
