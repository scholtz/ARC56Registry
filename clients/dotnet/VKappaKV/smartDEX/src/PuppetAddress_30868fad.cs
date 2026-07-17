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

namespace Arc56.Generated.VKappaKV.smartDEX.PuppetAddress_30868fad
{


    public class PuppetAddressProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PuppetAddressProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Create a new account, rekeying it to the caller application address
        ///</summary>
        public async Task<Algorand.Address> New(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 29, 47, 234 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> New_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 29, 47, 234 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJQdXBwZXRBZGRyZXNzIiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJuZXciLCJkZXNjIjoiQ3JlYXRlIGEgbmV3IGFjY291bnQsIHJla2V5aW5nIGl0IHRvIHRoZSBjYWxsZXIgYXBwbGljYXRpb24gYWRkcmVzcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjoiTmV3IGFjY291bnQgYWRkcmVzcyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJEZWxldGVBcHBsaWNhdGlvbiJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJjb250cmFjdHNcXHB1cHBldEFkZHJlc3MuYWxnby50czozIn0seyJwYyI6WzEsMiwzLDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIsInNvdXJjZSI6ImNvbnRyYWN0c1xccHVwcGV0QWRkcmVzcy5hbGdvLnRzOjMifSx7InBjIjpbNSw2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNCwic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6MyJ9LHsicGMiOls3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNSwic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6MyJ9LHsicGMiOls4LDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2LCJzb3VyY2UiOiJjb250cmFjdHNcXHB1cHBldEFkZHJlc3MuYWxnby50czozIn0seyJwYyI6WzEwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNywic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6MyJ9LHsicGMiOlsxMSwxMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6ImNvbnRyYWN0c1xccHVwcGV0QWRkcmVzcy5hbGdvLnRzOjMifSx7InBjIjpbMTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5LCJzb3VyY2UiOiJjb250cmFjdHNcXHB1cHBldEFkZHJlc3MuYWxnby50czozIn0seyJwYyI6WzE0LDE1LDE2LDE3LDE4LDE5LDIwLDIxLDIyLDIzLDI0LDI1LDI2LDI3LDI4LDI5LDMwLDMxLDMyLDMzLDM0LDM1LDM2LDM3LDM4LDM5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMCwic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6MyJ9LHsicGMiOls0MF0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI0LCJzb3VyY2UiOiJjb250cmFjdHNcXHB1cHBldEFkZHJlc3MuYWxnby50czozIn0seyJwYyI6WzQxLDQyLDQzLDQ0LDQ1LDQ2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyOSwic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6OCJ9LHsicGMiOls0Nyw0OCw0OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzIsInNvdXJjZSI6ImNvbnRyYWN0c1xccHVwcGV0QWRkcmVzcy5hbGdvLnRzOjgifSx7InBjIjpbNTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJjb250cmFjdHNcXHB1cHBldEFkZHJlc3MuYWxnby50czo4In0seyJwYyI6WzUxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNCwic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6OCJ9LHsicGMiOls1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzUsInNvdXJjZSI6ImNvbnRyYWN0c1xccHVwcGV0QWRkcmVzcy5hbGdvLnRzOjgifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJjb250cmFjdHNcXHB1cHBldEFkZHJlc3MuYWxnby50czo4In0seyJwYyI6WzU0LDU1LDU2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Mywic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6OCJ9LHsicGMiOls1N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTEsInNvdXJjZSI6ImNvbnRyYWN0c1xccHVwcGV0QWRkcmVzcy5hbGdvLnRzOjEwIn0seyJwYyI6WzU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Miwic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6MTAifSx7InBjIjpbNTksNjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUzLCJzb3VyY2UiOiJjb250cmFjdHNcXHB1cHBldEFkZHJlc3MuYWxnby50czoxMCJ9LHsicGMiOls2MSw2Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTcsInNvdXJjZSI6ImNvbnRyYWN0c1xccHVwcGV0QWRkcmVzcy5hbGdvLnRzOjExIn0seyJwYyI6WzYzLDY0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OCwic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6MTEifSx7InBjIjpbNjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYyLCJzb3VyY2UiOiJjb250cmFjdHNcXHB1cHBldEFkZHJlc3MuYWxnby50czoxMiJ9LHsicGMiOls2Niw2N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjMsInNvdXJjZSI6ImNvbnRyYWN0c1xccHVwcGV0QWRkcmVzcy5hbGdvLnRzOjEyIn0seyJwYyI6WzY4LDY5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Nywic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6MTMifSx7InBjIjpbNzAsNzFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY4LCJzb3VyY2UiOiJjb250cmFjdHNcXHB1cHBldEFkZHJlc3MuYWxnby50czoxMyJ9LHsicGMiOls3Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzEsInNvdXJjZSI6ImNvbnRyYWN0c1xccHVwcGV0QWRkcmVzcy5hbGdvLnRzOjEwIn0seyJwYyI6WzczLDc0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Miwic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6MTAifSx7InBjIjpbNzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc1LCJzb3VyY2UiOiJjb250cmFjdHNcXHB1cHBldEFkZHJlc3MuYWxnby50czoxMCJ9LHsicGMiOls3Niw3N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzksInNvdXJjZSI6ImNvbnRyYWN0c1xccHVwcGV0QWRkcmVzcy5hbGdvLnRzOjE2In0seyJwYyI6Wzc4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4MCwic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6OCJ9LHsicGMiOls3OSw4MCw4MSw4Miw4Myw4NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODMsInNvdXJjZSI6ImNvbnRyYWN0c1xccHVwcGV0QWRkcmVzcy5hbGdvLnRzOjMifSx7InBjIjpbODUsODYsODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg0LCJzb3VyY2UiOiJjb250cmFjdHNcXHB1cHBldEFkZHJlc3MuYWxnby50czozIn0seyJwYyI6Wzg4LDg5LDkwLDkxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NSwic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6MyJ9LHsicGMiOls5Ml0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgRGVsZXRlQXBwbGljYXRpb24iLCJ0ZWFsIjo4OCwic291cmNlIjoiY29udHJhY3RzXFxwdXBwZXRBZGRyZXNzLmFsZ28udHM6MyJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXdJREVLQ2k4dklGUm9hWE1nVkVWQlRDQjNZWE1nWjJWdVpYSmhkR1ZrSUdKNUlGUkZRVXhUWTNKcGNIUWdkakF1TVRBMkxqRUtMeThnYUhSMGNITTZMeTluYVhSb2RXSXVZMjl0TDJGc1oyOXlZVzVrWm05MWJtUmhkR2x2Ymk5VVJVRk1VMk55YVhCMENnb3ZMeUJVYUdseklHTnZiblJ5WVdOMElHbHpJR052YlhCc2FXRnVkQ0IzYVhSb0lHRnVaQzl2Y2lCcGJYQnNaVzFsYm5SeklIUm9aU0JtYjJ4c2IzZHBibWNnUVZKRGN6b2dXeUJCVWtNMElGMEtDaTh2SUZSb1pTQm1iMnhzYjNkcGJtY2dkR1Z1SUd4cGJtVnpJRzltSUZSRlFVd2dhR0Z1Wkd4bElHbHVhWFJwWVd3Z2NISnZaM0poYlNCbWJHOTNDaTh2SUZSb2FYTWdjR0YwZEdWeWJpQnBjeUIxYzJWa0lIUnZJRzFoYTJVZ2FYUWdaV0Z6ZVNCbWIzSWdZVzU1YjI1bElIUnZJSEJoY25ObElIUm9aU0J6ZEdGeWRDQnZaaUIwYUdVZ2NISnZaM0poYlNCaGJtUWdaR1YwWlhKdGFXNWxJR2xtSUdFZ2MzQmxZMmxtYVdNZ1lXTjBhVzl1SUdseklHRnNiRzkzWldRS0x5OGdTR1Z5WlN3Z1lXTjBhVzl1SUhKbFptVnljeUIwYnlCMGFHVWdUMjVEYjIxd2JHVjBaU0JwYmlCamIyMWlhVzVoZEdsdmJpQjNhWFJvSUhkb1pYUm9aWElnZEdobElHRndjQ0JwY3lCaVpXbHVaeUJqY21WaGRHVmtJRzl5SUdOaGJHeGxaQW92THlCRmRtVnllU0J3YjNOemFXSnNaU0JoWTNScGIyNGdabTl5SUhSb2FYTWdZMjl1ZEhKaFkzUWdhWE1nY21Wd2NtVnpaVzUwWldRZ2FXNGdkR2hsSUhOM2FYUmphQ0J6ZEdGMFpXMWxiblFLTHk4Z1NXWWdkR2hsSUdGamRHbHZiaUJwY3lCdWIzUWdhVzF3YkdWdFpXNTBaV1FnYVc0Z2RHaGxJR052Ym5SeVlXTjBMQ0JwZEhNZ2NtVnpjR1ZqZEdsMlpTQmljbUZ1WTJnZ2QybHNiQ0JpWlNBaUtrNVBWRjlKVFZCTVJVMUZUbFJGUkNJZ2QyaHBZMmdnYW5WemRDQmpiMjUwWVdsdWN5QWlaWEp5SWdwMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvaENuQjFjMmhwYm5RZ05nb3FDblI0YmlCUGJrTnZiWEJzWlhScGIyNEtLd3B6ZDJsMFkyZ2dLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcGpjbVZoZEdWZlJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0S0NpcE9UMVJmU1UxUVRFVk5SVTVVUlVRNkNna3ZMeUJVYUdVZ2NtVnhkV1Z6ZEdWa0lHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hwY3lCamIyNTBjbUZqZEM0Z1FYSmxJSGx2ZFNCMWMybHVaeUIwYUdVZ1kyOXljbVZqZENCUGJrTnZiWEJzWlhSbFB5QkVhV1FnZVc5MUlITmxkQ0I1YjNWeUlHRndjQ0JKUkQ4S0NXVnljZ29LTHk4Z2JtVjNLQ2xoWkdSeVpYTnpDaXBoWW1sZmNtOTFkR1ZmYm1WM09nb0pMeThnVkdobElFRkNTU0J5WlhSMWNtNGdjSEpsWm1sNENnbHdkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9LQ1M4dklHVjRaV04xZEdVZ2JtVjNLQ2xoWkdSeVpYTnpDZ2xqWVd4c2MzVmlJRzVsZHdvSlkyOXVZMkYwQ2dsc2IyY0tDV2x1ZEdNZ01TQXZMeUF4Q2dseVpYUjFjbTRLQ2k4dklHNWxkeWdwT2lCQlpHUnlaWE56Q2k4dkNpOHZJRU55WldGMFpTQmhJRzVsZHlCaFkyTnZkVzUwTENCeVpXdGxlV2x1WnlCcGRDQjBieUIwYUdVZ1kyRnNiR1Z5SUdGd2NHeHBZMkYwYVc5dUlHRmtaSEpsYzNNS0x5OGdRSEpsZEhWeWJuTWdUbVYzSUdGalkyOTFiblFnWVdSa2NtVnpjd3B1WlhjNkNnbHdjbTkwYnlBd0lERUtDZ2t2THlCamIyNTBjbUZqZEhOY2NIVndjR1YwUVdSa2NtVnpjeTVoYkdkdkxuUnpPakV3Q2drdkx5QnpaVzVrVUdGNWJXVnVkQ2g3Q2drdkx5QWdJQ0FnSUNCeVpXTmxhWFpsY2pvZ2RHaHBjeTVoY0hBdVlXUmtjbVZ6Y3l3S0NTOHZJQ0FnSUNBZ0lHRnRiM1Z1ZERvZ01Dd0tDUzh2SUNBZ0lDQWdJSEpsYTJWNVZHODZJR2RzYjJKaGJITXVZMkZzYkdWeVFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb0pMeThnSUNBZ0lIMHBDZ2xwZEhodVgySmxaMmx1Q2dscGJuUmpJREVnTHk4Z0lIQmhlUW9KYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvS0NTOHZJR052Ym5SeVlXTjBjMXh3ZFhCd1pYUkJaR1J5WlhOekxtRnNaMjh1ZEhNNk1URUtDUzh2SUhKbFkyVnBkbVZ5T2lCMGFHbHpMbUZ3Y0M1aFpHUnlaWE56Q2dsbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29KYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvS0NTOHZJR052Ym5SeVlXTjBjMXh3ZFhCd1pYUkJaR1J5WlhOekxtRnNaMjh1ZEhNNk1USUtDUzh2SUdGdGIzVnVkRG9nTUFvSmFXNTBZeUF3SUM4dklEQUtDV2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDZ29KTHk4Z1kyOXVkSEpoWTNSelhIQjFjSEJsZEVGa1pISmxjM011WVd4bmJ5NTBjem94TXdvSkx5OGdjbVZyWlhsVWJ6b2daMnh2WW1Gc2N5NWpZV3hzWlhKQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0NXZHNiMkpoYkNCRFlXeHNaWEpCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LQ1dsMGVHNWZabWxsYkdRZ1VtVnJaWGxVYndvS0NTOHZJRVpsWlNCbWFXVnNaQ0J1YjNRZ2MyVjBMQ0JrWldaaGRXeDBhVzVuSUhSdklEQUtDV2x1ZEdNZ01DQXZMeUF3Q2dscGRIaHVYMlpwWld4a0lFWmxaUW9LQ1M4dklGTjFZbTFwZENCcGJtNWxjaUIwY21GdWMyRmpkR2x2YmdvSmFYUjRibDl6ZFdKdGFYUUtDZ2t2THlCamIyNTBjbUZqZEhOY2NIVndjR1YwUVdSa2NtVnpjeTVoYkdkdkxuUnpPakUyQ2drdkx5QnlaWFIxY200Z2RHaHBjeTVoY0hBdVlXUmtjbVZ6Y3pzS0NXZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2dseVpYUnpkV0lLQ2lwamNtVmhkR1ZmUkdWc1pYUmxRWEJ3YkdsallYUnBiMjQ2Q2dsd2RYTm9ZbmwwWlhNZ01IZzFOakZrTW1abFlTQXZMeUJ0WlhSb2IyUWdJbTVsZHlncFlXUmtjbVZ6Y3lJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmYm1WM0Nnb0pMeThnZEdocGN5QmpiMjUwY21GamRDQmtiMlZ6SUc1dmRDQnBiWEJzWlcxbGJuUWdkR2hsSUdkcGRtVnVJRUZDU1NCdFpYUm9iMlFnWm05eUlHTnlaV0YwWlNCRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmdvSlpYSnkiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUV4R0JTQkJnc3hHUWlOREFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFKd0NBQkJVZmZIV0lBQVJRc0NORGlnQUJzU095RURJS3NnY2lzZ2d5RHJJZ0lySUJzeklLaVlBRVZoMHY2allhQUk0Qi84MEEiLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjowLCJwYXRjaCI6MywiY29tbWl0SGFzaCI6ImYzYmU0YTNiIn19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
