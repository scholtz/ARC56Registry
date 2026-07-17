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

namespace Arc56.Generated.algorandfoundation.puya.UIntOverflow_392859be
{


    public class UIntOverflowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public UIntOverflowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestUint8(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 113, 238, 125 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestUint8_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 113, 238, 125 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestUint16(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 25, 88, 249 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestUint16_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 25, 88, 249 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestUint32(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 237, 132, 151 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestUint32_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 237, 132, 151 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestAsUint64(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 17, 120, 151 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestAsUint64_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 17, 120, 151 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVUludE92ZXJmbG93IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfdWludDgiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF91aW50MTYiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF91aW50MzIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9hc191aW50NjQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls3Myw5NiwxMjMsMTU2LDE2NV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODEsMTA1LDEzNCwxNzFdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIHNob3VsZCBub3QgaGFwcGVuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElERTJJRGdLSUNBZ0lDOHZJR0Z5WXpSZmRIbHdaWE12ZFdsdWRGOXZkbVZ5Wm14dmR5NXdlVG8wQ2lBZ0lDQXZMeUJqYkdGemN5QlZTVzUwVDNabGNtWnNiM2NvWVhKak5DNUJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1URUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHVmhOekZsWlRka0lEQjRaVE14T1RVNFpqa2dNSGhqTjJWa09EUTVOeUF3ZURZMU1URTNPRGszSUM4dklHMWxkR2h2WkNBaWRHVnpkRjkxYVc1ME9DZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRjkxYVc1ME1UWW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0luUmxjM1JmZFdsdWRETXlLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wWDJGelgzVnBiblEyTkNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhSbGMzUmZkV2x1ZERnZ2RHVnpkRjkxYVc1ME1UWWdkR1Z6ZEY5MWFXNTBNeklnZEdWemRGOWhjMTkxYVc1ME5qUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TVRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1aGNtTTBYM1I1Y0dWekxuVnBiblJmYjNabGNtWnNiM2N1VlVsdWRFOTJaWEptYkc5M0xuUmxjM1JmZFdsdWREaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFgzVnBiblE0T2dvZ0lDQWdMeThnWVhKak5GOTBlWEJsY3k5MWFXNTBYMjkyWlhKbWJHOTNMbkI1T2pjS0lDQWdJQzh2SUhSdmIxOWlhV2NnUFNCaGNtTTBMbFZKYm5RNEtGUjRiaTV1ZFcxZllYQndYMkZ5WjNNZ0t5QXlLaW80S1NBZ0l5QnphRzkxYkdRZ1ptRnBiQ0JvWlhKbElIZHBkR2dnYjNabGNtWnNiM2NLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElESTFOZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpYVhSc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCbGVIUnlZV04wSURjZ01Rb2dJQ0FnTHk4Z1lYSmpORjkwZVhCbGN5OTFhVzUwWDI5MlpYSm1iRzkzTG5CNU9qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCMGIyOWZZbWxuTG1KNWRHVnpJQ0U5SUdJaVhIZ3dNU0lzSUNKMGFHbHpJSE5vYjNWc1pDQnViM1FnYUdGd2NHVnVJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREVLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z2RHaHBjeUJ6YUc5MWJHUWdibTkwSUdoaGNIQmxiZ29nSUNBZ0x5OGdZWEpqTkY5MGVYQmxjeTkxYVc1MFgyOTJaWEptYkc5M0xuQjVPalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NWhjbU0wWDNSNWNHVnpMblZwYm5SZmIzWmxjbVpzYjNjdVZVbHVkRTkyWlhKbWJHOTNMblJsYzNSZmRXbHVkREUyVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRjkxYVc1ME1UWTZDaUFnSUNBdkx5QmhjbU0wWDNSNWNHVnpMM1ZwYm5SZmIzWmxjbVpzYjNjdWNIazZNVElLSUNBZ0lDOHZJSFJ2YjE5aWFXY2dQU0JoY21NMExsVkpiblF4TmloVWVHNHViblZ0WDJGd2NGOWhjbWR6SUNzZ01pb3FNVFlwSUNBaklITm9iM1ZzWkNCbVlXbHNJR2hsY21VZ2QybDBhQ0J2ZG1WeVpteHZkd29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05qVTFNellLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW1sMGJHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z01UWUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNBdkx5QmhjbU0wWDNSNWNHVnpMM1ZwYm5SZmIzWmxjbVpzYjNjdWNIazZNVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQjBiMjlmWW1sbkxtSjVkR1Z6SUNFOUlHSWlYSGd3TUZ4NE1ERWlMQ0FpZEdocGN5QnphRzkxYkdRZ2JtOTBJR2hoY0hCbGJpSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREVLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z2RHaHBjeUJ6YUc5MWJHUWdibTkwSUdoaGNIQmxiZ29nSUNBZ0x5OGdZWEpqTkY5MGVYQmxjeTkxYVc1MFgyOTJaWEptYkc5M0xuQjVPakV3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVZWEpqTkY5MGVYQmxjeTUxYVc1MFgyOTJaWEptYkc5M0xsVkpiblJQZG1WeVpteHZkeTUwWlhOMFgzVnBiblF6TWx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JmZFdsdWRETXlPZ29nSUNBZ0x5OGdZWEpqTkY5MGVYQmxjeTkxYVc1MFgyOTJaWEptYkc5M0xuQjVPakUzQ2lBZ0lDQXZMeUIwYjI5ZlltbG5JRDBnWVhKak5DNVZTVzUwTXpJb1ZIaHVMbTUxYlY5aGNIQmZZWEpuY3lBcklESXFLak15S1NBZ0l5QnphRzkxYkdRZ1ptRnBiQ0JvWlhKbElIZHBkR2dnYjNabGNtWnNiM2NLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEUXlPVFE1TmpjeU9UWUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbWwwYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JsZUhSeVlXTjBJRFFnTkFvZ0lDQWdMeThnWVhKak5GOTBlWEJsY3k5MWFXNTBYMjkyWlhKbWJHOTNMbkI1T2pFNENpQWdJQ0F2THlCaGMzTmxjblFnZEc5dlgySnBaeTVpZVhSbGN5QWhQU0JpSWx4NE1EQmNlREF3WEhnd01GeDRNREVpTENBaWRHaHBjeUJ6YUc5MWJHUWdibTkwSUdoaGNIQmxiaUlLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXhDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSb2FYTWdjMmh2ZFd4a0lHNXZkQ0JvWVhCd1pXNEtJQ0FnSUM4dklHRnlZelJmZEhsd1pYTXZkV2x1ZEY5dmRtVnlabXh2ZHk1d2VUb3hOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtRnlZelJmZEhsd1pYTXVkV2x1ZEY5dmRtVnlabXh2ZHk1VlNXNTBUM1psY21ac2IzY3VkR1Z6ZEY5aGMxOTFhVzUwTmpSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wWDJGelgzVnBiblEyTkRvS0lDQWdJQzh2SUdGeVl6UmZkSGx3WlhNdmRXbHVkRjl2ZG1WeVpteHZkeTV3ZVRveU1nb2dJQ0FnTHk4Z1ltbG5kV2x1ZENBOUlFSnBaMVZKYm5Rb01pb3FOalFwSUNzZ1ZIaHVMbTUxYlY5aGNIQmZZWEpuY3dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lDOHZJR0Z5WXpSZmRIbHdaWE12ZFdsdWRGOXZkbVZ5Wm14dmR5NXdlVG95TXdvZ0lDQWdMeThnZEc5dlgySnBaeUE5SUdGeVl6UXVWVWx1ZERFeU9DaGlhV2QxYVc1MEtTNWhjMTkxYVc1ME5qUW9LU0FnSXlCemFHOTFiR1FnWm1GcGJDQm9aWEpsSUhkcGRHZ2diM1psY21ac2IzY0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTVRZS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBeE5nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JrZFhBS0lDQWdJR0pwZEd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdZWEpqTkY5MGVYQmxjeTkxYVc1MFgyOTJaWEptYkc5M0xuQjVPakkwQ2lBZ0lDQXZMeUJoYzNObGNuUWdkRzl2WDJKcFp5QWhQU0F3TENBaWRHaHBjeUJ6YUc5MWJHUWdibTkwSUdoaGNIQmxiaUlLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBhR2x6SUhOb2IzVnNaQ0J1YjNRZ2FHRndjR1Z1Q2lBZ0lDQXZMeUJoY21NMFgzUjVjR1Z6TDNWcGJuUmZiM1psY21ac2IzY3VjSGs2TWpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBUkFJTVJ0QkFDc3hHUlJFTVJoRWdnUUU2bkh1ZlFUakdWajVCTWZ0aEpjRVpSRjRsellhQUk0RUFBa0FId0EzQUZRQU1Sa1VNUmdVRUVNeEc0R0FBZ2dXU1pNa0RrUlhCd0dBQVFFVFJDSkRNUnVCZ0lBRUNCWkpreU1PUkZjR0FvQUNBQUVUUkNKRE1SdUJnSUNBZ0JBSUZrbVRnU0FPUkZjRUJJQUVBQUFBQVJORUlrTXhHeGFBQ1FFQUFBQUFBQUFBQUtCSkZTTU9SQ092cTBtVGdVQU9SRWtWSkFsYlJDSkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
