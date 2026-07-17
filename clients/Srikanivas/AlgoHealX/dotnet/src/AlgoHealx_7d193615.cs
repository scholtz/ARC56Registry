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

namespace Arc56.Generated.Srikanivas.AlgoHealX.AlgoHealx_7d193615
{


    public class AlgoHealxProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AlgoHealxProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner_addr"> </param>
        /// <param name="government_addr"> </param>
        public async Task CreateApplication(Algorand.Address owner_addr, Algorand.Address government_addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 23, 115, 32 };
            var owner_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); owner_addrAbi.From(owner_addr);
            var government_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); government_addrAbi.From(government_addr);

            var result = await base.CallApp(new List<object> { abiHandle, owner_addrAbi, government_addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Algorand.Address owner_addr, Algorand.Address government_addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 23, 115, 32 };
            var owner_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); owner_addrAbi.From(owner_addr);
            var government_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); government_addrAbi.From(government_addr);

            return await base.MakeTransactionList(new List<object> { abiHandle, owner_addrAbi, government_addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="manufacturer_addr"> </param>
        public async Task AddManufacturer(Algorand.Address manufacturer_addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 142, 172, 153 };
            var manufacturer_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); manufacturer_addrAbi.From(manufacturer_addr);

            var result = await base.CallApp(new List<object> { abiHandle, manufacturer_addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddManufacturer_Transactions(Algorand.Address manufacturer_addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 142, 172, 153 };
            var manufacturer_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); manufacturer_addrAbi.From(manufacturer_addr);

            return await base.MakeTransactionList(new List<object> { abiHandle, manufacturer_addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="batch_details"> </param>
        public async Task RegisterBatch(string batch_details, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 212, 185, 109 };
            var batch_detailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); batch_detailsAbi.From(batch_details);

            var result = await base.CallApp(new List<object> { abiHandle, batch_detailsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterBatch_Transactions(string batch_details, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 212, 185, 109 };
            var batch_detailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); batch_detailsAbi.From(batch_details);

            return await base.MakeTransactionList(new List<object> { abiHandle, batch_detailsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        public async Task<string> GetBatchDetails(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 150, 66, 204 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.SimApp(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetBatchDetails_Transactions(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 150, 66, 204 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWxnb0hlYWx4IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9hcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXJfYWRkciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImdvdmVybm1lbnRfYWRkciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfbWFudWZhY3R1cmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYW51ZmFjdHVyZXJfYWRkciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3Rlcl9iYXRjaCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYXRjaF9kZXRhaWxzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9iYXRjaF9kZXRhaWxzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzMwMF0sImVycm9yTWVzc2FnZSI6IkJhdGNoIGxpbWl0IHJlYWNoZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDldLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIGluZGV4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkxXSwiZXJyb3JNZXNzYWdlIjoiTm90IHdoaXRlbGlzdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk1XSwiZXJyb3JNZXNzYWdlIjoiVW5hdXRob3JpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg3XSwiZXJyb3JNZXNzYWdlIjoiV2hpdGVsaXN0IGZ1bGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTUsMzQ1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5iYXRjaF9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODIsMjMyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tYW51ZmFjdHVyZXJfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgKGxlbit1dGY4W10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOCwxMzYsMTc4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHVpbnQ4WzMyXSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXpJS0lDQWdJR0o1ZEdWallteHZZMnNnSW1KaGRHTm9YMk52ZFc1MElpQWliV0Z1ZFdaaFkzUjFjbVZ5WDJOdmRXNTBJaUFpYjNkdVpYSWlJREI0Tm1RMk1UWmxOelUxWmlBd2VEWXlOakUzTkRZek5qZzFaZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZhR1ZoYkhndlkyOXVkSEpoWTNRdWNIazZNVGdLSUNBZ0lDOHZJSE5sYkdZdVltRjBZMmhmWTI5MWJuUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUpoZEdOb1gyTnZkVzUwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5b1pXRnNlQzlqYjI1MGNtRmpkQzV3ZVRveE9Rb2dJQ0FnTHk4Z2MyVnNaaTV0WVc1MVptRmpkSFZ5WlhKZlkyOTFiblFnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW0xaGJuVm1ZV04wZFhKbGNsOWpiM1Z1ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTlvWldGc2VDOWpiMjUwY21GamRDNXdlVG8zQ2lBZ0lDQXZMeUJqYkdGemN5QkJiR2R2U0dWaGJIZ29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUE1Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TTJJNFpXRmpPVGtnTUhnNFltUTBZamsyWkNBd2VHTTVPVFkwTW1OaklDOHZJRzFsZEdodlpDQWlZV1JrWDIxaGJuVm1ZV04wZFhKbGNpaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFoybHpkR1Z5WDJKaGRHTm9LSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZZbUYwWTJoZlpHVjBZV2xzY3loMWFXNTBOalFwYzNSeWFXNW5JZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWVdSa1gyMWhiblZtWVdOMGRYSmxjaUJ5WldkcGMzUmxjbDlpWVhSamFDQm5aWFJmWW1GMFkyaGZaR1YwWVdsc2N3b2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTlvWldGc2VDOWpiMjUwY21GamRDNXdlVG8zQ2lBZ0lDQXZMeUJqYkdGemN5QkJiR2R2U0dWaGJIZ29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdKaU1UYzNNekl3SUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsWDJGd2NHeHBZMkYwYVc5dUtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxYMkZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXeG5iMTlvWldGc2VDNWpiMjUwY21GamRDNUJiR2R2U0dWaGJIZ3VZM0psWVhSbFgyRndjR3hwWTJGMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxYMkZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmFHVmhiSGd2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrNXZUM0FpWFN3Z1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlIVnBiblE0V3pNeVhRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdkV2x1ZERoYk16SmRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTlvWldGc2VDOWpiMjUwY21GamRDNXdlVG95TXdvZ0lDQWdMeThnYzJWc1ppNXZkMjVsY2lBOUlHOTNibVZ5WDJGa1pISUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYUdWaGJIZ3ZZMjl1ZEhKaFkzUXVjSGs2TWpRS0lDQWdJQzh2SUhObGJHWXVaMjkyWlhKdWJXVnVkRjloWkdSeVpYTnpJRDBnWjI5MlpYSnViV1Z1ZEY5aFpHUnlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltZHZkbVZ5Ym0xbGJuUmZZV1JrY21WemN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTlvWldGc2VDOWpiMjUwY21GamRDNXdlVG95TlFvZ0lDQWdMeThnYzJWc1ppNWlZWFJqYUY5amIzVnVkQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW1GMFkyaGZZMjkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgyaGxZV3g0TDJOdmJuUnlZV04wTG5CNU9qSTJDaUFnSUNBdkx5QnpaV3htTG0xaGJuVm1ZV04wZFhKbGNsOWpiM1Z1ZENBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJXRnVkV1poWTNSMWNtVnlYMk52ZFc1MElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOW9aV0ZzZUM5amIyNTBjbUZqZEM1d2VUb3lNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUbTlQY0NKZExDQmpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYkdkdlgyaGxZV3g0TG1OdmJuUnlZV04wTGtGc1oyOUlaV0ZzZUM1aFpHUmZiV0Z1ZFdaaFkzUjFjbVZ5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXUmtYMjFoYm5WbVlXTjBkWEpsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgyaGxZV3g0TDJOdmJuUnlZV04wTG5CNU9qSTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhWcGJuUTRXek15WFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmFHVmhiSGd2WTI5dWRISmhZM1F1Y0hrNk16QUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbTFoYm5WbVlXTjBkWEpsY2w5amIzVnVkQ0E4SUZWSmJuUTJOQ2hOUVZoZlRVRk9WVVpCUTFSVlVrVlNVeWtzSUNKWGFHbDBaV3hwYzNRZ1puVnNiQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnRZVzUxWm1GamRIVnlaWEpmWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YldGdWRXWmhZM1IxY21WeVgyTnZkVzUwSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURVd0lDOHZJRFV3Q2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z1YyaHBkR1ZzYVhOMElHWjFiR3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDJobFlXeDRMMk52Ym5SeVlXTjBMbkI1T2pNeENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG05M2JtVnlMQ0FpVlc1aGRYUm9iM0pwZW1Wa0lnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlZibUYxZEdodmNtbDZaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDJobFlXeDRMMk52Ym5SeVlXTjBMbkI1T2pNekNpQWdJQ0F2THlCelpXeG1MbTFoYm5WbVlXTjBkWEpsY25OYmFXUjRYU0E5SUcxaGJuVm1ZV04wZFhKbGNsOWhaR1J5Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGcyWkRZeE5tVTNOVFZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmFHVmhiSGd2WTI5dWRISmhZM1F1Y0hrNk16UUtJQ0FnSUM4dklITmxiR1l1YldGdWRXWmhZM1IxY21WeVgyTnZkVzUwSUQwZ2MyVnNaaTV0WVc1MVptRmpkSFZ5WlhKZlkyOTFiblFnS3lCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnRZVzUxWm1GamRIVnlaWEpmWTI5MWJuUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYUdWaGJIZ3ZZMjl1ZEhKaFkzUXVjSGs2TWpnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYkdkdlgyaGxZV3g0TG1OdmJuUnlZV04wTGtGc1oyOUlaV0ZzZUM1eVpXZHBjM1JsY2w5aVlYUmphRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFoybHpkR1Z5WDJKaGRHTm9PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYUdWaGJIZ3ZZMjl1ZEhKaFkzUXVjSGs2TXpZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQW9iR1Z1SzNWMFpqaGJYU2tLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTlvWldGc2VDOWpiMjUwY21GamRDNXdlVG8wTmdvZ0lDQWdMeThnYVRvZ1ZVbHVkRFkwSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvS2NtVm5hWE4wWlhKZlltRjBZMmhmZDJocGJHVmZkRzl3UURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOW9aV0ZzZUM5amIyNTBjbUZqZEM1d2VUbzBOd29nSUNBZ0x5OGdkMmhwYkdVZ2FTQThJSE5sYkdZdWJXRnVkV1poWTNSMWNtVnlYMk52ZFc1ME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW0xaGJuVm1ZV04wZFhKbGNsOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRZVzUxWm1GamRIVnlaWEpmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGdvZ0lDQWdZbm9nY21WbmFYTjBaWEpmWW1GMFkyaGZZV1owWlhKZmQyaHBiR1ZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmFHVmhiSGd2WTI5dWRISmhZM1F1Y0hrNk5EZ3ROVEVLSUNBZ0lDOHZJQ01nVkdobElHdHViM2RzWldSblpTQnpiM1Z5WTJWeklHUnZJRzV2ZENCd2NtOTJhV1JsSUdFZ2MyRm1aU0JrWldaaGRXeDBJR2xtSUhwbGNtOWZZV1JrY21WemN5QnBjeUIxYm1GMllXbHNZV0pzWlM0S0lDQWdJQzh2SUNNZ1ZYTnBibWNnUVdOamIzVnVkQ2dwSUdseklHNXZkQ0JrYjJOMWJXVnVkR1ZrSUdGeklIWmhiR2xrTGdvZ0lDQWdMeThnSXlCSlppQjZaWEp2WDJGa1pISmxjM01nYVhNZ1lYWmhhV3hoWW14bExDQjFjMlU2SUcwZ1BTQnpaV3htTG0xaGJuVm1ZV04wZFhKbGNuTXVaMlYwS0drc0lHUmxabUYxYkhROWVtVnliMTloWkdSeVpYTnpLUW9nSUNBZ0x5OGdiU0E5SUhObGJHWXViV0Z1ZFdaaFkzUjFjbVZ5Y3k1blpYUW9hU3dnWkdWbVlYVnNkRDFCWTJOdmRXNTBLQ0pYVFVoR05FWk1TazVMV1RKQ1VFWkxOMWxRVmpWSlJEWlBXamRNVmtSQ01rSTJObHBVV0VWQlRVeE1NazVZTkZkS1dsSktSbFpZTmpaTklpa3BJQ01nVG04Z1pHVm1ZWFZzZENCd2NtOTJhV1JsWkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0Tm1RMk1UWmxOelUxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ1ltRnpaVE15S0ZkTlNFWTBSa3hLVGt0Wk1rSlFSa3MzV1ZCV05VbEVOazlhTjB4V1JFSXlRalkyV2xSWVJVRk5URXd5VGxnMFYwcGFVa0VwSUM4dklHRmtaSElnVjAxSVJqUkdURXBPUzFreVFsQkdTemRaVUZZMVNVUTJUMW8zVEZaRVFqSkNOalphVkZoRlFVMU1UREpPV0RSWFNscFNTa1pXV0RZMlRRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5b1pXRnNlQzlqYjI1MGNtRmpkQzV3ZVRvMU1nb2dJQ0FnTHk4Z2FXWWdWSGh1TG5ObGJtUmxjaUE5UFNCdE9nb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHSjZJSEpsWjJsemRHVnlYMkpoZEdOb1gyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmFHVmhiSGd2WTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dweVpXZHBjM1JsY2w5aVlYUmphRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1aGJHZHZYMmhsWVd4NExtTnZiblJ5WVdOMExrRnNaMjlJWldGc2VDNWZhWE5mYzJWdVpHVnlYMjFoYm5WbVlXTjBkWEpsY2tBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZhR1ZoYkhndlkyOXVkSEpoWTNRdWNIazZNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTGw5cGMxOXpaVzVrWlhKZmJXRnVkV1poWTNSMWNtVnlLQ2tnUFQwZ1ZVbHVkRFkwS0RFcExDQWlUbTkwSUhkb2FYUmxiR2x6ZEdWa0lnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUhkb2FYUmxiR2x6ZEdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOW9aV0ZzZUM5amIyNTBjbUZqZEM1d2VUb3pPUW9nSUNBZ0x5OGdhV1I0T2lCVlNXNTBOalFnUFNCelpXeG1MbUpoZEdOb1gyTnZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbUYwWTJoZlkyOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltRjBZMmhmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOW9aV0ZzZUM5amIyNTBjbUZqZEM1d2VUbzBNQW9nSUNBZ0x5OGdZWE56WlhKMElHbGtlQ0E4SUZWSmJuUTJOQ2hOUVZoZlFrRlVRMGhGVXlrc0lDSkNZWFJqYUNCc2FXMXBkQ0J5WldGamFHVmtJZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFd01DQXZMeUF4TURBS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNZWFJqYUNCc2FXMXBkQ0J5WldGamFHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTlvWldGc2VDOWpiMjUwY21GamRDNXdlVG8wTVFvZ0lDQWdMeThnYzJWc1ppNWlZWFJqYUdWelcybGtlRjBnUFNCaVlYUmphRjlrWlhSaGFXeHpDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZzJNall4TnpRMk16WTROV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1JwWnlBekNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTlvWldGc2VDOWpiMjUwY21GamRDNXdlVG8wTWdvZ0lDQWdMeThnYzJWc1ppNWlZWFJqYUY5amIzVnVkQ0E5SUhObGJHWXVZbUYwWTJoZlkyOTFiblFnS3lCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmlZWFJqYUY5amIzVnVkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5b1pXRnNlQzlqYjI1MGNtRmpkQzV3ZVRvek5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B5WldkcGMzUmxjbDlpWVhSamFGOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOW9aV0ZzZUM5amIyNTBjbUZqZEM1d2VUbzFOQW9nSUNBZ0x5OGdhU0E5SUdrZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUJ5WldkcGMzUmxjbDlpWVhSamFGOTNhR2xzWlY5MGIzQkFNZ29LY21WbmFYTjBaWEpmWW1GMFkyaGZZV1owWlhKZmQyaHBiR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgyaGxZV3g0TDJOdmJuUnlZV04wTG5CNU9qVTFDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmFHVmhiSGd2WTI5dWRISmhZM1F1Y0hrNk16Z0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbDlwYzE5elpXNWtaWEpmYldGdWRXWmhZM1IxY21WeUtDa2dQVDBnVlVsdWREWTBLREVwTENBaVRtOTBJSGRvYVhSbGJHbHpkR1ZrSWdvZ0lDQWdZaUJ5WldkcGMzUmxjbDlpWVhSamFGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYkdkdlgyaGxZV3g0TG1OdmJuUnlZV04wTGtGc1oyOUlaV0ZzZUM1ZmFYTmZjMlZ1WkdWeVgyMWhiblZtWVdOMGRYSmxja0EzQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRnNaMjlmYUdWaGJIZ3VZMjl1ZEhKaFkzUXVRV3huYjBobFlXeDRMbWRsZEY5aVlYUmphRjlrWlhSaGFXeHpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgySmhkR05vWDJSbGRHRnBiSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5b1pXRnNlQzlqYjI1MGNtRmpkQzV3ZVRvMU5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQjFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgyaGxZV3g0TDJOdmJuUnlZV04wTG5CNU9qVTRDaUFnSUNBdkx5QmhjM05sY25RZ2FXNWtaWGdnUENCelpXeG1MbUpoZEdOb1gyTnZkVzUwTENBaVNXNTJZV3hwWkNCcGJtUmxlQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmlZWFJqYUY5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aVlYUmphRjlqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQnBibVJsZUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmFHVmhiSGd2WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUpoZEdOb1pYTXVaMlYwS0dsdVpHVjRMQ0JrWldaaGRXeDBQVk4wY21sdVp5Z2lJaWtwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TmpJMk1UYzBOak0yT0RWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOW9aV0ZzZUM5amIyNTBjbUZqZEM1d2VUbzFOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFFZ0pnVUxZbUYwWTJoZlkyOTFiblFTYldGdWRXWmhZM1IxY21WeVgyTnZkVzUwQlc5M2JtVnlCVzFoYm5WZkJtSmhkR05vWHpFWVFBQUdLQ0puS1NKbk1Sa1VSREVZUVFBZGdnTUVPNDZzbVFTTDFMbHRCTW1XUXN3MkdnQ09Bd0JCQUdrQTRnQ0FCTHNYY3lBMkdnQ09BUUFCQURZYUFVa1ZKQkpFTmhvQ1NSVWtFa1FxVHdKbmdCSm5iM1psY201dFpXNTBYMkZrWkhKbGMzTk1aeWdpWnlraVp5TkROaG9CU1JVa0VrUWlLV1ZFU1lFeURFUXhBQ0lxWlVRU1JFa1dLMHhRVHdLL0l3Z3BUR2NqUXpZYUFVa2lXWUVDQ0VzQkZSSkVWd0lBSWlJcFpVUkxBUTFCQUZsSkZpdE1VTDZBSUxNT1hoVnBhckdndktyK0gxNmdmblordW93NkQ3MlozSUJpMTZiZmxrNWlUZ0pOTVFBU1FRQWdJeU1TUkNJb1pVUkpnV1FNUkVrV0p3Uk1VRW04U0VzRHZ5TUlLRXhuSTBOSkl3aEZBVUwvblNKQy85VTJHZ0ZKRllFSUVrUVhJaWhsUkVzQkRVUVdKd1JNVUw2QUFFNENUVWtWRmxjR0FreFFnQVFWSDN4MVRGQ3dJME09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MiwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
