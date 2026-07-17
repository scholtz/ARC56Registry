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

namespace Arc56.Generated.ranadebsaha.algorand_risein.CertificateRegistry_8e25c8ba
{


    //
    // 
    //    A smart contract for registering and verifying certificate hashes on the Algorand blockchain.
    //    It uses Algorand's Box storage to map a certificate's hash to its owner's address.
    //    
    //
    public class CertificateRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CertificateRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Registers a new certificate hash and associates it with the transaction sender.
        ///</summary>
        /// <param name="cert_hash">The SHA-256 hash of the certificate file. </param>
        public async Task RegisterCertificate(byte[] cert_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 102, 247, 231 };
            var cert_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cert_hashAbi.From(cert_hash);

            var result = await base.CallApp(new List<object> { abiHandle, cert_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterCertificate_Transactions(byte[] cert_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 102, 247, 231 };
            var cert_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cert_hashAbi.From(cert_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, cert_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verifies if a given certificate hash is registered and returns the owner's address.
        ///</summary>
        /// <param name="cert_hash">The SHA-256 hash of the certificate to verify. </param>
        public async Task<byte[]> VerifyCertificate(byte[] cert_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 149, 39, 14 };
            var cert_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cert_hashAbi.From(cert_hash);

            var result = await base.CallApp(new List<object> { abiHandle, cert_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> VerifyCertificate_Transactions(byte[] cert_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 149, 39, 14 };
            var cert_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cert_hashAbi.From(cert_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, cert_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfers ownership of a certificate to a new address.
        ///This can only be called by the current owner of the certificate.
        ///</summary>
        /// <param name="cert_hash">The hash of the certificate to transfer. </param>
        /// <param name="new_owner">The Algorand address of the new owner. </param>
        public async Task TransferCertificate(byte[] cert_hash, byte[] new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 234, 18, 219 };
            var cert_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cert_hashAbi.From(cert_hash);
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); new_ownerAbi.From(new_owner);

            var result = await base.CallApp(new List<object> { abiHandle, cert_hashAbi, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferCertificate_Transactions(byte[] cert_hash, byte[] new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 234, 18, 219 };
            var cert_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cert_hashAbi.From(cert_hash);
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); new_ownerAbi.From(new_owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, cert_hashAbi, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2VydGlmaWNhdGVSZWdpc3RyeSIsImRlc2MiOiJcbiAgICBBIHNtYXJ0IGNvbnRyYWN0IGZvciByZWdpc3RlcmluZyBhbmQgdmVyaWZ5aW5nIGNlcnRpZmljYXRlIGhhc2hlcyBvbiB0aGUgQWxnb3JhbmQgYmxvY2tjaGFpbi5cbiAgICBJdCB1c2VzIEFsZ29yYW5kJ3MgQm94IHN0b3JhZ2UgdG8gbWFwIGEgY2VydGlmaWNhdGUncyBoYXNoIHRvIGl0cyBvd25lcidzIGFkZHJlc3MuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InJlZ2lzdGVyX2NlcnRpZmljYXRlIiwiZGVzYyI6IlJlZ2lzdGVycyBhIG5ldyBjZXJ0aWZpY2F0ZSBoYXNoIGFuZCBhc3NvY2lhdGVzIGl0IHdpdGggdGhlIHRyYW5zYWN0aW9uIHNlbmRlci4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2VydF9oYXNoIiwiZGVzYyI6IlRoZSBTSEEtMjU2IGhhc2ggb2YgdGhlIGNlcnRpZmljYXRlIGZpbGUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9jZXJ0aWZpY2F0ZSIsImRlc2MiOiJWZXJpZmllcyBpZiBhIGdpdmVuIGNlcnRpZmljYXRlIGhhc2ggaXMgcmVnaXN0ZXJlZCBhbmQgcmV0dXJucyB0aGUgb3duZXIncyBhZGRyZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjZXJ0X2hhc2giLCJkZXNjIjoiVGhlIFNIQS0yNTYgaGFzaCBvZiB0aGUgY2VydGlmaWNhdGUgdG8gdmVyaWZ5LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgb3duZXIncyBhZGRyZXNzIGFzIEJ5dGVzIGlmIGZvdW5kLCBvdGhlcndpc2UgYW4gZW1wdHkgQnl0ZXMgc3RyaW5nLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyX2NlcnRpZmljYXRlIiwiZGVzYyI6IlRyYW5zZmVycyBvd25lcnNoaXAgb2YgYSBjZXJ0aWZpY2F0ZSB0byBhIG5ldyBhZGRyZXNzLlxuVGhpcyBjYW4gb25seSBiZSBjYWxsZWQgYnkgdGhlIGN1cnJlbnQgb3duZXIgb2YgdGhlIGNlcnRpZmljYXRlLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjZXJ0X2hhc2giLCJkZXNjIjoiVGhlIGhhc2ggb2YgdGhlIGNlcnRpZmljYXRlIHRvIHRyYW5zZmVyLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X293bmVyIiwiZGVzYyI6IlRoZSBBbGdvcmFuZCBhZGRyZXNzIG9mIHRoZSBuZXcgb3duZXIuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTU5XSwiZXJyb3JNZXNzYWdlIjoiQ2VydGlmaWNhdGUgaGFzaCBpcyBhbHJlYWR5IHJlZ2lzdGVyZWQuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk3XSwiZXJyb3JNZXNzYWdlIjoiQ2VydGlmaWNhdGUgbm90IGZvdW5kIG9yIG5vdCByZWdpc3RlcmVkLiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5LDgzLDExOF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMV0sImVycm9yTWVzc2FnZSI6IlBlcm1pc3Npb24gZGVuaWVkOiBPbmx5IHRoZSBjdXJyZW50IG93bmVyIGNhbiB0cmFuc2Zlci4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2Miw4NiwxMjFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMlZ5ZEdsbWFXTmhkR1ZmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1UTJWeWRHbG1hV05oZEdWU1pXZHBjM1J5ZVM1ZlgyRnNaMjl3ZVY5bGJuUnllWEJ2YVc1MFgzZHBkR2hmYVc1cGRDZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNElDSmpaWEowYVdacFkyRjBaWE1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMlZ5ZEdsbWFXTmhkR1ZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1USUtJQ0FnSUM4dklHTnNZWE56SUVObGNuUnBabWxqWVhSbFVtVm5hWE4wY25rb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEE0Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TlRjMk5tWTNaVGNnTUhnelpUazFNamN3WlNBd2VHSmlaV0V4TW1SaUlDOHZJRzFsZEdodlpDQWljbVZuYVhOMFpYSmZZMlZ5ZEdsbWFXTmhkR1VvWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luWmxjbWxtZVY5alpYSjBhV1pwWTJGMFpTaGllWFJsVzEwcFlubDBaVnRkSWl3Z2JXVjBhRzlrSUNKMGNtRnVjMlpsY2w5alpYSjBhV1pwWTJGMFpTaGllWFJsVzEwc1lubDBaVnRkS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgzSmxaMmx6ZEdWeVgyTmxjblJwWm1sallYUmxYM0p2ZFhSbFFEVWdiV0ZwYmw5MlpYSnBabmxmWTJWeWRHbG1hV05oZEdWZmNtOTFkR1ZBTmlCdFlXbHVYM1J5WVc1elptVnlYMk5sY25ScFptbGpZWFJsWDNKdmRYUmxRRGNLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5alpYSjBhV1pwWTJGMFpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TWdvZ0lDQWdMeThnWTJ4aGMzTWdRMlZ5ZEdsbWFXTmhkR1ZTWldkcGMzUnllU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnY0hWemFHbHVkQ0F3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBjbUZ1YzJabGNsOWpaWEowYVdacFkyRjBaVjl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmxjblJwWm1sallYUmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pRM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmxjblJwWm1sallYUmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeUNpQWdJQ0F2THlCamJHRnpjeUJEWlhKMGFXWnBZMkYwWlZKbFoybHpkSEo1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWlhKMGFXWnBZMkYwWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzBOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJSFJ5WVc1elptVnlYMk5sY25ScFptbGpZWFJsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1psY21sbWVWOWpaWEowYVdacFkyRjBaVjl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmxjblJwWm1sallYUmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pNMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmxjblJwWm1sallYUmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeUNpQWdJQ0F2THlCamJHRnpjeUJEWlhKMGFXWnBZMkYwWlZKbFoybHpkSEo1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJObGNuUnBabWxqWVhSbFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnZG1WeWFXWjVYMk5sY25ScFptbGpZWFJsQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxaMmx6ZEdWeVgyTmxjblJwWm1sallYUmxYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyVnlkR2xtYVdOaGRHVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyVnlkR2xtYVdOaGRHVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRJS0lDQWdJQzh2SUdOc1lYTnpJRU5sY25ScFptbGpZWFJsVW1WbmFYTjBjbmtvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJWeWRHbG1hV05oZEdWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJ5WldkcGMzUmxjbDlqWlhKMGFXWnBZMkYwWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5alpYSjBhV1pwWTJGMFpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TWdvZ0lDQWdMeThnWTJ4aGMzTWdRMlZ5ZEdsbWFXTmhkR1ZTWldkcGMzUnllU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyVnlkR2xtYVdOaGRHVmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRMlZ5ZEdsbWFXTmhkR1ZTWldkcGMzUnllUzV5WldkcGMzUmxjbDlqWlhKMGFXWnBZMkYwWlNoalpYSjBYMmhoYzJnNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2w5alpYSjBhV1pwWTJGMFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5alpYSjBhV1pwWTJGMFpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG95TVMweU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2NtVm5hWE4wWlhKZlkyVnlkR2xtYVdOaGRHVW9jMlZzWml3Z1kyVnlkRjlvWVhOb09pQkNlWFJsY3lrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmxjblJwWm1sallYUmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJNENpQWdJQ0F2THlCbGVHbHpkR2x1WjE5dmQyNWxjaUE5SUhObGJHWXVZMlZ5ZEdsbWFXTmhkR1Z6TG1kbGRDaGpaWEowWDJoaGMyZ3NJR1JsWm1GMWJIUTlRbmwwWlhNb1lpSWlLU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU5sY25ScFptbGpZWFJsY3lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5sY25ScFptbGpZWFJsWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qTXdMVE14Q2lBZ0lDQXZMeUFqSUZWelpTQjBhR1VnYkc5M1pYSmpZWE5sSUNkaGMzTmxjblFuSUd0bGVYZHZjbVFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEdsdVoxOXZkMjVsY2lBOVBTQkNlWFJsY3loaUlpSXBMQ0FpUTJWeWRHbG1hV05oZEdVZ2FHRnphQ0JwY3lCaGJISmxZV1I1SUhKbFoybHpkR1Z5WldRdUlnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJEWlhKMGFXWnBZMkYwWlNCb1lYTm9JR2x6SUdGc2NtVmhaSGtnY21WbmFYTjBaWEpsWkM0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWlhKMGFXWnBZMkYwWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3pNd29nSUNBZ0x5OGdjMlZzWmk1alpYSjBhV1pwWTJGMFpYTmJZMlZ5ZEY5b1lYTm9YU0E5SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqWlhKMGFXWnBZMkYwWlY5eVpXZHBjM1J5ZVM1amIyNTBjbUZqZEM1RFpYSjBhV1pwWTJGMFpWSmxaMmx6ZEhKNUxuWmxjbWxtZVY5alpYSjBhV1pwWTJGMFpTaGpaWEowWDJoaGMyZzZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tkbVZ5YVdaNVgyTmxjblJwWm1sallYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmxjblJwWm1sallYUmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pNMUxUTTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQjJaWEpwWm5sZlkyVnlkR2xtYVdOaGRHVW9jMlZzWml3Z1kyVnlkRjlvWVhOb09pQkNlWFJsY3lrZ0xUNGdRbmwwWlhNNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpaWEowYVdacFkyRjBaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvME5Bb2dJQ0FnTHk4Z2IzZHVaWElnUFNCelpXeG1MbU5sY25ScFptbGpZWFJsY3k1blpYUW9ZMlZ5ZEY5b1lYTm9MQ0JrWldaaGRXeDBQVUo1ZEdWektHSWlJaWtwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pqWlhKMGFXWnBZMkYwWlhNaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJWeWRHbG1hV05oZEdWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZORFVLSUNBZ0lDOHZJSEpsZEhWeWJpQnZkMjVsY2dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU5sY25ScFptbGpZWFJsWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGtObGNuUnBabWxqWVhSbFVtVm5hWE4wY25rdWRISmhibk5tWlhKZlkyVnlkR2xtYVdOaGRHVW9ZMlZ5ZEY5b1lYTm9PaUJpZVhSbGN5d2dibVYzWDI5M2JtVnlPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tkSEpoYm5ObVpYSmZZMlZ5ZEdsbWFXTmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMlZ5ZEdsbWFXTmhkR1ZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5EY3RORGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JSFJ5WVc1elptVnlYMk5sY25ScFptbGpZWFJsS0hObGJHWXNJR05sY25SZmFHRnphRG9nUW5sMFpYTXNJRzVsZDE5dmQyNWxjam9nUW5sMFpYTXBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWlhKMGFXWnBZMkYwWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzFOZ29nSUNBZ0x5OGdZM1Z5Y21WdWRGOXZkMjVsY2lBOUlITmxiR1l1WTJWeWRHbG1hV05oZEdWekxtZGxkQ2hqWlhKMFgyaGhjMmdzSUdSbFptRjFiSFE5UW5sMFpYTW9ZaUlpS1NrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1ObGNuUnBabWxqWVhSbGN5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJObGNuUnBabWxqWVhSbFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalU0TFRVNUNpQWdJQ0F2THlBaklGVnpaU0IwYUdVZ2JHOTNaWEpqWVhObElDZGhjM05sY25RbklHdGxlWGR2Y21RS0lDQWdJQzh2SUdGemMyVnlkQ0JqZFhKeVpXNTBYMjkzYm1WeUlDRTlJRUo1ZEdWektHSWlJaWtzSUNKRFpYSjBhV1pwWTJGMFpTQnViM1FnWm05MWJtUWdiM0lnYm05MElISmxaMmx6ZEdWeVpXUXVJZ29nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVObGNuUnBabWxqWVhSbElHNXZkQ0JtYjNWdVpDQnZjaUJ1YjNRZ2NtVm5hWE4wWlhKbFpDNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5alpYSjBhV1pwWTJGMFpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8yTVMwMk1nb2dJQ0FnTHk4Z0l5QlZjMlVnZEdobElHeHZkMlZ5WTJGelpTQW5ZWE56WlhKMEp5QnJaWGwzYjNKa0NpQWdJQ0F2THlCaGMzTmxjblFnWTNWeWNtVnVkRjl2ZDI1bGNpQTlQU0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpMQ0FpVUdWeWJXbHpjMmx2YmlCa1pXNXBaV1E2SUU5dWJIa2dkR2hsSUdOMWNuSmxiblFnYjNkdVpYSWdZMkZ1SUhSeVlXNXpabVZ5TGlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHVnliV2x6YzJsdmJpQmtaVzVwWldRNklFOXViSGtnZEdobElHTjFjbkpsYm5RZ2IzZHVaWElnWTJGdUlIUnlZVzV6Wm1WeUxnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJObGNuUnBabWxqWVhSbFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJ6Wld4bUxtTmxjblJwWm1sallYUmxjMXRqWlhKMFgyaGhjMmhkSUQwZ2JtVjNYMjkzYm1WeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUJBU1lDQUF4alpYSjBhV1pwWTJGMFpYTXhHMEVBYklJREJGZG05K2NFUHBVbkRnUzc2aExiTmhvQWpnTUFQZ0FiQUFPQkFFTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ1Z3SUFpQUJuSWtNeEdSUkVNUmhFTmhvQlZ3SUFpQUJJU1JVV1Z3WUNURkNBQkJVZmZIVk1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQ0lBQTBpUXpFWlFQK3JNUmdVUkNKRGlnRUFLWXYvVUVtK0tFNENUU2dTUkRFQVN3RzhTTCtKaWdFQktZdi9VTDRvVGdKTmlZb0NBQ21ML2xCSnZpaE9BazFKS0JORU1RQVNSRW04U0l2L3Y0az0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
