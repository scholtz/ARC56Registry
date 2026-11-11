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

namespace Arc56.Generated.d13co.puya_ts_utils.CreateAccountConsumer_f379f985
{


    //
    // Exercises the minting subroutines the way a real contract would.
    //
    //This exists to give the test suites something to call, and doubles as the
    //worked example for both of them.
    //
    public class CreateAccountConsumerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CreateAccountConsumerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Mint an account and settle its minimum balance separately, out of this
        ///application's own escrow.
        ///</summary>
        public async Task<Algorand.Address> MintAndFund(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 115, 49, 84 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> MintAndFund_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 115, 49, 84 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mint an account, leaving the subroutine to settle its minimum balance out of
        ///`fundingAccount` — this application's escrow, or any account rekeyed to it.
        ///</summary>
        /// <param name="fundingAccount"> </param>
        public async Task<Algorand.Address> MintFundedBy(Algorand.Address fundingAccount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 17, 252, 193 };
            var fundingAccountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fundingAccountAbi.From(fundingAccount);

            var result = await base.CallApp(new List<object> { abiHandle, fundingAccountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> MintFundedBy_Transactions(Algorand.Address fundingAccount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 17, 252, 193 };
            var fundingAccountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fundingAccountAbi.From(fundingAccount);

            return await base.MakeTransactionList(new List<object> { abiHandle, fundingAccountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Spend from the minted account.
        ///
        ///The escrow holds no key of its own; it is rekeyed to this application, so
        ///this application is the only thing that can move its balance.
        ///</summary>
        /// <param name="receiver"> </param>
        /// <param name="amount"> </param>
        public async Task Spend(Algorand.Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 49, 154, 22 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, receiverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Spend_Transactions(Algorand.Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 49, 154, 22 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, receiverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3JlYXRlQWNjb3VudENvbnN1bWVyIiwiZGVzYyI6IkV4ZXJjaXNlcyB0aGUgbWludGluZyBzdWJyb3V0aW5lcyB0aGUgd2F5IGEgcmVhbCBjb250cmFjdCB3b3VsZC5cblxuVGhpcyBleGlzdHMgdG8gZ2l2ZSB0aGUgdGVzdCBzdWl0ZXMgc29tZXRoaW5nIHRvIGNhbGwsIGFuZCBkb3VibGVzIGFzIHRoZVxud29ya2VkIGV4YW1wbGUgZm9yIGJvdGggb2YgdGhlbS4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoibWludEFuZEZ1bmQiLCJkZXNjIjoiTWludCBhbiBhY2NvdW50IGFuZCBzZXR0bGUgaXRzIG1pbmltdW0gYmFsYW5jZSBzZXBhcmF0ZWx5LCBvdXQgb2YgdGhpc1xuYXBwbGljYXRpb24ncyBvd24gZXNjcm93LiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtaW50RnVuZGVkQnkiLCJkZXNjIjoiTWludCBhbiBhY2NvdW50LCBsZWF2aW5nIHRoZSBzdWJyb3V0aW5lIHRvIHNldHRsZSBpdHMgbWluaW11bSBiYWxhbmNlIG91dCBvZlxuYGZ1bmRpbmdBY2NvdW50YCDigJQgdGhpcyBhcHBsaWNhdGlvbidzIGVzY3Jvdywgb3IgYW55IGFjY291bnQgcmVrZXllZCB0byBpdC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZ1bmRpbmdBY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNwZW5kIiwiZGVzYyI6IlNwZW5kIGZyb20gdGhlIG1pbnRlZCBhY2NvdW50LlxuXG5UaGUgZXNjcm93IGhvbGRzIG5vIGtleSBvZiBpdHMgb3duOyBpdCBpcyByZWtleWVkIHRvIHRoaXMgYXBwbGljYXRpb24sIHNvXG50aGlzIGFwcGxpY2F0aW9uIGlzIHRoZSBvbmx5IHRoaW5nIHRoYXQgY2FuIG1vdmUgaXRzIGJhbGFuY2UuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTc3XSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE5LDI1OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRE15Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSW0xcGJuUmxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZoZEdWZllXTmpiM1Z1ZEM5amIyNXpkVzFsY2k1aGJHZHZMblJ6T2pFd0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRM0psWVhSbFFXTmpiM1Z1ZEVOdmJuTjFiV1Z5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3dNamN6TXpFMU5DQXdlREEzTVRGbVkyTXhJREI0TlRFek1UbGhNVFlnTHk4Z2JXVjBhRzlrSUNKdGFXNTBRVzVrUm5WdVpDZ3BZV1JrY21WemN5SXNJRzFsZEdodlpDQWliV2x1ZEVaMWJtUmxaRUo1S0dGa1pISmxjM01wWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpYzNCbGJtUW9ZV1JrY21WemN5eDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxcGJuUkJibVJHZFc1a0lHMXBiblJHZFc1a1pXUkNlU0J6Y0dWdVpBb2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21WaGRHVmZZV05qYjNWdWRDOWpiMjV6ZFcxbGNpNWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUTNKbFlYUmxRV05qYjNWdWRFTnZibk4xYldWeUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCemNtTXZZM0psWVhSbFFXTmpiM1Z1ZEM1aGJHZHZMblJ6T2pwamNtVmhkR1ZWYm1aMWJtUmxaRUZqWTI5MWJuUW9LU0F0UGlCaWVYUmxjem9LWTNKbFlYUmxWVzVtZFc1a1pXUkJZMk52ZFc1ME9nb2dJQ0FnTHk4Z2MzSmpMMk55WldGMFpVRmpZMjkxYm5RdVlXeG5ieTUwY3pvM015MDNOZ29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1WTI5dGNHbHNaVUZ5WXpRb1EzSmxZWFJsUVdOamIzVnVkQ2t1WTJGc2JDNWpjbVZoZEdWQlkyTnZkVzUwS0hzS0lDQWdJQzh2SUNBZ2IyNURiMjF3YkdWMGFXOXVPaUJQYmtOdmJYQnNaWFJsUVdOMGFXOXVMa1JsYkdWMFpVRndjR3hwWTJGMGFXOXVMQW9nSUNBZ0x5OGdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjM0pqTDJOeVpXRjBaVUZqWTI5MWJuUXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1WTI5dGNHbHNaVUZ5WXpRb1EzSmxZWFJsUVdOamIzVnVkQ2t1WTJGc2JDNWpjbVZoZEdWQlkyTnZkVzUwS0hzS0lDQWdJSEIxYzJoaWVYUmxjeUJpWVhObE5qUW9RelJGUWxGM1BUMHBDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnNaV0Z5VTNSaGRHVlFjbTluY21GdFVHRm5aWE1LSUNBZ0lIQjFjMmhpZVhSbGN5QmlZWE5sTmpRb1EzbEJRMEZCUjBGQ1FrTjFZV0k0TWtkblEwOUJVVUZDUVVSRldtZFJWVk5OVW1kVlJVVlNRMEZCUVhsRGNrVjRRVXhKWjBseVNVbFRZa2xJU1RkSlVVbHlTVUp6TkVGRlJsSTVPR1JWZUZGelEwNUVLUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJ5YjNaaGJGQnliMmR5WVcxUVlXZGxjd29nSUNBZ0x5OGdjM0pqTDJOeVpXRjBaVUZqWTI5MWJuUXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdiMjVEYjIxd2JHVjBhVzl1T2lCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdjSFZ6YUdsdWRDQTFDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0x5OGdjM0pqTDJOeVpXRjBaVUZqWTI5MWJuUXVZV3huYnk1MGN6bzNNeTAzTmdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVkyOXRjR2xzWlVGeVl6UW9RM0psWVhSbFFXTmpiM1Z1ZENrdVkyRnNiQzVqY21WaGRHVkJZMk52ZFc1MEtIc0tJQ0FnSUM4dklDQWdiMjVEYjIxd2JHVjBhVzl1T2lCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UQmhaVFk1WW1ZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQlkyTnZkVzUwS0NsaFpHUnlaWE56SWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpjbU12WTNKbFlYUmxRV05qYjNWdWRDNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5Qm1aV1U2SURBc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOeVl5OWpjbVZoZEdWQlkyTnZkVzUwTG1Gc1oyOHVkSE02TnpNdE56WUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbU52YlhCcGJHVkJjbU0wS0VOeVpXRjBaVUZqWTI5MWJuUXBMbU5oYkd3dVkzSmxZWFJsUVdOamIzVnVkQ2g3Q2lBZ0lDQXZMeUFnSUc5dVEyOXRjR3hsZEdsdmJqb2dUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNUVaV3hsZEdWQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FubDBaWE1nYUdGeklIWmhiR2xrSUhCeVpXWnBlQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV0YwWlY5aFkyTnZkVzUwTDJOdmJuTjFiV1Z5TG1Gc1oyOHVkSE02T2tOeVpXRjBaVUZqWTI5MWJuUkRiMjV6ZFcxbGNpNXRhVzUwUVc1a1JuVnVaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q20xcGJuUkJibVJHZFc1a09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXRjBaVjloWTJOdmRXNTBMMk52Ym5OMWJXVnlMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJR052Ym5OMElHVnpZM0p2ZHlBOUlHTnlaV0YwWlZWdVpuVnVaR1ZrUVdOamIzVnVkQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHTnlaV0YwWlZWdVpuVnVaR1ZrUVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV0YwWlY5aFkyTnZkVzUwTDJOdmJuTjFiV1Z5TG1Gc1oyOHVkSE02TWpNdE1qa0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQmxjMk55YjNjc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQkhiRzlpWVd3dWJXbHVRbUZzWVc1alpTd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV0YwWlY5aFkyTnZkVzUwTDJOdmJuTjFiV1Z5TG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUdGdGIzVnVkRG9nUjJ4dlltRnNMbTFwYmtKaGJHRnVZMlVzQ2lBZ0lDQm5iRzlpWVd3Z1RXbHVRbUZzWVc1alpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXRjBaVjloWTJOdmRXNTBMMk52Ym5OMWJXVnlMbUZzWjI4dWRITTZNak10TWpnS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCbGMyTnliM2NzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCSGJHOWlZV3d1YldsdVFtRnNZVzVqWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldGMFpWOWhZMk52ZFc1MEwyTnZibk4xYldWeUxtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklHWmxaVG9nTUN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldGMFpWOWhZMk52ZFc1MEwyTnZibk4xYldWeUxtRnNaMjh1ZEhNNk1qTXRNamtLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJsYzJOeWIzY3NDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJIYkc5aVlXd3ViV2x1UW1Gc1lXNWpaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21WaGRHVmZZV05qYjNWdWRDOWpiMjV6ZFcxbGNpNWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QnRhVzUwWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dKMjFwYm5SbFpDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTFwYm5SbFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmhkR1ZmWVdOamIzVnVkQzlqYjI1emRXMWxjaTVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUIwYUdsekxtMXBiblJsWkM1MllXeDFaU0E5SUdWelkzSnZkd29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWVhSbFgyRmpZMjkxYm5RdlkyOXVjM1Z0WlhJdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUcxcGJuUkJibVJHZFc1a0tDazZJRUZqWTI5MWJuUWdld29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmhkR1ZmWVdOamIzVnVkQzlqYjI1emRXMWxjaTVoYkdkdkxuUnpPanBEY21WaGRHVkJZMk52ZFc1MFEyOXVjM1Z0WlhJdWJXbHVkRVoxYm1SbFpFSjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYldsdWRFWjFibVJsWkVKNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXRjBaVjloWTJOdmRXNTBMMk52Ym5OMWJXVnlMbUZzWjI4dWRITTZNemtLSUNBZ0lDOHZJSEIxWW14cFl5QnRhVzUwUm5WdVpHVmtRbmtvWm5WdVpHbHVaMEZqWTI5MWJuUTZJRUZqWTI5MWJuUXBPaUJCWTJOdmRXNTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjM0pqTDJOeVpXRjBaVUZqWTI5MWJuUXVZV3huYnk1MGN6bzVOUW9nSUNBZ0x5OGdZMjl1YzNRZ1pYTmpjbTkzSUQwZ1kzSmxZWFJsVlc1bWRXNWtaV1JCWTJOdmRXNTBLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1kzSmxZWFJsVlc1bWRXNWtaV1JCWTJOdmRXNTBDaUFnSUNBdkx5QnpjbU12WTNKbFlYUmxRV05qYjNWdWRDNWhiR2R2TG5Sek9qazNMVEV3TkFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlPaUJtZFc1a2FXNW5RV05qYjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nWlhOamNtOTNMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nUjJ4dlltRnNMbTFwYmtKaGJHRnVZMlVzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOeVl5OWpjbVZoZEdWQlkyTnZkVzUwTG1Gc1oyOHVkSE02TVRBeENpQWdJQ0F2THlCaGJXOTFiblE2SUVkc2IySmhiQzV0YVc1Q1lXeGhibU5sTEFvZ0lDQWdaMnh2WW1Gc0lFMXBia0poYkdGdVkyVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6Y21NdlkzSmxZWFJsUVdOamIzVnVkQzVoYkdkdkxuUnpPamszTFRFd013b2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5T2lCbWRXNWthVzVuUVdOamIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ1pYTmpjbTkzTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ1IyeHZZbUZzTG0xcGJrSmhiR0Z1WTJVc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOeVl5OWpjbVZoZEdWQlkyTnZkVzUwTG1Gc1oyOHVkSE02TVRBeUNpQWdJQ0F2THlCbVpXVTZJREFzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE55WXk5amNtVmhkR1ZCWTJOdmRXNTBMbUZzWjI4dWRITTZPVGN0TVRBMENpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWEk2SUdaMWJtUnBibWRCWTJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCbGMyTnliM2NzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCSGJHOWlZV3d1YldsdVFtRnNZVzVqWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmhkR1ZmWVdOamIzVnVkQzlqYjI1emRXMWxjaTVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJ0YVc1MFpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHdGxlVG9nSjIxcGJuUmxaQ2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW0xcGJuUmxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZoZEdWZllXTmpiM1Z1ZEM5amIyNXpkVzFsY2k1aGJHZHZMblJ6T2pReUNpQWdJQ0F2THlCMGFHbHpMbTFwYm5SbFpDNTJZV3gxWlNBOUlHVnpZM0p2ZHdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFlYUmxYMkZqWTI5MWJuUXZZMjl1YzNWdFpYSXVZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdjSFZpYkdsaklHMXBiblJHZFc1a1pXUkNlU2htZFc1a2FXNW5RV05qYjNWdWREb2dRV05qYjNWdWRDazZJRUZqWTI5MWJuUWdld29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmhkR1ZmWVdOamIzVnVkQzlqYjI1emRXMWxjaTVoYkdkdkxuUnpPanBEY21WaGRHVkJZMk52ZFc1MFEyOXVjM1Z0WlhJdWMzQmxibVJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwemNHVnVaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZoZEdWZllXTmpiM1Z1ZEM5amIyNXpkVzFsY2k1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCd2RXSnNhV01nYzNCbGJtUW9jbVZqWldsMlpYSTZJRUZqWTI5MWJuUXNJR0Z0YjNWdWREb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFlYUmxYMkZqWTI5MWJuUXZZMjl1YzNWdFpYSXVZV3huYnk1MGN6bzFNeTAyTUFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlPaUIwYUdsekxtMXBiblJsWkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmhkR1ZmWVdOamIzVnVkQzlqYjI1emRXMWxjaTVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJ6Wlc1a1pYSTZJSFJvYVhNdWJXbHVkR1ZrTG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmhkR1ZmWVdOamIzVnVkQzlqYjI1emRXMWxjaTVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJ0YVc1MFpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHdGxlVG9nSjIxcGJuUmxaQ2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW0xcGJuUmxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZoZEdWZllXTmpiM1Z1ZEM5amIyNXpkVzFsY2k1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCelpXNWtaWEk2SUhSb2FYTXViV2x1ZEdWa0xuWmhiSFZsTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdVMlZ1WkdWeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXRjBaVjloWTJOdmRXNTBMMk52Ym5OMWJXVnlMbUZzWjI4dWRITTZOVE10TlRrS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjam9nZEdocGN5NXRhVzUwWldRdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFlYUmxYMkZqWTI5MWJuUXZZMjl1YzNWdFpYSXVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdabVZsT2lBd0xBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFlYUmxYMkZqWTI5MWJuUXZZMjl1YzNWdFpYSXVZV3huYnk1MGN6bzFNeTAyTUFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlPaUIwYUdsekxtMXBiblJsWkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxZWFJsWDJGalkyOTFiblF2WTI5dWMzVnRaWEl1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnY0hWaWJHbGpJSE53Wlc1a0tISmxZMlZwZG1WeU9pQkJZMk52ZFc1MExDQmhiVzkxYm5RNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBUUFnSmdJRUZSOThkUVp0YVc1MFpXUXhHMEVBSkRFWkZFUXhHRVNDQXdRQ2N6RlVCQWNSL01FRVVUR2FGallhQUk0REFId0FtQUMvQURFWkZERVlGQkJEc1lBRUM0RUJRN0pDZ0Q4TElBSUFBWUFFRUs1cHZ6WWFBSTRCQUFFQU1SbUJCUkl4R0JRUVJFSUFBRElLc1RFQXNpQWlzZ2hKc2djanNoQWlzZ0d6Z0FRVkgzeDFURkN3STBPeVFJRUZzaG1BQkJDdWFiK3lHb0VHc2hBanNnR3p0RDVKVndRQVRGY0FCQ2dTUkVrVkpCSkVpWWovaXJFeUFiSUlTYklISXJJUUk3SUJzeWxMQVdjb1RGQ3dJa00yR2dGSkZTUVNSSWovWnJFeUFiSUlTYklIVExJQUlySVFJN0lCc3lsTEFXY29URkN3SWtNMkdnRkpGU1FTUkRZYUFra1ZnUWdTUkJleEl5bGxSTElBc2dpeUJ5S3lFQ095QWJNaVF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
