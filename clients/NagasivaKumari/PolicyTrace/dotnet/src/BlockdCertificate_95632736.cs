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

namespace Arc56.Generated.NagasivaKumari.PolicyTrace.BlockdCertificate_95632736
{


    public class BlockdCertificateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BlockdCertificateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mint a Certificate NFT and record it on-chain.
        ///</summary>
        /// <param name="scan_id"> </param>
        /// <param name="ipfs_url"> </param>
        public async Task<ulong> IssueCertificate(string scan_id, string ipfs_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 173, 218, 243 };
            var scan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scan_idAbi.From(scan_id);
            var ipfs_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_urlAbi.From(ipfs_url);

            var result = await base.CallApp(new List<object> { abiHandle, scan_idAbi, ipfs_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IssueCertificate_Transactions(string scan_id, string ipfs_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 173, 218, 243 };
            var scan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scan_idAbi.From(scan_id);
            var ipfs_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_urlAbi.From(ipfs_url);

            return await base.MakeTransactionList(new List<object> { abiHandle, scan_idAbi, ipfs_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieve the minted Asset ID for a scan.
        ///</summary>
        /// <param name="scan_id"> </param>
        public async Task<ulong> GetCertificateAsset(string scan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 127, 147, 44 };
            var scan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scan_idAbi.From(scan_id);

            var result = await base.SimApp(new List<object> { abiHandle, scan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCertificateAsset_Transactions(string scan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 127, 147, 44 };
            var scan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scan_idAbi.From(scan_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, scan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read total number of certificates issued.
        ///</summary>
        public async Task<ulong> GetTotalCertificates(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 123, 102, 216 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalCertificates_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 123, 102, 216 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmxvY2tkQ2VydGlmaWNhdGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imlzc3VlX2NlcnRpZmljYXRlIiwiZGVzYyI6Ik1pbnQgYSBDZXJ0aWZpY2F0ZSBORlQgYW5kIHJlY29yZCBpdCBvbi1jaGFpbi4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2Nhbl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXBmc191cmwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY2VydGlmaWNhdGVfYXNzZXQiLCJkZXNjIjoiUmV0cmlldmUgdGhlIG1pbnRlZCBBc3NldCBJRCBmb3IgYSBzY2FuLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY2FuX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdG90YWxfY2VydGlmaWNhdGVzIiwiZGVzYyI6IlJlYWQgdG90YWwgbnVtYmVyIG9mIGNlcnRpZmljYXRlcyBpc3N1ZWQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE5MV0sImVycm9yTWVzc2FnZSI6IkNlcnRpZmljYXRlIGFscmVhZHkgaXNzdWVkIGZvciBzY2FuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg4XSwiZXJyb3JNZXNzYWdlIjoiQ2VydGlmaWNhdGUgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc0XSwiZXJyb3JNZXNzYWdlIjoiT25seSBpc3N1ZXIgY2FuIGlzc3VlIGNlcnRpZmljYXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaXNzdWVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MywzMDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2NlcnRpZmljYXRlcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDAsMTU2LDI3MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NywxNjMsMjc3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MV0sImVycm9yTWVzc2FnZSI6ImlwZnNfdXJsIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc4XSwiZXJyb3JNZXNzYWdlIjoic2Nhbl9pZCByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpZEc5MFlXeGZZMlZ5ZEdsbWFXTmhkR1Z6SWlBd2VERTFNV1kzWXpjMUlDSnBjM04xWlhJaUlDSmpaWEowYVdacFkyRjBaWE1pQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteHZZMnRrWDJObGNuUnBabWxqWVhSbEwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmWTJWeWRHbG1hV05oZEdWeklEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkY5alpYSjBhV1pwWTJGMFpYTWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHOWphMlJmWTJWeWRHbG1hV05oZEdVdlkyOXVkSEpoWTNRdWNIazZOd29nSUNBZ0x5OGdjMlZzWmk1MlpYSnphVzl1SUQwZ1UzUnlhVzVuS0NJeUxqQXVNQ0lwQ2lBZ0lDQndkWE5vWW5sMFpYTnpJQ0oyWlhKemFXOXVJaUFpTWk0d0xqQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNiMk5yWkY5alpYSjBhV1pwWTJGMFpTOWpiMjUwY21GamRDNXdlVG80Q2lBZ0lDQXZMeUJ6Wld4bUxtbHpjM1ZsY2lBOUlHRnlZelF1UVdSa2NtVnpjeWhIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOektRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWFYTnpkV1Z5SWdvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteHZZMnRrWDJObGNuUnBabWxqWVhSbEwyTnZiblJ5WVdOMExuQjVPak1LSUNBZ0lDOHZJR05zWVhOeklFSnNiMk5yWkVObGNuUnBabWxqWVhSbEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEa0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzFOV0ZrWkdGbU15QXdlRFE0TjJZNU16SmpJREI0T0RnM1lqWTJaRGdnTHk4Z2JXVjBhRzlrSUNKcGMzTjFaVjlqWlhKMGFXWnBZMkYwWlNoemRISnBibWNzYzNSeWFXNW5LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDJObGNuUnBabWxqWVhSbFgyRnpjMlYwS0hOMGNtbHVaeWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5MGIzUmhiRjlqWlhKMGFXWnBZMkYwWlhNb0tYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHbHpjM1ZsWDJObGNuUnBabWxqWVhSbElHZGxkRjlqWlhKMGFXWnBZMkYwWlY5aGMzTmxkQ0JuWlhSZmRHOTBZV3hmWTJWeWRHbG1hV05oZEdWekNpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHOWphMlJmWTJWeWRHbG1hV05oZEdVdlkyOXVkSEpoWTNRdWNIazZNd29nSUNBZ0x5OGdZMnhoYzNNZ1FteHZZMnRrUTJWeWRHbG1hV05oZEdVb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFJqTldNMk1XSmhJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5amNtVmhkR1ZmY205MWRHVkFNVEFLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZmNtOTFkR1ZBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14dlkydGtYMk5sY25ScFptbGpZWFJsTDJOdmJuUnlZV04wTG5CNU9qRXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU3dnWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNUNiRzlqYTJSRFpYSjBhV1pwWTJGMFpTNXBjM04xWlY5alpYSjBhV1pwWTJGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx6YzNWbFgyTmxjblJwWm1sallYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNiMk5yWkY5alpYSjBhV1pwWTJGMFpTOWpiMjUwY21GamRDNXdlVG94TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHOWphMlJmWTJWeWRHbG1hV05oZEdVdlkyOXVkSEpoWTNRdWNIazZNakV0TWpJS0lDQWdJQzh2SUNNZ1FXTmpaWE56SUdOdmJuUnliMnc2SUdObGNuUnBabWxqWVhSbGN5QnlaWEJ5WlhObGJuUWdZVzRnWVhSMFpYTjBZWFJwYjI0Z1lXNWtJRzExYzNRZ1ltVWdhWE56ZFdWeUxXTnZiblJ5YjJ4c1pXUUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtnUFQwZ2MyVnNaaTVwYzNOMVpYSXNJQ0pQYm14NUlHbHpjM1ZsY2lCallXNGdhWE56ZFdVZ1kyVnlkR2xtYVdOaGRHVnpJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1semMzVmxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1cGMzTjFaWElnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dhWE56ZFdWeUlHTmhiaUJwYzNOMVpTQmpaWEowYVdacFkyRjBaWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZlkyVnlkR2xtYVdOaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TWpNS0lDQWdJQzh2SUdGemMyVnlkQ0J6WTJGdVgybGtMQ0FpYzJOaGJsOXBaQ0J5WlhGMWFYSmxaQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QnpZMkZ1WDJsa0lISmxjWFZwY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14dlkydGtYMk5sY25ScFptbGpZWFJsTDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QmhjM05sY25RZ2FYQm1jMTkxY213c0lDSnBjR1p6WDNWeWJDQnlaWEYxYVhKbFpDSUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnYVhCbWMxOTFjbXdnY21WeGRXbHlaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZlkyVnlkR2xtYVdOaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TWpVS0lDQWdJQzh2SUdGemMyVnlkQ0J6WTJGdVgybGtJRzV2ZENCcGJpQnpaV3htTG1ObGNuUnBabWxqWVhSbGN5d2dJa05sY25ScFptbGpZWFJsSUdGc2NtVmhaSGtnYVhOemRXVmtJR1p2Y2lCelkyRnVJZ29nSUNBZ1lubDBaV05mTXlBdkx5QWlZMlZ5ZEdsbWFXTmhkR1Z6SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRMlZ5ZEdsbWFXTmhkR1VnWVd4eVpXRmtlU0JwYzNOMVpXUWdabTl5SUhOallXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHOWphMlJmWTJWeWRHbG1hV05oZEdVdlkyOXVkSEpoWTNRdWNIazZNamN0TXpVS0lDQWdJQzh2SUNNZ1RtOTBaVG9nVFVKU0lHWnZjaUIwYUdVZ1ltOTRJR0Z1WkNCMGFHVWdZWE56WlhRZ2JYVnpkQ0JpWlNCamIzWmxjbVZrSUdKNUlIUm9aU0JqWVd4c1pYSUtJQ0FnSUM4dklHRnpjMlYwWDIxcGJuUWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOVUzUnlhVzVuS0NKQ2JHOWphMFFnUTJWeWRHbG1hV05oZEdVaUtTd0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFgyNWhiV1U5VTNSeWFXNW5LQ0pDVEV0RUlpa3NDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzlNU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3owd0xBb2dJQ0FnTHk4Z0lDQWdJR1JsWm1GMWJIUmZabkp2ZW1WdVBVWmhiSE5sTEFvZ0lDQWdMeThnSUNBZ0lIVnliRDFwY0daelgzVnliQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZVa3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZlkyVnlkR2xtYVdOaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TXpNS0lDQWdJQzh2SUdSbFptRjFiSFJmWm5KdmVtVnVQVVpoYkhObExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRVpXWmhkV3gwUm5KdmVtVnVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteHZZMnRrWDJObGNuUnBabWxqWVhSbEwyTnZiblJ5WVdOMExuQjVPak15Q2lBZ0lDQXZMeUJrWldOcGJXRnNjejB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJFWldOcGJXRnNjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNiMk5yWkY5alpYSjBhV1pwWTJGMFpTOWpiMjUwY21GamRDNXdlVG96TVFvZ0lDQWdMeThnZEc5MFlXdzlNU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWRzkwWVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkc5amEyUmZZMlZ5ZEdsbWFXTmhkR1V2WTI5dWRISmhZM1F1Y0hrNk16QUtJQ0FnSUM4dklIVnVhWFJmYm1GdFpUMVRkSEpwYm1jb0lrSk1TMFFpS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUFpUWt4TFJDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc2IyTnJaRjlqWlhKMGFXWnBZMkYwWlM5amIyNTBjbUZqZEM1d2VUb3lPUW9nSUNBZ0x5OGdZWE56WlhSZmJtRnRaVDFUZEhKcGJtY29Ja0pzYjJOclJDQkRaWEowYVdacFkyRjBaU0lwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pDYkc5amEwUWdRMlZ5ZEdsbWFXTmhkR1VpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVG1GdFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc2IyTnJaRjlqWlhKMGFXWnBZMkYwWlM5amIyNTBjbUZqZEM1d2VUb3lOeTB5T0FvZ0lDQWdMeThnSXlCT2IzUmxPaUJOUWxJZ1ptOXlJSFJvWlNCaWIzZ2dZVzVrSUhSb1pTQmhjM05sZENCdGRYTjBJR0psSUdOdmRtVnlaV1FnWW5rZ2RHaGxJR05oYkd4bGNnb2dJQ0FnTHk4Z1lYTnpaWFJmYldsdWRDQTlJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNCd2RYTm9hVzUwSURNZ0x5OGdZV05tWndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteHZZMnRrWDJObGNuUnBabWxqWVhSbEwyTnZiblJ5WVdOMExuQjVPakkzTFRNMUNpQWdJQ0F2THlBaklFNXZkR1U2SUUxQ1VpQm1iM0lnZEdobElHSnZlQ0JoYm1RZ2RHaGxJR0Z6YzJWMElHMTFjM1FnWW1VZ1kyOTJaWEpsWkNCaWVTQjBhR1VnWTJGc2JHVnlDaUFnSUNBdkx5QmhjM05sZEY5dGFXNTBJRDBnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl1WVcxbFBWTjBjbWx1WnlnaVFteHZZMnRFSUVObGNuUnBabWxqWVhSbElpa3NDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFZOMGNtbHVaeWdpUWt4TFJDSXBMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNQVEVzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNOU1Dd0tJQ0FnSUM4dklDQWdJQ0JrWldaaGRXeDBYMlp5YjNwbGJqMUdZV3h6WlN3S0lDQWdJQzh2SUNBZ0lDQjFjbXc5YVhCbWMxOTFjbXdzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJEY21WaGRHVmtRWE56WlhSSlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc2IyTnJaRjlqWlhKMGFXWnBZMkYwWlM5amIyNTBjbUZqZEM1d2VUb3pPUzAwTUFvZ0lDQWdMeThnSXlCTllYQWdkR2hsSUhOallXNWZhV1FnZEc4Z2RHaGxJR055WldGMFpXUWdZWE56WlhRZ2FXUUtJQ0FnSUM4dklITmxiR1l1WTJWeWRHbG1hV05oZEdWelczTmpZVzVmYVdSZElEMGdZM0psWVhSbFpGOWhjM05sZEY5cFpBb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZlkyVnlkR2xtYVdOaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TkRFS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZlkyVnlkR2xtYVdOaGRHVnpJQ3M5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjNSaGJGOWpaWEowYVdacFkyRjBaWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmWTJWeWRHbG1hV05oZEdWeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnZkR0ZzWDJObGNuUnBabWxqWVhSbGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteHZZMnRrWDJObGNuUnBabWxqWVhSbEwyTnZiblJ5WVdOMExuQjVPakUwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEM1Q2JHOWphMlJEWlhKMGFXWnBZMkYwWlM1blpYUmZZMlZ5ZEdsbWFXTmhkR1ZmWVhOelpYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZlkyVnlkR2xtYVdOaGRHVmZZWE56WlhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14dlkydGtYMk5sY25ScFptbGpZWFJsTDJOdmJuUnlZV04wTG5CNU9qUTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14dlkydGtYMk5sY25ScFptbGpZWFJsTDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5QmhjM05sY25RZ2MyTmhibDlwWkNCcGJpQnpaV3htTG1ObGNuUnBabWxqWVhSbGN5d2dJa05sY25ScFptbGpZWFJsSUc1dmRDQm1iM1Z1WkNJS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1ObGNuUnBabWxqWVhSbGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEWlhKMGFXWnBZMkYwWlNCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkc5amEyUmZZMlZ5ZEdsbWFXTmhkR1V2WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbU5sY25ScFptbGpZWFJsYzF0elkyRnVYMmxrWFFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14dlkydGtYMk5sY25ScFptbGpZWFJsTDJOdmJuUnlZV04wTG5CNU9qUTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNUNiRzlqYTJSRFpYSjBhV1pwWTJGMFpTNW5aWFJmZEc5MFlXeGZZMlZ5ZEdsbWFXTmhkR1Z6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYM1J2ZEdGc1gyTmxjblJwWm1sallYUmxjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZlkyVnlkR2xtYVdOaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TlRRS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxuUnZkR0ZzWDJObGNuUnBabWxqWVhSbGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYMk5sY25ScFptbGpZWFJsY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5alpYSjBhV1pwWTJGMFpYTWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14dlkydGtYMk5sY25ScFptbGpZWFJsTDJOdmJuUnlZV04wTG5CNU9qVXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBRUNKZ1FTZEc5MFlXeGZZMlZ5ZEdsbWFXTmhkR1Z6QkJVZmZIVUdhWE56ZFdWeURHTmxjblJwWm1sallYUmxjekVZUUFBWUtDSm5nZ0lIZG1WeWMybHZiZ1V5TGpBdU1HY3FNZ2xuTVJrVVJERVlRUUFkZ2dNRVZhM2E4d1JJZjVNc0JJaDdadGcyR2dDT0F3QVJBSk1BdFFDQUJFeGNZYm8yR2dDT0FRQUJBQ05ETmhvQlNTSlpKQWhMQVJVU1JGY0NBRFlhQWtraVdTUUlTd0VWRWtSWEFnQXhBQ0lxWlVRU1JFc0JGVVJKRlVRclR3SlFTYjFGQVJSRXNVeXlKeUt5SkNLeUl5T3lJb0FFUWt4TFJMSWxnQkpDYkc5amEwUWdRMlZ5ZEdsbWFXTmhkR1d5Sm9FRHNoQWlzZ0d6dER3V1RFc0J2eUlvWlVRakNDaE1aeWxNVUxBalF6WWFBVWtpV1NRSVN3RVZFa1JYQWdBclRGQkp2VVVCUkw1SUZ4WXBURkN3STBNaUtHVkVGaWxNVUxBalF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
