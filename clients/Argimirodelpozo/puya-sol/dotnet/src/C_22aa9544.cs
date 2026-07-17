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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_22aa9544
{


    public class CProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_key0"> </param>
        /// <param name="__arc4_key1"> </param>
        public async Task<ulong> A(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_key0, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_key1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 229, 61, 22 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_key0, __arc4_key1 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> A_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_key0, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_key1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 229, 61, 22 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_key0, __arc4_key1 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfa2V5MCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9rZXkxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzMxOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGEgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ0XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTMsMzAyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNV0sImVycm9yTWVzc2FnZSI6Im5vdCBwYXlhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZaMlYwZEdWeWN5OWhjbkpoZVhNdWMyOXNMa011WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXlJREVnTUNBNENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNElDSmhJZ29nSUNBZ2NIVnphR2x1ZENBME1EazJDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCemRHOXlaU0ExQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWTJGc2JITjFZaUJ6ZEdGMGFXTmZZWEp5WVhsZmNtVmhaRjlpZVhSbFgyeGxibWQwYUY5bGJHVnRaVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF3Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdOaGJHeHpkV0lnYzNSaGRHbGpYMkZ5Y21GNVgzSmxjR3hoWTJWZllubDBaVjlzWlc1bmRHaGZhR1ZoWkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1kyRnNiSE4xWWlCemRHRjBhV05mWVhKeVlYbGZjbVZoWkY5aWVYUmxYMnhsYm1kMGFGOWxiR1Z0Wlc1MENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBd0NpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHTmhiR3h6ZFdJZ2MzUmhkR2xqWDJGeWNtRjVYM0psY0d4aFkyVmZZbmwwWlY5c1pXNW5kR2hmYUdWaFpBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJR1IxY0FvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnYkc5aFpDQXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EZ3dDaUFnSUNCeVpYQnNZV05sTWlBMk5Bb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNak5sTlROa01UWWdMeThnYldWMGFHOWtJQ0poS0hWcGJuUXlOVFlzZFdsdWRESTFOaWwxYVc1ME5qUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyRmZjbTkxZEdWQU5Bb2dJQ0FnWlhKeUNncHRZV2x1WDJGZmNtOTFkR1ZBTkRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUlHRUtDZ292THlCZmNIVjVZVjlzYVdJdVlYSmpOQzV6ZEdGMGFXTmZZWEp5WVhsZmNtVmhaRjlpZVhSbFgyeGxibWQwYUY5bGJHVnRaVzUwS0dGeWNtRjVPaUJpZVhSbGN5d2dhVzVrWlhnNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNuTjBZWFJwWTE5aGNuSmhlVjl5WldGa1gySjVkR1ZmYkdWdVozUm9YMlZzWlcxbGJuUTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdYM0IxZVdGZmJHbGlMbUZ5WXpRdWMzUmhkR2xqWDJGeWNtRjVYM0psY0d4aFkyVmZZbmwwWlY5c1pXNW5kR2hmYUdWaFpDaGhjbkpoZVY5b1pXRmtYMkZ1WkY5MFlXbHNPaUJpZVhSbGN5d2dibVYzWDJsMFpXMDZJR0o1ZEdWekxDQnBibVJsZURvZ2RXbHVkRFkwTENCaGNuSmhlVjlzWlc1bmRHZzZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbk4wWVhScFkxOWhjbkpoZVY5eVpYQnNZV05sWDJKNWRHVmZiR1Z1WjNSb1gyaGxZV1E2Q2lBZ0lDQndjbTkwYnlBMElERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ29LSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJQ3NLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzAwQ2dwemRHRjBhV05mWVhKeVlYbGZjbVZ3YkdGalpWOWllWFJsWDJ4bGJtZDBhRjlvWldGa1gyWnZjbDlvWldGa1pYSkFNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnUEFvZ0lDQWdZbm9nYzNSaGRHbGpYMkZ5Y21GNVgzSmxjR3hoWTJWZllubDBaVjlzWlc1bmRHaGZhR1ZoWkY5aFpuUmxjbDltYjNKQU5Bb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlDMDBDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJR0lnYzNSaGRHbGpYMkZ5Y21GNVgzSmxjR3hoWTJWZllubDBaVjlzWlc1bmRHaGZhR1ZoWkY5bWIzSmZhR1ZoWkdWeVFESUtDbk4wWVhScFkxOWhjbkpoZVY5eVpYQnNZV05sWDJKNWRHVmZiR1Z1WjNSb1gyaGxZV1JmWVdaMFpYSmZabTl5UURRNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMM1JsYzNSekwzTnZiR2xrYVhSNUxYTmxiV0Z1ZEdsakxYUmxjM1J6TDNSbGMzUnpMMmRsZEhSbGNuTXZZWEp5WVhsekxuTnZiQzVETG1GYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBekNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LWVY5MFpYSnVZWEo1WDIxbGNtZGxRRFE2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCaElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlITjBZWFJwWTE5aGNuSmhlVjl5WldGa1gySjVkR1ZmYkdWdVozUm9YMlZzWlcxbGJuUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JuWlhSaWVYUmxDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbUZmZEdWeWJtRnllVjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdJZ1lWOTBaWEp1WVhKNVgyMWxjbWRsUURRSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WjJWMGRHVnljeTloY25KaGVYTXVjMjlzTGtNdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQWdFQUNDWUNBQUZoZ1lBZ3IwazFCVEVZUUFBNUtDT0lBSGRKSkZrakNCWlhCZ0JjQUlBQkExQW9UQ01paUFCNVNTT0lBRnhKSkZrakNCWlhCZ0JjQUlBQkJGQWpJb2dBWUNsTVp5TkRTVFVBTkFDQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNBWEVBMUFJQUVJK1U5RmpZYUFJNEJBQUVBTVJrVU1SZ1FSRUlBaVlvQ0FZdi9JZ3VML2t4WmkvNUxBVmtpQ0l2K1RnSllpWW9FQVl2K0lndUwvRXNCV1l2OFN3RlpTd0VJSWdpTC9DUlBBMUtML1ZDTC9CV0wvRThEVHdKU1VJdi9JZ3RKVGdKT0EwbExBMWxQQWt5TC9rMU9Bb3o4aXdLTEFBeEJBQ09MQVVrV1Z3WUFpL3lMQWtsT0JFOENYVW1NL0VzQldTSUlDSXdCSWdpTUFrTC8xWXY4akFDSk5ob0JTUldCSUJKRU5ob0NTUldCSUJKRU1SWkJBRHN4RmlNSk9BZ1VSQ1FwWlVRbHIwbExCRkJKRlNVSlcweExBMUJKRlNVSlcwc0JJZ3hFVGdLSS96WlhBZ0JNVlJhQUJCVWZmSFZNVUxBalF5UkMvOGM9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
