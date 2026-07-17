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

namespace Arc56.Generated.CiottiGiorgio.lib_pcg_avm.LibPcg64TestHarnessAlgoTs_7ac6d039
{


    public class LibPcg64TestHarnessAlgoTsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LibPcg64TestHarnessAlgoTsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="seed"> </param>
        /// <param name="lower_bound"> </param>
        /// <param name="upper_bound"> </param>
        /// <param name="length"> </param>
        public async Task<ulong[]> GetPcg64SequenceArc4Uint64Return(byte[] seed, ulong lower_bound, ulong upper_bound, ushort length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 138, 225, 129 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); seedAbi.From(seed);
            var lower_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lower_boundAbi.From(lower_bound);
            var upper_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upper_boundAbi.From(upper_bound);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lengthAbi.From(length);

            var result = await base.CallApp(new List<object> { abiHandle, seedAbi, lower_boundAbi, upper_boundAbi, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> GetPcg64SequenceArc4Uint64Return_Transactions(byte[] seed, ulong lower_bound, ulong upper_bound, ushort length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 138, 225, 129 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); seedAbi.From(seed);
            var lower_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lower_boundAbi.From(lower_bound);
            var upper_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upper_boundAbi.From(upper_bound);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lengthAbi.From(length);

            return await base.MakeTransactionList(new List<object> { abiHandle, seedAbi, lower_boundAbi, upper_boundAbi, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RuntimeAssertsPcg64StackArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 111, 72, 56 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RuntimeAssertsPcg64StackArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 111, 72, 56 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RuntimeFailureStackBytesliceOverflow(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 11, 72, 152 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RuntimeFailureStackBytesliceOverflow_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 11, 72, 152 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTGliUGNnNjRUZXN0SGFybmVzc0FsZ29UcyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRfcGNnNjRfc2VxdWVuY2VfYXJjNF91aW50NjRfcmV0dXJuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMTZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibG93ZXJfYm91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVwcGVyX2JvdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsZW5ndGgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJ1bnRpbWVfYXNzZXJ0c19wY2c2NF9zdGFja19hcnJheSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJydW50aW1lX2ZhaWx1cmVfc3RhY2tfYnl0ZXNsaWNlX292ZXJmbG93IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAxNj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTcsNTA2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE0XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJREUySURZek5qUXhNell5TWpNNE5EWTNPVE13TURVZ01UUTBNalk1TlRBME1EZzRPRGsyTXpRd055QXhORFF5TmprMU1EUXdPRGc0T1RZek5EQTVJRFF5T1RRNU5qY3lPVFVLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE1Bb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzFaamhoWlRFNE1TQXdlR05oTm1ZME9ETTRJREI0Tm1Nd1lqUTRPVGdnTHk4Z2JXVjBhRzlrSUNKblpYUmZjR05uTmpSZmMyVnhkV1Z1WTJWZllYSmpORjkxYVc1ME5qUmZjbVYwZFhKdUtHSjVkR1ZiTVRaZExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWRERTJLWFZwYm5RMk5GdGRJaXdnYldWMGFHOWtJQ0p5ZFc1MGFXMWxYMkZ6YzJWeWRITmZjR05uTmpSZmMzUmhZMnRmWVhKeVlYa29LWFp2YVdRaUxDQnRaWFJvYjJRZ0luSjFiblJwYldWZlptRnBiSFZ5WlY5emRHRmphMTlpZVhSbGMyeHBZMlZmYjNabGNtWnNiM2NvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JuWlhSZmNHTm5OalJmYzJWeGRXVnVZMlZmWVhKak5GOTFhVzUwTmpSZmNtVjBkWEp1SUhKMWJuUnBiV1ZmWVhOelpYSjBjMTl3WTJjMk5GOXpkR0ZqYTE5aGNuSmhlU0J5ZFc1MGFXMWxYMlpoYVd4MWNtVmZjM1JoWTJ0ZllubDBaWE5zYVdObFgyOTJaWEptYkc5M0NpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV3T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNDQW1KaUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnNhV0pmY0dObkwzQmpaek15TG1Gc1oyOHVkSE02T2w5ZmNHTm5NekpQZFhSd2RYUW9jM1JoZEdVNklIVnBiblEyTkNrZ0xUNGdkV2x1ZERZME9ncGZYM0JqWnpNeVQzVjBjSFYwT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnTVRnZ0x5OGdNVGdLSUNBZ0lITm9jZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCZUNpQWdJQ0J3ZFhOb2FXNTBJREkzSUM4dklESTNDaUFnSUNCemFISUtJQ0FnSUdsdWRHTWdOaUF2THlBME1qazBPVFkzTWprMUNpQWdJQ0FtQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ05Ua2dMeThnTlRrS0lDQWdJSE5vY2dvZ0lDQWdaSFZ3TWdvZ0lDQWdjMmh5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQitDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWVdSa2R3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCd2RYTm9hVzUwSURNeElDOHZJRE14Q2lBZ0lDQW1DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSE5vYkFvZ0lDQWdhVzUwWXlBMklDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lDWUtJQ0FnSUh3S0lDQWdJSEpsZEhOMVlnb0tDaTh2SUd4cFlsOXdZMmN2Y0dObk5qUXVZV3huYnk1MGN6bzZjR05uTmpSSmJtbDBLSE5sWldRNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2NHTm5OalJKYm1sME9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklERTJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk15QXZMeUEyTXpZME1UTTJNakl6T0RRMk56a3pNREExQ2lBZ0lDQnRkV3gzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMElDOHZJREUwTkRJMk9UVXdOREE0T0RnNU5qTTBNRGNLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaFpHUjNDaUFnSUNCaWRYSjVJREVLSUNBZ0lHbHVkR05mTXlBdkx5QTJNelkwTVRNMk1qSXpPRFEyTnprek1EQTFDaUFnSUNCdGRXeDNDaUFnSUNCaWRYSjVJREVLSUNBZ0lHbHVkR01nTkNBdkx5QXhORFF5TmprMU1EUXdPRGc0T1RZek5EQTNDaUFnSUNCaFpHUjNDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQndiM0FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBNElDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqSURVZ0x5OGdNVFEwTWpZNU5UQTBNRGc0T0RrMk16UXdPUW9nSUNBZ1lXUmtkd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhaR1IzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR2x1ZEdOZk15QXZMeUEyTXpZME1UTTJNakl6T0RRMk56a3pNREExQ2lBZ0lDQnRkV3gzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR2x1ZEdNZ05TQXZMeUF4TkRReU5qazFNRFF3T0RnNE9UWXpOREE1Q2lBZ0lDQmhaR1IzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2JHbGlYM0JqWnk5d1kyYzJOQzVoYkdkdkxuUnpPanB3WTJjMk5GSmhibVJ2YlNoemRHRjBaVG9nWW5sMFpYTXNJR3h2ZDJWeVFtOTFibVE2SUhWcGJuUTJOQ3dnZFhCd1pYSkNiM1Z1WkRvZ2RXbHVkRFkwTENCc1pXNW5kR2c2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q25Calp6WTBVbUZ1Wkc5dE9nb2dJQ0FnY0hKdmRHOGdOQ0F4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCa2RYQnVJRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCaWFYUnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXhOZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1ltNTZJSEJqWnpZMFVtRnVaRzl0WDJWc2MyVmZZbTlrZVVBMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0p1ZWlCd1kyYzJORkpoYm1SdmJWOWxiSE5sWDJKdlpIbEFOZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ013b2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0NuQmpaelkwVW1GdVpHOXRYM2RvYVd4bFgzUnZjRUF6T2dvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BBb2dJQ0FnWW5vZ2NHTm5OalJTWVc1a2IyMWZZV1owWlhKZmFXWmZaV3h6WlVBeE9Rb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR05oYkd4emRXSWdYMTl3WTJjMk5GVnVZbTkxYm1SbFpGSmhibVJ2YlFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNVFlLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1pYaDBjbUZqZENBeE5pQTRDaUFnSUNCbWNtRnRaVjlrYVdjZ05nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEWUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDaUFnSUNCaUlIQmpaelkwVW1GdVpHOXRYM2RvYVd4bFgzUnZjRUF6Q2dwd1kyYzJORkpoYm1SdmJWOWhablJsY2w5cFpsOWxiSE5sUURFNU9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01ERXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwd1kyYzJORkpoYm1SdmJWOWxiSE5sWDJKdlpIbEFOam9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lub2djR05uTmpSU1lXNWtiMjFmWld4elpWOWliMlI1UURnS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lENEtJQ0FnSUdGemMyVnlkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNBdENpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0NuQmpaelkwVW1GdVpHOXRYMkZtZEdWeVgybG1YMlZzYzJWQU9Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJSDRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaFpHUjNDaUFnSUNCaWRYSjVJREVLSUNBZ0lITjNZWEFLSUNBZ0lDVUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTkFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLQ25Calp6WTBVbUZ1Wkc5dFgzZG9hV3hsWDNSdmNFQXhNRG9LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUR3S0lDQWdJR0o2SUhCalp6WTBVbUZ1Wkc5dFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRrS0NuQmpaelkwVW1GdVpHOXRYM2RvYVd4bFgzUnZjRUF4TWpvS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmpZV3hzYzNWaUlGOWZjR05uTmpSVmJtSnZkVzVrWldSU1lXNWtiMjBLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lERTJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdQajBLSUNBZ0lHSjZJSEJqWnpZMFVtRnVaRzl0WDNkb2FXeGxYM1J2Y0VBeE1nb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQWxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUEyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTmdvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0lDQWdJR0lnY0dObk5qUlNZVzVrYjIxZmQyaHBiR1ZmZEc5d1FERXdDZ3B3WTJjMk5GSmhibVJ2YlY5bGJITmxYMkp2WkhsQU9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnY0hWemFHbHVkQ0F4T0RRME5qYzBOREEzTXpjd09UVTFNVFl4TlNBdkx5QXhPRFEwTmpjME5EQTNNemN3T1RVMU1UWXhOUW9nSUNBZ1BBb2dJQ0FnWVhOelpYSjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWWkwS0lDQWdJR0owYjJrS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdZaUJ3WTJjMk5GSmhibVJ2YlY5aFpuUmxjbDlwWmw5bGJITmxRRGtLQ2dvdkx5QnNhV0pmY0dObkwzQmpaelkwTG1Gc1oyOHVkSE02T2w5ZmNHTm5OalJWYm1KdmRXNWtaV1JTWVc1a2IyMG9jM1JoZEdVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1gxOXdZMmMyTkZWdVltOTFibVJsWkZKaGJtUnZiVG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJRFl6TmpReE16WXlNak00TkRZM09UTXdNRFVLSUNBZ0lHMTFiSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdhVzUwWXlBMElDOHZJREUwTkRJMk9UVXdOREE0T0RnNU5qTTBNRGNLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElEZ2dMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeENpQWdJQ0FoQ2lBZ0lDQnBiblJqSURVZ0x5OGdNVFEwTWpZNU5UQTBNRGc0T0RrMk16UXdPUW9nSUNBZ2MzZGhjQW9nSUNBZ2MyaHNDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh6SUM4dklEWXpOalF4TXpZeU1qTTRORFkzT1RNd01EVUtJQ0FnSUcxMWJIY0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lXUmtkd29nSUNBZ1luVnllU0F4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRjlmY0dObk16SlBkWFJ3ZFhRS0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUhOb2JBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlGOWZjR05uTXpKUGRYUndkWFFLSUNBZ0lId0tJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBZbDl3WTJjMk5GOTBaWE4wWDJoaGNtNWxjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VEdsaVVHTm5OalJVWlhOMFNHRnlibVZ6YzBGc1oyOVVjeTVuWlhSZmNHTm5OalJmYzJWeGRXVnVZMlZmWVhKak5GOTFhVzUwTmpSZmNtVjBkWEp1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYM0JqWnpZMFgzTmxjWFZsYm1ObFgyRnlZelJmZFdsdWREWTBYM0psZEhWeWJqb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURFMlBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReE5nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpZV3hzYzNWaUlIQmpaelkwU1c1cGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdKMGIya0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZblJ2YVFvZ0lDQWdZMkZzYkhOMVlpQndZMmMyTkZKaGJtUnZiUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2xpWDNCalp6WTBYM1JsYzNSZmFHRnlibVZ6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTWFXSlFZMmMyTkZSbGMzUklZWEp1WlhOelFXeG5iMVJ6TG5KMWJuUnBiV1ZmWVhOelpYSjBjMTl3WTJjMk5GOXpkR0ZqYTE5aGNuSmhlVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KMWJuUnBiV1ZmWVhOelpYSjBjMTl3WTJjMk5GOXpkR0ZqYTE5aGNuSmhlVG9LSUNBZ0lHbHVkR05mTWlBdkx5QXhOZ29nSUNBZ1lucGxjbThLSUNBZ0lHTmhiR3h6ZFdJZ2NHTm5OalJKYm1sMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEVXdPU0F2THlBMU1Ea0tJQ0FnSUdOaGJHeHpkV0lnY0dObk5qUlNZVzVrYjIwS0lDQWdJSEJ2Y0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhV0pmY0dObk5qUmZkR1Z6ZEY5b1lYSnVaWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2t4cFlsQmpaelkwVkdWemRFaGhjbTVsYzNOQmJHZHZWSE11Y25WdWRHbHRaVjltWVdsc2RYSmxYM04wWVdOclgySjVkR1Z6YkdsalpWOXZkbVZ5Wm14dmQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkoxYm5ScGJXVmZabUZwYkhWeVpWOXpkR0ZqYTE5aWVYUmxjMnhwWTJWZmIzWmxjbVpzYjNjNkNpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJR0o2WlhKdkNpQWdJQ0JqWVd4c2MzVmlJSEJqWnpZMFNXNXBkQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0ExTVRBZ0x5OGdOVEV3Q2lBZ0lDQmpZV3hzYzNWaUlIQmpaelkwVW1GdVpHOXRDaUFnSUNCd2IzQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUhBUUFRcmY3VjVOU0YvYWhZejRLZXUrL3Yzb0lVMFlLZXUrL3Yzb0lVLy8vLy93OHhHMEVBSkRFWkZFUXhHRVNDQXdSZml1R0JCTXB2U0RnRWJBdEltRFlhQUk0REFaTUIyUUhwQURFWkZERVlGQkJFSWtPS0FRR0wvNEVTa1l2L0c0RWJrU0VHR292L2dUdVJTcEZNSENJZVJRR0JIeHBQQWt5UUlRWWFHWW1LQVFHTC94VWtFa1NML3lOYkl5VWRSUUZKSVFRZVJRRlBBaDVGQVNVZFJRRWhCQjVPQWtpTC80RUlXMHdoQlI1RkFSNUZBU1VkUlFFaEJSNUZBVXdXVEJaUWlZb0VBU09BQUVjRWkvOFdTWk1rRGtSWEJnS0wvVUFBUG92K1FBQTVJNHdEaS95TUFJc0RpLzhNUVFBZGl3Q0lBS3hKVndBUWpBQlhFQWlMQmt4UWpBYUxBeUlJakFOQy85dUwvSUFDQUJKUWl3WlFqQUNKaS81QkFGMkwvaUlOUkl2K0lnbUwvUTFFaS82TC9RbU1BWXNCU1J3aUhrVUJUQmlNQlNPTUJJdjhqQUNMQkl2L0RFSC92NHNBaUFCT1NWY0FFSXdBSkZ0SmpBS0xCUTlCLytxTEFvc0JHSXY5Q0JhTEJreFFqQWFMQkNJSWpBUkMvOHFML1lILy8vLy8vLy8vLy84QkRFU0wvUmFBQ1FFQUFBQUFBQUFBQUV5aEY0d0JRditTaWdFQmkvOGpXMGtsSFVVQklRUWVSUUdMLzRFSVcwc0JGQ0VGVEpCTEFTVWRSUUVlUlFGUEFoWk1GbEJQQW9qK2hJRWdrRThDaVA1OEdSWlFpVFlhQVVrVkpCSkVOaG9DU1JXQkNCSkVOaG9EU1JXQkNCSkVOaG9FU1JXQkFoSkVUd09JL25wUEF4ZFBBeGRQQXhlSS9ySkpKRmxMQVJWU2dBUVZIM3gxVEZDd0lrTWtyNGorVnlOSmdmMERpUDZUU0NKREpLK0kva2NqU1lIK0E0aitnMGdpUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
