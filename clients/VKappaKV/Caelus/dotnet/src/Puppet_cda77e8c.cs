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

namespace Arc56.Generated.VKappaKV.Caelus.Puppet_cda77e8c
{


    public class PuppetProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PuppetProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Spawn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 145, 142, 144 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Spawn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 145, 142, 144 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJQdXBwZXQiLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InNwYXduIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJEZWxldGVBcHBsaWNhdGlvbiJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjMifSx7InBjIjpbMSwyLDMsNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoiY29udHJhY3RzXFxQdXBwZXQuYWxnby50czozIn0seyJwYyI6WzUsNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQsInNvdXJjZSI6ImNvbnRyYWN0c1xcUHVwcGV0LmFsZ28udHM6MyJ9LHsicGMiOls3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNSwic291cmNlIjoiY29udHJhY3RzXFxQdXBwZXQuYWxnby50czozIn0seyJwYyI6WzgsOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6ImNvbnRyYWN0c1xcUHVwcGV0LmFsZ28udHM6MyJ9LHsicGMiOlsxMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcsInNvdXJjZSI6ImNvbnRyYWN0c1xcUHVwcGV0LmFsZ28udHM6MyJ9LHsicGMiOlsxMSwxMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6ImNvbnRyYWN0c1xcUHVwcGV0LmFsZ28udHM6MyJ9LHsicGMiOlsxM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTksInNvdXJjZSI6ImNvbnRyYWN0c1xcUHVwcGV0LmFsZ28udHM6MyJ9LHsicGMiOlsxNCwxNSwxNiwxNywxOCwxOSwyMCwyMSwyMiwyMywyNCwyNSwyNiwyNywyOCwyOSwzMCwzMSwzMiwzMywzNCwzNSwzNiwzNywzOCwzOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6ImNvbnRyYWN0c1xcUHVwcGV0LmFsZ28udHM6MyJ9LHsicGMiOls0MF0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI0LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjMifSx7InBjIjpbNDEsNDIsNDMsNDQsNDUsNDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI5LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjQifSx7InBjIjpbNDcsNDgsNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMyLCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjQifSx7InBjIjpbNTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjQifSx7InBjIjpbNTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM0LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjQifSx7InBjIjpbNTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM1LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjQifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjQifSx7InBjIjpbNTQsNTUsNTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQwLCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjQifSx7InBjIjpbNTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ4LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjYifSx7InBjIjpbNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ5LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjYifSx7InBjIjpbNTksNjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUwLCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjYifSx7InBjIjpbNjEsNjJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU0LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjcifSx7InBjIjpbNjMsNjRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU1LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjcifSx7InBjIjpbNjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU5LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjgifSx7InBjIjpbNjYsNjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYwLCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjgifSx7InBjIjpbNjgsNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY0LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjkifSx7InBjIjpbNzAsNzFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY1LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjkifSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY4LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjYifSx7InBjIjpbNzMsNzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY5LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjYifSx7InBjIjpbNzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcyLCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjYifSx7InBjIjpbNzYsNzddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc2LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjExIn0seyJwYyI6Wzc4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Nywic291cmNlIjoiY29udHJhY3RzXFxQdXBwZXQuYWxnby50czo0In0seyJwYyI6Wzc5LDgwLDgxLDgyLDgzLDg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4MCwic291cmNlIjoiY29udHJhY3RzXFxQdXBwZXQuYWxnby50czozIn0seyJwYyI6Wzg1LDg2LDg3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4MSwic291cmNlIjoiY29udHJhY3RzXFxQdXBwZXQuYWxnby50czozIn0seyJwYyI6Wzg4LDg5LDkwLDkxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Miwic291cmNlIjoiY29udHJhY3RzXFxQdXBwZXQuYWxnby50czozIn0seyJwYyI6WzkyXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBEZWxldGVBcHBsaWNhdGlvbiIsInRlYWwiOjg1LCJzb3VyY2UiOiJjb250cmFjdHNcXFB1cHBldC5hbGdvLnRzOjMifV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF3SURFS0NpOHZJRlJvYVhNZ1ZFVkJUQ0IzWVhNZ1oyVnVaWEpoZEdWa0lHSjVJRlJGUVV4VFkzSnBjSFFnZGpBdU1UQTNMaklLTHk4Z2FIUjBjSE02THk5bmFYUm9kV0l1WTI5dEwyRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOVVSVUZNVTJOeWFYQjBDZ292THlCVWFHbHpJR052Ym5SeVlXTjBJR2x6SUdOdmJYQnNhV0Z1ZENCM2FYUm9JR0Z1WkM5dmNpQnBiWEJzWlcxbGJuUnpJSFJvWlNCbWIyeHNiM2RwYm1jZ1FWSkRjem9nV3lCQlVrTTBJRjBLQ2k4dklGUm9aU0JtYjJ4c2IzZHBibWNnZEdWdUlHeHBibVZ6SUc5bUlGUkZRVXdnYUdGdVpHeGxJR2x1YVhScFlXd2djSEp2WjNKaGJTQm1iRzkzQ2k4dklGUm9hWE1nY0dGMGRHVnliaUJwY3lCMWMyVmtJSFJ2SUcxaGEyVWdhWFFnWldGemVTQm1iM0lnWVc1NWIyNWxJSFJ2SUhCaGNuTmxJSFJvWlNCemRHRnlkQ0J2WmlCMGFHVWdjSEp2WjNKaGJTQmhibVFnWkdWMFpYSnRhVzVsSUdsbUlHRWdjM0JsWTJsbWFXTWdZV04wYVc5dUlHbHpJR0ZzYkc5M1pXUUtMeThnU0dWeVpTd2dZV04wYVc5dUlISmxabVZ5Y3lCMGJ5QjBhR1VnVDI1RGIyMXdiR1YwWlNCcGJpQmpiMjFpYVc1aGRHbHZiaUIzYVhSb0lIZG9aWFJvWlhJZ2RHaGxJR0Z3Y0NCcGN5QmlaV2x1WnlCamNtVmhkR1ZrSUc5eUlHTmhiR3hsWkFvdkx5QkZkbVZ5ZVNCd2IzTnphV0pzWlNCaFkzUnBiMjRnWm05eUlIUm9hWE1nWTI5dWRISmhZM1FnYVhNZ2NtVndjbVZ6Wlc1MFpXUWdhVzRnZEdobElITjNhWFJqYUNCemRHRjBaVzFsYm5RS0x5OGdTV1lnZEdobElHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hsSUdOdmJuUnlZV04wTENCcGRITWdjbVZ6Y0dWamRHbDJaU0JpY21GdVkyZ2dkMmxzYkNCaVpTQWlLazVQVkY5SlRWQk1SVTFGVGxSRlJDSWdkMmhwWTJnZ2FuVnpkQ0JqYjI1MFlXbHVjeUFpWlhKeUlncDBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2hDbkIxYzJocGJuUWdOZ29xQ25SNGJpQlBia052YlhCc1pYUnBiMjRLS3dwemQybDBZMmdnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BqY21WaGRHVmZSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtDaXBPVDFSZlNVMVFURVZOUlU1VVJVUTZDZ2t2THlCVWFHVWdjbVZ4ZFdWemRHVmtJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdocGN5QmpiMjUwY21GamRDNGdRWEpsSUhsdmRTQjFjMmx1WnlCMGFHVWdZMjl5Y21WamRDQlBia052YlhCc1pYUmxQeUJFYVdRZ2VXOTFJSE5sZENCNWIzVnlJR0Z3Y0NCSlJEOEtDV1Z5Y2dvS0x5OGdjM0JoZDI0b0tXRmtaSEpsYzNNS0ttRmlhVjl5YjNWMFpWOXpjR0YzYmpvS0NTOHZJRlJvWlNCQlFra2djbVYwZFhKdUlIQnlaV1pwZUFvSmNIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtDZ2t2THlCbGVHVmpkWFJsSUhOd1lYZHVLQ2xoWkdSeVpYTnpDZ2xqWVd4c2MzVmlJSE53WVhkdUNnbGpiMjVqWVhRS0NXeHZad29KYVc1MFl5QXhJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdjM0JoZDI0b0tUb2dRV1JrY21WemN3cHpjR0YzYmpvS0NYQnliM1J2SURBZ01Rb0tDUzh2SUdOdmJuUnlZV04wYzF4UWRYQndaWFF1WVd4bmJ5NTBjem8yQ2drdkx5QnpaVzVrVUdGNWJXVnVkQ2g3Q2drdkx5QWdJQ0FnSUNCeVpXTmxhWFpsY2pvZ2RHaHBjeTVoY0hBdVlXUmtjbVZ6Y3l3S0NTOHZJQ0FnSUNBZ0lHRnRiM1Z1ZERvZ01Dd0tDUzh2SUNBZ0lDQWdJSEpsYTJWNVZHODZJR2RzYjJKaGJITXVZMkZzYkdWeVFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb0pMeThnSUNBZ0lIMHBDZ2xwZEhodVgySmxaMmx1Q2dscGJuUmpJREVnTHk4Z0lIQmhlUW9KYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvS0NTOHZJR052Ym5SeVlXTjBjMXhRZFhCd1pYUXVZV3huYnk1MGN6bzNDZ2t2THlCeVpXTmxhWFpsY2pvZ2RHaHBjeTVoY0hBdVlXUmtjbVZ6Y3dvSloyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LQ1dsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVUhWd2NHVjBMbUZzWjI4dWRITTZPQW9KTHk4Z1lXMXZkVzUwT2lBd0NnbHBiblJqSURBZ0x5OGdNQW9KYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLQ2drdkx5QmpiMjUwY21GamRITmNVSFZ3Y0dWMExtRnNaMjh1ZEhNNk9Rb0pMeThnY21WclpYbFViem9nWjJ4dlltRnNjeTVqWVd4c1pYSkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtDV2RzYjJKaGJDQkRZV3hzWlhKQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0NXbDBlRzVmWm1sbGJHUWdVbVZyWlhsVWJ3b0tDUzh2SUVabFpTQm1hV1ZzWkNCdWIzUWdjMlYwTENCa1pXWmhkV3gwYVc1bklIUnZJREFLQ1dsdWRHTWdNQ0F2THlBd0NnbHBkSGh1WDJacFpXeGtJRVpsWlFvS0NTOHZJRk4xWW0xcGRDQnBibTVsY2lCMGNtRnVjMkZqZEdsdmJnb0phWFI0Ymw5emRXSnRhWFFLQ2drdkx5QmpiMjUwY21GamRITmNVSFZ3Y0dWMExtRnNaMjh1ZEhNNk1URUtDUzh2SUhKbGRIVnliaUIwYUdsekxtRndjQzVoWkdSeVpYTnpPd29KWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtDWEpsZEhOMVlnb0tLbU55WldGMFpWOUVaV3hsZEdWQmNIQnNhV05oZEdsdmJqb0tDWEIxYzJoaWVYUmxjeUF3ZURGak9URTRaVGt3SUM4dklHMWxkR2h2WkNBaWMzQmhkMjRvS1dGa1pISmxjM01pQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDZ2x0WVhSamFDQXFZV0pwWDNKdmRYUmxYM053WVhkdUNnb0pMeThnZEdocGN5QmpiMjUwY21GamRDQmtiMlZ6SUc1dmRDQnBiWEJzWlcxbGJuUWdkR2hsSUdkcGRtVnVJRUZDU1NCdFpYUm9iMlFnWm05eUlHTnlaV0YwWlNCRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmdvSlpYSnkiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUV4R0JTQkJnc3hHUWlOREFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFKd0NBQkJVZmZIV0lBQVJRc0NORGlnQUJzU095RURJS3NnY2lzZ2d5RHJJZ0lySUJzeklLaVlBRUhKR09rRFlhQUk0Qi84MEEiLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjozLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6IjNlNWQ2OTRiIn19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
