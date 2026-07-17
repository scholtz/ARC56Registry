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

namespace Arc56.Generated.algorandfoundation.puya_ts_demo.VotingContract_4cba2725
{


    public class VotingContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public VotingContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="topic"> </param>
        public async Task SetTopic(string topic, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 12, 56, 66 };
            var topicAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); topicAbi.From(topic);

            var result = await base.CallApp(new List<object> { abiHandle, topicAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetTopic_Transactions(string topic, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 12, 56, 66 };
            var topicAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); topicAbi.From(topic);

            return await base.MakeTransactionList(new List<object> { abiHandle, topicAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay"> </param>
        public async Task<bool> Vote(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 243, 201, 134, 179 };

            var result = await base.CallApp(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Vote_Transactions(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 243, 201, 134, 179 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetVotes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 244, 112, 171 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetVotes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 244, 112, 171 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVm90aW5nQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoic2V0VG9waWMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9waWMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidm90ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Vm90ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjEsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTMwXSwiZXJyb3JNZXNzYWdlIjoiRXhwZWN0ZWQgMiB0cmFuc2FjdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzhdLCJlcnJvck1lc3NhZ2UiOiJJbmNvcnJlY3QgcGF5bWVudCBhbW91bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NF0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgc2VuZGVyIG11c3QgbWF0Y2ggdHJhbnNhY3Rpb24gc2VuZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY3LDE4N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0oyYjNSbGN5SWdJblJ2Y0dsaklpQWlkbTkwWldRaUlEQjRNVFV4Wmpkak56VUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5MmIzUnBibWN2ZG05MGFXNW5MbUZzWjI4dWRITTZNVFF0TVRjS0lDQWdJQzh2SUhSdmNHbGpJRDBnUjJ4dlltRnNVM1JoZEdVb2V3b2dJQ0FnTHk4Z0lDQnBibWwwYVdGc1ZtRnNkV1U2SUVKNWRHVnpLQ0prWldaaGRXeDBYM1J2Y0dsaklpa3NDaUFnSUNBdkx5QWdJR3RsZVRvZ1FubDBaWE1vSW5SdmNHbGpJaWtzQ2lBZ0lDQXZMeUI5S1RzS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmNHbGpJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1p2ZEdsdVp5OTJiM1JwYm1jdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z2FXNXBkR2xoYkZaaGJIVmxPaUJDZVhSbGN5Z2laR1ZtWVhWc2RGOTBiM0JwWXlJcExBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKa1pXWmhkV3gwWDNSdmNHbGpJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1p2ZEdsdVp5OTJiM1JwYm1jdVlXeG5ieTUwY3pveE5DMHhOd29nSUNBZ0x5OGdkRzl3YVdNZ1BTQkhiRzlpWVd4VGRHRjBaU2g3Q2lBZ0lDQXZMeUFnSUdsdWFYUnBZV3hXWVd4MVpUb2dRbmwwWlhNb0ltUmxabUYxYkhSZmRHOXdhV01pS1N3S0lDQWdJQzh2SUNBZ2EyVjVPaUJDZVhSbGN5Z2lkRzl3YVdNaUtTd0tJQ0FnSUM4dklIMHBPd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTkyYjNScGJtY3ZkbTkwYVc1bkxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklIWnZkR1Z6SUQwZ1IyeHZZbUZzVTNSaGRHVW9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTd2dhMlY1T2lCQ2VYUmxjeWdpZG05MFpYTWlLU0I5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5admRHVnpJZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5MmIzUnBibWN2ZG05MGFXNW5MbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmtaV1poZFd4MElHTnNZWE56SUZadmRHbHVaME52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdZWEpqTkM1RGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVElLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TldFd1l6TTRORElnTUhobU0yTTVPRFppTXlBd2VHVTRaalEzTUdGaUlDOHZJRzFsZEdodlpDQWljMlYwVkc5d2FXTW9jM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW5admRHVW9jR0Y1S1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWRsZEZadmRHVnpLQ2wxYVc1ME5qUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J6WlhSVWIzQnBZeUIyYjNSbElHZGxkRlp2ZEdWekNpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV5T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNadmRHbHVaeTkyYjNScGJtY3VZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdaWGh3YjNKMElHUmxabUYxYkhRZ1kyeGhjM01nVm05MGFXNW5RMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QmhjbU0wTGtOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUlDOHZJRzl1SUdWeWNtOXlPaUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdJQ1ltSUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvS0NpOHZJR052Ym5SeVlXTjBjeTkyYjNScGJtY3ZkbTkwYVc1bkxtRnNaMjh1ZEhNNk9sWnZkR2x1WjBOdmJuUnlZV04wTG5ObGRGUnZjR2xqVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBWRzl3YVdNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtOTBhVzVuTDNadmRHbHVaeTVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTJiM1JwYm1jdmRtOTBhVzVuTG1Gc1oyOHVkSE02TVRRdE1UY0tJQ0FnSUM4dklIUnZjR2xqSUQwZ1IyeHZZbUZzVTNSaGRHVW9ld29nSUNBZ0x5OGdJQ0JwYm1sMGFXRnNWbUZzZFdVNklFSjVkR1Z6S0NKa1pXWmhkV3gwWDNSdmNHbGpJaWtzQ2lBZ0lDQXZMeUFnSUd0bGVUb2dRbmwwWlhNb0luUnZjR2xqSWlrc0NpQWdJQ0F2THlCOUtUc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZjR2xqSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNadmRHbHVaeTkyYjNScGJtY3VZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdkR2hwY3k1MGIzQnBZeTUyWVd4MVpTQTlJRUo1ZEdWektIUnZjR2xqS1RzS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtOTBhVzVuTDNadmRHbHVaeTVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OTJiM1JwYm1jdmRtOTBhVzVuTG1Gc1oyOHVkSE02T2xadmRHbHVaME52Ym5SeVlXTjBMblp2ZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJiM1JsT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNadmRHbHVaeTkyYjNScGJtY3VZV3huYnk1MGN6b3lOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNadmRHbHVaeTkyYjNScGJtY3VZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdZWE56WlhKMEtHOXdMa2RzYjJKaGJDNW5jbTkxY0ZOcGVtVWdQVDA5SURJc0lDSkZlSEJsWTNSbFpDQXlJSFJ5WVc1ellXTjBhVzl1Y3lJcE93b2dJQ0FnWjJ4dlltRnNJRWR5YjNWd1UybDZaUW9nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1JYaHdaV04wWldRZ01pQjBjbUZ1YzJGamRHbHZibk1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTkyYjNScGJtY3ZkbTkwYVc1bkxtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENod1lYa3VZVzF2ZFc1MElEMDlQU0F4TUY4d01EQXNJQ0pKYm1OdmNuSmxZM1FnY0dGNWJXVnVkQ0JoYlc5MWJuUWlLVHNLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdJQzh2SURFd01EQXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdVkyOXljbVZqZENCd1lYbHRaVzUwSUdGdGIzVnVkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1p2ZEdsdVp5OTJiM1JwYm1jdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z2NHRjVMbk5sYm1SbGNpQTlQVDBnVkhodUxuTmxibVJsY2l3S0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTJiM1JwYm1jdmRtOTBhVzVuTG1Gc1oyOHVkSE02TWprdE16SUtJQ0FnSUM4dklHRnpjMlZ5ZENnS0lDQWdJQzh2SUNBZ2NHRjVMbk5sYm1SbGNpQTlQVDBnVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lsQmhlVzFsYm5RZ2MyVnVaR1Z5SUcxMWMzUWdiV0YwWTJnZ2RISmhibk5oWTNScGIyNGdjMlZ1WkdWeUlpd0tJQ0FnSUM4dklDazdDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCelpXNWtaWElnYlhWemRDQnRZWFJqYUNCMGNtRnVjMkZqZEdsdmJpQnpaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5MmIzUnBibWN2ZG05MGFXNW5MbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJR2xtSUNoMGFHbHpMblp2ZEdWa0tGUjRiaTV6Wlc1a1pYSXBMbWhoYzFaaGJIVmxLU0I3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzWnZkR2x1Wnk5MmIzUnBibWN1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnZG05MFpXUWdQU0JNYjJOaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJRUo1ZEdWektDSjJiM1JsWkNJcElIMHBPd29nSUNBZ1lubDBaV05mTWlBdkx5QWlkbTkwWldRaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtOTBhVzVuTDNadmRHbHVaeTVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJwWmlBb2RHaHBjeTUyYjNSbFpDaFVlRzR1YzJWdVpHVnlLUzVvWVhOV1lXeDFaU2tnZXdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQjJiM1JsWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1p2ZEdsdVp5OTJiM1JwYm1jdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QmhjbU0wTGtKdmIyd29abUZzYzJVcE95QXZMeUJCYkhKbFlXUjVJSFp2ZEdWa0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb0tkbTkwWlY5aFpuUmxjbDlwYm14cGJtVmtYMk52Ym5SeVlXTjBjeTkyYjNScGJtY3ZkbTkwYVc1bkxtRnNaMjh1ZEhNNk9sWnZkR2x1WjBOdmJuUnlZV04wTG5admRHVkFORG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTkyYjNScGJtY3ZkbTkwYVc1bkxtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncDJiM1JsWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTkyYjNScGJtY3ZkbTkwYVc1bkxtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklIUm9hWE11ZG05MFpYTXVkbUZzZFdVZ1BTQjBhR2x6TG5admRHVnpMblpoYkhWbElDc2dNVHNLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbTkwYVc1bkwzWnZkR2x1Wnk1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCMmIzUmxjeUE5SUVkc2IySmhiRk4wWVhSbEtIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrc0lHdGxlVG9nUW5sMFpYTW9Jblp2ZEdWeklpa2dmU2s3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oyYjNSbGN5SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTJiM1JwYm1jdmRtOTBhVzVuTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUhSb2FYTXVkbTkwWlhNdWRtRnNkV1VnUFNCMGFHbHpMblp2ZEdWekxuWmhiSFZsSUNzZ01Uc0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1p2ZEdsdVp5OTJiM1JwYm1jdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z2RtOTBaWE1nUFNCSGJHOWlZV3hUZEdGMFpTaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcExDQnJaWGs2SUVKNWRHVnpLQ0oyYjNSbGN5SXBJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZG05MFpYTWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbTkwYVc1bkwzWnZkR2x1Wnk1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCMGFHbHpMblp2ZEdWekxuWmhiSFZsSUQwZ2RHaHBjeTUyYjNSbGN5NTJZV3gxWlNBcklERTdDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1p2ZEdsdVp5OTJiM1JwYm1jdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z2RHaHBjeTUyYjNSbFpDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJREU3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbTkwYVc1bkwzWnZkR2x1Wnk1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCMmIzUmxaQ0E5SUV4dlkyRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nUW5sMFpYTW9Jblp2ZEdWa0lpa2dmU2s3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0oyYjNSbFpDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTJiM1JwYm1jdmRtOTBhVzVuTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUhSb2FYTXVkbTkwWldRb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQXhPd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTJiM1JwYm1jdmRtOTBhVzVuTG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1lYSmpOQzVDYjI5c0tIUnlkV1VwT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5MmIzUnBibWN2ZG05MGFXNW5MbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCaUlIWnZkR1ZmWVdaMFpYSmZhVzVzYVc1bFpGOWpiMjUwY21GamRITXZkbTkwYVc1bkwzWnZkR2x1Wnk1aGJHZHZMblJ6T2pwV2IzUnBibWREYjI1MGNtRmpkQzUyYjNSbFFEUUtDZ292THlCamIyNTBjbUZqZEhNdmRtOTBhVzVuTDNadmRHbHVaeTVoYkdkdkxuUnpPanBXYjNScGJtZERiMjUwY21GamRDNW5aWFJXYjNSbGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZadmRHVnpPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1p2ZEdsdVp5OTJiM1JwYm1jdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2gwYUdsekxuWnZkR1Z6TG5aaGJIVmxLVHNLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbTkwYVc1bkwzWnZkR2x1Wnk1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCMmIzUmxjeUE5SUVkc2IySmhiRk4wWVhSbEtIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrc0lHdGxlVG9nUW5sMFpYTW9Jblp2ZEdWeklpa2dmU2s3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oyYjNSbGN5SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTJiM1JwYm1jdmRtOTBhVzVuTG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9kR2hwY3k1MmIzUmxjeTUyWVd4MVpTazdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzWnZkR2x1Wnk5MmIzUnBibWN1WVd4bmJ5NTBjem8wTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJqYjI1MGNtRmpkSE12ZG05MGFXNW5MM1p2ZEdsdVp5NWhiR2R2TG5Sek9qcFdiM1JwYm1kRGIyNTBjbUZqZEM1amJHVmhjbE4wWVhSbFVISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5MmIzUnBibWN2ZG05MGFXNW5MbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJSEpsZEhWeWJpQjBjblZsT3dvZ0lDQWdjSFZ6YUdsdWRDQXhJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUJBVjJiM1JsY3dWMGIzQnBZd1YyYjNSbFpBUVZIM3gxTVJoQUFCUXBnQTFrWldaaGRXeDBYM1J2Y0dsalp5Z2paekViUVFBa01Sa1VSREVZUklJREJGb01PRUlFODhtR3N3VG85SENyTmhvQWpnTUFDUUFVQUZrQU1Sa1VNUmdVRUVNMkdnRlhBZ0FwVEdjaVF6RVdJZ2xKT0JBaUVrUXlCSUVDRWtSSk9BaUJrRTRTUkRnQU1RQVNSREVBSXlwalJRRkJBQW1BQVFBclRGQ3dJa01qS0dWRUlnZ29UR2N4QUNvaVpvQUJnRUwvNWlNb1pVUVdLMHhRc0NKRCIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
