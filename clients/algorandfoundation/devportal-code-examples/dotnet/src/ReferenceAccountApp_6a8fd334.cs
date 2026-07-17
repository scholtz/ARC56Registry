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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.ReferenceAccountApp_6a8fd334
{


    //
    // 
    //    Get the counter value from another account's local state with hardcoded values
    //    @returns The counter value or 0 if it doesn't exist
    //    
    //
    public class ReferenceAccountAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReferenceAccountAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetMyCounter(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 93, 179, 167 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMyCounter_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 93, 179, 167 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="acct"> </param>
        /// <param name="app"> </param>
        public async Task<ulong> GetMyCounterWithArg(Algorand.Address acct, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 86, 136, 62 };
            var acctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); acctAbi.From(acct);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, acctAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMyCounterWithArg_Transactions(Algorand.Address acct, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 86, 136, 62 };
            var acctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); acctAbi.From(acct);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, acctAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVmZXJlbmNlQWNjb3VudEFwcCIsImRlc2MiOiJcbiAgICBHZXQgdGhlIGNvdW50ZXIgdmFsdWUgZnJvbSBhbm90aGVyIGFjY291bnQncyBsb2NhbCBzdGF0ZSB3aXRoIGhhcmRjb2RlZCB2YWx1ZXNcbiAgICBAcmV0dXJucyBUaGUgY291bnRlciB2YWx1ZSBvciAwIGlmIGl0IGRvZXNuJ3QgZXhpc3RcbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2V0X215X2NvdW50ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbXlfY291bnRlcl93aXRoX2FyZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZzJaRGM1TldZMk16Wm1OelUyWlRjME5qVTNNaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxYMkZqWTI5MWJuUmZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qVXlDaUFnSUNBdkx5QmpiR0Z6Y3lCU1pXWmxjbVZ1WTJWQlkyTnZkVzUwUVhCd0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBNUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEbG1OV1JpTTJFM0lEQjRaREkxTmpnNE0yVWdMeThnYldWMGFHOWtJQ0puWlhSZmJYbGZZMjkxYm5SbGNpZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmYlhsZlkyOTFiblJsY2w5M2FYUm9YMkZ5WnloaFpHUnlaWE56TEhWcGJuUTJOQ2wxYVc1ME5qUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JuWlhSZmJYbGZZMjkxYm5SbGNpQm5aWFJmYlhsZlkyOTFiblJsY2w5M2FYUm9YMkZ5WndvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFEazZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliaUF2THlCdmJpQmxjbkp2Y2pvZ1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0NBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y21WbVpYSmxibU5sWDJGalkyOTFiblJmWVhCd0xtTnZiblJ5WVdOMExsSmxabVZ5Wlc1alpVRmpZMjkxYm5SQmNIQXVaMlYwWDIxNVgyTnZkVzUwWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmYlhsZlkyOTFiblJsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVdOamIzVnVkRjloY0hBdlkyOXVkSEpoWTNRdWNIazZOakF0TmpJS0lDQWdJQzh2SUdGalkzUWdQU0JCWTJOdmRXNTBLQW9nSUNBZ0x5OGdJQ0FnSUNKWFRVaEdORVpNU2s1TFdUSkNVRVpMTjFsUVZqVkpSRFpQV2pkTVZrUkNNa0kyTmxwVVdFVkJUVXhNTWs1WU5GZEtXbEpLUmxaWU5qWk5JZ29nSUNBZ0x5OGdLU0FnSXlCU1pYQnNZV05sSUhkcGRHZ2dlVzkxY2lCaFkyTnZkVzUwSUdGa1pISmxjM01LSUNBZ0lIQjFjMmhpZVhSbGN5QmlZWE5sTXpJb1YwMUlSalJHVEVwT1Mxa3lRbEJHU3pkWlVGWTFTVVEyVDFvM1RGWkVRakpDTmpaYVZGaEZRVTFNVERKT1dEUlhTbHBTUVNrZ0x5OGdZV1JrY2lCWFRVaEdORVpNU2s1TFdUSkNVRVpMTjFsUVZqVkpSRFpQV2pkTVZrUkNNa0kyTmxwVVdFVkJUVXhNTWs1WU5GZEtXbEpLUmxaWU5qWk5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObFgyRmpZMjkxYm5SZllYQndMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCaGNIQWdQU0JCY0hCc2FXTmhkR2x2YmlneE56RTNLU0FnSXlCU1pYQnNZV05sSUhkcGRHZ2dlVzkxY2lCaGNIQnNhV05oZEdsdmJpQnBaQW9nSUNBZ2NIVnphR2x1ZENBeE56RTNJQzh2SURFM01UY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJWZllXTmpiM1Z1ZEY5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TmpVdE5qWUtJQ0FnSUM4dklDTWdRMmhsWTJzZ2FXWWdkR2hsSUdOdmRXNTBaWElnZG1Gc2RXVWdaWGhwYzNSeklHbHVJSFJvWlNCaFkyTnZkVzUwSjNNZ2JHOWpZV3dnYzNSaGRHVWdabTl5SUhSb1pTQnpjR1ZqYVdacFpXUWdZWEJ3Q2lBZ0lDQXZMeUJ0ZVY5amIzVnVkQ3dnWlhocGMzUWdQU0J2Y0M1QmNIQk1iMk5oYkM1blpYUmZaWGhmZFdsdWREWTBLR0ZqWTNRc0lHRndjQ3dnWWlKdGVWOWpiM1Z1ZEdWeUlpa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJaRGM1TldZMk16Wm1OelUyWlRjME5qVTNNZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWm1WeVpXNWpaVjloWTJOdmRXNTBYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUbzJOd29nSUNBZ0x5OGdhV1lnYm05MElHVjRhWE4wT2dvZ0lDQWdZbTU2SUdkbGRGOXRlVjlqYjNWdWRHVnlYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFptVnlaVzVqWlY5aFkyTnZkVzUwWDJGd2NDOWpiMjUwY21GamRDNXdlVG8yT0FvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtDbWRsZEY5dGVWOWpiM1Z1ZEdWeVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsWm1WeVpXNWpaVjloWTJOdmRXNTBYMkZ3Y0M1amIyNTBjbUZqZEM1U1pXWmxjbVZ1WTJWQlkyTnZkVzUwUVhCd0xtZGxkRjl0ZVY5amIzVnVkR1Z5UURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sWDJGalkyOTFiblJmWVhCd0wyTnZiblJ5WVdOMExuQjVPalU0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwblpYUmZiWGxmWTI5MWJuUmxjbDloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJWZllXTmpiM1Z1ZEY5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TlRnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR0lnWjJWMFgyMTVYMk52ZFc1MFpYSmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11Y21WbVpYSmxibU5sWDJGalkyOTFiblJmWVhCd0xtTnZiblJ5WVdOMExsSmxabVZ5Wlc1alpVRmpZMjkxYm5SQmNIQXVaMlYwWDIxNVgyTnZkVzUwWlhKQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WldabGNtVnVZMlZmWVdOamIzVnVkRjloY0hBdVkyOXVkSEpoWTNRdVVtVm1aWEpsYm1ObFFXTmpiM1Z1ZEVGd2NDNW5aWFJmYlhsZlkyOTFiblJsY2w5M2FYUm9YMkZ5WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjl0ZVY5amIzVnVkR1Z5WDNkcGRHaGZZWEpuT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWm1WeVpXNWpaVjloWTJOdmRXNTBYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUbzNPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxabVZ5Wlc1alpWOWhZMk52ZFc1MFgyRndjQzlqYjI1MGNtRmpkQzV3ZVRvNE1DMDRNUW9nSUNBZ0x5OGdJeUJEYUdWamF5QnBaaUIwYUdVZ1kyOTFiblJsY2lCMllXeDFaU0JsZUdsemRITWdhVzRnZEdobElHRmpZMjkxYm5RbmN5QnNiMk5oYkNCemRHRjBaU0JtYjNJZ2RHaGxJSE53WldOcFptbGxaQ0JoY0hBS0lDQWdJQzh2SUcxNVgyTnZkVzUwTENCbGVHbHpkQ0E5SUc5d0xrRndjRXh2WTJGc0xtZGxkRjlsZUY5MWFXNTBOalFvWVdOamRDd2dZWEJ3TENCaUltMTVYMk52ZFc1MFpYSWlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFprTnprMVpqWXpObVkzTlRabE56UTJOVGN5Q2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sWDJGalkyOTFiblJmWVhCd0wyTnZiblJ5WVdOMExuQjVPamd5Q2lBZ0lDQXZMeUJwWmlCdWIzUWdaWGhwYzNRNkNpQWdJQ0JpYm5vZ1oyVjBYMjE1WDJOdmRXNTBaWEpmZDJsMGFGOWhjbWRmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObFgyRmpZMjkxYm5SZllYQndMMk52Ym5SeVlXTjBMbkI1T2pnekNpQWdJQ0F2THlCeVpYUjFjbTRnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWjJWMFgyMTVYMk52ZFc1MFpYSmZkMmwwYUY5aGNtZGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11Y21WbVpYSmxibU5sWDJGalkyOTFiblJmWVhCd0xtTnZiblJ5WVdOMExsSmxabVZ5Wlc1alpVRmpZMjkxYm5SQmNIQXVaMlYwWDIxNVgyTnZkVzUwWlhKZmQybDBhRjloY21kQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJWZllXTmpiM1Z1ZEY5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TnpnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRjl0ZVY5amIzVnVkR1Z5WDNkcGRHaGZZWEpuWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxabVZ5Wlc1alpWOWhZMk52ZFc1MFgyRndjQzlqYjI1MGNtRmpkQzV3ZVRvM09Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnWWlCblpYUmZiWGxmWTI5MWJuUmxjbDkzYVhSb1gyRnlaMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1eVpXWmxjbVZ1WTJWZllXTmpiM1Z1ZEY5aGNIQXVZMjl1ZEhKaFkzUXVVbVZtWlhKbGJtTmxRV05qYjNWdWRFRndjQzVuWlhSZmJYbGZZMjkxYm5SbGNsOTNhWFJvWDJGeVowQTBDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBQUVtQWdwdGVWOWpiM1Z1ZEdWeUJCVWZmSFV4RzBFQUhURVpGRVF4R0VTQ0FnU2ZYYk9uQk5KV2lENDJHZ0NPQWdBSkFEOEFNUmtVTVJnVUVFT0FJTE1PWGhWcGFyR2d2S3IrSDE2Z2ZuWit1b3c2RDcyWjNJQmkxNmJmbGs1aWdiVU5LR05BQUFnaUZpbE1VTEFqUTBsQy8vVTJHZ0UyR2dJWEtHTkFBQWdpRmlsTVVMQWpRMGxDLy9VPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
