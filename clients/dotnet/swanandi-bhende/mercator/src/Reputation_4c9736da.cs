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

namespace Arc56.Generated.swanandi_bhende.mercator.Reputation_4c9736da
{


    //
    // On-chain seller reputation scoring system.
    //    
    //    State:
    //        seller_scores: BoxMap(seller_address => score) storing seller trust scores (uint64).
    //    
    //    Purpose: Decentralized oracle for buyer purchase decisions + seller track record.
    //    
    //
    public class ReputationProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReputationProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Update or create a seller reputation score on-chain.
        ///Purpose: Record seller's current reputation (0-100 scale). Called during seller verification flow or post-purchase reputation updates.
        ///Actions: 1. Store new_score in boxes under seller's address. 2. Overwrites any previous score (last-write-wins). 3. Emit event log for audit trail.
        ///</summary>
        /// <param name="seller">Algorand wallet address to score. </param>
        /// <param name="new_score">New reputation score (0-100 typically, no hard limit in contract). </param>
        public async Task UpdateScore(Algorand.Address seller, ulong new_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 60, 223, 92 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var new_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_scoreAbi.From(new_score);

            var result = await base.CallApp(new List<object> { abiHandle, sellerAbi, new_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateScore_Transactions(Algorand.Address seller, ulong new_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 60, 223, 92 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var new_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_scoreAbi.From(new_score);

            return await base.MakeTransactionList(new List<object> { abiHandle, sellerAbi, new_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read a seller's current reputation score on-chain.
        ///Purpose: Public query for seller trust score. Called by buyer agent during evaluation. Readonly method (no state mutations, viewable via any algod node).
        ///</summary>
        /// <param name="seller">Algorand wallet address to look up. </param>
        public async Task<ulong> GetScore(Algorand.Address seller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 91, 114, 12 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);

            var result = await base.SimApp(new List<object> { abiHandle, sellerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetScore_Transactions(Algorand.Address seller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 91, 114, 12 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);

            return await base.MakeTransactionList(new List<object> { abiHandle, sellerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVwdXRhdGlvbiIsImRlc2MiOiJPbi1jaGFpbiBzZWxsZXIgcmVwdXRhdGlvbiBzY29yaW5nIHN5c3RlbS5cbiAgICBcbiAgICBTdGF0ZTpcbiAgICAgICAgc2VsbGVyX3Njb3JlczogQm94TWFwKHNlbGxlcl9hZGRyZXNzID0+IHNjb3JlKSBzdG9yaW5nIHNlbGxlciB0cnVzdCBzY29yZXMgKHVpbnQ2NCkuXG4gICAgXG4gICAgUHVycG9zZTogRGVjZW50cmFsaXplZCBvcmFjbGUgZm9yIGJ1eWVyIHB1cmNoYXNlIGRlY2lzaW9ucyArIHNlbGxlciB0cmFjayByZWNvcmQuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InVwZGF0ZV9zY29yZSIsImRlc2MiOiJVcGRhdGUgb3IgY3JlYXRlIGEgc2VsbGVyIHJlcHV0YXRpb24gc2NvcmUgb24tY2hhaW4uXG5QdXJwb3NlOiBSZWNvcmQgc2VsbGVyJ3MgY3VycmVudCByZXB1dGF0aW9uICgwLTEwMCBzY2FsZSkuIENhbGxlZCBkdXJpbmcgc2VsbGVyIHZlcmlmaWNhdGlvbiBmbG93IG9yIHBvc3QtcHVyY2hhc2UgcmVwdXRhdGlvbiB1cGRhdGVzLlxuQWN0aW9uczogMS4gU3RvcmUgbmV3X3Njb3JlIGluIGJveGVzIHVuZGVyIHNlbGxlcidzIGFkZHJlc3MuIDIuIE92ZXJ3cml0ZXMgYW55IHByZXZpb3VzIHNjb3JlIChsYXN0LXdyaXRlLXdpbnMpLiAzLiBFbWl0IGV2ZW50IGxvZyBmb3IgYXVkaXQgdHJhaWwuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxsZXIiLCJkZXNjIjoiQWxnb3JhbmQgd2FsbGV0IGFkZHJlc3MgdG8gc2NvcmUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfc2NvcmUiLCJkZXNjIjoiTmV3IHJlcHV0YXRpb24gc2NvcmUgKDAtMTAwIHR5cGljYWxseSwgbm8gaGFyZCBsaW1pdCBpbiBjb250cmFjdCkuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9zY29yZSIsImRlc2MiOiJSZWFkIGEgc2VsbGVyJ3MgY3VycmVudCByZXB1dGF0aW9uIHNjb3JlIG9uLWNoYWluLlxuUHVycG9zZTogUHVibGljIHF1ZXJ5IGZvciBzZWxsZXIgdHJ1c3Qgc2NvcmUuIENhbGxlZCBieSBidXllciBhZ2VudCBkdXJpbmcgZXZhbHVhdGlvbi4gUmVhZG9ubHkgbWV0aG9kIChubyBzdGF0ZSBtdXRhdGlvbnMsIHZpZXdhYmxlIHZpYSBhbnkgYWxnb2Qgbm9kZSkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxsZXIiLCJkZXNjIjoiQWxnb3JhbmQgd2FsbGV0IGFkZHJlc3MgdG8gbG9vayB1cC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiU2VsbGVyJ3MgcmVwdXRhdGlvbiBzY29yZSAodWludDY0KS4gUmV0dXJucyAwIGlmIHNlbGxlciBub3QgZm91bmQgKGRlZmF1bHQ6IHVudHJ1c3RlZCkuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzYwLDg1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBek1pQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjROekkyTlRjd0NpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dUwzTnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakkzQ2lBZ0lDQXZMeUJqYkdGemN5QlNaWEIxZEdGMGFXOXVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhNUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaR0V6WTJSbU5XTWdNSGd5TURWaU56SXdZeUF2THlCdFpYUm9iMlFnSW5Wd1pHRjBaVjl6WTI5eVpTaGhaR1J5WlhOekxIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZmMyTnZjbVVvWVdSa2NtVnpjeWwxYVc1ME5qUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0IxY0dSaGRHVmZjMk52Y21VZ1oyVjBYM05qYjNKbENpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVEU2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWEIxZEdGMGFXOXVMbU52Ym5SeVlXTjBMbEpsY0hWMFlYUnBiMjR1ZFhCa1lYUmxYM05qYjNKbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkWEJrWVhSbFgzTmpiM0psT2dvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymk5emJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3pPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNHZjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TlRrS0lDQWdJQzh2SUhObGJHWXVjMlZzYkdWeVgzTmpiM0psYzF0elpXeHNaWEpkSUQwZ2JtVjNYM05qYjNKbENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE56STJOVGN3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymk5emJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3pPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y21Wd2RYUmhkR2x2Ymk1amIyNTBjbUZqZEM1U1pYQjFkR0YwYVc5dUxtZGxkRjl6WTI5eVpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5elkyOXlaVG9LSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5qRUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMM050WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pjNUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXpaV3hzWlhKZmMyTnZjbVZ6TG1kbGRDaHpaV3hzWlhJc0lHUmxabUYxYkhROVlYSmpOQzVWU1c1ME5qUW9NQ2twQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TnpJMk5UY3dDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJpOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8yTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNJQUVtQVFOeVpYQXhHMEVBSFRFWkZFUXhHRVNDQWdUYVBOOWNCQ0JiY2d3MkdnQ09BZ0FKQUNJQU1Sa1VNUmdVRUVNMkdnRkpGU0lTUkRZYUFra1ZnUWdTUkNoUEFsQk12eU5ETmhvQlNSVWlFa1FvVEZDK2dBZ0FBQUFBQUFBQUFFNENUWUFFRlI5OGRVeFFzQ05EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
