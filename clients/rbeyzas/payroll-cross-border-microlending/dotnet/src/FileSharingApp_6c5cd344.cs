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

namespace Arc56.Generated.rbeyzas.payroll_cross_border_microlending.FileSharingApp_6c5cd344
{


    public class FileSharingAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FileSharingAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the file sharing application
        ///</summary>
        /// <param name="adminAddress">Admin address who can manage the system </param>
        public async Task Initialize(string adminAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 243, 57, 231 };
            var adminAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); adminAddressAbi.From(adminAddress);

            var result = await base.CallApp(new List<object> { abiHandle, adminAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(string adminAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 243, 57, 231 };
            var adminAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); adminAddressAbi.From(adminAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a file sharing request with escrow
        ///</summary>
        /// <param name="fileId">Unique identifier for the file </param>
        /// <param name="recipientAddress">Recipient's Algorand address </param>
        /// <param name="fileHash">SHA256 hash of the file content </param>
        /// <param name="fileSize">Size of the file in bytes </param>
        /// <param name="accessFee">Fee required to access the file (in microALGO) </param>
        /// <param name="fileType">Type of file (e.g., "payslip", "contract", "document") </param>
        /// <param name="isIPFS">Whether file is stored on IPFS (true) or WebRTC (false) </param>
        /// <param name="ipfsCID">IPFS Content ID (empty string if WebRTC) </param>
        public async Task CreateFileRequest(string fileId, string recipientAddress, string fileHash, string fileSize, string accessFee, string fileType, string isIPFS, string ipfsCID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 53, 207, 183 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);
            var recipientAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); recipientAddressAbi.From(recipientAddress);
            var fileHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileHashAbi.From(fileHash);
            var fileSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileSizeAbi.From(fileSize);
            var accessFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); accessFeeAbi.From(accessFee);
            var fileTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileTypeAbi.From(fileType);
            var isIPFSAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); isIPFSAbi.From(isIPFS);
            var ipfsCIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfsCIDAbi.From(ipfsCID);

            var result = await base.CallApp(new List<object> { abiHandle, fileIdAbi, recipientAddressAbi, fileHashAbi, fileSizeAbi, accessFeeAbi, fileTypeAbi, isIPFSAbi, ipfsCIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateFileRequest_Transactions(string fileId, string recipientAddress, string fileHash, string fileSize, string accessFee, string fileType, string isIPFS, string ipfsCID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 53, 207, 183 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);
            var recipientAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); recipientAddressAbi.From(recipientAddress);
            var fileHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileHashAbi.From(fileHash);
            var fileSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileSizeAbi.From(fileSize);
            var accessFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); accessFeeAbi.From(accessFee);
            var fileTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileTypeAbi.From(fileType);
            var isIPFSAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); isIPFSAbi.From(isIPFS);
            var ipfsCIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfsCIDAbi.From(ipfsCID);

            return await base.MakeTransactionList(new List<object> { abiHandle, fileIdAbi, recipientAddressAbi, fileHashAbi, fileSizeAbi, accessFeeAbi, fileTypeAbi, isIPFSAbi, ipfsCIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Recipient approves and pays for file access
        ///</summary>
        /// <param name="fileId">Unique identifier for the file </param>
        public async Task ApproveAndPay(string fileId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 73, 237, 56 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);

            var result = await base.CallApp(new List<object> { abiHandle, fileIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveAndPay_Transactions(string fileId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 73, 237, 56 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);

            return await base.MakeTransactionList(new List<object> { abiHandle, fileIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Recipient confirms file receipt and releases payment
        ///</summary>
        /// <param name="fileId">Unique identifier for the file </param>
        /// <param name="confirmationHash">Hash of the received file for verification </param>
        public async Task ConfirmReceipt(string fileId, string confirmationHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 56, 206, 212 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);
            var confirmationHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); confirmationHashAbi.From(confirmationHash);

            var result = await base.CallApp(new List<object> { abiHandle, fileIdAbi, confirmationHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConfirmReceipt_Transactions(string fileId, string confirmationHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 56, 206, 212 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);
            var confirmationHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); confirmationHashAbi.From(confirmationHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, fileIdAbi, confirmationHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Dispute file transfer - can be called by either party
        ///</summary>
        /// <param name="fileId">Unique identifier for the file </param>
        /// <param name="reason">Reason for dispute </param>
        public async Task DisputeTransfer(string fileId, string reason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 176, 174, 166 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);

            var result = await base.CallApp(new List<object> { abiHandle, fileIdAbi, reasonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DisputeTransfer_Transactions(string fileId, string reason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 176, 174, 166 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);

            return await base.MakeTransactionList(new List<object> { abiHandle, fileIdAbi, reasonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin resolves dispute
        ///</summary>
        /// <param name="fileId">Unique identifier for the file </param>
        /// <param name="resolution">Resolution: "sender_wins" or "recipient_wins" </param>
        public async Task ResolveDispute(string fileId, string resolution, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 190, 253, 198 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);
            var resolutionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); resolutionAbi.From(resolution);

            var result = await base.CallApp(new List<object> { abiHandle, fileIdAbi, resolutionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ResolveDispute_Transactions(string fileId, string resolution, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 190, 253, 198 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);
            var resolutionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); resolutionAbi.From(resolution);

            return await base.MakeTransactionList(new List<object> { abiHandle, fileIdAbi, resolutionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cancel file request (only by sender before approval)
        ///</summary>
        /// <param name="fileId">Unique identifier for the file </param>
        public async Task CancelRequest(string fileId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 167, 238, 192 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);

            var result = await base.CallApp(new List<object> { abiHandle, fileIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CancelRequest_Transactions(string fileId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 167, 238, 192 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);

            return await base.MakeTransactionList(new List<object> { abiHandle, fileIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get file request information
        ///</summary>
        /// <param name="fileId">Unique identifier for the file </param>
        public async Task<string> GetFileRequest(string fileId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 4, 37, 206 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);

            var result = await base.CallApp(new List<object> { abiHandle, fileIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetFileRequest_Transactions(string fileId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 4, 37, 206 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);

            return await base.MakeTransactionList(new List<object> { abiHandle, fileIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get all file requests for a user (sender or recipient)
        ///</summary>
        /// <param name="userAddress">User's Algorand address </param>
        public async Task<string> GetUserFileRequests(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 28, 53, 156 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetUserFileRequests_Transactions(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 28, 53, 156 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update file metadata (only by sender before approval)
        ///</summary>
        /// <param name="fileId">Unique identifier for the file </param>
        /// <param name="newFileHash">New file hash </param>
        /// <param name="newFileSize">New file size </param>
        /// <param name="newAccessFee">New access fee </param>
        public async Task UpdateFileMetadata(string fileId, string newFileHash, string newFileSize, string newAccessFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 44, 124, 131 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);
            var newFileHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newFileHashAbi.From(newFileHash);
            var newFileSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newFileSizeAbi.From(newFileSize);
            var newAccessFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newAccessFeeAbi.From(newAccessFee);

            var result = await base.CallApp(new List<object> { abiHandle, fileIdAbi, newFileHashAbi, newFileSizeAbi, newAccessFeeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateFileMetadata_Transactions(string fileId, string newFileHash, string newFileSize, string newAccessFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 44, 124, 131 };
            var fileIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fileIdAbi.From(fileId);
            var newFileHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newFileHashAbi.From(newFileHash);
            var newFileSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newFileSizeAbi.From(newFileSize);
            var newAccessFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newAccessFeeAbi.From(newAccessFee);

            return await base.MakeTransactionList(new List<object> { abiHandle, fileIdAbi, newFileHashAbi, newFileSizeAbi, newAccessFeeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency withdrawal by admin (for stuck funds)
        ///</summary>
        /// <param name="amount">Amount to withdraw in microALGO </param>
        public async Task EmergencyWithdraw(string amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 120, 9, 68 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> EmergencyWithdraw_Transactions(string amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 120, 9, 68 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get application statistics
        ///</summary>
        public async Task<string> GetStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 89, 194, 17 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 89, 194, 17 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRmlsZVNoYXJpbmdBcHAiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBmaWxlIHNoYXJpbmcgYXBwbGljYXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW5BZGRyZXNzIiwiZGVzYyI6IkFkbWluIGFkZHJlc3Mgd2hvIGNhbiBtYW5hZ2UgdGhlIHN5c3RlbSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVGaWxlUmVxdWVzdCIsImRlc2MiOiJDcmVhdGUgYSBmaWxlIHNoYXJpbmcgcmVxdWVzdCB3aXRoIGVzY3JvdyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWxlSWQiLCJkZXNjIjoiVW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBmaWxlIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnRBZGRyZXNzIiwiZGVzYyI6IlJlY2lwaWVudCdzIEFsZ29yYW5kIGFkZHJlc3MiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpbGVIYXNoIiwiZGVzYyI6IlNIQTI1NiBoYXNoIG9mIHRoZSBmaWxlIGNvbnRlbnQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpbGVTaXplIiwiZGVzYyI6IlNpemUgb2YgdGhlIGZpbGUgaW4gYnl0ZXMiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY2Vzc0ZlZSIsImRlc2MiOiJGZWUgcmVxdWlyZWQgdG8gYWNjZXNzIHRoZSBmaWxlIChpbiBtaWNyb0FMR08pIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWxlVHlwZSIsImRlc2MiOiJUeXBlIG9mIGZpbGUgKGUuZy4sIFwicGF5c2xpcFwiLCBcImNvbnRyYWN0XCIsIFwiZG9jdW1lbnRcIikiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlzSVBGUyIsImRlc2MiOiJXaGV0aGVyIGZpbGUgaXMgc3RvcmVkIG9uIElQRlMgKHRydWUpIG9yIFdlYlJUQyAoZmFsc2UpIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpcGZzQ0lEIiwiZGVzYyI6IklQRlMgQ29udGVudCBJRCAoZW1wdHkgc3RyaW5nIGlmIFdlYlJUQykiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXBwcm92ZUFuZFBheSIsImRlc2MiOiJSZWNpcGllbnQgYXBwcm92ZXMgYW5kIHBheXMgZm9yIGZpbGUgYWNjZXNzIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpbGVJZCIsImRlc2MiOiJVbmlxdWUgaWRlbnRpZmllciBmb3IgdGhlIGZpbGUiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29uZmlybVJlY2VpcHQiLCJkZXNjIjoiUmVjaXBpZW50IGNvbmZpcm1zIGZpbGUgcmVjZWlwdCBhbmQgcmVsZWFzZXMgcGF5bWVudCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWxlSWQiLCJkZXNjIjoiVW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBmaWxlIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb25maXJtYXRpb25IYXNoIiwiZGVzYyI6Ikhhc2ggb2YgdGhlIHJlY2VpdmVkIGZpbGUgZm9yIHZlcmlmaWNhdGlvbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkaXNwdXRlVHJhbnNmZXIiLCJkZXNjIjoiRGlzcHV0ZSBmaWxlIHRyYW5zZmVyIC0gY2FuIGJlIGNhbGxlZCBieSBlaXRoZXIgcGFydHkiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmlsZUlkIiwiZGVzYyI6IlVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUgZmlsZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhc29uIiwiZGVzYyI6IlJlYXNvbiBmb3IgZGlzcHV0ZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNvbHZlRGlzcHV0ZSIsImRlc2MiOiJBZG1pbiByZXNvbHZlcyBkaXNwdXRlIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpbGVJZCIsImRlc2MiOiJVbmlxdWUgaWRlbnRpZmllciBmb3IgdGhlIGZpbGUiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc29sdXRpb24iLCJkZXNjIjoiUmVzb2x1dGlvbjogXCJzZW5kZXJfd2luc1wiIG9yIFwicmVjaXBpZW50X3dpbnNcIiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5jZWxSZXF1ZXN0IiwiZGVzYyI6IkNhbmNlbCBmaWxlIHJlcXVlc3QgKG9ubHkgYnkgc2VuZGVyIGJlZm9yZSBhcHByb3ZhbCkiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmlsZUlkIiwiZGVzYyI6IlVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUgZmlsZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRGaWxlUmVxdWVzdCIsImRlc2MiOiJHZXQgZmlsZSByZXF1ZXN0IGluZm9ybWF0aW9uIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpbGVJZCIsImRlc2MiOiJVbmlxdWUgaWRlbnRpZmllciBmb3IgdGhlIGZpbGUiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjoiRmlsZSByZXF1ZXN0IGluZm8gYXMgSlNPTiBzdHJpbmcifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRVc2VyRmlsZVJlcXVlc3RzIiwiZGVzYyI6IkdldCBhbGwgZmlsZSByZXF1ZXN0cyBmb3IgYSB1c2VyIChzZW5kZXIgb3IgcmVjaXBpZW50KSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQWRkcmVzcyIsImRlc2MiOiJVc2VyJ3MgQWxnb3JhbmQgYWRkcmVzcyIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJMaXN0IG9mIGZpbGUgcmVxdWVzdHMgYXMgSlNPTiBzdHJpbmcifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVGaWxlTWV0YWRhdGEiLCJkZXNjIjoiVXBkYXRlIGZpbGUgbWV0YWRhdGEgKG9ubHkgYnkgc2VuZGVyIGJlZm9yZSBhcHByb3ZhbCkiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmlsZUlkIiwiZGVzYyI6IlVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUgZmlsZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3RmlsZUhhc2giLCJkZXNjIjoiTmV3IGZpbGUgaGFzaCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3RmlsZVNpemUiLCJkZXNjIjoiTmV3IGZpbGUgc2l6ZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QWNjZXNzRmVlIiwiZGVzYyI6Ik5ldyBhY2Nlc3MgZmVlIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVtZXJnZW5jeVdpdGhkcmF3IiwiZGVzYyI6IkVtZXJnZW5jeSB3aXRoZHJhd2FsIGJ5IGFkbWluIChmb3Igc3R1Y2sgZnVuZHMpIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiJBbW91bnQgdG8gd2l0aGRyYXcgaW4gbWljcm9BTEdPIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFN0YXRzIiwiZGVzYyI6IkdldCBhcHBsaWNhdGlvbiBzdGF0aXN0aWNzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlN0YXRpc3RpY3MgYXMgSlNPTiBzdHJpbmcifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEwNiwxMjYsMTM1LDE0NCwxNjQsMTkxLDIwMCwyMDksMjE4LDIyNywyMzYsMjQ1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU5XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA5LDEyOSwxMzgsMTQ3LDE2NywxOTQsMjAzLDIxMiwyMjEsMjMwLDIzOSwyNDhdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnBiR1ZmYzJoaGNtbHVaMTloY0hBdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdSbWxzWlZOb1lYSnBibWRCY0hBZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UY0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGxZMll6TXpsbE55QXdlRGcxTXpWalptSTNJREI0WmpFME9XVmtNemdnTUhobU9ETTRZMlZrTkNBd2VHVTJZakJoWldFMklEQjROVEppWldaa1l6WWdNSGcyTkdFM1pXVmpNQ0F3ZUdZek1EUXlOV05sSURCNFpqSXhZek0xT1dNZ01IZ3dNREpqTjJNNE15QXdlR1ptTnpnd09UUTBJREI0WldVMU9XTXlNVEVnTHk4Z2JXVjBhRzlrSUNKcGJtbDBhV0ZzYVhwbEtITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0pqY21WaGRHVkdhV3hsVW1WeGRXVnpkQ2h6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ3Y0hKdmRtVkJibVJRWVhrb2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU52Ym1acGNtMVNaV05sYVhCMEtITjBjbWx1Wnl4emRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWlaR2x6Y0hWMFpWUnlZVzV6Wm1WeUtITjBjbWx1Wnl4emRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWljbVZ6YjJ4MlpVUnBjM0IxZEdVb2MzUnlhVzVuTEhOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSmpZVzVqWld4U1pYRjFaWE4wS0hOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJHYVd4bFVtVnhkV1Z6ZENoemRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSVmMyVnlSbWxzWlZKbGNYVmxjM1J6S0hOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJblZ3WkdGMFpVWnBiR1ZOWlhSaFpHRjBZU2h6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWlaVzFsY21kbGJtTjVWMmwwYUdSeVlYY29jM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGTjBZWFJ6S0NsemRISnBibWNpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMmx1YVhScFlXeHBlbVZmY205MWRHVkFNeUJ0WVdsdVgyTnlaV0YwWlVacGJHVlNaWEYxWlhOMFgzSnZkWFJsUURRZ2JXRnBibDloY0hCeWIzWmxRVzVrVUdGNVgzSnZkWFJsUURVZ2JXRnBibDlqYjI1bWFYSnRVbVZqWldsd2RGOXliM1YwWlVBMklHMWhhVzVmWkdsemNIVjBaVlJ5WVc1elptVnlYM0p2ZFhSbFFEY2diV0ZwYmw5eVpYTnZiSFpsUkdsemNIVjBaVjl5YjNWMFpVQTRJRzFoYVc1ZlkyRnVZMlZzVW1WeGRXVnpkRjl5YjNWMFpVQTVJRzFoYVc1ZloyVjBSbWxzWlZKbGNYVmxjM1JmY205MWRHVkFNVEFnYldGcGJsOW5aWFJWYzJWeVJtbHNaVkpsY1hWbGMzUnpYM0p2ZFhSbFFERXhJRzFoYVc1ZmRYQmtZWFJsUm1sc1pVMWxkR0ZrWVhSaFgzSnZkWFJsUURFeUlHMWhhVzVmWlcxbGNtZGxibU41VjJsMGFHUnlZWGRmY205MWRHVkFNVE1nYldGcGJsOW5aWFJUZEdGMGMxOXliM1YwWlVBeE5Bb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpwYkdWZmMyaGhjbWx1WjE5aGNIQXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUm1sc1pWTm9ZWEpwYm1kQmNIQWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCd2RYTm9hVzUwSURBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZOMFlYUnpYM0p2ZFhSbFFERTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnBiR1ZmYzJoaGNtbHVaMTloY0hBdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qSUtJQ0FnSUM4dklIQjFZbXhwWXlCblpYUlRkR0YwY3lncE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01ESTNZamRrQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaVzFsY21kbGJtTjVWMmwwYUdSeVlYZGZjbTkxZEdWQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptbHNaVjl6YUdGeWFXNW5YMkZ3Y0M5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdWdFpYSm5aVzVqZVZkcGRHaGtjbUYzS0dGdGIzVnVkRG9nYzNSeWFXNW5LVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRYQmtZWFJsUm1sc1pVMWxkR0ZrWVhSaFgzSnZkWFJsUURFeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJacGJHVmZjMmhoY21sdVoxOWhjSEF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURZS0lDQWdJQzh2SUhCMVlteHBZeUIxY0dSaGRHVkdhV3hsVFdWMFlXUmhkR0VvWm1sc1pVbGtPaUJ6ZEhKcGJtY3NJRzVsZDBacGJHVklZWE5vT2lCemRISnBibWNzSUc1bGQwWnBiR1ZUYVhwbE9pQnpkSEpwYm1jc0lHNWxkMEZqWTJWemMwWmxaVG9nYzNSeWFXNW5LVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBWWE5sY2tacGJHVlNaWEYxWlhOMGMxOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWFXeGxYM05vWVhKcGJtZGZZWEJ3TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RRS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSVmMyVnlSbWxzWlZKbGNYVmxjM1J6S0hWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01ESTFZalZrQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwUm1sc1pWSmxjWFZsYzNSZmNtOTFkR1ZBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1sc1pWOXphR0Z5YVc1blgyRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamcwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMlYwUm1sc1pWSmxjWFZsYzNRb1ptbHNaVWxrT2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURrMlpUWm1OelExWmpZMk5tWTNOVFpsTmpRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqWVc1alpXeFNaWEYxWlhOMFgzSnZkWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1sc1pWOXphR0Z5YVc1blgyRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZMkZ1WTJWc1VtVnhkV1Z6ZENobWFXeGxTV1E2SUhOMGNtbHVaeWs2SUhadmFXUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxjMjlzZG1WRWFYTndkWFJsWDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabWxzWlY5emFHRnlhVzVuWDJGd2NDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTNDaUFnSUNBdkx5QndkV0pzYVdNZ2NtVnpiMngyWlVScGMzQjFkR1VvWm1sc1pVbGtPaUJ6ZEhKcGJtY3NJSEpsYzI5c2RYUnBiMjQ2SUhOMGNtbHVaeWs2SUhadmFXUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyUnBjM0IxZEdWVWNtRnVjMlpsY2w5eWIzVjBaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpwYkdWZmMyaGhjbWx1WjE5aGNIQXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdjSFZpYkdsaklHUnBjM0IxZEdWVWNtRnVjMlpsY2lobWFXeGxTV1E2SUhOMGNtbHVaeXdnY21WaGMyOXVPaUJ6ZEhKcGJtY3BPaUIyYjJsa0lIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amIyNW1hWEp0VW1WalpXbHdkRjl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnBiR1ZmYzJoaGNtbHVaMTloY0hBdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdOdmJtWnBjbTFTWldObGFYQjBLR1pwYkdWSlpEb2djM1J5YVc1bkxDQmpiMjVtYVhKdFlYUnBiMjVJWVhOb09pQnpkSEpwYm1jcE9pQjJiMmxrSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloY0hCeWIzWmxRVzVrVUdGNVgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1sc1pWOXphR0Z5YVc1blgyRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEJ3Y205MlpVRnVaRkJoZVNobWFXeGxTV1E2SUhOMGNtbHVaeWs2SUhadmFXUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlVacGJHVlNaWEYxWlhOMFgzSnZkWFJsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1sc1pWOXphR0Z5YVc1blgyRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TFRNeUNpQWdJQ0F2THlCd2RXSnNhV01nWTNKbFlYUmxSbWxzWlZKbGNYVmxjM1FvQ2lBZ0lDQXZMeUFnSUdacGJHVkpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0J5WldOcGNHbGxiblJCWkdSeVpYTnpPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJR1pwYkdWSVlYTm9PaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJR1pwYkdWVGFYcGxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJR0ZqWTJWemMwWmxaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0JtYVd4bFZIbHdaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0JwYzBsUVJsTTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdhWEJtYzBOSlJEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYVc1cGRHbGhiR2w2WlY5eWIzVjBaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpwYkdWZmMyaGhjbWx1WjE5aGNIQXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QndkV0pzYVdNZ2FXNXBkR2xoYkdsNlpTaGhaRzFwYmtGa1pISmxjM002SUhOMGNtbHVaeWs2SUhadmFXUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEF4TnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYVd4bFgzTm9ZWEpwYm1kZllYQndMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVacGJHVlRhR0Z5YVc1blFYQndJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU1Rb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQkFURWJRUUR5Z2d3RTdQTTU1d1NGTmMrM0JQRko3VGdFK0RqTzFBVG1zSzZtQkZLKy9jWUVaS2Z1d0FUekJDWE9CUEljTlp3RUFDeDhnd1QvZUFsRUJPNVp3aEUyR2dDT0RBQ09BSVVBZkFCekFHb0FZUUJZQUQwQUtRQWdBQmNBQTRFQVF6RVpGRVF4R0VTQUNCVWZmSFVBQW50OXNDSkRNUmtVUkRFWVJDSkRNUmtVUkRFWVJDSkRNUmtVUkRFWVJJQUlGUjk4ZFFBQ1cxMndJa014R1JSRU1SaEVnQThWSDN4MUFBbHViM1JmWm05MWJtU3dJa014R1JSRU1SaEVJa014R1JSRU1SaEVJa014R1JSRU1SaEVJa014R1JSRU1SaEVJa014R1JSRU1SaEVJa014R1JSRU1SaEVJa014R1JSRU1SaEVJa014R1VEL1pERVlGRVFpUXc9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
