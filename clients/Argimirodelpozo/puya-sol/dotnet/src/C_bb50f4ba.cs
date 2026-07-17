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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_bb50f4ba
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
        public async Task F(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 73, 112, 199 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> F_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 73, 112, 199 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> X(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 16, 114, 175 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> X_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 16, 114, 175 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJmIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IngiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzExOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHggZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE1LDE1NV0sImVycm9yTWVzc2FnZSI6Im5vdCBwYXlhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdmIzQjBhVzFwZW1WeUwzVnVkWE5sWkY5emRHOXlaVjl6ZEc5eVlXZGxYM0psYlc5MllXeGZZblZuTG5OdmJDNURMbUZ3Y0hKdmRtRnNYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRE15SURJS0lDQWdJR0o1ZEdWallteHZZMnNnSW5naUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3YmlBeE5Bb2dJQ0FnY0hWemFHbHVkQ0EwTURrMkNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0J6ZEc5eVpTQTFDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnNiMkZrSURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3T0RBS0lDQWdJSEpsY0d4aFkyVXlJRFkwQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0o0SWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3laRFE1TnpCak55QXdlRGRqTVRBM01tRm1JQzh2SUcxbGRHaHZaQ0FpWmlncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZUNncGRXbHVkREkxTmlJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWmw5eWIzVjBaVUExSUcxaGFXNWZlRjl5YjNWMFpVQTJDaUFnSUNCbGNuSUtDbTFoYVc1ZmVGOXliM1YwWlVBMk9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhNZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNem9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5naUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhnZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRJNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRNS0NtMWhhVzVmWmw5eWIzVjBaVUExT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE53b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE9Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbmdpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMk9Rb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ1luVnllU0F4TlFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESXpPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBK0NpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qVUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF5TmpvS0lDQWdJR1JwWnlBeE5Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWRYSjVJRElLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ1Bnb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESTRDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWprNkNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWRYSjVJREVLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQ0S0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek1Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRE15T2dvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5WeWVTQXhOQW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnUGdvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURNMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNelU2Q2lBZ0lDQmthV2NnTVRRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5WeWVTQXhNd29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05Rb2dJQ0FnUGdvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURNM0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNemc2Q2lBZ0lDQmthV2NnTVRNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnUGdvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURRd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOREU2Q2lBZ0lDQmthV2NnTVRJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5WeWVTQXhNUW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ053b2dJQ0FnUGdvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURRekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBM0NncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFORFE2Q2lBZ0lDQmthV2NnTVRFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5WeWVTQXhNQW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUGdvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURRMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBNENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFORGM2Q2lBZ0lDQmthV2NnTVRBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5WeWVTQTVDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2NIVnphR2x1ZENBNUNpQWdJQ0ErQ2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTkRrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURrS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTFNRG9LSUNBZ0lHUnBaeUE1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ09Bb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJRDRLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRBS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTFNem9LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ053b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTVRFS0lDQWdJRDRLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExTlFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRFS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTFOam9LSUNBZ0lHUnBaeUEzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ05nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJRDRLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExT0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRJS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTFPVG9LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ05Rb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTVRNS0lDQWdJRDRLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRNS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTJNam9LSUNBZ0lHUnBaeUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ05Bb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTVRRS0lDQWdJRDRLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRRS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTJOVG9LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ013b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTVRVS0lDQWdJRDRLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyTndvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRVS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTJPRG9LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTNNRG9LSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNRFFLSUNBZ0lHSStDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFOeklLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjRJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBM01qb0tJQ0FnSUd4dllXUWdNQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEWTNPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTJPQW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURZME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMk5Rb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFl4T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEyTWdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEVTRPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTFPUW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURVMU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMU5nb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFV5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUExTXdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEUTVPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTFNQW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURRMk9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBME53b0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFF6T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTkFvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEUXdPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTBNUW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURNM09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBek9Bb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRE0wT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TlFvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFETXhPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXpNZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJNE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU9Rb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREkxT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF5TmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF5TXdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEWTVPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTNNQW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFM09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFNENnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdmIzQjBhVzFwZW1WeUwzVnVkWE5sWkY5emRHOXlaVjl6ZEc5eVlXZGxYM0psYlc5MllXeGZZblZuTG5OdmJDNURMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFBRWdBaVlCQVhnaVJ3NkJnQ0N2U1RVRk5RQTBBSUFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFJQmNRRFVBTVJoQUFBWW9nQUJuSTBNeEdSUkVNUmhFZ2dJRUxVbHd4d1I4RUhLdk5ob0FqZ0lBS1FBQkFERVdRUUFmTVJZakNUZ0lGRVFpS0dWRVNSVWtEa1FrcjZ1QUJCVWZmSFZNVUxBalF5SkMvK014RmtFQmhERVdJd2s0Q0JSRUl4WW9UR2N4RzBFQmJURWJRUUZoTmhvQVJROHhHeU1OUVFGUU5ob0JTdzlNVUVVQ01Sc2xEVUVCT3pZYUFrc0NURkJGQVRFYmdRTU5RUUVsTmhvRFN3Rk1VRVVPTVJ1QkJBMUJBUTgyR2dSTERreFFSUTB4RzRFRkRVRUErVFlhQlVzTlRGQkZEREViZ1FZTlFRRGpOaG9HU3d4TVVFVUxNUnVCQncxQkFNMDJHZ2RMQzB4UVJRb3hHNEVJRFVFQXR6WWFDRXNLVEZCRkNURWJnUWtOUVFDaE5ob0pTd2xNVUVVSU1SdUJDZzFCQUlzMkdncExDRXhRUlFjeEc0RUxEVUVBZFRZYUMwc0hURkJGQmpFYmdRd05RUUJmTmhvTVN3Wk1VRVVGTVJ1QkRRMUJBRWsyR2cxTEJVeFFSUVF4RzRFT0RVRUFNellhRGtzRVRGQkZBekViZ1E4TlFRQWROaG9QU3dOTVVCVVdnQUVFcFVFQUJ5VVdLRXhuSTBNMEFEVUFJME1pcjBMLzRTS3ZRdi9MSXE5Qy83VWlyMEwvbnlLdlF2K0pJcTlDLzNNaXIwTC9YU0t2UXY5SElxOUMvekVpcjBML0d5S3ZRdjhGSXE5Qy91OGlyMEwrMlNLdlF2N0RJcTlDL3E0aXIwVVBRdjZkSXE5Qy81TWlRdjUrIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
