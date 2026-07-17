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

namespace Arc56.Generated.Danish0703.ComplianceAudit.CertificateManager_f5a82a2e
{


    public class CertificateManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CertificateManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="metadata_hash"> </param>
        /// <param name="expires_at_round"> </param>
        public async Task<ulong> IssueCertificate(Address wallet, string metadata_hash, ulong expires_at_round, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 125, 72, 178, 84 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var metadata_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadata_hashAbi.From(metadata_hash);
            var expires_at_roundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expires_at_roundAbi.From(expires_at_round);

            var result = await base.CallApp(new List<object> { abiHandle, walletRefIndex, metadata_hashAbi, expires_at_roundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IssueCertificate_Transactions(Address wallet, string metadata_hash, ulong expires_at_round, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 125, 72, 178, 84 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var metadata_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadata_hashAbi.From(metadata_hash);
            var expires_at_roundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expires_at_roundAbi.From(expires_at_round);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex, metadata_hashAbi, expires_at_roundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="certificate_id"> </param>
        public async Task RevokeCertificate(ulong certificate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 190, 37, 121 };
            var certificate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); certificate_idAbi.From(certificate_id);

            var result = await base.CallApp(new List<object> { abiHandle, certificate_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeCertificate_Transactions(ulong certificate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 190, 37, 121 };
            var certificate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); certificate_idAbi.From(certificate_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, certificate_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="certificate_id"> </param>
        /// <param name="wallet"> </param>
        public async Task<bool> VerifyCertificate(Address wallet, ulong certificate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 126, 96, 211, 49 };
            var certificate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); certificate_idAbi.From(certificate_id);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, certificate_idAbi, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyCertificate_Transactions(Address wallet, ulong certificate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 126, 96, 211, 49 };
            var certificate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); certificate_idAbi.From(certificate_id);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, certificate_idAbi, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="certificate_id"> </param>
        public async Task<string> GetCertificateMetadata(ulong certificate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 127, 98, 6 };
            var certificate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); certificate_idAbi.From(certificate_id);

            var result = await base.SimApp(new List<object> { abiHandle, certificate_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetCertificateMetadata_Transactions(ulong certificate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 127, 98, 6 };
            var certificate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); certificate_idAbi.From(certificate_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, certificate_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="certificate_id"> </param>
        public async Task<bool> IsCertificateActive(ulong certificate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 243, 243, 193 };
            var certificate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); certificate_idAbi.From(certificate_id);

            var result = await base.SimApp(new List<object> { abiHandle, certificate_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsCertificateActive_Transactions(ulong certificate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 243, 243, 193 };
            var certificate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); certificate_idAbi.From(certificate_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, certificate_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2VydGlmaWNhdGVNYW5hZ2VyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6Imlzc3VlX2NlcnRpZmljYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1ldGFkYXRhX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyZXNfYXRfcm91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VfY2VydGlmaWNhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2VydGlmaWNhdGVfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2NlcnRpZmljYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNlcnRpZmljYXRlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2NlcnRpZmljYXRlX21ldGFkYXRhIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNlcnRpZmljYXRlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19jZXJ0aWZpY2F0ZV9hY3RpdmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2VydGlmaWNhdGVfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM1Ml0sImVycm9yTWVzc2FnZSI6IkNlcnRpZmljYXRlIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4NV0sImVycm9yTWVzc2FnZSI6IkV4cGlyeSByb3VuZCBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4Ml0sImVycm9yTWVzc2FnZSI6Ik1ldGFkYXRhIGhhc2ggcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjksMTU0LDE4MiwyMTMsMjI5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBpc3N1ZSBjZXJ0aWZpY2F0ZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIHJldm9rZSBjZXJ0aWZpY2F0ZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjddLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzIsMTU3LDE4NSwyMTYsMjMyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubmV4dF9jZXJ0aWZpY2F0ZV9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyVnlkR2xtYVdOaGRHVmZiV0Z1WVdkbGNpNWpiMjUwY21GamRDNURaWEowYVdacFkyRjBaVTFoYm1GblpYSXVYMTloYkdkdmNIbGZaVzUwY25sd2IybHVkRjkzYVhSb1gybHVhWFFvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSW1OdFgyRmpkRjhpSUNKdVpYaDBYMk5sY25ScFptbGpZWFJsWDJsa0lpQXdlREF3SUNKamJWOXZkMjVsY2w4aUlDSmpiVjl0WlhSaFh5SWdJbU50WDJWNGNGOGlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJWeWRHbG1hV05oZEdWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNd29nSUNBZ0x5OGdjMlZzWmk1dVpYaDBYMk5sY25ScFptbGpZWFJsWDJsa0lEMGdWVWx1ZERZMEtERXBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnVaWGgwWDJObGNuUnBabWxqWVhSbFgybGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWlhKMGFXWnBZMkYwWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qVUtJQ0FnSUM4dklHTnNZWE56SUVObGNuUnBabWxqWVhSbFRXRnVZV2RsY2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREV3Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TjJRME9HSXlOVFFnTUhobU1XSmxNalUzT1NBd2VEZGxOakJrTXpNeElEQjROemszWmpZeU1EWWdNSGcyT0dZelpqTmpNU0F2THlCdFpYUm9iMlFnSW1semMzVmxYMk5sY25ScFptbGpZWFJsS0dGalkyOTFiblFzYzNSeWFXNW5MSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luSmxkbTlyWlY5alpYSjBhV1pwWTJGMFpTaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZG1WeWFXWjVYMk5sY25ScFptbGpZWFJsS0hWcGJuUTJOQ3hoWTJOdmRXNTBLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltZGxkRjlqWlhKMGFXWnBZMkYwWlY5dFpYUmhaR0YwWVNoMWFXNTBOalFwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0pwYzE5alpYSjBhV1pwWTJGMFpWOWhZM1JwZG1Vb2RXbHVkRFkwS1dKdmIyd2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgybHpjM1ZsWDJObGNuUnBabWxqWVhSbFgzSnZkWFJsUURVZ2JXRnBibDl5WlhadmEyVmZZMlZ5ZEdsbWFXTmhkR1ZmY205MWRHVkFOaUJ0WVdsdVgzWmxjbWxtZVY5alpYSjBhV1pwWTJGMFpWOXliM1YwWlVBM0lHMWhhVzVmWjJWMFgyTmxjblJwWm1sallYUmxYMjFsZEdGa1lYUmhYM0p2ZFhSbFFEZ2diV0ZwYmw5cGMxOWpaWEowYVdacFkyRjBaVjloWTNScGRtVmZjbTkxZEdWQU9Rb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5sY25ScFptbGpZWFJsWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nUTJWeWRHbG1hV05oZEdWTllXNWhaMlZ5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgybHpYMk5sY25ScFptbGpZWFJsWDJGamRHbDJaVjl5YjNWMFpVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmxjblJwWm1sallYUmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TmpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmxjblJwWm1sallYUmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdRMlZ5ZEdsbWFXTmhkR1ZOWVc1aFoyVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJWeWRHbG1hV05oZEdWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzJNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWTJGc2JITjFZaUJwYzE5alpYSjBhV1pwWTJGMFpWOWhZM1JwZG1VS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5alpYSjBhV1pwWTJGMFpWOXRaWFJoWkdGMFlWOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJObGNuUnBabWxqWVhSbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOVFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJObGNuUnBabWxqWVhSbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1EyVnlkR2xtYVdOaGRHVk5ZVzVoWjJWeUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMlZ5ZEdsbWFXTmhkR1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmWTJWeWRHbG1hV05oZEdWZmJXVjBZV1JoZEdFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1psY21sbWVWOWpaWEowYVdacFkyRjBaVjl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmxjblJwWm1sallYUmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TkRFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmxjblJwWm1sallYUmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdRMlZ5ZEdsbWFXTmhkR1ZOWVc1aFoyVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aGN5QkJZMk52ZFc1MGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJObGNuUnBabWxqWVhSbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOREVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdOaGJHeHpkV0lnZG1WeWFXWjVYMk5sY25ScFptbGpZWFJsQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaWFp2YTJWZlkyVnlkR2xtYVdOaGRHVmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5alpYSjBhV1pwWTJGMFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5sY25ScFptbGpZWFJsWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nUTJWeWRHbG1hV05oZEdWTllXNWhaMlZ5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyVnlkR2xtYVdOaGRHVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG96TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJSEpsZG05clpWOWpaWEowYVdacFkyRjBaUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXBjM04xWlY5alpYSjBhV1pwWTJGMFpWOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJObGNuUnBabWxqWVhSbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMlZ5ZEdsbWFXTmhkR1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJEWlhKMGFXWnBZMkYwWlUxaGJtRm5aWElvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJObGNuUnBabWxqWVhSbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQnBjM04xWlY5alpYSjBhV1pwWTJGMFpRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMlZ5ZEdsbWFXTmhkR1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJEWlhKMGFXWnBZMkYwWlUxaGJtRm5aWElvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTmxjblJwWm1sallYUmxYMjFoYm1GblpYSXVZMjl1ZEhKaFkzUXVRMlZ5ZEdsbWFXTmhkR1ZOWVc1aFoyVnlMbWx6YzNWbFgyTmxjblJwWm1sallYUmxLSGRoYkd4bGREb2dZbmwwWlhNc0lHMWxkR0ZrWVhSaFgyaGhjMmc2SUdKNWRHVnpMQ0JsZUhCcGNtVnpYMkYwWDNKdmRXNWtPaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LYVhOemRXVmZZMlZ5ZEdsbWFXTmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMlZ5ZEdsbWFXTmhkR1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE5TMHlNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ2FYTnpkV1ZmWTJWeWRHbG1hV05oZEdVb0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3S0lDQWdJQzh2SUNBZ0lDQjNZV3hzWlhRNklFRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdiV1YwWVdSaGRHRmZhR0Z6YURvZ1UzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lHVjRjR2x5WlhOZllYUmZjbTkxYm1RNklGVkpiblEyTkN3S0lDQWdJQzh2SUNrZ0xUNGdWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMlZ5ZEdsbWFXTmhkR1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0lrOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2FYTnpkV1VnWTJWeWRHbG1hV05oZEdWeklnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2FYTnpkV1VnWTJWeWRHbG1hV05oZEdWekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJWeWRHbG1hV05oZEdWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3lNd29nSUNBZ0x5OGdZWE56WlhKMElHMWxkR0ZrWVhSaFgyaGhjMmd1WW5sMFpYTXViR1Z1WjNSb0lENGdWVWx1ZERZMEtEQXBMQ0FpVFdWMFlXUmhkR0VnYUdGemFDQnlaWEYxYVhKbFpDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnVFdWMFlXUmhkR0VnYUdGemFDQnlaWEYxYVhKbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJObGNuUnBabWxqWVhSbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNalFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlSEJwY21WelgyRjBYM0p2ZFc1a0lENGdWVWx1ZERZMEtEQXBMQ0FpUlhod2FYSjVJSEp2ZFc1a0lHMTFjM1FnWW1VZ1BpQXdJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxjblFnTHk4Z1JYaHdhWEo1SUhKdmRXNWtJRzExYzNRZ1ltVWdQaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMlZ5ZEdsbWFXTmhkR1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU5nb2dJQ0FnTHk4Z1kyVnlkRjlwWkNBOUlITmxiR1l1Ym1WNGRGOWpaWEowYVdacFkyRjBaVjlwWkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTVsZUhSZlkyVnlkR2xtYVdOaGRHVmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJtVjRkRjlqWlhKMGFXWnBZMkYwWlY5cFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWlhKMGFXWnBZMkYwWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qSTNDaUFnSUNBdkx5QnpaV3htTG1ObGNuUnBabWxqWVhSbFgyOTNibVZ5VzJObGNuUmZhV1JkSUQwZ2QyRnNiR1YwQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbU50WDI5M2JtVnlYeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJObGNuUnBabWxqWVhSbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNamdLSUNBZ0lDOHZJSE5sYkdZdVkyVnlkR2xtYVdOaGRHVmZiV1YwWVdSaGRHRmJZMlZ5ZEY5cFpGMGdQU0J0WlhSaFpHRjBZVjlvWVhOb0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKamJWOXRaWFJoWHlJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpaWEowYVdacFkyRjBaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pJNUNpQWdJQ0F2THlCelpXeG1MbU5sY25ScFptbGpZWFJsWDJWNGNHbHllVnRqWlhKMFgybGtYU0E5SUdWNGNHbHlaWE5mWVhSZmNtOTFibVFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbU50WDJWNGNGOGlDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWlhKMGFXWnBZMkYwWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qTXdDaUFnSUNBdkx5QnpaV3htTG1ObGNuUnBabWxqWVhSbFgyRmpkR2wyWlZ0alpYSjBYMmxrWFNBOUlGVkpiblEyTkNneEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkyMWZZV04wWHlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5alpYSjBhV1pwWTJGMFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJ6Wld4bUxtNWxlSFJmWTJWeWRHbG1hV05oZEdWZmFXUWdQU0JqWlhKMFgybGtJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKdVpYaDBYMk5sY25ScFptbGpZWFJsWDJsa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5alpYSjBhV1pwWTJGMFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPak16Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZMlZ5ZEY5cFpBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1ObGNuUnBabWxqWVhSbFgyMWhibUZuWlhJdVkyOXVkSEpoWTNRdVEyVnlkR2xtYVdOaGRHVk5ZVzVoWjJWeUxuSmxkbTlyWlY5alpYSjBhV1pwWTJGMFpTaGpaWEowYVdacFkyRjBaVjlwWkRvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dweVpYWnZhMlZmWTJWeWRHbG1hV05oZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJWeWRHbG1hV05oZEdWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3pOUzB6TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdjbVYyYjJ0bFgyTmxjblJwWm1sallYUmxLSE5sYkdZc0lHTmxjblJwWm1sallYUmxYMmxrT2lCVlNXNTBOalFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5alpYSjBhV1pwWTJGMFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPak0zQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQ0FpVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJ5WlhadmEyVWdZMlZ5ZEdsbWFXTmhkR1Z6SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZM0psWVhSdmNpQmpZVzRnY21WMmIydGxJR05sY25ScFptbGpZWFJsY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5sY25ScFptbGpZWFJsWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk16Z0tJQ0FnSUM4dklHRnpjMlZ5ZENCalpYSjBhV1pwWTJGMFpWOXBaQ0JwYmlCelpXeG1MbU5sY25ScFptbGpZWFJsWDJGamRHbDJaU3dnSWtObGNuUnBabWxqWVhSbElHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkyMWZZV04wWHlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRaWEowYVdacFkyRjBaU0J1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpaWEowYVdacFkyRjBaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pNNUNpQWdJQ0F2THlCelpXeG1MbU5sY25ScFptbGpZWFJsWDJGamRHbDJaVnRqWlhKMGFXWnBZMkYwWlY5cFpGMGdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMlZ5ZEdsbWFXTmhkR1ZmYldGdVlXZGxjaTVqYjI1MGNtRmpkQzVEWlhKMGFXWnBZMkYwWlUxaGJtRm5aWEl1ZG1WeWFXWjVYMk5sY25ScFptbGpZWFJsS0dObGNuUnBabWxqWVhSbFgybGtPaUIxYVc1ME5qUXNJSGRoYkd4bGREb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tkbVZ5YVdaNVgyTmxjblJwWm1sallYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmxjblJwWm1sallYUmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TkRFdE5ESUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQjJaWEpwWm5sZlkyVnlkR2xtYVdOaGRHVW9jMlZzWml3Z1kyVnlkR2xtYVdOaGRHVmZhV1E2SUZWSmJuUTJOQ3dnZDJGc2JHVjBPaUJCWTJOdmRXNTBLU0F0UGlCaWIyOXNPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJWeWRHbG1hV05oZEdWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzBNd29nSUNBZ0x5OGdZV04wYVhabExDQmhZM1JwZG1WZlpYaHBjM1J6SUQwZ2MyVnNaaTVqWlhKMGFXWnBZMkYwWlY5aFkzUnBkbVV1YldGNVltVW9ZMlZ5ZEdsbWFXTmhkR1ZmYVdRcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1OdFgyRmpkRjhpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMlZ5ZEdsbWFXTmhkR1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvME5Bb2dJQ0FnTHk4Z2IzZHVaWElzSUc5M2JtVnlYMlY0YVhOMGN5QTlJSE5sYkdZdVkyVnlkR2xtYVdOaGRHVmZiM2R1WlhJdWJXRjVZbVVvWTJWeWRHbG1hV05oZEdWZmFXUXBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmpiVjl2ZDI1bGNsOGlDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JqYjNabGNpQXpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMlZ5ZEdsbWFXTmhkR1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvME5Rb2dJQ0FnTHk4Z1pYaHdhWEo1TENCbGVIQnBjbmxmWlhocGMzUnpJRDBnYzJWc1ppNWpaWEowYVdacFkyRjBaVjlsZUhCcGNua3ViV0Y1WW1Vb1kyVnlkR2xtYVdOaGRHVmZhV1FwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pqYlY5bGVIQmZJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWlhKMGFXWnBZMkYwWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qUTNDaUFnSUNBdkx5QnBaaUJ1YjNRZ1lXTjBhWFpsWDJWNGFYTjBjeUJ2Y2lCdWIzUWdiM2R1WlhKZlpYaHBjM1J6SUc5eUlHNXZkQ0JsZUhCcGNubGZaWGhwYzNSek9nb2dJQ0FnWW5vZ2RtVnlhV1o1WDJObGNuUnBabWxqWVhSbFgybG1YMkp2WkhsQU13b2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR0o2SUhabGNtbG1lVjlqWlhKMGFXWnBZMkYwWlY5cFpsOWliMlI1UURNS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQmlibm9nZG1WeWFXWjVYMk5sY25ScFptbGpZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9LZG1WeWFXWjVYMk5sY25ScFptbGpZWFJsWDJsbVgySnZaSGxBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWlhKMGFXWnBZMkYwWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5QnlaWFIxY200Z1JtRnNjMlVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LZG1WeWFXWjVYMk5sY25ScFptbGpZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpaWEowYVdacFkyRjBaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pRNUNpQWdJQ0F2THlCcFppQmhZM1JwZG1VZ0lUMGdWVWx1ZERZMEtERXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FoUFFvZ0lDQWdZbm9nZG1WeWFXWjVYMk5sY25ScFptbGpZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmxjblJwWm1sallYUmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TlRBS0lDQWdJQzh2SUhKbGRIVnliaUJHWVd4elpRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncDJaWEpwWm5sZlkyVnlkR2xtYVdOaGRHVmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJObGNuUnBabWxqWVhSbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOVEVLSUNBZ0lDOHZJR2xtSUc5M2JtVnlJQ0U5SUhkaGJHeGxkRG9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNFOUNpQWdJQ0JpZWlCMlpYSnBabmxmWTJWeWRHbG1hV05oZEdWZllXWjBaWEpmYVdaZlpXeHpaVUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMlZ5ZEdsbWFXTmhkR1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUVaaGJITmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDblpsY21sbWVWOWpaWEowYVdacFkyRjBaVjloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyVnlkR2xtYVdOaGRHVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnY21WMGRYSnVJRWRzYjJKaGJDNXliM1Z1WkNBOFBTQmxlSEJwY25rS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lEdzlDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1alpYSjBhV1pwWTJGMFpWOXRZVzVoWjJWeUxtTnZiblJ5WVdOMExrTmxjblJwWm1sallYUmxUV0Z1WVdkbGNpNW5aWFJmWTJWeWRHbG1hV05oZEdWZmJXVjBZV1JoZEdFb1kyVnlkR2xtYVdOaGRHVmZhV1E2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q21kbGRGOWpaWEowYVdacFkyRjBaVjl0WlhSaFpHRjBZVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpaWEowYVdacFkyRjBaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pVMUxUVTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdaMlYwWDJObGNuUnBabWxqWVhSbFgyMWxkR0ZrWVhSaEtITmxiR1lzSUdObGNuUnBabWxqWVhSbFgybGtPaUJWU1c1ME5qUXBJQzArSUZOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJObGNuUnBabWxqWVhSbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOVGNLSUNBZ0lDOHZJRzFsZEdGa1lYUmhMQ0JsZUdsemRITWdQU0J6Wld4bUxtTmxjblJwWm1sallYUmxYMjFsZEdGa1lYUmhMbTFoZVdKbEtHTmxjblJwWm1sallYUmxYMmxrS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pqYlY5dFpYUmhYeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJObGNuUnBabWxqWVhSbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOVGdLSUNBZ0lDOHZJR2xtSUdWNGFYTjBjem9LSUNBZ0lHSjZJR2RsZEY5alpYSjBhV1pwWTJGMFpWOXRaWFJoWkdGMFlWOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWlhKMGFXWnBZMkYwWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QnlaWFIxY200Z2JXVjBZV1JoZEdFS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NtZGxkRjlqWlhKMGFXWnBZMkYwWlY5dFpYUmhaR0YwWVY5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMlZ5ZEdsbWFXTmhkR1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpSWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU5sY25ScFptbGpZWFJsWDIxaGJtRm5aWEl1WTI5dWRISmhZM1F1UTJWeWRHbG1hV05oZEdWTllXNWhaMlZ5TG1selgyTmxjblJwWm1sallYUmxYMkZqZEdsMlpTaGpaWEowYVdacFkyRjBaVjlwWkRvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNtbHpYMk5sY25ScFptbGpZWFJsWDJGamRHbDJaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpaWEowYVdacFkyRjBaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pZeUxUWXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdhWE5mWTJWeWRHbG1hV05oZEdWZllXTjBhWFpsS0hObGJHWXNJR05sY25ScFptbGpZWFJsWDJsa09pQlZTVzUwTmpRcElDMCtJR0p2YjJ3NkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpaWEowYVdacFkyRjBaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pZMENpQWdJQ0F2THlCaFkzUnBkbVVzSUdWNGFYTjBjeUE5SUhObGJHWXVZMlZ5ZEdsbWFXTmhkR1ZmWVdOMGFYWmxMbTFoZVdKbEtHTmxjblJwWm1sallYUmxYMmxrS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pqYlY5aFkzUmZJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJWeWRHbG1hV05oZEdWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzJOUW9nSUNBZ0x5OGdjbVYwZFhKdUlHVjRhWE4wY3lCaGJtUWdZV04wYVhabElEMDlJRlZKYm5RMk5DZ3hLUW9nSUNBZ1lub2dhWE5mWTJWeWRHbG1hV05oZEdWZllXTjBhWFpsWDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2dhWE5mWTJWeWRHbG1hV05oZEdWZllXTjBhWFpsWDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0NtbHpYMk5sY25ScFptbGpZWFJsWDJGamRHbDJaVjlpYjI5c1gyMWxjbWRsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJWeWRHbG1hV05oZEdWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzJOUW9nSUNBZ0x5OGdjbVYwZFhKdUlHVjRhWE4wY3lCaGJtUWdZV04wYVhabElEMDlJRlZKYm5RMk5DZ3hLUW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dwcGMxOWpaWEowYVdacFkyRjBaVjloWTNScGRtVmZZbTl2YkY5bVlXeHpaVUF6T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdhWE5mWTJWeWRHbG1hV05oZEdWZllXTjBhWFpsWDJKdmIyeGZiV1Z5WjJWQU5Bbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQW1Cd1FWSDN4MUIyTnRYMkZqZEY4VGJtVjRkRjlqWlhKMGFXWnBZMkYwWlY5cFpBRUFDV050WDI5M2JtVnlYd2hqYlY5dFpYUmhYd2RqYlY5bGVIQmZNUmhBQUFNcUltY3hHMEVBc1lJRkJIMUlzbFFFOGI0bGVRUitZTk14QkhsL1lnWUVhUFB6d1RZYUFJNEZBR1lBVmdBM0FCc0FBaU5ETVJrVVJERVlSRFlhQVJlSUFVSXJJMDhDVkNoTVVMQWlRekVaRkVReEdFUTJHZ0VYaUFFVFNSVVdWd1lDVEZBb1RGQ3dJa014R1JSRU1SaEVOaG9CRnpZYUFoZkFISWdBbmlzalR3SlVLRXhRc0NKRE1Sa1VSREVZUkRZYUFSZUlBRzBpUXpFWkZFUXhHRVEyR2dFWHdCdzJHZ0pYQWdBMkdnTVhpQUFTRmloTVVMQWlRekVaUVA5ME1SZ1VSQ0pEaWdNQk1RQXlDUkpFaS80VlJJdi9SQ01xWlVSSkZpY0VTd0ZRaS8yL0p3VkxBVkJKdkVpTC9yOG5Ca3NCVUl2L0ZyOHBURkFpRnI5SklnZ3FUR2VKaWdFQU1RQXlDUkpFaS84V0tVeFFTYjFGQVVRakZyK0ppZ0lCaS80V0tVc0JVTDVNRjA0Q0p3UkxBbEMrVGdOT0FpY0dUd0pRdms0Q0YweEJBQXFMQVVFQUJZc0RRQUFFSTR3QWlZc0FJaE5CQUFRampBQ0ppd0tML3hOQkFBUWpqQUNKTWdhTEJBNk1BSW1LQVFHTC94WW5CVXhRdmtFQUJJc0FUSW1BQUV5SmlnRUJpLzhXS1V4UXZrd1hURUVBQ29zQUloSkJBQU1pVElralF2LzYiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
