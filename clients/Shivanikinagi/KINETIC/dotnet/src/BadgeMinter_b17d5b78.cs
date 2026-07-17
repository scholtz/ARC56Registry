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

namespace Arc56.Generated.Shivanikinagi.KINETIC.BadgeMinter_b17d5b78
{


    public class BadgeMinterProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BadgeMinterProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="campus_id"> </param>
        public async Task<ulong> MintBadge(Algorand.Address recipient, byte[] campus_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 22, 225, 85 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var campus_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); campus_idAbi.From(campus_id);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, campus_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MintBadge_Transactions(Algorand.Address recipient, byte[] campus_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 22, 225, 85 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var campus_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); campus_idAbi.From(campus_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, campus_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="holder"> </param>
        public async Task<ulong> VerifyBadge(Algorand.Address holder, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 219, 17, 50 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);

            var result = await base.SimApp(new List<object> { abiHandle, holderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyBadge_Transactions(Algorand.Address holder, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 219, 17, 50 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);

            return await base.MakeTransactionList(new List<object> { abiHandle, holderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="holder"> </param>
        public async Task RevokeBadge(Algorand.Address holder, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 111, 187, 57 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);

            var result = await base.CallApp(new List<object> { abiHandle, holderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeBadge_Transactions(Algorand.Address holder, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 111, 187, 57 };
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);

            return await base.MakeTransactionList(new List<object> { abiHandle, holderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmFkZ2VNaW50ZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6eyJjdXJyZW50Ijp7ImFwcElEIjo3NTg4MTM1NjJ9fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJtaW50X2JhZGdlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbXB1c19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9iYWRnZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9sZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VfYmFkZ2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhvbGRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI3NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYmFkZ2VfaG9sZGVycyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX21pbnRlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTNdLCJlcnJvck1lc3NhZ2UiOiJob2xkZXIgaGFzIG5vIGJhZGdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4LDI1MywyOThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4XSwiZXJyb3JNZXNzYWdlIjoib25seSBhZG1pbiBjYW4gbWludCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNF0sImVycm9yTWVzc2FnZSI6Im9ubHkgYWRtaW4gY2FuIHJldm9rZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTXpJZ01UQXdNQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlRGMwTm1ZM05EWXhObU0xWmpaa05qazJaVGMwTmpVMk5DQXdlRFl5TmpFMk5EWTNOalVnTUhneE5URm1OMk0zTlFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkpoWkdkbExuQjVPamNLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYldsdWRHVmtJRDBnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwS0RBcExDQnJaWGs5WWlKMGIzUmhiRjl0YVc1MFpXUWlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRGMwTm1ZM05EWXhObU0xWmpaa05qazJaVGMwTmpVMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpWVdSblpTNXdlVG8wQ2lBZ0lDQXZMeUJqYkdGemN5QkNZV1JuWlUxcGJuUmxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVElLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR0poTVRabE1UVTFJREI0TjJaa1lqRXhNeklnTUhnM05UWm1ZbUl6T1NBdkx5QnRaWFJvYjJRZ0ltMXBiblJmWW1Ga1oyVW9ZV1JrY21WemN5eGllWFJsVzEwcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxmWW1Ga1oyVW9ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luSmxkbTlyWlY5aVlXUm5aU2hoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRhVzUwWDJKaFpHZGxJSFpsY21sbWVWOWlZV1JuWlNCeVpYWnZhMlZmWW1Ga1oyVUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TWpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TG1KaFpHZGxMa0poWkdkbFRXbHVkR1Z5TG0xcGJuUmZZbUZrWjJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHRhVzUwWDJKaFpHZGxPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkpoWkdkbExuQjVPamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkpoWkdkbExuQjVPakV4Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQ0FpYjI1c2VTQmhaRzFwYmlCallXNGdiV2x1ZENJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVJR0ZrYldsdUlHTmhiaUJ0YVc1MENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlltRmtaMlV1Y0hrNk1UTUtJQ0FnSUM4dklHRnpjMlYwWDI1aGJXVWdQU0JpSWtOaGJYQjFjMEpoWkdkbExTSWdLeUJqWVcxd2RYTmZhV1F1WW5sMFpYTUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUXpOakUyWkRjd056VTNNelF5TmpFMk5EWTNOalV5WkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlltRmtaMlV1Y0hrNk1UUXRNallLSUNBZ0lDOHZJRzFwYm5SbFpDQTlJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNneE1EQXdLU3dLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDFWU1c1ME5qUW9NU2tzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR1JsWm1GMWJIUmZabkp2ZW1WdVBWUnlkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1kyeGhkMkpoWTJzOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQnRZVzVoWjJWeVBVZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WelpYSjJaVDFIYkc5aVlXd3VlbVZ5YjE5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlQxSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhSZmJtRnRaVDFpSWtKQlJFZEZJaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl1WVcxbFBXRnpjMlYwWDI1aGJXVXNDaUFnSUNBdkx5QWdJQ0FnZFhKc1BXSWlhWEJtY3pvdkwySmhabmxpWldsallXMXdkWE5pWVdSblpXMWxkR0ZrWVhSaElpd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aVlXUm5aUzV3ZVRveE9Rb2dJQ0FnTHk4Z1kyeGhkMkpoWTJzOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlltRmtaMlV1Y0hrNk1qQUtJQ0FnSUM4dklHMWhibUZuWlhJOVIyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKaFpHZGxMbkI1T2pJeExUSXlDaUFnSUNBdkx5QnlaWE5sY25abFBVZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTXNDaUFnSUNBdkx5Qm1jbVZsZW1VOVIyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5d0tJQ0FnSUdSMWNHNGdNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkpoWkdkbExuQjVPakkxQ2lBZ0lDQXZMeUIxY213OVlpSnBjR1p6T2k4dlltRm1lV0psYVdOaGJYQjFjMkpoWkdkbGJXVjBZV1JoZEdFaUxBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5qazNNRFkyTnpNellUSm1NbVkyTWpZeE5qWTNPVFl5TmpVMk9UWXpOakUyWkRjd056VTNNell5TmpFMk5EWTNOalUyWkRZMU56UTJNVFkwTmpFM05EWXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWVkpNQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk9ZVzFsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW1Ga1oyVXVjSGs2TWpNS0lDQWdJQzh2SUhWdWFYUmZibUZ0WlQxaUlrSkJSRWRGSWl3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURReU5ERTBORFEzTkRVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVmJtbDBUbUZ0WlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVaeVpXVjZaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRkpsYzJWeWRtVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk5ZVzVoWjJWeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFEyeGhkMkpoWTJzS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aVlXUm5aUzV3ZVRveE9Bb2dJQ0FnTHk4Z1pHVm1ZWFZzZEY5bWNtOTZaVzQ5VkhKMVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFJHVm1ZWFZzZEVaeWIzcGxiZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkpoWkdkbExuQjVPakUzQ2lBZ0lDQXZMeUJrWldOcGJXRnNjejFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVJsWTJsdFlXeHpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbUZrWjJVdWNIazZNVFlLSUNBZ0lDOHZJSFJ2ZEdGc1BWVkpiblEyTkNneEtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZHOTBZV3dLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpWVdSblpTNXdlVG94TkFvZ0lDQWdMeThnYldsdWRHVmtJRDBnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lIQjFjMmhwYm5RZ015QXZMeUJoWTJabkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW1Ga1oyVXVjSGs2TVRVS0lDQWdJQzh2SUdabFpUMVZTVzUwTmpRb01UQXdNQ2tzQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aVlXUm5aUzV3ZVRveE5DMHlOZ29nSUNBZ0x5OGdiV2x1ZEdWa0lEMGdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUM4dklDQWdJQ0JtWldVOVZVbHVkRFkwS0RFd01EQXBMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNQVlZKYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3oxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVZISjFaU3dLSUNBZ0lDOHZJQ0FnSUNCamJHRjNZbUZqYXoxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJOVIyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxQVWRzYjJKaGJDNTZaWEp2WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1puSmxaWHBsUFVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEY5dVlXMWxQV0lpUWtGRVIwVWlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOVlYTnpaWFJmYm1GdFpTd0tJQ0FnSUM4dklDQWdJQ0IxY213OVlpSnBjR1p6T2k4dlltRm1lV0psYVdOaGJYQjFjMkpoWkdkbGJXVjBZV1JoZEdFaUxBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1EzSmxZWFJsWkVGemMyVjBTVVFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpWVdSblpTNXdlVG95T1FvZ0lDQWdMeThnYzJWc1ppNWlZV1JuWlY5b2IyeGtaWEp6VzNKbFkybHdhV1Z1ZEYwZ1BTQmhjM05sZEY5cFpBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEWXlOakUyTkRZM05qVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkpoWkdkbExuQjVPak13Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDIxcGJuUmxaQzUyWVd4MVpTQTlJSE5sYkdZdWRHOTBZV3hmYldsdWRHVmtMblpoYkhWbElDc2dWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEYzBObVkzTkRZeE5tTTFaalprTmprMlpUYzBOalUyTkFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDIxcGJuUmxaQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TnpRMlpqYzBOakUyWXpWbU5tUTJPVFpsTnpRMk5UWTBDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkpoWkdkbExuQjVPamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k1aVlXUm5aUzVDWVdSblpVMXBiblJsY2k1MlpYSnBabmxmWW1Ga1oyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWlhKcFpubGZZbUZrWjJVNkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aVlXUm5aUzV3ZVRvek13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWlZV1JuWlM1d2VUb3pOUW9nSUNBZ0x5OGdhV1lnYUc5c1pHVnlJRzV2ZENCcGJpQnpaV3htTG1KaFpHZGxYMmh2YkdSbGNuTTZDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROakkyTVRZME5qYzJOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklIWmxjbWxtZVY5aVlXUm5aVjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWlZV1JuWlM1d2VUb3pOZ29nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NuWmxjbWxtZVY5aVlXUm5aVjloWm5SbGNsOXBibXhwYm1Wa1gyTnZiblJ5WVdOMGN5NWlZV1JuWlM1Q1lXUm5aVTFwYm5SbGNpNTJaWEpwWm5sZlltRmtaMlZBTmpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aVlXUm5aUzV3ZVRvek13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3AyWlhKcFpubGZZbUZrWjJWZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKaFpHZGxMbkI1T2pNM0NpQWdJQ0F2THlCaGMyRmZhV1FnUFNCelpXeG1MbUpoWkdkbFgyaHZiR1JsY25OYmFHOXNaR1Z5WFFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aVlXUm5aVjlvYjJ4a1pYSnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aVlXUm5aUzV3ZVRvek9Bb2dJQ0FnTHk4Z2FXWWdZWE5oWDJsa0lEMDlJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHSnVlaUIyWlhKcFpubGZZbUZrWjJWZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW1Ga1oyVXVjSGs2TXprS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbUZrWjJVdWNIazZNek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUIyWlhKcFpubGZZbUZrWjJWZllXWjBaWEpmYVc1c2FXNWxaRjlqYjI1MGNtRmpkSE11WW1Ga1oyVXVRbUZrWjJWTmFXNTBaWEl1ZG1WeWFXWjVYMkpoWkdkbFFEWUtDblpsY21sbWVWOWlZV1JuWlY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKaFpHZGxMbkI1T2pNekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdJZ2RtVnlhV1o1WDJKaFpHZGxYMkZtZEdWeVgybHViR2x1WldSZlkyOXVkSEpoWTNSekxtSmhaR2RsTGtKaFpHZGxUV2x1ZEdWeUxuWmxjbWxtZVY5aVlXUm5aVUEyQ2dvS0x5OGdZMjl1ZEhKaFkzUnpMbUpoWkdkbExrSmhaR2RsVFdsdWRHVnlMbkpsZG05clpWOWlZV1JuWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxkbTlyWlY5aVlXUm5aVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpWVdSblpTNXdlVG8wTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWlZV1JuWlM1d2VUbzBOQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d2dJbTl1YkhrZ1lXUnRhVzRnWTJGdUlISmxkbTlyWlNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVJR0ZrYldsdUlHTmhiaUJ5WlhadmEyVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWlZV1JuWlM1d2VUbzBOUW9nSUNBZ0x5OGdZWE56WlhKMElHaHZiR1JsY2lCcGJpQnpaV3htTG1KaFpHZGxYMmh2YkdSbGNuTXNJQ0pvYjJ4a1pYSWdhR0Z6SUc1dklHSmhaR2RsSWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURZeU5qRTJORFkzTmpVS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdhRzlzWkdWeUlHaGhjeUJ1YnlCaVlXUm5aUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkpoWkdkbExuQjVPalEzQ2lBZ0lDQXZMeUJoYzNObGRGOXBaQ0E5SUhObGJHWXVZbUZrWjJWZmFHOXNaR1Z5YzF0b2IyeGtaWEpkQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKaFpHZGxMbkI1T2pRNUxUVTFDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNneE1EQXdLU3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwWDJsa0xBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFZWSmJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5elpXNWtaWEk5YUc5c1pHVnlMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySmhaR2RsTG5CNU9qVXlDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZObGJtUmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkpoWkdkbExuQjVPalV6Q2lBZ0lDQXZMeUJoYzNObGRGOWhiVzkxYm5ROVZVbHVkRFkwS0RFcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aVlXUm5aUzV3ZVRvME9Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbUZrWjJVdWNIazZOVEFLSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTVRBd01Da3NDaUFnSUNCcGJuUmpYek1nTHk4Z01UQXdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpWVdSblpTNXdlVG8wT1MwMU5Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTVRBd01Da3NDaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxaGMzTmxkRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFWU1c1ME5qUW9NU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYzJWdVpHVnlQV2h2YkdSbGNpd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlltRmtaMlV1Y0hrNk5UY0tJQ0FnSUM4dklHUmxiQ0J6Wld4bUxtSmhaR2RsWDJodmJHUmxjbk5iYUc5c1pHVnlYUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW1Ga1oyVXVjSGs2TkRJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQWc2QWNtQXd4MGIzUmhiRjl0YVc1MFpXUUZZbUZrWjJVRUZSOThkVEVZUUFBREtDTm5NUnRCQUNReEdSUkVNUmhFZ2dNRXVoYmhWUVIvMnhFeUJIVnZ1emsyR2dDT0F3QUpBS0lBMFFBeEdSUXhHQlFRUXpZYUFVa1ZKQkpFTmhvQ1NTTlpnUUlJU3dFVkVrUXhBRElKRWtTQURFTmhiWEIxYzBKaFpHZGxMVXhRc1RJS01nTkhBb0FoYVhCbWN6b3ZMMkpoWm5saVpXbGpZVzF3ZFhOaVlXUm5aVzFsZEdGa1lYUmhzaWRQQkxJbWdBVkNRVVJIUmJJbHNpdXlLcklwc2l3aXNpUWpzaU1pc2lLQkE3SVFKYklCczdROEtVOENVRXdXVEVzQnZ5TW9aVVFpQ0NoTVp5cE1VTEFpUTRBQU5ob0JTUlVrRWtRcFRGQkp2VVVCUUFBSUl4WXFURkN3SWtOSnZrUVhTVVVEUUFBRUkwTC82MHNCUXYvbU5ob0JTUlVrRWtReEFESUpFa1FwU3dGUVNiMUZBVVJKdmtnWHNUSUtUd095RXlLeUVySVVzaEdCQkxJUUpiSUJzN3hJSWtNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
