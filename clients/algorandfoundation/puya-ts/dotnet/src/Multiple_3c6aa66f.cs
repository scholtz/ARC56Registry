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

namespace Arc56.Generated.algorandfoundation.puya_ts.Multiple_3c6aa66f
{


    public class MultipleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MultipleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> FromOther(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 97, 25, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FromOther_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 97, 25, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Value(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 87, 19, 58 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Value_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 87, 19, 58 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> FromSuper(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 81, 141, 130 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FromSuper_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 81, 141, 130 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Read(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 14, 55, 79 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Read_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 14, 55, 79 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> ReadOther(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 173, 230, 159 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ReadOther_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 173, 230, 159 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXVsdGlwbGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiZnJvbU90aGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmcm9tU3VwZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWFkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVhZE90aGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVLSUNBZ0lHSWdiV0ZwYmw5aWJHOWphMEF3Q2dwdFlXbHVYMkpzYjJOclFEQTZDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JpSUcxaGFXNWZhV1pmWW05a2VVQXhDZ3B0WVdsdVgybG1YMkp2WkhsQU1Ub0tJQ0FnSUdOaGJHeHpkV0lnWTI5dWMzUnlkV04wYjNJS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ1lpQnRZV2x1WDJKc2IyTnJRRE1LQ20xaGFXNWZZbXh2WTJ0QU16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dmRtVnljbWxrWlMxa2FYTndZWFJqYUM1aGJHZHZMblJ6T2pNNUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUWFZzZEdsd2JHVWdaWGgwWlc1a2N5QmpiR0Z6YzJWektFeGxZV1lzSUU5MGFHVnlLU0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDRTlDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TkFvZ0lDQWdZaUJ0WVdsdVgyRmlhVjl5YjNWMGFXNW5RRFFLQ20xaGFXNWZZV0pwWDNKdmRYUnBibWRBTkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2ZG1WeWNtbGtaUzFrYVhOd1lYUmphQzVoYkdkdkxuUnpPak01Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RYVnNkR2x3YkdVZ1pYaDBaVzVrY3lCamJHRnpjMlZ6S0V4bFlXWXNJRTkwYUdWeUtTQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdUbTlQY0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0FoUFFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TWdvZ0lDQWdZaUJ0WVdsdVgyTmhiR3hmVG05UGNFQTFDZ3B0WVdsdVgyTmhiR3hmVG05UGNFQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyOTJaWEp5YVdSbExXUnBjM0JoZEdOb0xtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJOZFd4MGFYQnNaU0JsZUhSbGJtUnpJR05zWVhOelpYTW9UR1ZoWml3Z1QzUm9aWElwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBeE5qRXhPVEpqSUM4dklHMWxkR2h2WkNBaVpuSnZiVTkwYUdWeUtDbDFhVzUwTmpRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa05UVTNNVE16WVNBdkx5QnRaWFJvYjJRZ0luWmhiSFZsS0NsMWFXNTBOalFpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc1WVRVeE9HUTRNaUF2THlCdFpYUm9iMlFnSW1aeWIyMVRkWEJsY2lncGRXbHVkRFkwSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRrd1pUTTNOR1lnTHk4Z2JXVjBhRzlrSUNKeVpXRmtLQ2wxYVc1ME5qUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzVNR0ZrWlRZNVppQXZMeUJ0WlhSb2IyUWdJbkpsWVdSUGRHaGxjaWdwZFdsdWREWTBJZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0J0WVhSamFDQnRZV2x1WDJaeWIyMVBkR2hsY2w5eWIzVjBaVUEySUcxaGFXNWZkbUZzZFdWZmNtOTFkR1ZBTnlCdFlXbHVYMlp5YjIxVGRYQmxjbDl5YjNWMFpVQTRJRzFoYVc1ZmNtVmhaRjl5YjNWMFpVQTVJRzFoYVc1ZmNtVmhaRTkwYUdWeVgzSnZkWFJsUURFd0NpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhNUW9LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERXhPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVE1LQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE16b0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTFDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjNabGNuSnBaR1V0WkdsemNHRjBZMmd1WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMTFiSFJwY0d4bElHVjRkR1Z1WkhNZ1kyeGhjM05sY3loTVpXRm1MQ0JQZEdobGNpa2dld29nSUNBZ1pYSnlDZ3B0WVdsdVgzSmxZV1JQZEdobGNsOXliM1YwWlVBeE1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dmRtVnljbWxrWlMxa2FYTndZWFJqYUM1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCeVpXRmtUM1JvWlhJb0tUb2dkV2x1ZERZMElIc0tJQ0FnSUdOaGJHeHpkV0lnY21WaFpFOTBhR1Z5Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE1Rb0tiV0ZwYmw5eVpXRmtYM0p2ZFhSbFFEazZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmIzWmxjbkpwWkdVdFpHbHpjR0YwWTJndVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2NtVmhaQ2dwT2lCMWFXNTBOalFnZXdvZ0lDQWdZMkZzYkhOMVlpQnlaV0ZrQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE1Rb0tiV0ZwYmw5bWNtOXRVM1Z3WlhKZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2ZG1WeWNtbGtaUzFrYVhOd1lYUmphQzVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJtY205dFUzVndaWElvS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR05oYkd4emRXSWdabkp2YlZOMWNHVnlDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TVFvS2JXRnBibDkyWVd4MVpWOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5MlpYSnlhV1JsTFdScGMzQmhkR05vTG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUc5MlpYSnlhV1JsSUhaaGJIVmxLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQmpZV3hzYzNWaUlIWmhiSFZsQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE1Rb0tiV0ZwYmw5bWNtOXRUM1JvWlhKZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2ZG1WeWNtbGtaUzFrYVhOd1lYUmphQzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJtY205dFQzUm9aWElvS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR05oYkd4emRXSWdabkp2YlU5MGFHVnlDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TVFvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE1qb0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXpDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dmRtVnljbWxrWlMxa2FYTndZWFJqYUM1aGJHZHZMblJ6T2pNNUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUWFZzZEdsd2JHVWdaWGgwWlc1a2N5QmpiR0Z6YzJWektFeGxZV1lzSUU5MGFHVnlLU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR05oYkd4emRXSWdYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjkyWlhKeWFXUmxMV1JwYzNCaGRHTm9MbUZzWjI4dWRITTZPazExYkhScGNHeGxMbVp5YjIxUGRHaGxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21aeWIyMVBkR2hsY2pvS0lDQWdJR0lnWm5KdmJVOTBhR1Z5WDJKc2IyTnJRREFLQ21aeWIyMVBkR2hsY2w5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjkyWlhKeWFXUmxMV1JwYzNCaGRHTm9MbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJR1p5YjIxUGRHaGxjaWdwT2lCMWFXNTBOalFnZXdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdmIzWmxjbkpwWkdVdFpHbHpjR0YwWTJndVlXeG5ieTUwY3pvNlRYVnNkR2x3YkdVdVpuSnZiVTkwYUdWeUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmIzWmxjbkpwWkdVdFpHbHpjR0YwWTJndVlXeG5ieTUwY3pvNlRHVmhaaTUyWVd4MVpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpoYkhWbE9nb2dJQ0FnWWlCMllXeDFaVjlpYkc5amEwQXdDZ3AyWVd4MVpWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5MlpYSnlhV1JsTFdScGMzQmhkR05vTG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUc5MlpYSnlhV1JsSUhaaGJIVmxLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dmRtVnljbWxrWlMxa2FYTndZWFJqYUM1aGJHZHZMblJ6T2pwTVpXRm1MblpoYkhWbENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmIzWmxjbkpwWkdVdFpHbHpjR0YwWTJndVlXeG5ieTUwY3pvNlRHVmhaaTVtY205dFUzVndaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbWNtOXRVM1Z3WlhJNkNpQWdJQ0JpSUdaeWIyMVRkWEJsY2w5aWJHOWphMEF3Q2dwbWNtOXRVM1Z3WlhKZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2ZG1WeWNtbGtaUzFrYVhOd1lYUmphQzVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJtY205dFUzVndaWElvS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyOTJaWEp5YVdSbExXUnBjM0JoZEdOb0xtRnNaMjh1ZEhNNk9reGxZV1l1Wm5KdmJWTjFjR1Z5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjNabGNuSnBaR1V0WkdsemNHRjBZMmd1WVd4bmJ5NTBjem82UW1GelpTNXlaV0ZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVmhaRG9LSUNBZ0lHSWdjbVZoWkY5aWJHOWphMEF3Q2dweVpXRmtYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmIzWmxjbkpwWkdVdFpHbHpjR0YwWTJndVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2NtVmhaQ2dwT2lCMWFXNTBOalFnZXdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdmIzWmxjbkpwWkdVdFpHbHpjR0YwWTJndVlXeG5ieTUwY3pvNlFtRnpaUzV5WldGa0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmIzWmxjbkpwWkdVdFpHbHpjR0YwWTJndVlXeG5ieTUwY3pvNlQzUm9aWEl1Y21WaFpFOTBhR1Z5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVmhaRTkwYUdWeU9nb2dJQ0FnWWlCeVpXRmtUM1JvWlhKZllteHZZMnRBTUFvS2NtVmhaRTkwYUdWeVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjNabGNuSnBaR1V0WkdsemNHRjBZMmd1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnY21WaFpFOTBhR1Z5S0NrNklIVnBiblEyTkNCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZkbVZ5Y21sa1pTMWthWE53WVhSamFDNWhiR2R2TG5Sek9qcFBkR2hsY2k1eVpXRmtUM1JvWlhJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dmRtVnljbWxrWlMxa2FYTndZWFJqYUM1aGJHZHZMblJ6T2pwTmRXeDBhWEJzWlM1bWNtOXRUM1JvWlhJb0tTQXRQaUIxYVc1ME5qUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXZkbVZ5Y21sa1pTMWthWE53WVhSamFDNWhiR2R2TG5Sek9qcE5kV3gwYVhCc1pTNW1jbTl0VDNSb1pYSTZDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dmRtVnljbWxrWlMxa2FYTndZWFJqYUM1aGJHZHZMblJ6T2pwTmRXeDBhWEJzWlM1bWNtOXRUM1JvWlhKZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5MlpYSnlhV1JsTFdScGMzQmhkR05vTG1Gc1oyOHVkSE02T2sxMWJIUnBjR3hsTG1aeWIyMVBkR2hsY2w5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjkyWlhKeWFXUmxMV1JwYzNCaGRHTm9MbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJSEpsZEhWeWJpQnpkWEJsY2k1amJHRnpjeWhQZEdobGNpa3VkbUZzZFdVb0tRb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiM1psY25KcFpHVXRaR2x6Y0dGMFkyZ3VZV3huYnk1MGN6bzZUM1JvWlhJdWRtRnNkV1VLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZkbVZ5Y21sa1pTMWthWE53WVhSamFDNWhiR2R2TG5Sek9qcE1aV0ZtTG5aaGJIVmxLQ2tnTFQ0Z2RXbHVkRFkwT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12YjNabGNuSnBaR1V0WkdsemNHRjBZMmd1WVd4bmJ5NTBjem82VEdWaFppNTJZV3gxWlRvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjkyWlhKeWFXUmxMV1JwYzNCaGRHTm9MbUZzWjI4dWRITTZPa3hsWVdZdWRtRnNkV1ZmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMjkyWlhKeWFXUmxMV1JwYzNCaGRHTm9MbUZzWjI4dWRITTZPa3hsWVdZdWRtRnNkV1ZmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZkbVZ5Y21sa1pTMWthWE53WVhSamFDNWhiR2R2TG5Sek9qSXdDaUFnSUNBdkx5QnlaWFIxY200Z01nb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiM1psY25KcFpHVXRaR2x6Y0dGMFkyZ3VZV3huYnk1MGN6bzZUR1ZoWmk1bWNtOXRVM1Z3WlhJb0tTQXRQaUIxYVc1ME5qUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXZkbVZ5Y21sa1pTMWthWE53WVhSamFDNWhiR2R2TG5Sek9qcE1aV0ZtTG1aeWIyMVRkWEJsY2pvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjkyWlhKeWFXUmxMV1JwYzNCaGRHTm9MbUZzWjI4dWRITTZPa3hsWVdZdVpuSnZiVk4xY0dWeVgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5dmRtVnljbWxrWlMxa2FYTndZWFJqYUM1aGJHZHZMblJ6T2pwTVpXRm1MbVp5YjIxVGRYQmxjbDlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyOTJaWEp5YVdSbExXUnBjM0JoZEdOb0xtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklISmxkSFZ5YmlCemRYQmxjaTUyWVd4MVpTZ3BDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2ZG1WeWNtbGtaUzFrYVhOd1lYUmphQzVoYkdkdkxuUnpPanBDWVhObExuWmhiSFZsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiM1psY25KcFpHVXRaR2x6Y0dGMFkyZ3VZV3huYnk1MGN6bzZRbUZ6WlM1MllXeDFaU2dwSUMwK0lIVnBiblEyTkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5MlpYSnlhV1JsTFdScGMzQmhkR05vTG1Gc1oyOHVkSE02T2tKaGMyVXVkbUZzZFdVNkNpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2ZG1WeWNtbGtaUzFrYVhOd1lYUmphQzVoYkdkdkxuUnpPanBDWVhObExuWmhiSFZsWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2ZG1WeWNtbGtaUzFrYVhOd1lYUmphQzVoYkdkdkxuUnpPanBDWVhObExuWmhiSFZsWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiM1psY25KcFpHVXRaR2x6Y0dGMFkyZ3VZV3huYnk1MGN6bzNDaUFnSUNBdkx5QnlaWFIxY200Z01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2ZG1WeWNtbGtaUzFrYVhOd1lYUmphQzVoYkdkdkxuUnpPanBDWVhObExuSmxZV1FvS1NBdFBpQjFhVzUwTmpRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5dmRtVnljbWxrWlMxa2FYTndZWFJqYUM1aGJHZHZMblJ6T2pwQ1lYTmxMbkpsWVdRNkNpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2ZG1WeWNtbGtaUzFrYVhOd1lYUmphQzVoYkdkdkxuUnpPanBDWVhObExuSmxZV1JmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMjkyWlhKeWFXUmxMV1JwYzNCaGRHTm9MbUZzWjI4dWRITTZPa0poYzJVdWNtVmhaRjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyOTJaWEp5YVdSbExXUnBjM0JoZEdOb0xtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMblpoYkhWbEtDa0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjkyWlhKeWFXUmxMV1JwYzNCaGRHTm9MbUZzWjI4dWRITTZPa3hsWVdZdWRtRnNkV1VLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZkbVZ5Y21sa1pTMWthWE53WVhSamFDNWhiR2R2TG5Sek9qcFBkR2hsY2k1MllXeDFaU2dwSUMwK0lIVnBiblEyTkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5MlpYSnlhV1JsTFdScGMzQmhkR05vTG1Gc1oyOHVkSE02T2s5MGFHVnlMblpoYkhWbE9nb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjNabGNuSnBaR1V0WkdsemNHRjBZMmd1WVd4bmJ5NTBjem82VDNSb1pYSXVkbUZzZFdWZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5MlpYSnlhV1JsTFdScGMzQmhkR05vTG1Gc1oyOHVkSE02T2s5MGFHVnlMblpoYkhWbFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjNabGNuSnBaR1V0WkdsemNHRjBZMmd1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnY21WMGRYSnVJRE1LSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5MlpYSnlhV1JsTFdScGMzQmhkR05vTG1Gc1oyOHVkSE02T2s5MGFHVnlMbkpsWVdSUGRHaGxjaWdwSUMwK0lIVnBiblEyTkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5MlpYSnlhV1JsTFdScGMzQmhkR05vTG1Gc1oyOHVkSE02T2s5MGFHVnlMbkpsWVdSUGRHaGxjam9LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyOTJaWEp5YVdSbExXUnBjM0JoZEdOb0xtRnNaMjh1ZEhNNk9rOTBhR1Z5TG5KbFlXUlBkR2hsY2w5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12YjNabGNuSnBaR1V0WkdsemNHRjBZMmd1WVd4bmJ5NTBjem82VDNSb1pYSXVjbVZoWkU5MGFHVnlYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmIzWmxjbkpwWkdVdFpHbHpjR0YwWTJndVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVkbUZzZFdVb0tRb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiM1psY25KcFpHVXRaR2x6Y0dGMFkyZ3VZV3huYnk1MGN6bzZUR1ZoWmk1MllXeDFaUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyOTJaWEp5YVdSbExXUnBjM0JoZEdOb0xtRnNaMjh1ZEhNNk9rMTFiSFJwY0d4bExsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlNncElDMCtJSFp2YVdRNkNsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlRvS0lDQWdJR0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxYMkpzYjJOclFEQUtDbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpWOWliRzlqYTBBd09nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2NHOXNlWFI1Y0dVdmJHbGlMM0J2YkhsMGVYQmxMVzF2WkhWc1pTNWtMblJ6T2pwRGJIVnpkR1Z5WldSRGIyNTBjbUZqZER4MFpYTjBjeTloY0hCeWIzWmhiSE12YjNabGNuSnBaR1V0WkdsemNHRjBZMmd1WVd4bmJ5NTBjem82VEdWaFppeDBaWE4wY3k5aGNIQnliM1poYkhNdmIzWmxjbkpwWkdVdFpHbHpjR0YwWTJndVlXeG5ieTUwY3pvNlQzUm9aWEkrTG1OdmJuTjBjblZqZEc5eUtDa2dMVDRnZG05cFpEb0tZMjl1YzNSeWRXTjBiM0k2Q2lBZ0lDQmlJR052Ym5OMGNuVmpkRzl5WDJKc2IyTnJRREFLQ21OdmJuTjBjblZqZEc5eVgySnNiMk5yUURBNkNpQWdJQ0JpSUdOdmJuTjBjblZqZEc5eVgySnNiMk5yUURFS0NtTnZibk4wY25WamRHOXlYMkpzYjJOclFERTZDaUFnSUNCaUlHTnZibk4wY25WamRHOXlYMkZtZEdWeVgybHViR2x1WldSZlFHRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOWhiR2R2Y21GdVpDMTBlWEJsYzJOeWFYQjBMMkpoYzJVdFkyOXVkSEpoWTNRdVpDNTBjem82UW1GelpVTnZiblJ5WVdOMExtTnZibk4wY25WamRHOXlRRElLQ21OdmJuTjBjblZqZEc5eVgyRm1kR1Z5WDJsdWJHbHVaV1JmUUdGc1oyOXlZVzVrWm05MWJtUmhkR2x2Ymk5aGJHZHZjbUZ1WkMxMGVYQmxjMk55YVhCMEwySmhjMlV0WTI5dWRISmhZM1F1WkM1MGN6bzZRbUZ6WlVOdmJuUnlZV04wTG1OdmJuTjBjblZqZEc5eVFESTZDaUFnSUNCaUlHTnZibk4wY25WamRHOXlYMkpzYjJOclFETUtDbU52Ym5OMGNuVmpkRzl5WDJKc2IyTnJRRE02Q2lBZ0lDQmlJR052Ym5OMGNuVmpkRzl5WDJGbWRHVnlYMmx1YkdsdVpXUmZRR0ZzWjI5eVlXNWtabTkxYm1SaGRHbHZiaTloYkdkdmNtRnVaQzEwZVhCbGMyTnlhWEIwTDJKaGMyVXRZMjl1ZEhKaFkzUXVaQzUwY3pvNlFtRnpaVU52Ym5SeVlXTjBMbU52Ym5OMGNuVmpkRzl5UURRS0NtTnZibk4wY25WamRHOXlYMkZtZEdWeVgybHViR2x1WldSZlFHRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOWhiR2R2Y21GdVpDMTBlWEJsYzJOeWFYQjBMMkpoYzJVdFkyOXVkSEpoWTNRdVpDNTBjem82UW1GelpVTnZiblJ5WVdOMExtTnZibk4wY25WamRHOXlRRFE2Q2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FRQW1BUVFWSDN4MVFnQUFNUmhBQUFsQ0FBQ0lBUDlDQUFCQ0FBQXhHeU1UUVFCc1FnQUFNUmtqRWtReEdDTVRRUUJhUWdBQU5ob0FnQVFCWVJrc2dBVFZWeE02Z0FTYVVZMkNnQVJKRGpkUGdBU1FyZWFmVHdXT0JRQWlBQndBRmdBUUFBcENBQUJDQUFCQ0FBQUFpQUJsUXYvemlBQlJRdi90aUFBOVF2L25pQUFwUXYvaGlBQVZRdi9iUXYvYk1Sa2pFakVZSXhJUVJJZ0FkU0pEUWdBQWlBQkFGaWhQQVZDd0lrTkNBQUNJQURrV0tFOEJVTEFpUTBJQUFJZ0FNUllvVHdGUXNDSkRRZ0FBaUFBdkZpaFBBVkN3SWtOQ0FBQ0lBQzRXS0U4QlVMQWlRMElBQUlnQUdvbENBQUNCQW9sQ0FBQ0lBQUdKUWdBQUlvbENBQUNJLytpSlFnQUFnUU9KUWdBQWlQL2JpVUlBQUlsQ0FBQkNBQUJDQUFCQ0FBQkNBQUNKIiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
