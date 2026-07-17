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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.SelfVerificationRootTest_da8e24d7
{


    //
    //  M13: Tests SelfVerificationRoot abstract contract integration.
    // A minimal concrete subclass that exposes testable internal functions
    // without requiring an actual hub or Poseidon deployment.
    //
    public class SelfVerificationRootTestProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SelfVerificationRootTestProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="destinationChainId"> </param>
        /// <param name="userIdentifier"> </param>
        /// <param name=""> </param>
        public async Task<byte[]> GetConfigId(byte[] destinationChainId, byte[] userIdentifier, byte[] , Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 212, 127, 95 };
            var destinationChainIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); destinationChainIdAbi.From(destinationChainId);
            var userIdentifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); userIdentifierAbi.From(userIdentifier);
            var Abi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); Abi.From();

            var result = await base.SimApp(new List<object> { abiHandle, destinationChainIdAbi, userIdentifierAbi, Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetConfigId_Transactions(byte[] destinationChainId, byte[] userIdentifier, byte[] , Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 212, 127, 95 };
            var destinationChainIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); destinationChainIdAbi.From(destinationChainId);
            var userIdentifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); userIdentifierAbi.From(userIdentifier);
            var Abi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); Abi.From();

            return await base.MakeTransactionList(new List<object> { abiHandle, destinationChainIdAbi, userIdentifierAbi, Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> TestScope(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 111, 224, 129 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> TestScope_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 111, 224, 129 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proofPayload"> </param>
        public async Task<byte[]> TestBuildBaseInput(byte[] proofPayload, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 74, 87, 124 };
            var proofPayloadAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proofPayloadAbi.From(proofPayload);

            var result = await base.SimApp(new List<object> { abiHandle, proofPayloadAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> TestBuildBaseInput_Transactions(byte[] proofPayload, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 74, 87, 124 };
            var proofPayloadAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proofPayloadAbi.From(proofPayload);

            return await base.MakeTransactionList(new List<object> { abiHandle, proofPayloadAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<byte[]> TestBytesConcat(byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 156, 235, 213 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            var result = await base.SimApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> TestBytesConcat_Transactions(byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 156, 235, 213 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="chainId"> </param>
        /// <param name="userId"> </param>
        public async Task<byte[]> TestConfigId(byte[] chainId, byte[] userId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 179, 154, 11 };
            var chainIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); chainIdAbi.From(chainId);
            var userIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); userIdAbi.From(userId);

            var result = await base.SimApp(new List<object> { abiHandle, chainIdAbi, userIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> TestConfigId_Transactions(byte[] chainId, byte[] userId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 179, 154, 11 };
            var chainIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); chainIdAbi.From(chainId);
            var userIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); userIdAbi.From(userId);

            return await base.MakeTransactionList(new List<object> { abiHandle, chainIdAbi, userIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="charcodes"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> TestPassportOlderThan(byte[] charcodes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 246, 175, 42 };
            var charcodesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); charcodesAbi.From(charcodes);

            var result = await base.SimApp(new List<object> { abiHandle, charcodesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> TestPassportOlderThan_Transactions(byte[] charcodes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 246, 175, 42 };
            var charcodesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); charcodesAbi.From(charcodes);

            return await base.MakeTransactionList(new List<object> { abiHandle, charcodesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="charcodes"> </param>
        /// <param name="start"> </param>
        /// <param name="end"> </param>
        public async Task<string> TestExtractString(byte[] charcodes, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 199, 160, 182 };
            var charcodesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); charcodesAbi.From(charcodes);

            var result = await base.SimApp(new List<object> { abiHandle, charcodesAbi, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> TestExtractString_Transactions(byte[] charcodes, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 199, 160, 182 };
            var charcodesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); charcodesAbi.From(charcodes);

            return await base.MakeTransactionList(new List<object> { abiHandle, charcodesAbi, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="s"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> TestStringToBigInt(string s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 206, 81, 77 };
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); sAbi.From(s);

            var result = await base.SimApp(new List<object> { abiHandle, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> TestStringToBigInt_Transactions(string s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 206, 81, 77 };
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); sAbi.From(s);

            return await base.MakeTransactionList(new List<object> { abiHandle, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="s"> </param>
        /// <param name="start"> </param>
        /// <param name="end"> </param>
        public async Task<string> TestSubstring(string s, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 224, 57, 169 };
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); sAbi.From(s);

            var result = await base.SimApp(new List<object> { abiHandle, sAbi, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> TestSubstring_Transactions(string s, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 224, 57, 169 };
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); sAbi.From(s);

            return await base.MakeTransactionList(new List<object> { abiHandle, sAbi, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Returns the current scope value
        /// @dev Public view function to access the current scope setting
        /// @return The scope value that proofs must match
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> Scope(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 220, 197, 44 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Scope_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 220, 197, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Verifies a self-proof using the bytes-based interface
        /// @dev Parses relayer data format and validates against contract settings before calling hub V2
        /// @param proofPayload Packed data from relayer in format: | 32 bytes attestationId | proof data |
        /// @param userContextData User-defined data in format: | 32 bytes destChainId | 32 bytes userIdentifier | data |
        /// @custom:data-format proofPayload = | 32 bytes attestationId | proofData |
        /// @custom:data-format userContextData = | 32 bytes destChainId | 32 bytes userIdentifier | data |
        /// @custom:data-format hubData = | 1 bytes contract version | 31 bytes buffer | 32 bytes scope | 32 bytes attestationId | proofData |
        ///</summary>
        /// <param name="proofPayload"> </param>
        /// <param name="userContextData"> </param>
        public async Task VerifySelfProof(byte[] proofPayload, byte[] userContextData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 175, 191, 197 };
            var proofPayloadAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proofPayloadAbi.From(proofPayload);
            var userContextDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userContextDataAbi.From(userContextData);

            var result = await base.CallApp(new List<object> { abiHandle, proofPayloadAbi, userContextDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VerifySelfProof_Transactions(byte[] proofPayload, byte[] userContextData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 175, 191, 197 };
            var proofPayloadAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proofPayloadAbi.From(proofPayload);
            var userContextDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userContextDataAbi.From(userContextData);

            return await base.MakeTransactionList(new List<object> { abiHandle, proofPayloadAbi, userContextDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Callback function called upon successful verification by the hub contract
        /// @dev Only callable by the identity verification hub V2 contract for security
        /// @param output The verification output data containing disclosed identity information
        /// @param userData The user-defined data passed through the verification process
        /// @custom:security Only the authorized hub contract can call this function
        /// @custom:flow This function decodes the output and calls the customizable verification hook
        ///</summary>
        /// <param name="output"> </param>
        /// <param name="userData"> </param>
        public async Task OnVerificationSuccess(byte[] output, byte[] userData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 202, 30, 187 };
            var outputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); outputAbi.From(output);
            var userDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userDataAbi.From(userData);

            var result = await base.CallApp(new List<object> { abiHandle, outputAbi, userDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OnVerificationSuccess_Transactions(byte[] output, byte[] userData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 202, 30, 187 };
            var outputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); outputAbi.From(output);
            var userDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userDataAbi.From(userData);

            return await base.MakeTransactionList(new List<object> { abiHandle, outputAbi, userDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2VsZlZlcmlmaWNhdGlvblJvb3RUZXN0IiwiZGVzYyI6IiBNMTM6IFRlc3RzIFNlbGZWZXJpZmljYXRpb25Sb290IGFic3RyYWN0IGNvbnRyYWN0IGludGVncmF0aW9uLlxuIEEgbWluaW1hbCBjb25jcmV0ZSBzdWJjbGFzcyB0aGF0IGV4cG9zZXMgdGVzdGFibGUgaW50ZXJuYWwgZnVuY3Rpb25zXG4gd2l0aG91dCByZXF1aXJpbmcgYW4gYWN0dWFsIGh1YiBvciBQb3NlaWRvbiBkZXBsb3ltZW50LiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRDb25maWdJZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlc3RpbmF0aW9uQ2hhaW5JZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VySWRlbnRpZmllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RTY29wZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RCdWlsZEJhc2VJbnB1dCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9vZlBheWxvYWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RCeXRlc0NvbmNhdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0Q29uZmlnSWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFpbklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0UGFzc3BvcnRPbGRlclRoYW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhcmNvZGVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEV4dHJhY3RTdHJpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhcmNvZGVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RTdHJpbmdUb0JpZ0ludCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdFN1YnN0cmluZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNjb3BlIiwiZGVzYyI6IiBAbm90aWNlIFJldHVybnMgdGhlIGN1cnJlbnQgc2NvcGUgdmFsdWVcbiBAZGV2IFB1YmxpYyB2aWV3IGZ1bmN0aW9uIHRvIGFjY2VzcyB0aGUgY3VycmVudCBzY29wZSBzZXR0aW5nXG4gQHJldHVybiBUaGUgc2NvcGUgdmFsdWUgdGhhdCBwcm9vZnMgbXVzdCBtYXRjaCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeVNlbGZQcm9vZiIsImRlc2MiOiIgQG5vdGljZSBWZXJpZmllcyBhIHNlbGYtcHJvb2YgdXNpbmcgdGhlIGJ5dGVzLWJhc2VkIGludGVyZmFjZVxuIEBkZXYgUGFyc2VzIHJlbGF5ZXIgZGF0YSBmb3JtYXQgYW5kIHZhbGlkYXRlcyBhZ2FpbnN0IGNvbnRyYWN0IHNldHRpbmdzIGJlZm9yZSBjYWxsaW5nIGh1YiBWMlxuIEBwYXJhbSBwcm9vZlBheWxvYWQgUGFja2VkIGRhdGEgZnJvbSByZWxheWVyIGluIGZvcm1hdDogfCAzMiBieXRlcyBhdHRlc3RhdGlvbklkIHwgcHJvb2YgZGF0YSB8XG4gQHBhcmFtIHVzZXJDb250ZXh0RGF0YSBVc2VyLWRlZmluZWQgZGF0YSBpbiBmb3JtYXQ6IHwgMzIgYnl0ZXMgZGVzdENoYWluSWQgfCAzMiBieXRlcyB1c2VySWRlbnRpZmllciB8IGRhdGEgfFxuIEBjdXN0b206ZGF0YS1mb3JtYXQgcHJvb2ZQYXlsb2FkID0gfCAzMiBieXRlcyBhdHRlc3RhdGlvbklkIHwgcHJvb2ZEYXRhIHxcbiBAY3VzdG9tOmRhdGEtZm9ybWF0IHVzZXJDb250ZXh0RGF0YSA9IHwgMzIgYnl0ZXMgZGVzdENoYWluSWQgfCAzMiBieXRlcyB1c2VySWRlbnRpZmllciB8IGRhdGEgfFxuIEBjdXN0b206ZGF0YS1mb3JtYXQgaHViRGF0YSA9IHwgMSBieXRlcyBjb250cmFjdCB2ZXJzaW9uIHwgMzEgYnl0ZXMgYnVmZmVyIHwgMzIgYnl0ZXMgc2NvcGUgfCAzMiBieXRlcyBhdHRlc3RhdGlvbklkIHwgcHJvb2ZEYXRhIHwiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvb2ZQYXlsb2FkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQ29udGV4dERhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib25WZXJpZmljYXRpb25TdWNjZXNzIiwiZGVzYyI6IiBAbm90aWNlIENhbGxiYWNrIGZ1bmN0aW9uIGNhbGxlZCB1cG9uIHN1Y2Nlc3NmdWwgdmVyaWZpY2F0aW9uIGJ5IHRoZSBodWIgY29udHJhY3RcbiBAZGV2IE9ubHkgY2FsbGFibGUgYnkgdGhlIGlkZW50aXR5IHZlcmlmaWNhdGlvbiBodWIgVjIgY29udHJhY3QgZm9yIHNlY3VyaXR5XG4gQHBhcmFtIG91dHB1dCBUaGUgdmVyaWZpY2F0aW9uIG91dHB1dCBkYXRhIGNvbnRhaW5pbmcgZGlzY2xvc2VkIGlkZW50aXR5IGluZm9ybWF0aW9uXG4gQHBhcmFtIHVzZXJEYXRhIFRoZSB1c2VyLWRlZmluZWQgZGF0YSBwYXNzZWQgdGhyb3VnaCB0aGUgdmVyaWZpY2F0aW9uIHByb2Nlc3NcbiBAY3VzdG9tOnNlY3VyaXR5IE9ubHkgdGhlIGF1dGhvcml6ZWQgaHViIGNvbnRyYWN0IGNhbiBjYWxsIHRoaXMgZnVuY3Rpb25cbiBAY3VzdG9tOmZsb3cgVGhpcyBmdW5jdGlvbiBkZWNvZGVzIHRoZSBvdXRwdXQgYW5kIGNhbGxzIHRoZSBjdXN0b21pemFibGUgdmVyaWZpY2F0aW9uIGhvb2siLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3V0cHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyRGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjR9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzg3M10sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudENoYXJjb2RlTGVuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIzOCwxMjQ0XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZERhdGFGb3JtYXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDIwXSwiZXJyb3JNZXNzYWdlIjoiTm9uLUFTQ0lJIGNoYXJhY3RlciBkZXRlY3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4Nl0sImVycm9yTWVzc2FnZSI6IlN0cmluZyB0b28gbG9uZyBmb3IgQmlnSW50IGNvbnZlcnNpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzU3XSwiZXJyb3JNZXNzYWdlIjoiVW5hdXRob3JpemVkQ2FsbGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI5MCwxMzU0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX2lkZW50aXR5VmVyaWZpY2F0aW9uSHViVjIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjIxLDY1OSwxMTgyLDEyNzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfc2NvcGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTkxLDY0MSw2ODYsNzAzLDc3Miw4MzAsOTY4LDEwNjIsMTIwMiwxMjE5LDEzMjcsMTM0MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5OCw2NDksNjk0LDcxMSw3ODAsODM4LDk3NiwxMDcwLDEyMTAsMTIyNywxMzM1LDEzNDhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc2LDU4NSw3MzgsNzQ3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1Myw4NjQsMTA4MiwxMDkzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDUxMiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyNiw4MTcsMTA0NywxMTg3XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlluVnBiR1F2TGk0dlpYaGhiWEJzWlhNdmMyVnNabDltWldGMGRYSmxjeTlqYjI1MGNtRmpkSE12VFRFelgxTmxiR1pXWlhKcFptbGpZWFJwYjI1U2IyOTBWR1Z6ZEM1emIyd3VVMlZzWmxabGNtbG1hV05oZEdsdmJsSnZiM1JVWlhOMExtRndjSEp2ZG1Gc1gzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEZ2dOalFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0F3ZUNBaVgzTmpiM0JsSWlBaVgybGtaVzUwYVhSNVZtVnlhV1pwWTJGMGFXOXVTSFZpVmpJaUlEQjRNREVnWW1GelpUTXlLRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRXBJQ0pzWVhOMFFYUjBaWE4wWVhScGIyNUpaQ0lnSW14aGMzUlBiR1JsY2xSb1lXNGlJQ0l3TVRJek5EVTJOemc1WVdKalpHVm1JaUF3ZURsbU5URmhZell6SURCNE1ESXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z05Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWDNOamIzQmxJZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbDlwWkdWdWRHbDBlVlpsY21sbWFXTmhkR2x2YmtoMVlsWXlJZ29nSUNBZ1lubDBaV01nTlNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEySUM4dklDSnNZWE4wUVhSMFpYTjBZWFJwYjI1SlpDSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSnNZWE4wVDJ4a1pYSlVhR0Z1SWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWalh6TWdMeThnSWw5cFpHVnVkR2wwZVZabGNtbG1hV05oZEdsdmJraDFZbFl5SWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFlLSUNBZ0lIQjFjMmhwYm5RZ05ESXlNakFLSUNBZ0lHbDBiMklLSUNBZ0lHSTlQUW9nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl6Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQmlkWEo1SURNS0NtMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOHZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlluVnBiR1F2TGk0dlpYaGhiWEJzWlhNdmMyVnNabDltWldGMGRYSmxjeTlqYjI1MGNtRmpkSE12VFRFelgxTmxiR1pXWlhKcFptbGpZWFJwYjI1U2IyOTBWR1Z6ZEM1emIyd3VVMlZzWmxabGNtbG1hV05oZEdsdmJsSnZiM1JVWlhOMExsOW5aWFJRYjNObGFXUnZia0ZrWkhKbGMzTkFNalk2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZbmwwWldNZ05TQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lEMDlDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNamtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRHOWlDZ3B0WVdsdVgyRm1kR1Z5WDJsdWJHbHVaV1JmTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMkoxYVd4a0x5NHVMMlY0WVcxd2JHVnpMM05sYkdaZlptVmhkSFZ5WlhNdlkyOXVkSEpoWTNSekwwMHhNMTlUWld4bVZtVnlhV1pwWTJGMGFXOXVVbTl2ZEZSbGMzUXVjMjlzTGxObGJHWldaWEpwWm1sallYUnBiMjVTYjI5MFZHVnpkQzVmWTJGc1kzVnNZWFJsVTJOdmNHVkFNekU2Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pmYzJOdmNHVWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNU9nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE16QTNPREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaWRYSjVJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCaWRYSjVJRFFLQ20xaGFXNWZkMmhwYkdWZmRHOXdRRE16T2dvZ0lDQWdjSFZ6YUdsdWRDQXlNQW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHSStDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYM2RvYVd4bFFETTFDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURVS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWkdsbklERUtJQ0FnSUdJcUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWWlzS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ01USUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTBDaUFnSUNCaUt3b2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURVS0lDQWdJSE4zWVhBS0lDQWdJR2RsZEdKNWRHVUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUE0SUM4dklDSXdNVEl6TkRVMk56ZzVZV0pqWkdWbUlnb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWWlzS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ01UVUtJQ0FnSUNZS0lDQWdJR0o1ZEdWaklEZ2dMeThnSWpBeE1qTTBOVFkzT0RsaFltTmtaV1lpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEpsY0d4aFkyVXpDaUFnSUNCaWRYSjVJRE1LSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TVFvZ0lDQWdZaXNLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdZaUJ0WVdsdVgzZG9hV3hsWDNSdmNFQXpNd29LYldGcGJsOWhablJsY2w5M2FHbHNaVUF6TlRvS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdiV1YwYUc5a0lDSm9ZWE5vS0hWcGJuUXlOVFpiTWwwcGRXbHVkRFV4TWlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nT1NBdkx5QnRaWFJvYjJRZ0ltaGhjMmdvZFdsdWRESTFObHN5WFNsMWFXNTBOVEV5SWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybHViR2x1WldSZkwyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJKMWFXeGtMeTR1TDJWNFlXMXdiR1Z6TDNObGJHWmZabVZoZEhWeVpYTXZZMjl1ZEhKaFkzUnpMMDB4TTE5VFpXeG1WbVZ5YVdacFkyRjBhVzl1VW05dmRGUmxjM1F1YzI5c0xsTmxiR1pXWlhKcFptbGpZWFJwYjI1U2IyOTBWR1Z6ZEM1ZlkyRnNZM1ZzWVhSbFUyTnZjR1ZBTXpFS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlNem9LSUNBZ0lIQjFjMmhwYm5RZ01URXhOREl5TWpBS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBMUNpQWdJQ0JpUFQwS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU5Rb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWW5WeWVTQXpDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOHZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlluVnBiR1F2TGk0dlpYaGhiWEJzWlhNdmMyVnNabDltWldGMGRYSmxjeTlqYjI1MGNtRmpkSE12VFRFelgxTmxiR1pXWlhKcFptbGpZWFJwYjI1U2IyOTBWR1Z6ZEM1emIyd3VVMlZzWmxabGNtbG1hV05oZEdsdmJsSnZiM1JVWlhOMExsOW5aWFJRYjNObGFXUnZia0ZrWkhKbGMzTkFNallLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU5Ub0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JpZFhKNUlETUtJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBibXhwYm1Wa1h5OW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5aWRXbHNaQzh1TGk5bGVHRnRjR3hsY3k5elpXeG1YMlpsWVhSMWNtVnpMMk52Ym5SeVlXTjBjeTlOTVROZlUyVnNabFpsY21sbWFXTmhkR2x2YmxKdmIzUlVaWE4wTG5OdmJDNVRaV3htVm1WeWFXWnBZMkYwYVc5dVVtOXZkRlJsYzNRdVgyZGxkRkJ2YzJWcFpHOXVRV1JrY21WemMwQXlOZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMU5HUTBOMlkxWmlBd2VHRXdObVpsTURneElEQjROak0wWVRVM04yTWdNSGhrTkRsalpXSmtOU0F3ZUdZMVlqTTVZVEJpSURCNE9UWm1ObUZtTW1FZ01IaGlObU0zWVRCaU5pQXdlREUwWTJVMU1UUmtJREI0T0RabE1ETTVZVGtnTUhnM00yUmpZelV5WXlBd2VHUTJZV1ppWm1NMUlEQjRPR1JqWVRGbFltSWdMeThnYldWMGFHOWtJQ0puWlhSRGIyNW1hV2RKWkNoaWVYUmxXek15WFN4aWVYUmxXek15WFN4aWVYUmxXMTBwWW5sMFpWc3pNbDBpTENCdFpYUm9iMlFnSW5SbGMzUlRZMjl3WlNncGRXbHVkRFV4TWlJc0lHMWxkR2h2WkNBaWRHVnpkRUoxYVd4a1FtRnpaVWx1Y0hWMEtHSjVkR1ZiWFNsaWVYUmxXMTBpTENCdFpYUm9iMlFnSW5SbGMzUkNlWFJsYzBOdmJtTmhkQ2hpZVhSbFcxMHNZbmwwWlZ0ZEtXSjVkR1ZiWFNJc0lHMWxkR2h2WkNBaWRHVnpkRU52Ym1acFowbGtLR0o1ZEdWYk16SmRMR0o1ZEdWYk16SmRLV0o1ZEdWYk16SmRJaXdnYldWMGFHOWtJQ0owWlhOMFVHRnpjM0J2Y25SUGJHUmxjbFJvWVc0b1lubDBaVnRkS1hWcGJuUTFNVElpTENCdFpYUm9iMlFnSW5SbGMzUkZlSFJ5WVdOMFUzUnlhVzVuS0dKNWRHVmJYU3gxYVc1ME5URXlMSFZwYm5RMU1USXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSjBaWE4wVTNSeWFXNW5WRzlDYVdkSmJuUW9jM1J5YVc1bktYVnBiblExTVRJaUxDQnRaWFJvYjJRZ0luUmxjM1JUZFdKemRISnBibWNvYzNSeWFXNW5MSFZwYm5RMU1USXNkV2x1ZERVeE1pbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luTmpiM0JsS0NsMWFXNTBOVEV5SWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxUWld4bVVISnZiMllvWW5sMFpWdGRMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdmJsWmxjbWxtYVdOaGRHbHZibE4xWTJObGMzTW9ZbmwwWlZ0ZExHSjVkR1ZiWFNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWjJWMFEyOXVabWxuU1dRb015a2dkR1Z6ZEZOamIzQmxJSFJsYzNSQ2RXbHNaRUpoYzJWSmJuQjFkQ0IwWlhOMFFubDBaWE5EYjI1allYUWdkR1Z6ZEVOdmJtWnBaMGxrSUhSbGMzUlFZWE56Y0c5eWRFOXNaR1Z5VkdoaGJpQjBaWE4wUlhoMGNtRmpkRk4wY21sdVp5QjBaWE4wVTNSeWFXNW5WRzlDYVdkSmJuUWdkR1Z6ZEZOMVluTjBjbWx1WnlCelkyOXdaU0IyWlhKcFpubFRaV3htVUhKdmIyWWdiMjVXWlhKcFptbGpZWFJwYjI1VGRXTmpaWE56Q2lBZ0lDQmxjbklLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlluVnBiR1F2TGk0dlpYaGhiWEJzWlhNdmMyVnNabDltWldGMGRYSmxjeTlqYjI1MGNtRmpkSE12VFRFelgxTmxiR1pXWlhKcFptbGpZWFJwYjI1U2IyOTBWR1Z6ZEM1emIyd3VVMlZzWmxabGNtbG1hV05oZEdsdmJsSnZiM1JVWlhOMExtZGxkRU52Ym1acFowbGtLRE1wVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBRMjl1Wm1sblNXUW9NeWs2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjhDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3RsWTJOaGF6STFOZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5aWRXbHNaQzh1TGk5bGVHRnRjR3hsY3k5elpXeG1YMlpsWVhSMWNtVnpMMk52Ym5SeVlXTjBjeTlOTVROZlUyVnNabFpsY21sbWFXTmhkR2x2YmxKdmIzUlVaWE4wTG5OdmJDNVRaV3htVm1WeWFXWnBZMkYwYVc5dVVtOXZkRlJsYzNRdWRHVnpkRk5qYjNCbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEZOamIzQmxPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0lsOXpZMjl3WlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWDNOamIzQmxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHpJQzh2SURZMENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZZblZwYkdRdkxpNHZaWGhoYlhCc1pYTXZjMlZzWmw5bVpXRjBkWEpsY3k5amIyNTBjbUZqZEhNdlRURXpYMU5sYkdaV1pYSnBabWxqWVhScGIyNVNiMjkwVkdWemRDNXpiMnd1VTJWc1psWmxjbWxtYVdOaGRHbHZibEp2YjNSVVpYTjBMblJsYzNSQ2RXbHNaRUpoYzJWSmJuQjFkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUkNkV2xzWkVKaGMyVkpibkIxZERvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdZbnBsY204S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pmYzJOdmNHVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklGOXpZMjl3WlNCbGVHbHpkSE1LSUNBZ0lHSjhDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF5TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWlkV2xzWkM4dUxpOWxlR0Z0Y0d4bGN5OXpaV3htWDJabFlYUjFjbVZ6TDJOdmJuUnlZV04wY3k5Tk1UTmZVMlZzWmxabGNtbG1hV05oZEdsdmJsSnZiM1JVWlhOMExuTnZiQzVUWld4bVZtVnlhV1pwWTJGMGFXOXVVbTl2ZEZSbGMzUXVkR1Z6ZEVKNWRHVnpRMjl1WTJGMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEVKNWRHVnpRMjl1WTJGME9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlluVnBiR1F2TGk0dlpYaGhiWEJzWlhNdmMyVnNabDltWldGMGRYSmxjeTlqYjI1MGNtRmpkSE12VFRFelgxTmxiR1pXWlhKcFptbGpZWFJwYjI1U2IyOTBWR1Z6ZEM1emIyd3VVMlZzWmxabGNtbG1hV05oZEdsdmJsSnZiM1JVWlhOMExuUmxjM1JEYjI1bWFXZEpaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUkRiMjVtYVdkSlpEb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZbndLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW53S0lDQWdJR052Ym1OaGRBb2dJQ0FnYTJWalkyRnJNalUyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wySjFhV3hrTHk0dUwyVjRZVzF3YkdWekwzTmxiR1pmWm1WaGRIVnlaWE12WTI5dWRISmhZM1J6TDAweE0xOVRaV3htVm1WeWFXWnBZMkYwYVc5dVVtOXZkRlJsYzNRdWMyOXNMbE5sYkdaV1pYSnBabWxqWVhScGIyNVNiMjkwVkdWemRDNTBaWE4wVUdGemMzQnZjblJQYkdSbGNsUm9ZVzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBVR0Z6YzNCdmNuUlBiR1JsY2xSb1lXNDZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHbHVkR05mTXlBdkx5QTJOQW9nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEZzRDaUFnSUNCblpYUmllWFJsQ2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vYVc1MElEUTRDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1lpMEtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJR2wwYjJJS0lDQWdJR0lxQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhCMWMyaHBiblFnT0RrS0lDQWdJR2RsZEdKNWRHVUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZaTBLSUNBZ0lHSXJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURZMENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlpZFdsc1pDOHVMaTlsZUdGdGNHeGxjeTl6Wld4bVgyWmxZWFIxY21WekwyTnZiblJ5WVdOMGN5OU5NVE5mVTJWc1psWmxjbWxtYVdOaGRHbHZibEp2YjNSVVpYTjBMbk52YkM1VFpXeG1WbVZ5YVdacFkyRjBhVzl1VW05dmRGUmxjM1F1ZEdWemRFVjRkSEpoWTNSVGRISnBibWRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBSWGgwY21GamRGTjBjbWx1WnpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTFNVElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWWp3OUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzV6ZFdabWFXTnBaVzUwUTJoaGNtTnZaR1ZNWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjNabGNpQXpDaUFnSUNCa2FXY2dNZ29nSUNBZ1lpMEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpS3dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWVtVnlid29nSUNBZ2MzZGhjQW9LZEdWemRFVjRkSEpoWTNSVGRISnBibWRmZDJocGJHVmZkRzl3UURJNkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMENpQWdJQ0JpUEQwS0lDQWdJR0o2SUhSbGMzUkZlSFJ5WVdOMFUzUnlhVzVuWDJGbWRHVnlYM2RvYVd4bFFEUUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ1pHbG5JRFlLSUNBZ0lHSXRDaUFnSUNCa2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklEZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEpsY0d4aFkyVXpDaUFnSUNCaWRYSjVJRE1LSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TVFvZ0lDQWdZaXNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUIwWlhOMFJYaDBjbUZqZEZOMGNtbHVaMTkzYUdsc1pWOTBiM0JBTWdvS2RHVnpkRVY0ZEhKaFkzUlRkSEpwYm1kZllXWjBaWEpmZDJocGJHVkFORG9LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5aWRXbHNaQzh1TGk5bGVHRnRjR3hsY3k5elpXeG1YMlpsWVhSMWNtVnpMMk52Ym5SeVlXTjBjeTlOTVROZlUyVnNabFpsY21sbWFXTmhkR2x2YmxKdmIzUlVaWE4wTG5OdmJDNVRaV3htVm1WeWFXWnBZMkYwYVc5dVVtOXZkRlJsYzNRdWRHVnpkRk4wY21sdVoxUnZRbWxuU1c1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEZOMGNtbHVaMVJ2UW1sblNXNTBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURNeENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRk4wY21sdVp5QjBiMjhnYkc5dVp5Qm1iM0lnUW1sblNXNTBJR052Ym5abGNuTnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtDblJsYzNSVGRISnBibWRVYjBKcFowbHVkRjkzYUdsc1pWOTBiM0JBTWpvS0lDQWdJR1JwWnlBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWWo0S0lDQWdJR0o2SUhSbGMzUlRkSEpwYm1kVWIwSnBaMGx1ZEY5aFpuUmxjbDkzYUdsc1pVQTBDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklEVUtJQ0FnSUhOM1lYQUtJQ0FnSUdkbGRHSjVkR1VLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1qY0tJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVG05dUxVRlRRMGxKSUdOb1lYSmhZM1JsY2lCa1pYUmxZM1JsWkFvZ0lDQWdjSFZ6YUdsdWRDQXlOVFlLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmlLZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lud0tJQ0FnSUdKMWNua2dNd29nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF4Q2lBZ0lDQmlLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJSFJsYzNSVGRISnBibWRVYjBKcFowbHVkRjkzYUdsc1pWOTBiM0JBTWdvS2RHVnpkRk4wY21sdVoxUnZRbWxuU1c1MFgyRm1kR1Z5WDNkb2FXeGxRRFE2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTJOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eklDOHZJRFkwQ2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlluVnBiR1F2TGk0dlpYaGhiWEJzWlhNdmMyVnNabDltWldGMGRYSmxjeTlqYjI1MGNtRmpkSE12VFRFelgxTmxiR1pXWlhKcFptbGpZWFJwYjI1U2IyOTBWR1Z6ZEM1emIyd3VVMlZzWmxabGNtbG1hV05oZEdsdmJsSnZiM1JVWlhOMExuUmxjM1JUZFdKemRISnBibWRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBVM1ZpYzNSeWFXNW5PZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTFNVElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTJOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5URXlDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRElLSUNBZ0lHSXRDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0o2WlhKdkNpQWdJQ0J6ZDJGd0NncDBaWE4wVTNWaWMzUnlhVzVuWDNkb2FXeGxYM1J2Y0VBeU9nb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWWp3S0lDQWdJR0o2SUhSbGMzUlRkV0p6ZEhKcGJtZGZZV1owWlhKZmQyaHBiR1ZBTkFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JrYVdjZ05nb2dJQ0FnWWkwS0lDQWdJR1JwWnlBMENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnT0FvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR0oxY25rZ013b2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhDaUFnSUNCaUt3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlIUmxjM1JUZFdKemRISnBibWRmZDJocGJHVmZkRzl3UURJS0NuUmxjM1JUZFdKemRISnBibWRmWVdaMFpYSmZkMmhwYkdWQU5Eb0tJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlpZFdsc1pDOHVMaTlsZUdGdGNHeGxjeTl6Wld4bVgyWmxZWFIxY21WekwyTnZiblJ5WVdOMGN5OU5NVE5mVTJWc1psWmxjbWxtYVdOaGRHbHZibEp2YjNSVVpYTjBMbk52YkM1VFpXeG1WbVZ5YVdacFkyRjBhVzl1VW05dmRGUmxjM1F1YzJOdmNHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WTI5d1pUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKZmMyTnZjR1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRjl6WTI5d1pTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk15QXZMeUEyTkFvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wySjFhV3hrTHk0dUwyVjRZVzF3YkdWekwzTmxiR1pmWm1WaGRIVnlaWE12WTI5dWRISmhZM1J6TDAweE0xOVRaV3htVm1WeWFXWnBZMkYwYVc5dVVtOXZkRlJsYzNRdWMyOXNMbE5sYkdaV1pYSnBabWxqWVhScGIyNVNiMjkwVkdWemRDNTJaWEpwWm5sVFpXeG1VSEp2YjJaYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJaWEpwWm5sVFpXeG1VSEp2YjJZNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUEFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdSRVlYUmhSbTl5YldGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRFkwQ2lBZ0lDQThDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaRVJoZEdGR2IzSnRZWFFLSUNBZ0lHUjFjQW9nSUNBZ2MzVmljM1J5YVc1bklEQWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkV0p6ZEhKcGJtY2dNeklnTmpRS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWW53S0lDQWdJR1JwWnlBeENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHdGxZMk5oYXpJMU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSWw5elkyOXdaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dYM05qYjNCbElHVjRhWE4wY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IZ3dNakF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbDlwWkdWdWRHbDBlVlpsY21sbWFXTmhkR2x2YmtoMVlsWXlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmZhV1JsYm5ScGRIbFdaWEpwWm1sallYUnBiMjVJZFdKV01pQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdWak1qWXhZalU1SUM4dklHMWxkR2h2WkNBaWRtVnlhV1o1S0dKNWRHVmJYU3hpZVhSbFcxMHBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMkoxYVd4a0x5NHVMMlY0WVcxd2JHVnpMM05sYkdaZlptVmhkSFZ5WlhNdlkyOXVkSEpoWTNSekwwMHhNMTlUWld4bVZtVnlhV1pwWTJGMGFXOXVVbTl2ZEZSbGMzUXVjMjlzTGxObGJHWldaWEpwWm1sallYUnBiMjVTYjI5MFZHVnpkQzV2YmxabGNtbG1hV05oZEdsdmJsTjFZMk5sYzNOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHZibFpsY21sbWFXTmhkR2x2YmxOMVkyTmxjM002Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSWw5cFpHVnVkR2wwZVZabGNtbG1hV05oZEdsdmJraDFZbFl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmYVdSbGJuUnBkSGxXWlhKcFptbGpZWFJwYjI1SWRXSldNaUJsZUdsemRITUtJQ0FnSUNFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdWVzVoZFhSb2IzSnBlbVZrUTJGc2JHVnlDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTWlBek1nb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJHRnpkRUYwZEdWemRHRjBhVzl1U1dRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY0hWemFHbHVkQ0EwTXpJS0lDQWdJR2x1ZEdOZk15QXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0lteGhjM1JQYkdSbGNsUm9ZVzRpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WW5WcGJHUXZMaTR2WlhoaGJYQnNaWE12YzJWc1psOW1aV0YwZFhKbGN5OWpiMjUwY21GamRITXZUVEV6WDFObGJHWldaWEpwWm1sallYUnBiMjVTYjI5MFZHVnpkQzV6YjJ3dVUyVnNabFpsY21sbWFXTmhkR2x2YmxKdmIzUlVaWE4wTG1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBQUVJUUNZTEJCVWZmSFVBQmw5elkyOXdaUnBmYVdSbGJuUnBkSGxXWlhKcFptbGpZWFJwYjI1SWRXSldNZ0VCSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFV3hoYzNSQmRIUmxjM1JoZEdsdmJrbGtEV3hoYzNSUGJHUmxjbFJvWVc0UU1ERXlNelExTmpjNE9XRmlZMlJsWmdTZlVheGpJQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlrY0VNUmhBQVNJcUtXY3JKd1ZuSndZcFp5Y0hLV2NyTmhvQVp6SUlGa2xGQm9Ic3lRSVdxRUVBNWlsRkEwc0NKd1VTUVFBSEloWXFUR2NqUTRBcU1IZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBUlFJaUZrVUVnUlFXU3dTbFFRQmhKSytCQWhaTEJVbE9BMHNCbzB4TEFhQkxBa3hRU1JVa0NWdUJEQlpMQktCTEEweFFTUlVrQ1Z0TEJVeFZTWUVFQ0NjSVRDTllTd2RQQTA4Q1hZRURGazhEb0U4RFRGQkpGU1FKVzA4Q2dROGFKd2hNSTFoZFJRTW5CS0JGQkVML2xyRkxBb0VZVzRFR3NoQWlzaGtpc2dGSnNoZ25DYklhS2JJYXM3R0JCcklRSXJJWklySUJzaGduQ2JJYUtiSWFzN1ErVndRQVF2OG5nY3lJcUFVV1N3V29RUUFHS1VVRFF2OExKd1ZGQTBML0JERVpGRVF4R0VTQ0RBUlUxSDlmQktCdjRJRUVZMHBYZkFUVW5PdlZCUFd6bWdzRWx2YXZLZ1MyeDZDMkJCVE9VVTBFaHVBNXFRUnozTVVzQk5hdnY4VUVqY29ldXpZYUFJNE1BQUVBTXdCRkFISUFvd0RJQVFJQmpBSHFBbVFDZGdMekFEWWFBVWtWZ1NBU1JEWWFBa2tWZ1NBU1JEWWFBMGtpV1lFQ0NFd1ZFa1NCSUs5SlR3T3JURThDcTFBQ0tFeFFzQ05ESWlwbFJFa1ZKUTVFSmErcktFeFFzQ05ETmhvQlNTSlpnUUlJU3dFVkVrUlhBZ0NCSUs4aUttVkVxeWNLVEZCTVVFa1ZGbGNHQWt4UUtFeFFzQ05ETmhvQlNTSlpnUUlJU3dFVkVrUlhBZ0EyR2dKSklsbUJBZ2hMQVJVU1JGY0NBRkJKRlJaWEJnSk1VQ2hNVUxBalF6WWFBVWtWZ1NBU1JEWWFBa2tWZ1NBU1JJRWdyMGxQQTZ0TVR3S3JVQUlvVEZDd0kwTTJHZ0ZKSWxtQkFnaExBUlVTUkZjQ0FDV3ZTd0dCV0ZVV2dUQVdURXNCb1lFS0ZxTlBBNEZaVlJaUEFxR2dTUlVsRGtTcktFeFFzQ05ETmhvQlNTSlpnUUlJU3dFVkVrUlhBZ0JKTmhvQ1NVNENTUlVsRWtRMkdnTkpUZ05KRlNVU1JFOENGUlpMQWFZVVJDU3ZTVTRDVGdOTEFxRWpGcUJRU1JVa0NWdXZURWxMQktaQkFDMUhBa3NHb1VzRVNVOENVRWtWSkFsYlRFc0NVRWtWSkFsYlN3aE1JMWhMQkU0Q1hVVURKd1NnUlFGQy84eExBVWtWRmxjR0FreFFLRXhRc0NORE5ob0JTU0paZ1FJSVN3RVZFa1JYQWdCSkZVbUJIdzVFSWhaSlN3SVdTd0dsUVFBcUpLOUxBVWxPQWxCSkZTUUpXMHNGVEZWSmdYOE9SSUdBQWhaTEJLTk1GcXRGQXljRW9FVUJRdi9OU3dGSkZTVU9SQ1d2cXloTVVMQWpRellhQVVraVdZRUNDRXNCRlJKRVZ3SUFOaG9DUndJVkpSSkVOaG9EU1U0Q1NSVWxFa1FrcjBsT0EweExBcUZRU1JVa0NWdXZURWxMQktSQkFDMUhBa3NHb1VzRVNVOENVRWtWSkFsYlRFc0NVRWtWSkFsYlN3aE1JMWhMQkU0Q1hVVURKd1NnUlFGQy84eExBVWtWRmxjR0FreFFLRXhRc0NORElpcGxSRWtWSlE1RUphK3JLRXhRc0NORE5ob0JTU0paZ1FJSVN3RVZFa1JYQWdBMkdnSkpJbG1CQWdoTEFSVVNSRmNDQUVzQkZZRWdEQlJFU1JVbERCUkVTVkVBSUVzQlVTQkFnU0N2U1U4RHEwc0JUd09yVUFJaUttVkVUd0tySndwTVVFOERVTEZNVHdKUUlpdGxSSUVZVzRFR3NoQWlzaGtpc2dHeUdJQUU3Q1liV2JJYVRMSWFzaHF6STBNMkdnRkpJbG1CQWdoTEFSVVNSRFlhQWtraVdZRUNDRXdWRWtReEFDSXJaVVFURkVSSlZ3SWdKd1pNWjRHd0F5VllKd2RNWnlORCIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
