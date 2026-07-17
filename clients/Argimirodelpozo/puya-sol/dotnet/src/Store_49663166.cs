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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.Store_49663166
{


    public class StoreProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StoreProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task PostInit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_v"> </param>
        public async Task Add(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_v, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 27, 229, 16 };

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_v }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Add_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_v, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 27, 229, 16 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_v }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_v"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Find(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_v, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 215, 110, 90 };

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_v }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Find_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_v, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 215, 110, 90 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_v }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RvcmUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiX19wb3N0SW5pdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF92IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZpbmQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF92IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDM2XSwiZXJyb3JNZXNzYWdlIjoiX19wb3N0SW5pdCBhbHJlYWR5IGNhbGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4OCw1NzJdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxNV0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzIsMjQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NSwyNTNdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMl0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM5LDYxNF0sImVycm9yTWVzc2FnZSI6InVuZGVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WVhKeVlYa3ZjM1J2Y21GblpWOWhjbkpoZVY5eVpXWXVjMjlzTGxOMGIzSmxMbUZ3Y0hKdmRtRnNYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ016SWdNaUF3SURFS0lDQWdJR0o1ZEdWallteHZZMnNnSW1SaGRHRWlJREI0TURFZ01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFnSWw5ZlkzUnZjbDl3Wlc1a2FXNW5JZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2NIVnphR2x1ZENBME1EazJDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCemRHOXlaU0ExQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JzYjJGa0lEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd09EQUtJQ0FnSUhKbGNHeGhZMlV5SURZMENpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaVlXTmpORGxsTXlBd2VEaGxNV0psTlRFd0lEQjRPRFZrTnpabE5XRWdMeThnYldWMGFHOWtJQ0pmWDNCdmMzUkpibWwwS0NsMmIybGtJaXdnYldWMGFHOWtJQ0poWkdRb2RXbHVkREkxTmlsMmIybGtJaXdnYldWMGFHOWtJQ0ptYVc1a0tIVnBiblF5TlRZcGRXbHVkREkxTmlJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWDE5d2IzTjBTVzVwZEY5eWIzVjBaVUExSUcxaGFXNWZZV1JrWDNKdmRYUmxRRFlnYldGcGJsOW1hVzVrWDNKdmRYUmxRRGNLSUNBZ0lHVnljZ29LYldGcGJsOW1hVzVrWDNKdmRYUmxRRGM2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TkRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaR0YwWVNJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHTmhiR3h6ZFdJZ1ptbHVaQ2d5TXl4MU1qVTJMSFV5TlRZc2RUSTFOaWtLSUNBZ0lIQnZjQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV6T2dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREUwQ2dwdFlXbHVYMkZrWkY5eWIzVjBaVUEyT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURRS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRnS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRrNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVJoZEdFaUNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmtZWFJoSWdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnY0c5d0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVJoZEdFaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNtVnphWHBsQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWkdGMFlTSUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmtZWFJoSWdvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSnZlRjl6Y0d4cFkyVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltUmhkR0VpQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQStQUW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREl4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0prWVhSaElnb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ2NHOXdDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpJNkNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdkNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERUtJQ0FnSUdJK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUhWdVpHVnlabXh2ZHdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNCaWVtVnlid29nSUNBZ1luVnllU0F5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0prWVhSaElnb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ2NHOXdDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnUGowS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU5Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpHRjBZU0lLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJSEJ2Y0FvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESTFPZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVFvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltUmhkR0VpQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQStQUW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREkzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0prWVhSaElnb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ2NHOXdDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpnNkNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdkNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0F0Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1SaGRHRWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dOQW9nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlOem9LSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXlPQW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJME9nb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURJMUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNakU2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNaklLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE9Eb0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE9Rb0tiV0ZwYmw5ZlgzQnZjM1JKYm1sMFgzSnZkWFJsUURVNkNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdYMTl3YjNOMFNXNXBkQ0JoYkhKbFlXUjVJR05oYkd4bFpBb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVgxOWpkRzl5WDNCbGJtUnBibWNpQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVJoZEdFaUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDNSbGMzUnpMM052Ykdsa2FYUjVMWE5sYldGdWRHbGpMWFJsYzNSekwzUmxjM1J6TDJGeWNtRjVMM04wYjNKaFoyVmZZWEp5WVhsZmNtVm1Mbk52YkM1VGRHOXlaUzVtYVc1a0tESXpMSFV5TlRZc2RUSTFOaXgxTWpVMktTaGZaR0YwWVRvZ1lubDBaWE1zSUY5aVpXZHBiam9nWW5sMFpYTXNJRjlzWlc0NklHSjVkR1Z6TENCZmRtRnNkV1U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTTZDbVpwYm1Rb01qTXNkVEkxTml4MU1qVTJMSFV5TlRZcE9nb2dJQ0FnY0hKdmRHOGdOQ0F5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlQW9nSUNBZ1lqMDlDaUFnSUNCaWJub2dabWx1WkNneU15eDFNalUyTEhVeU5UWXNkVEkxTmlsZmFXWmZZbTlrZVVBekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWWowOUNpQWdJQ0JpZWlCbWFXNWtLREl6TEhVeU5UWXNkVEkxTml4MU1qVTJLVjloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUlUMEtJQ0FnSUdKNklHWnBibVFvTWpNc2RUSTFOaXgxTWpVMkxIVXlOVFlwWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9LWm1sdVpDZ3lNeXgxTWpVMkxIVXlOVFlzZFRJMU5pbGZhV1pmWW05a2VVQXpPZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BtYVc1a0tESXpMSFV5TlRZc2RUSTFOaXgxTWpVMktWOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBeUNpQWdJQ0JpTHdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlLd29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSStDaUFnSUNCaWVpQm1hVzVrS0RJekxIVXlOVFlzZFRJMU5peDFNalUyS1Y5bGJITmxYMkp2WkhsQU9Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1ptbHVaQ2d5TXl4MU1qVTJMSFV5TlRZc2RUSTFOaWtLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXROQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWm1sdVpDZ3lNeXgxTWpVMkxIVXlOVFlzZFRJMU5pbGZaV3h6WlY5aWIyUjVRRGc2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaVBnb2dJQ0FnWW5vZ1ptbHVaQ2d5TXl4MU1qVTJMSFV5TlRZc2RUSTFOaWxmWld4elpWOWliMlI1UURFeUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFS0lDQWdJR0krUFFvZ0lDQWdZWE56WlhKMElDOHZJSFZ1WkdWeVpteHZkd29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNUW9nSUNBZ1lpc0tJQ0FnSUhOM1lYQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1ptbHVaQ2d5TXl4MU1qVTJMSFV5TlRZc2RUSTFOaWtLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXROQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWm1sdVpDZ3lNeXgxTWpVMkxIVXlOVFlzZFRJMU5pbGZaV3h6WlY5aWIyUjVRREV5T2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZZWEp5WVhrdmMzUnZjbUZuWlY5aGNuSmhlVjl5WldZdWMyOXNMbE4wYjNKbExtTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFSUFJQUFTWUVCR1JoZEdFQkFTRUJBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBT1gxOWpkRzl5WDNCbGJtUnBibWNrUndLQmdDQ3ZTVFVGTlFBMEFJQWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlCY1FEVUFNUmhBQUFVckpXY2xRekVaRkVReEdFU0NBd1M2ekVuakJJNGI1UkFFaGRkdVdqWWFBSTREQVJBQVJRQUJBRFlhQVVsRkJCVWlFa1F4RmtFQU1URVdKUWs0Q0JSRUtMNkFBZ0FBVGdKTkpCWkxBU1JaRmtzRmlBRHZTRWtWSWc1RUlxK3JnQVFWSDN4MVRGQ3dKVU1rUXYvUk5ob0JTVVVFRlNJU1JERVdRUUM0TVJZbENUZ0lGRVFvSkNPNkZ5aTlTQ0lJS0V6VFNTVUlGbGNHQWlna1R3SzdJZ3NqQ0NoTUpJQWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFEU0tMMUlJdzlCQUdFb3ZVZ2pDU0lLRmltblJJRUlyMFVDS0wxSUl3OUJBRVVvdlVnakNTSUtGaXFnS2FFcXFrc0NURkJGQVNpOVNDTVBRUUFsS0wxSUl3a2lDaFlxb0NtaEtxcExBa3hRRllFSUNVc0JURnNpQ3lNSUtFeExCTHNsUXlOQy85b2pRdis2STBML25pUkMvMG9yWkVRckpHY29JN2xJSlVPS0JBSWtSd0tML29BQXFFQUFJNHYrS2FoQkFFV0JDSytML1ZCSkZZRUlDVnVML0ZjQ0FFd2lDeUpZaS8rcFFRQXBnQ0QvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy80djhqQUdNQUltTC9vQUJBcUpKakFDQkNLK0wvVThDb0VtTUFWQkpGWUVJQ1Z1TC9GY0NBRXdpQ3lKWVNZd0NpLytsUVFBVGkveUwvWXNBaS8rSS8yMUpqUHlNQVl3QWlZdi9pd0tsUVFBaWl3QkpLYWRFaXdFcG9Fd3FvQ21oS3FxTC9FNENpLytJLzBOSmpQeU1BWXdBaVlzQmkveU1BWXdBaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
