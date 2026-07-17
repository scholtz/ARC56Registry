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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_40909960
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
        public async Task FillArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 191, 1, 153 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FillArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 191, 1, 153 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ClearArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 48, 144, 175 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClearArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 48, 144, 175 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong[]> X(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 30, 25, 68 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(40, "uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> X_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 30, 25, 68 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJmaWxsQXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xlYXJBcnJheSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ4IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFs0MF0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMjksMTkyLDQ5Nl0sImVycm9yTWVzc2FnZSI6Im5vdCBwYXlhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZjM1J2Y21GblpTOXpkRzl5WVdkbFgySnZkVzVrWVhKNVgzQmhZMnRsWkY5aGNuSmhlUzV6YjJ3dVF5NWhjSEJ5YjNaaGJGOXdjbTluY21GdEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURFZ016SWdNQ0F5TkFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZUNBaVgxOWtlVzVmYzNSdmNtRm5aU0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJaUlLSUNBZ0lIQjFjMmhwYm5RZ05EQTVOZ29nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ2MzUnZjbVVnTlFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnYkc5aFpDQXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EZ3dDaUFnSUNCeVpYQnNZV05sTWlBMk5Bb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd5WW1KbU1ERTVPU0F3ZURrMk16QTVNR0ZtSURCNFpXTXhaVEU1TkRRZ0x5OGdiV1YwYUc5a0lDSm1hV3hzUVhKeVlYa29LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTnNaV0Z5UVhKeVlYa29LWFp2YVdRaUxDQnRaWFJvYjJRZ0luZ29LWFZwYm5RMk5GczBNRjBpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMlpwYkd4QmNuSmhlVjl5YjNWMFpVQTFJRzFoYVc1ZlkyeGxZWEpCY25KaGVWOXliM1YwWlVBMklHMWhhVzVmZUY5eWIzVjBaVUEzQ2lBZ0lDQmxjbklLQ20xaGFXNWZlRjl5YjNWMFpVQTNPZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TkRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNalFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTRPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ016SXdDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGNHeGhZMlV5SURZMENpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCc2IyRmtJREFLSUNBZ0lITjBiM0psSURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5ZlpIbHVYM04wYjNKaFoyVWlDaUFnSUNCd2RYTm9hVzUwSURneE9USUtJQ0FnSUdKdmVGOWpjbVZoZEdVS0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDE5a2VXNWZjM1J2Y21GblpTSUtJQ0FnSUhCMWMyaHBiblFnT0RBek1nb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UTTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UUUtDbTFoYVc1ZlkyeGxZWEpCY25KaGVWOXliM1YwWlVBMk9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhPQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhPVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnYkc5aFpDQXdDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQndkWE5vYVc1MElERTRORFEyTnpRME1EY3pOekE1TlRVeE5qRXhDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ2NIVnphR2x1ZENBeE9EUTBOamMwTkRBM016Y3dPVFUxTVRZeE1nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWTJGc2JITjFZaUJmWDNOMGIzSmhaMlZmZDNKcGRHVUtJQ0FnSUhCMWMyaHBiblFnTVRnME5EWTNORFF3TnpNM01EazFOVEUyTVRNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdYMTl6ZEc5eVlXZGxYM2R5YVhSbENpQWdJQ0J3ZFhOb2FXNTBJREU0TkRRMk56UTBNRGN6TnpBNU5UVXhOakUwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpZV3hzYzNWaUlGOWZjM1J2Y21GblpWOTNjbWwwWlFvZ0lDQWdjSFZ6YUdsdWRDQXhPRFEwTmpjME5EQTNNemN3T1RVMU1UWXhOUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyRnNiSE4xWWlCZlgzTjBiM0poWjJWZmQzSnBkR1VLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdOaGJHeHpkV0lnWDE5emRHOXlZV2RsWDNkeWFYUmxDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdYMTl6ZEc5eVlXZGxYM2R5YVhSbENpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdOaGJHeHpkV0lnWDE5emRHOXlZV2RsWDNkeWFYUmxDaUFnSUNCd2RYTm9hVzUwSURVS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdYMTl6ZEc5eVlXZGxYM2R5YVhSbENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQndkWE5vYVc1MElEY0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdOaGJHeHpkV0lnWDE5emRHOXlZV2RsWDNkeWFYUmxDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdYMTl6ZEc5eVlXZGxYM2R5YVhSbENpQWdJQ0J3ZFhOb2FXNTBJRGtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ2NIVnphR2x1ZENBeE1Rb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWTJGc2JITjFZaUJmWDNOMGIzSmhaMlZmZDNKcGRHVUtJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdYMTl6ZEc5eVlXZGxYM2R5YVhSbENpQWdJQ0J3ZFhOb2FXNTBJREV6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpZV3hzYzNWaUlGOWZjM1J2Y21GblpWOTNjbWwwWlFvZ0lDQWdjSFZ6YUdsdWRDQXhOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyRnNiSE4xWWlCZlgzTjBiM0poWjJWZmQzSnBkR1VLSUNBZ0lIQjFjMmhwYm5RZ01UVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdOaGJHeHpkV0lnWDE5emRHOXlZV2RsWDNkeWFYUmxDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqWVd4c2MzVmlJRjlmYzNSdmNtRm5aVjkzY21sMFpRb2dJQ0FnY0hWemFHbHVkQ0F4TndvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZMkZzYkhOMVlpQmZYM04wYjNKaFoyVmZkM0pwZEdVS0lDQWdJSEIxYzJocGJuUWdNVGdLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQndkWE5vYVc1MElERTVDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ2NIVnphR2x1ZENBeU1Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWTJGc2JITjFZaUJmWDNOMGIzSmhaMlZmZDNKcGRHVUtJQ0FnSUhCMWMyaHBiblFnTWpFS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdYMTl6ZEc5eVlXZGxYM2R5YVhSbENpQWdJQ0J3ZFhOb2FXNTBJREl5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpZV3hzYzNWaUlGOWZjM1J2Y21GblpWOTNjbWwwWlFvZ0lDQWdjSFZ6YUdsdWRDQXlNd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyRnNiSE4xWWlCZlgzTjBiM0poWjJWZmQzSnBkR1VLSUNBZ0lHbHVkR05mTXlBdkx5QXlOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyRnNiSE4xWWlCZlgzTjBiM0poWjJWZmQzSnBkR1VLSUNBZ0lIQjFjMmhwYm5RZ01qVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdOaGJHeHpkV0lnWDE5emRHOXlZV2RsWDNkeWFYUmxDaUFnSUNCd2RYTm9hVzUwSURJMkNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqWVd4c2MzVmlJRjlmYzNSdmNtRm5aVjkzY21sMFpRb2dJQ0FnY0hWemFHbHVkQ0F5TndvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZMkZzYkhOMVlpQmZYM04wYjNKaFoyVmZkM0pwZEdVS0lDQWdJSEIxYzJocGJuUWdNamdLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQndkWE5vYVc1MElESTVDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ2NIVnphR2x1ZENBek1Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWTJGc2JITjFZaUJmWDNOMGIzSmhaMlZmZDNKcGRHVUtJQ0FnSUhCMWMyaHBiblFnTXpFS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdYMTl6ZEc5eVlXZGxYM2R5YVhSbENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdYMTl6ZEc5eVlXZGxYM2R5YVhSbENpQWdJQ0J3ZFhOb2FXNTBJRE16Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpZV3hzYzNWaUlGOWZjM1J2Y21GblpWOTNjbWwwWlFvZ0lDQWdjSFZ6YUdsdWRDQXpOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyRnNiSE4xWWlCZlgzTjBiM0poWjJWZmQzSnBkR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE9Eb0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE9Rb0tiV0ZwYmw5bWFXeHNRWEp5WVhsZmNtOTFkR1ZBTlRvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qTUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qUTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdKMWNua2dNUW9LYldGcGJsOTNhR2xzWlY5MGIzQkFNalU2Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05EQUtJQ0FnSUR3S0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmQyaHBiR1ZBTWpjS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlnb2dJQ0FnWWlzS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJmWDNOMGIzSmhaMlZmZDNKcGRHVUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnYldGcGJsOTNhR2xzWlY5MGIzQkFNalVLQ20xaGFXNWZZV1owWlhKZmQyaHBiR1ZBTWpjNkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNak02Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNalFLQ2dvdkx5QmZYM0IxZVdGemIyeGZYMTl6ZEc5eVlXZGxYM2R5YVhSbEtGOWZjMnh2ZERvZ2RXbHVkRFkwTENCZlgzWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWDE5emRHOXlZV2RsWDNkeWFYUmxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZlgyUjVibDl6ZEc5eVlXZGxJZ29nSUNBZ2NIVnphR2x1ZENBNE1Ua3lDaUFnSUNCaWIzaGZZM0psWVhSbENpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdsdWRDQXlOVFlLSUNBZ0lDVUtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDlmWkhsdVgzTjBiM0poWjJVaUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZjM1J2Y21GblpTOXpkRzl5WVdkbFgySnZkVzVrWVhKNVgzQmhZMnRsWkY5aGNuSmhlUzV6YjJ3dVF5NWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQVNBQUdDWUNBQTFmWDJSNWJsOXpkRzl5WVdkbEtJR0FJSzlKTlFVMUFEUUFnQ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWdGeEFOUUF4R0VBQUFpSkRNUmtVUkRFWVJJSURCQ3UvQVprRWxqQ1Fyd1RzSGhsRU5ob0FqZ01CY0FCQUFBRUFNUlpCQURZeEZpSUpPQWdVUkRRQUphOUxBWUZZVzRIQUFnZ1dVRnhBTlFBMEFEVUFLWUdBUUxsSUtZSGdQaU82Z0FRVkgzeDFURkN3SWtNa1F2L01NUlpCQVNjeEZpSUpPQWdVUkRRQU5RQ0IrLy8vLy8vLy8vLy9BU2lJQVdtQi9QLy8vLy8vLy8vL0FTaUlBVnFCL2YvLy8vLy8vLy8vQVNpSUFVdUIvdi8vLy8vLy8vLy9BU2lJQVR5Qi8vLy8vLy8vLy8vL0FTaUlBUzBrS0lnQktDSW9pQUVqZ1FJb2lBRWRnUU1vaUFFWGdRUW9pQUVSZ1FVb2lBRUxnUVlvaUFFRmdRY29pQUQvZ1Fnb2lBRDVnUWtvaUFEemdRb29pQUR0Z1Fzb2lBRG5nUXdvaUFEaGdRMG9pQURiZ1E0b2lBRFZnUThvaUFEUGdSQW9pQURKZ1JFb2lBRERnUklvaUFDOWdSTW9pQUMzZ1JRb2lBQ3hnUlVvaUFDcmdSWW9pQUNsZ1Jjb2lBQ2ZKU2lJQUpxQkdTaUlBSlNCR2lpSUFJNkJHeWlJQUlpQkhDaUlBSUtCSFNpSUFIeUJIaWlJQUhhQkh5aUlBSEFqS0lnQWE0RWhLSWdBWllFaUtJZ0FYeUpESkVMKzJ6RVdRUUJRTVJZaUNUZ0lGRVEwQURVQUlrVUJTWUVvREVFQU9FY0NGb0FnLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vdWdTUldCQ0FsYlN3R0lBQTBpQ0VVQlF2L0JJa01rUXYreWlnSUFLWUdBUUxsSWkvNkJnQUlZSXdzanI0di9VRWtWSXdraldDbE9BcnVKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
