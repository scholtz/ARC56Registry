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

namespace Arc56.Generated.AndaruHP.algorand_smart_contract.bank_app_82a99cc2
{


    public class bank_appProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public bank_appProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrPay"> </param>
        public async Task<ulong> Deposit(PaymentTransaction mbrPay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 50, 152, 231, 192 };

            var result = await base.CallApp(new List<object> { abiHandle, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction mbrPay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 50, 152, 231, 192 };

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<ulong> Withdraw(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 33, 65, 118 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 33, 65, 118 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetMyBalance(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 180, 80, 214 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMyBalance_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 180, 80, 214 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiYmFua19hcHAiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiZGVwb3NpdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRNeUJhbGFuY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIzOV0sImVycm9yTWVzc2FnZSI6IkNhbid0IHdpdGhkcmF3IG1vcmUgdGhhbiBkZXBvc2l0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzldLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIHJlY2VpdmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM1XSwiZXJyb3JNZXNzYWdlIjoiTm8gRGVwb3NpdCBGb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExM10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMyXSwiZXJyb3JNZXNzYWdlIjoiU2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk2XSwiZXJyb3JNZXNzYWdlIjoiWW91J3ZlIG5vdCBiZWVuIGRlcG9zaXRlZCBiZWZvcmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDNdLCJlcnJvck1lc3NhZ2UiOiJaZXJvIEFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NSwyNjFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2RlcG9zaXRlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3VzZXJzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NSwxOTcsMjc0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi51c2VyX2JhbGFuY2VzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0luVnpaWEpmWW1Gc1lXNWpaWE1pSUNKMGIzUmhiRjlrWlhCdmMybDBaV1FpSUNKMGIzUmhiRjkxYzJWeWN5SWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtdGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qY3RPQW9nSUNBZ0x5OGdJeUJIYkc5aVlXd2djM1J2Y21GblpRb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOWtaWEJ2YzJsMFpXUWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjlrWlhCdmMybDBaV1FpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZVzVyWDJGd2NDOWpiMjUwY21GamRDNXdlVG81Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNWelpYSnpJRDBnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwS0RBcEtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmZFhObGNuTWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm10ZllYQndMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJR0poYm10ZllYQndLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhNZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd6TWprNFpUZGpNQ0F3ZURNeE1qRTBNVGMySURCNE5EQmlORFV3WkRZZ0x5OGdiV1YwYUc5a0lDSmtaWEJ2YzJsMEtIQmhlU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNLSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRTE1UW1Gc1lXNWpaU2dwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWkdWd2IzTnBkQ0IzYVhSb1pISmhkeUJuWlhSTmVVSmhiR0Z1WTJVS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhNam9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBZ0ppWWdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1KaGJtdGZZWEJ3TG1OdmJuUnlZV04wTG1KaGJtdGZZWEJ3TG1SbGNHOXphWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pYQnZjMmwwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm10ZllYQndMMk52Ym5SeVlXTjBMbkI1T2pFMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZVzVyWDJGd2NDOWpiMjUwY21GamRDNXdlVG94TmkweE53b2dJQ0FnTHk4Z0l5QlFZWGx0Wlc1MElFTm9aV05yQ2lBZ0lDQXZMeUJoYzNObGNuUWdiV0p5VUdGNUxuTmxibVJsY2lBOVBTQlVlRzR1YzJWdVpHVnlMQ0FpVTJWdVpHVnlJRzFwYzIxaGRHTm9JZ29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMlZ1WkdWeUlHMXBjMjFoZEdOb0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWExOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCdFluSlFZWGt1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3Z0lrbHVkbUZzYVdRZ2NtVmpaV2wyWlhJaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5aaGJHbGtJSEpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnVhMTloY0hBdlkyOXVkSEpoWTNRdWNIazZNVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnRZbkpRWVhrdVlXMXZkVzUwSUQ0Z01Dd2dJbHBsY204Z1FXMXZkVzUwSWdvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmFaWEp2SUVGdGIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXRmWVhCd0wyTnZiblJ5WVdOMExuQjVPakl4TFRJeUNpQWdJQ0F2THlBaklFTm9aV05ySUdsbUlIVnpaWElnYUdGeklHUmxjRzl6YVhSbFpDQmlaV1p2Y21VS0lDQWdJQzh2SUdSbGNHOXphWFJmWVcxMExDQm9ZWE5FWlhCdmMybDBaV1FnUFNCelpXeG1MblZ6WlhKZlltRnNZVzVqWlhNdWJXRjVZbVVvVkhodUxuTmxibVJsY2lrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5WelpYSmZZbUZzWVc1alpYTWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVc1clgyRndjQzlqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z2FXWWdibTkwSUdoaGMwUmxjRzl6YVhSbFpEb0tJQ0FnSUdKdWVpQmtaWEJ2YzJsMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm10ZllYQndMMk52Ym5SeVlXTjBMbkI1T2pJMENpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzVnpaWEp6TG5aaGJIVmxJQ3M5SURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOTFjMlZ5Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5MWMyVnljeUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOTFjMlZ5Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncGtaWEJ2YzJsMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVc1clgyRndjQzlqYjI1MGNtRmpkQzV3ZVRveU5pMHlOd29nSUNBZ0x5OGdJeUJWY0dSaGRHVWdaMnh2WW1Gc0lDWWdRbTk0SUhOMGIzSmhaMlVLSUNBZ0lDOHZJR2xtSUdoaGMwUmxjRzl6YVhSbFpEb0tJQ0FnSUdSMWNBb2dJQ0FnWW5vZ1pHVndiM05wZEY5bGJITmxYMkp2WkhsQU5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtdGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qSTRDaUFnSUNBdkx5QnpaV3htTG5WelpYSmZZbUZzWVc1alpYTmJWSGh1TG5ObGJtUmxjbDBnS3owZ2JXSnlVR0Y1TG1GdGIzVnVkQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkWE5sY2w5aVlXeGhibU5sY3lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MWMyVnlYMkpoYkdGdVkyVnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURNS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0NtUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm10ZllYQndMMk52Ym5SeVlXTjBMbkI1T2pNeUNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyUmxjRzl6YVhSbFpDNTJZV3gxWlNBclBTQnRZbkpRWVhrdVlXMXZkVzUwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZlpHVndiM05wZEdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyUmxjRzl6YVhSbFpDQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeUNpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOWtaWEJ2YzJsMFpXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXRmWVhCd0wyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1MWMyVnlYMkpoYkdGdVkyVnpXMVI0Ymk1elpXNWtaWEpkQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oxYzJWeVgySmhiR0Z1WTJWeklnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTFjMlZ5WDJKaGJHRnVZMlZ6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtdGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BrWlhCdmMybDBYMlZzYzJWZlltOWtlVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm10ZllYQndMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCelpXeG1MblZ6WlhKZlltRnNZVzVqWlhOYlZIaHVMbk5sYm1SbGNsMGdQU0J0WW5KUVlYa3VZVzF2ZFc1MENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMWMyVnlYMkpoYkdGdVkyVnpJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNZ29nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdZaUJrWlhCdmMybDBYMkZtZEdWeVgybG1YMlZzYzJWQU5nb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVpWVc1clgyRndjQzVqYjI1MGNtRmpkQzVpWVc1clgyRndjQzUzYVhSb1pISmhkMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25kcGRHaGtjbUYzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm10ZllYQndMMk52Ym5SeVlXTjBMbkI1T2pNMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ1YTE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TXpndE16a0tJQ0FnSUM4dklDTWdRMmhsWTJzZ2FXWWdkWE5sY2lCb1lYTWdaR1Z3YjNOcGRHVmtJR0psWm05eVpRb2dJQ0FnTHk4Z1pHVndiM05wZEY5aGJYUXNJR2hoYzBSbGNHOXphWFJsWkNBOUlITmxiR1l1ZFhObGNsOWlZV3hoYm1ObGN5NXRZWGxpWlNoVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRYTmxjbDlpWVd4aGJtTmxjeUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm10ZllYQndMMk52Ym5SeVlXTjBMbkI1T2pRd0NpQWdJQ0F2THlCaGMzTmxjblFnYUdGelJHVndiM05wZEdWa0xDQWlUbThnUkdWd2IzTnBkQ0JHYjNWdVpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGemMyVnlkQ0F2THlCT2J5QkVaWEJ2YzJsMElFWnZkVzVrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ1YTE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TkRFS0lDQWdJQzh2SUdGemMyVnlkQ0JrWlhCdmMybDBYMkZ0ZENBK1BTQmhiVzkxYm5Rc0lDSkRZVzRuZENCM2FYUm9aSEpoZHlCdGIzSmxJSFJvWVc0Z1pHVndiM05wZEdWa0lnb2dJQ0FnWkdsbklERUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnUTJGdUozUWdkMmwwYUdSeVlYY2diVzl5WlNCMGFHRnVJR1JsY0c5emFYUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXRmWVhCd0wyTnZiblJ5WVdOMExuQjVPalF6TFRRNENpQWdJQ0F2THlBaklGUnlZVzV6Wm1WeUlHWjFibVJ6SUhSdklIVnpaWElnZFhOcGJtY2dTVzUwWlhKdVlXd2dWSEpoYm5OaFkzUnBiMjRLSUNBZ0lDOHZJSEpsYzNWc2RDQTlJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQUtJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVc1clgyRndjQzlqYjI1MGNtRmpkQzV3ZVRvME5Rb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtdGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qUXpMVFEwQ2lBZ0lDQXZMeUFqSUZSeVlXNXpabVZ5SUdaMWJtUnpJSFJ2SUhWelpYSWdkWE5wYm1jZ1NXNTBaWEp1WVd3Z1ZISmhibk5oWTNScGIyNEtJQ0FnSUM4dklISmxjM1ZzZENBOUlHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUbzBOd29nSUNBZ0x5OGdabVZsUFRBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm10ZllYQndMMk52Ym5SeVlXTjBMbkI1T2pRekxUUTRDaUFnSUNBdkx5QWpJRlJ5WVc1elptVnlJR1oxYm1SeklIUnZJSFZ6WlhJZ2RYTnBibWNnU1c1MFpYSnVZV3dnVkhKaGJuTmhZM1JwYjI0S0lDQWdJQzh2SUhKbGMzVnNkQ0E5SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRUZ0YjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtdGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qVXdMVFV4Q2lBZ0lDQXZMeUFqSUZWd1pHRjBaU0J6YldGeWRDQmpiMjUwY21GamRDQmhZMk52ZFc1MGFXNW5DaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMlJsY0c5emFYUmxaQzUyWVd4MVpTQXRQU0JoYlc5MWJuUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjlrWlhCdmMybDBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmWkdWd2IzTnBkR1ZrSUdWNGFYTjBjd29nSUNBZ1pHbG5JRElLSUNBZ0lDMEtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzWDJSbGNHOXphWFJsWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWExOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk5USUtJQ0FnSUM4dklITmxiR1l1ZFhObGNsOWlZV3hoYm1ObGMxdFVlRzR1YzJWdVpHVnlYU0F0UFNCaGJXOTFiblFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblZ6WlhKZlltRnNZVzVqWlhNaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRYTmxjbDlpWVd4aGJtTmxjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR0owYjJrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXRmWVhCd0wyTnZiblJ5WVdOMExuQjVPak0yQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtSmhibXRmWVhCd0xtTnZiblJ5WVdOMExtSmhibXRmWVhCd0xtZGxkRTE1UW1Gc1lXNWpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRFMTVRbUZzWVc1alpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUbzFPQW9nSUNBZ0x5OGdZVzEwTENCb1lYTkVaWEJ2YzJsMFpXUWdQU0J6Wld4bUxuVnpaWEpmWW1Gc1lXNWpaWE11YldGNVltVW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblZ6WlhKZlltRnNZVzVqWlhNaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUbzFPUW9nSUNBZ0x5OGdZWE56WlhKMElHaGhjMFJsY0c5emFYUmxaQ3dnSWxsdmRTZDJaU0J1YjNRZ1ltVmxiaUJrWlhCdmMybDBaV1FnWW1WbWIzSmxJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYTnpaWEowSUM4dklGbHZkU2QyWlNCdWIzUWdZbVZsYmlCa1pYQnZjMmwwWldRZ1ltVm1iM0psQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ1YTE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TlRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQVFBbUJBMTFjMlZ5WDJKaGJHRnVZMlZ6RDNSdmRHRnNYMlJsY0c5emFYUmxaQXQwYjNSaGJGOTFjMlZ5Y3dRVkgzeDFNUmhBQUFZcEkyY3FJMmN4RzBFQUpERVpGRVF4R0VTQ0F3UXltT2ZBQkRFaFFYWUVRTFJRMWpZYUFJNERBQXNBY0FDM0FERVpGREVZRkJCRUlrTXhGaUlKU1RnUUloSkVTVGdBTVFBU1JFazRCeklLRWtRNENFbEVLREVBVUwxSlR3SklRQUFKSXlwbFJDSUlLa3huU1VFQUpTZ3hBRkJKdmtRWFN3TUlGcjhqS1dWRVN3SUlLVXhuS0RFQVVMNUVGeFlyVEZDd0lrTW9NUUJRU3dJV3YwTC8zVFlhQVVrVmdRZ1NSQmNvTVFCUXZrd1hURVJMQVE5RXNURUFTd0d5Q0xJSElySVFJN0lCczdRSUl5bGxSRXNDQ1NsTVp5Z3hBRkJKdmtRWFR3TUpGcjhXSzB4UXNDSkRLREVBVUw1TUYweEVGaXRNVUxBaVF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo0LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
