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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.Airdrop_64a1bfd4
{


    //
    //  @title Airdrop V2 (Experimental)
    // @notice This contract manages an airdrop campaign by verifying user registrations with zero-knowledge proofs
    //         supporting both E-Passport and EU ID Card attestations, and distributing ERC20 tokens.
    //         It is provided for testing and demonstration purposes only.
    //         **WARNING:** This contract has not been audited and is NOT intended for production use.
    // @dev Inherits from SelfVerificationRoot V2 for registration logic and Ownable for administrative control.
    //
    public class AirdropProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AirdropProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        /// @notice Sets the Merkle root for claim validation.
        /// @dev Only callable by the contract owner.
        /// @param newMerkleRoot The new Merkle root.
        ///</summary>
        /// <param name="newMerkleRoot"> </param>
        public async Task SetMerkleRoot(byte[] newMerkleRoot, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 79, 161, 236 };
            var newMerkleRootAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); newMerkleRootAbi.From(newMerkleRoot);

            var result = await base.CallApp(new List<object> { abiHandle, newMerkleRootAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetMerkleRoot_Transactions(byte[] newMerkleRoot, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 79, 161, 236 };
            var newMerkleRootAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); newMerkleRootAbi.From(newMerkleRoot);

            return await base.MakeTransactionList(new List<object> { abiHandle, newMerkleRootAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Opens the registration phase for users.
        /// @dev Only callable by the contract owner.
        ///</summary>
        public async Task OpenRegistration(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 219, 75, 98 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpenRegistration_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 219, 75, 98 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Closes the registration phase.
        /// @dev Only callable by the contract owner.
        ///</summary>
        public async Task CloseRegistration(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 160, 115, 126 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CloseRegistration_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 160, 115, 126 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Opens the claim phase, allowing registered users to claim tokens.
        /// @dev Only callable by the contract owner.
        ///</summary>
        public async Task OpenClaim(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 163, 251, 251 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpenClaim_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 163, 251, 251 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Closes the claim phase.
        /// @dev Only callable by the contract owner.
        ///</summary>
        public async Task CloseClaim(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 27, 147, 143 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CloseClaim_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 27, 147, 143 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Retrieves the expected proof scope.
        /// @return The scope value used for registration verification.
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> GetScope(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 162, 147, 100 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetScope_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 162, 147, 100 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Sets the verification config ID
        /// @dev Only callable by the contract owner
        /// @param configId The verification config ID to set
        ///</summary>
        /// <param name="configId"> </param>
        public async Task SetConfigId(byte[] configId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 69, 160, 88 };
            var configIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); configIdAbi.From(configId);

            var result = await base.CallApp(new List<object> { abiHandle, configIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetConfigId_Transactions(byte[] configId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 69, 160, 88 };
            var configIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); configIdAbi.From(configId);

            return await base.MakeTransactionList(new List<object> { abiHandle, configIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Generates a configId for the user
        /// @dev Override of the SelfVerificationRoot virtual function
        /// @param destinationChainId The destination chain ID
        /// @param userIdentifier The user identifier
        /// @param userDefinedData The user defined data
        /// @return The stored verification config ID
        ///</summary>
        /// <param name="destinationChainId"> </param>
        /// <param name="userIdentifier"> </param>
        /// <param name="userDefinedData"> </param>
        public async Task<byte[]> GetConfigId(byte[] destinationChainId, byte[] userIdentifier, byte[] userDefinedData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 212, 127, 95 };
            var destinationChainIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); destinationChainIdAbi.From(destinationChainId);
            var userIdentifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); userIdentifierAbi.From(userIdentifier);
            var userDefinedDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userDefinedDataAbi.From(userDefinedData);

            var result = await base.SimApp(new List<object> { abiHandle, destinationChainIdAbi, userIdentifierAbi, userDefinedDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetConfigId_Transactions(byte[] destinationChainId, byte[] userIdentifier, byte[] userDefinedData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 212, 127, 95 };
            var destinationChainIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); destinationChainIdAbi.From(destinationChainId);
            var userIdentifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); userIdentifierAbi.From(userIdentifier);
            var userDefinedDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userDefinedDataAbi.From(userDefinedData);

            return await base.MakeTransactionList(new List<object> { abiHandle, destinationChainIdAbi, userIdentifierAbi, userDefinedDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Checks if a given address is registered.
        /// @param registeredAddress The address to check.
        /// @return True if the address is registered, false otherwise.
        ///</summary>
        /// <param name="registeredAddress"> </param>
        public async Task<bool> IsRegistered(Algorand.Address registeredAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 82, 67, 96 };
            var registeredAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); registeredAddressAbi.From(registeredAddress);

            var result = await base.SimApp(new List<object> { abiHandle, registeredAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsRegistered_Transactions(Algorand.Address registeredAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 82, 67, 96 };
            var registeredAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); registeredAddressAbi.From(registeredAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, registeredAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @notice Allows a registered user to claim their tokens.
        /// @dev Reverts if registration is still open, if claiming is disabled, if already claimed,
        ///      or if the sender is not registered. Also validates the claim using a Merkle proof.
        /// @param index The index of the claim in the Merkle tree.
        /// @param amount The amount of tokens to be claimed.
        /// @param merkleProof The Merkle proof verifying the claim.
        ///</summary>
        /// <param name="index"> </param>
        /// <param name="amount"> </param>
        /// <param name="__arc4_merkleProof"> </param>
        public async Task Claim(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 index, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 amount, byte[][] __arc4_merkleProof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 181, 166, 157 };
            var __arc4_merkleProofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("uint8[32]"); __arc4_merkleProofAbi.From(__arc4_merkleProof);

            var result = await base.CallApp(new List<object> { abiHandle, index, amount, __arc4_merkleProofAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Claim_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 index, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 amount, byte[][] __arc4_merkleProof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 181, 166, 157 };
            var __arc4_merkleProofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("uint8[32]"); __arc4_merkleProofAbi.From(__arc4_merkleProof);

            return await base.MakeTransactionList(new List<object> { abiHandle, index, amount, __arc4_merkleProofAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Returns the address of the current owner.
        ///</summary>
        public async Task<Algorand.Address> Owner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 187, 176, 168 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Owner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 187, 176, 168 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Leaves the contract without owner. It will not be possible to call
        /// `onlyOwner` functions. Can only be called by the current owner.
        /// NOTE: Renouncing ownership will leave the contract without an owner,
        /// thereby disabling any functionality that is only available to the owner.
        ///</summary>
        public async Task RenounceOwnership(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 44, 97, 229 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenounceOwnership_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 44, 97, 229 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Transfers ownership of the contract to a new account (`newOwner`).
        /// Can only be called by the current owner.
        ///</summary>
        /// <param name="newOwner"> </param>
        public async Task TransferOwnership(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 123, 175, 180 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferOwnership_Transactions(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 123, 175, 180 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWlyZHJvcCIsImRlc2MiOiIgQHRpdGxlIEFpcmRyb3AgVjIgKEV4cGVyaW1lbnRhbClcbiBAbm90aWNlIFRoaXMgY29udHJhY3QgbWFuYWdlcyBhbiBhaXJkcm9wIGNhbXBhaWduIGJ5IHZlcmlmeWluZyB1c2VyIHJlZ2lzdHJhdGlvbnMgd2l0aCB6ZXJvLWtub3dsZWRnZSBwcm9vZnNcbiAgICAgICAgIHN1cHBvcnRpbmcgYm90aCBFLVBhc3Nwb3J0IGFuZCBFVSBJRCBDYXJkIGF0dGVzdGF0aW9ucywgYW5kIGRpc3RyaWJ1dGluZyBFUkMyMCB0b2tlbnMuXG4gICAgICAgICBJdCBpcyBwcm92aWRlZCBmb3IgdGVzdGluZyBhbmQgZGVtb25zdHJhdGlvbiBwdXJwb3NlcyBvbmx5LlxuICAgICAgICAgKipXQVJOSU5HOioqIFRoaXMgY29udHJhY3QgaGFzIG5vdCBiZWVuIGF1ZGl0ZWQgYW5kIGlzIE5PVCBpbnRlbmRlZCBmb3IgcHJvZHVjdGlvbiB1c2UuXG4gQGRldiBJbmhlcml0cyBmcm9tIFNlbGZWZXJpZmljYXRpb25Sb290IFYyIGZvciByZWdpc3RyYXRpb24gbG9naWMgYW5kIE93bmFibGUgZm9yIGFkbWluaXN0cmF0aXZlIGNvbnRyb2wuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InNldE1lcmtsZVJvb3QiLCJkZXNjIjoiIEBub3RpY2UgU2V0cyB0aGUgTWVya2xlIHJvb3QgZm9yIGNsYWltIHZhbGlkYXRpb24uXG4gQGRldiBPbmx5IGNhbGxhYmxlIGJ5IHRoZSBjb250cmFjdCBvd25lci5cbiBAcGFyYW0gbmV3TWVya2xlUm9vdCBUaGUgbmV3IE1lcmtsZSByb290LiIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld01lcmtsZVJvb3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3BlblJlZ2lzdHJhdGlvbiIsImRlc2MiOiIgQG5vdGljZSBPcGVucyB0aGUgcmVnaXN0cmF0aW9uIHBoYXNlIGZvciB1c2Vycy5cbiBAZGV2IE9ubHkgY2FsbGFibGUgYnkgdGhlIGNvbnRyYWN0IG93bmVyLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbG9zZVJlZ2lzdHJhdGlvbiIsImRlc2MiOiIgQG5vdGljZSBDbG9zZXMgdGhlIHJlZ2lzdHJhdGlvbiBwaGFzZS5cbiBAZGV2IE9ubHkgY2FsbGFibGUgYnkgdGhlIGNvbnRyYWN0IG93bmVyLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcGVuQ2xhaW0iLCJkZXNjIjoiIEBub3RpY2UgT3BlbnMgdGhlIGNsYWltIHBoYXNlLCBhbGxvd2luZyByZWdpc3RlcmVkIHVzZXJzIHRvIGNsYWltIHRva2Vucy5cbiBAZGV2IE9ubHkgY2FsbGFibGUgYnkgdGhlIGNvbnRyYWN0IG93bmVyLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbG9zZUNsYWltIiwiZGVzYyI6IiBAbm90aWNlIENsb3NlcyB0aGUgY2xhaW0gcGhhc2UuXG4gQGRldiBPbmx5IGNhbGxhYmxlIGJ5IHRoZSBjb250cmFjdCBvd25lci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U2NvcGUiLCJkZXNjIjoiIEBub3RpY2UgUmV0cmlldmVzIHRoZSBleHBlY3RlZCBwcm9vZiBzY29wZS5cbiBAcmV0dXJuIFRoZSBzY29wZSB2YWx1ZSB1c2VkIGZvciByZWdpc3RyYXRpb24gdmVyaWZpY2F0aW9uLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldENvbmZpZ0lkIiwiZGVzYyI6IiBAbm90aWNlIFNldHMgdGhlIHZlcmlmaWNhdGlvbiBjb25maWcgSURcbiBAZGV2IE9ubHkgY2FsbGFibGUgYnkgdGhlIGNvbnRyYWN0IG93bmVyXG4gQHBhcmFtIGNvbmZpZ0lkIFRoZSB2ZXJpZmljYXRpb24gY29uZmlnIElEIHRvIHNldCIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbmZpZ0lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldENvbmZpZ0lkIiwiZGVzYyI6IiBAbm90aWNlIEdlbmVyYXRlcyBhIGNvbmZpZ0lkIGZvciB0aGUgdXNlclxuIEBkZXYgT3ZlcnJpZGUgb2YgdGhlIFNlbGZWZXJpZmljYXRpb25Sb290IHZpcnR1YWwgZnVuY3Rpb25cbiBAcGFyYW0gZGVzdGluYXRpb25DaGFpbklkIFRoZSBkZXN0aW5hdGlvbiBjaGFpbiBJRFxuIEBwYXJhbSB1c2VySWRlbnRpZmllciBUaGUgdXNlciBpZGVudGlmaWVyXG4gQHBhcmFtIHVzZXJEZWZpbmVkRGF0YSBUaGUgdXNlciBkZWZpbmVkIGRhdGFcbiBAcmV0dXJuIFRoZSBzdG9yZWQgdmVyaWZpY2F0aW9uIGNvbmZpZyBJRCIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlc3RpbmF0aW9uQ2hhaW5JZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VySWRlbnRpZmllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckRlZmluZWREYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzUmVnaXN0ZXJlZCIsImRlc2MiOiIgQG5vdGljZSBDaGVja3MgaWYgYSBnaXZlbiBhZGRyZXNzIGlzIHJlZ2lzdGVyZWQuXG4gQHBhcmFtIHJlZ2lzdGVyZWRBZGRyZXNzIFRoZSBhZGRyZXNzIHRvIGNoZWNrLlxuIEByZXR1cm4gVHJ1ZSBpZiB0aGUgYWRkcmVzcyBpcyByZWdpc3RlcmVkLCBmYWxzZSBvdGhlcndpc2UuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RlcmVkQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltIiwiZGVzYyI6IiBAbm90aWNlIEFsbG93cyBhIHJlZ2lzdGVyZWQgdXNlciB0byBjbGFpbSB0aGVpciB0b2tlbnMuXG4gQGRldiBSZXZlcnRzIGlmIHJlZ2lzdHJhdGlvbiBpcyBzdGlsbCBvcGVuLCBpZiBjbGFpbWluZyBpcyBkaXNhYmxlZCwgaWYgYWxyZWFkeSBjbGFpbWVkLFxuICAgICAgb3IgaWYgdGhlIHNlbmRlciBpcyBub3QgcmVnaXN0ZXJlZC4gQWxzbyB2YWxpZGF0ZXMgdGhlIGNsYWltIHVzaW5nIGEgTWVya2xlIHByb29mLlxuIEBwYXJhbSBpbmRleCBUaGUgaW5kZXggb2YgdGhlIGNsYWltIGluIHRoZSBNZXJrbGUgdHJlZS5cbiBAcGFyYW0gYW1vdW50IFRoZSBhbW91bnQgb2YgdG9rZW5zIHRvIGJlIGNsYWltZWQuXG4gQHBhcmFtIG1lcmtsZVByb29mIFRoZSBNZXJrbGUgcHJvb2YgdmVyaWZ5aW5nIHRoZSBjbGFpbS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl1bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9tZXJrbGVQcm9vZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvd25lciIsImRlc2MiOiIgQGRldiBSZXR1cm5zIHRoZSBhZGRyZXNzIG9mIHRoZSBjdXJyZW50IG93bmVyLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbm91bmNlT3duZXJzaGlwIiwiZGVzYyI6IiBAZGV2IExlYXZlcyB0aGUgY29udHJhY3Qgd2l0aG91dCBvd25lci4gSXQgd2lsbCBub3QgYmUgcG9zc2libGUgdG8gY2FsbFxuIGBvbmx5T3duZXJgIGZ1bmN0aW9ucy4gQ2FuIG9ubHkgYmUgY2FsbGVkIGJ5IHRoZSBjdXJyZW50IG93bmVyLlxuIE5PVEU6IFJlbm91bmNpbmcgb3duZXJzaGlwIHdpbGwgbGVhdmUgdGhlIGNvbnRyYWN0IHdpdGhvdXQgYW4gb3duZXIsXG4gdGhlcmVieSBkaXNhYmxpbmcgYW55IGZ1bmN0aW9uYWxpdHkgdGhhdCBpcyBvbmx5IGF2YWlsYWJsZSB0byB0aGUgb3duZXIuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyT3duZXJzaGlwIiwiZGVzYyI6IiBAZGV2IFRyYW5zZmVycyBvd25lcnNoaXAgb2YgdGhlIGNvbnRyYWN0IHRvIGEgbmV3IGFjY291bnQgKGBuZXdPd25lcmApLlxuIENhbiBvbmx5IGJlIGNhbGxlZCBieSB0aGUgY3VycmVudCBvd25lci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNjb3BlIiwiZGVzYyI6IiBAbm90aWNlIFJldHVybnMgdGhlIGN1cnJlbnQgc2NvcGUgdmFsdWVcbiBAZGV2IFB1YmxpYyB2aWV3IGZ1bmN0aW9uIHRvIGFjY2VzcyB0aGUgY3VycmVudCBzY29wZSBzZXR0aW5nXG4gQHJldHVybiBUaGUgc2NvcGUgdmFsdWUgdGhhdCBwcm9vZnMgbXVzdCBtYXRjaCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeVNlbGZQcm9vZiIsImRlc2MiOiIgQG5vdGljZSBWZXJpZmllcyBhIHNlbGYtcHJvb2YgdXNpbmcgdGhlIGJ5dGVzLWJhc2VkIGludGVyZmFjZVxuIEBkZXYgUGFyc2VzIHJlbGF5ZXIgZGF0YSBmb3JtYXQgYW5kIHZhbGlkYXRlcyBhZ2FpbnN0IGNvbnRyYWN0IHNldHRpbmdzIGJlZm9yZSBjYWxsaW5nIGh1YiBWMlxuIEBwYXJhbSBwcm9vZlBheWxvYWQgUGFja2VkIGRhdGEgZnJvbSByZWxheWVyIGluIGZvcm1hdDogfCAzMiBieXRlcyBhdHRlc3RhdGlvbklkIHwgcHJvb2YgZGF0YSB8XG4gQHBhcmFtIHVzZXJDb250ZXh0RGF0YSBVc2VyLWRlZmluZWQgZGF0YSBpbiBmb3JtYXQ6IHwgMzIgYnl0ZXMgZGVzdENoYWluSWQgfCAzMiBieXRlcyB1c2VySWRlbnRpZmllciB8IGRhdGEgfFxuIEBjdXN0b206ZGF0YS1mb3JtYXQgcHJvb2ZQYXlsb2FkID0gfCAzMiBieXRlcyBhdHRlc3RhdGlvbklkIHwgcHJvb2ZEYXRhIHxcbiBAY3VzdG9tOmRhdGEtZm9ybWF0IHVzZXJDb250ZXh0RGF0YSA9IHwgMzIgYnl0ZXMgZGVzdENoYWluSWQgfCAzMiBieXRlcyB1c2VySWRlbnRpZmllciB8IGRhdGEgfFxuIEBjdXN0b206ZGF0YS1mb3JtYXQgaHViRGF0YSA9IHwgMSBieXRlcyBjb250cmFjdCB2ZXJzaW9uIHwgMzEgYnl0ZXMgYnVmZmVyIHwgMzIgYnl0ZXMgc2NvcGUgfCAzMiBieXRlcyBhdHRlc3RhdGlvbklkIHwgcHJvb2ZEYXRhIHwiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvb2ZQYXlsb2FkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQ29udGV4dERhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib25WZXJpZmljYXRpb25TdWNjZXNzIiwiZGVzYyI6IiBAbm90aWNlIENhbGxiYWNrIGZ1bmN0aW9uIGNhbGxlZCB1cG9uIHN1Y2Nlc3NmdWwgdmVyaWZpY2F0aW9uIGJ5IHRoZSBodWIgY29udHJhY3RcbiBAZGV2IE9ubHkgY2FsbGFibGUgYnkgdGhlIGlkZW50aXR5IHZlcmlmaWNhdGlvbiBodWIgVjIgY29udHJhY3QgZm9yIHNlY3VyaXR5XG4gQHBhcmFtIG91dHB1dCBUaGUgdmVyaWZpY2F0aW9uIG91dHB1dCBkYXRhIGNvbnRhaW5pbmcgZGlzY2xvc2VkIGlkZW50aXR5IGluZm9ybWF0aW9uXG4gQHBhcmFtIHVzZXJEYXRhIFRoZSB1c2VyLWRlZmluZWQgZGF0YSBwYXNzZWQgdGhyb3VnaCB0aGUgdmVyaWZpY2F0aW9uIHByb2Nlc3NcbiBAY3VzdG9tOnNlY3VyaXR5IE9ubHkgdGhlIGF1dGhvcml6ZWQgaHViIGNvbnRyYWN0IGNhbiBjYWxsIHRoaXMgZnVuY3Rpb25cbiBAY3VzdG9tOmZsb3cgVGhpcyBmdW5jdGlvbiBkZWNvZGVzIHRoZSBvdXRwdXQgYW5kIGNhbGxzIHRoZSBjdXN0b21pemFibGUgdmVyaWZpY2F0aW9uIGhvb2siLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3V0cHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyRGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjZ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzk4MF0sImVycm9yTWVzc2FnZSI6IkFscmVhZHlDbGFpbWVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTYzXSwiZXJyb3JNZXNzYWdlIjoiQ2xhaW1Ob3RPcGVuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIzMiwxMjM5XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZERhdGFGb3JtYXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDk0XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZFByb29mIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzMl0sImVycm9yTWVzc2FnZSI6IkludmFsaWRVc2VySWRlbnRpZmllciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk5Nl0sImVycm9yTWVzc2FnZSI6Ik5vdFJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDEsMTE2N10sImVycm9yTWVzc2FnZSI6Ik93bmFibGVJbnZhbGlkT3duZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDc3XSwiZXJyb3JNZXNzYWdlIjoiT3duYWJsZVVuYXV0aG9yaXplZEFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDIxXSwiZXJyb3JNZXNzYWdlIjoiUmVnaXN0ZXJlZE51bGxpZmllciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk1N10sImVycm9yTWVzc2FnZSI6IlJlZ2lzdHJhdGlvbk5vdENsb3NlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNzJdLCJlcnJvck1lc3NhZ2UiOiJSZWdpc3RyYXRpb25Ob3RPcGVuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExM10sImVycm9yTWVzc2FnZSI6IlNhZmVFUkMyMEZhaWxlZE9wZXJhdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNjZdLCJlcnJvck1lc3NhZ2UiOiJVbmF1dGhvcml6ZWRDYWxsZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDQ5XSwiZXJyb3JNZXNzYWdlIjoiVXNlcklkZW50aWZpZXJBbHJlYWR5UmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMDAsMTM2M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9pZGVudGl0eVZlcmlmaWNhdGlvbkh1YlYyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMzUsMTQ3MiwxNDg3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX293bmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwMSwxMTc2LDEyNTBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfc2NvcGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTYyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgaXNDbGFpbU9wZW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTU1LDEzNzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBpc1JlZ2lzdHJhdGlvbk9wZW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIG1lcmtsZVJvb3QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHRva2VuIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg2NiwxMjQ0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgdmVyaWZpY2F0aW9uQ29uZmlnSWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA1M10sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODU1LDkzNiwxMTk5LDEyMTUsMTMzNywxMzUwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTQ1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODYxLDEyMDYsMTIyMiwxMzQ0LDEzNTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzE0LDgyNiw4NDIsODQ5LDg4MSwxMTU5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkxOCw5MzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NTEyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODA3LDExODJdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WW5WcGJHUXZMaTR2WlhoaGJYQnNaWE12WlhoaGJYQnNaVE12WTI5dWRISmhZM1J6TDJWNFlXMXdiR1V2UVdseVpISnZjQzV6YjJ3dVFXbHlaSEp2Y0M1aGNIQnliM1poYkY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREFnTVNBek1pQXlDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRJR0poYzJVek1paEJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQktTQWlYM05qYjNCbElpQWlYMjkzYm1WeUlpQWlhWE5TWldkcGMzUnlZWFJwYjI1UGNHVnVJaUF3ZURFMU1XWTNZemMxSUNKZmFXUmxiblJwZEhsV1pYSnBabWxqWVhScGIyNUlkV0pXTWlJZ0ltbHpRMnhoYVcxUGNHVnVJaUFpZG1WeWFXWnBZMkYwYVc5dVEyOXVabWxuU1dRaUlDSjBiMnRsYmlJZ0ltMWxjbXRzWlZKdmIzUWlJQ0pmY21WbmFYTjBaWEpsWkZWelpYSkpaR1Z1ZEdsbWFXVnljeUlnSWpBeE1qTTBOVFkzT0RsaFltTmtaV1lpSURCNE9XWTFNV0ZqTmpNZ0ltTnNZV2x0WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3YmlBMUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pmYzJOdmNHVWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlYMmxrWlc1MGFYUjVWbVZ5YVdacFkyRjBhVzl1U0hWaVZqSWlDaUFnSUNCaWVYUmxZMTh4SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0lsOXZkMjVsY2lJS0lDQWdJR0o1ZEdWalh6RWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpZEc5clpXNGlDaUFnSUNCaWVYUmxZMTh4SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSnRaWEpyYkdWU2IyOTBJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbWx6VW1WbmFYTjBjbUYwYVc5dVQzQmxiaUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlhWE5EYkdGcGJVOXdaVzRpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblpsY21sbWFXTmhkR2x2YmtOdmJtWnBaMGxrSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0oxY25rZ013b2dJQ0FnWW5sMFpXTWdOaUF2THlBaVgybGtaVzUwYVhSNVZtVnlhV1pwWTJGMGFXOXVTSFZpVmpJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTndvZ0lDQWdjSFZ6YUdsdWRDQTBNakl5TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZajA5Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWprS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0oxY25rZ05Bb0tiV0ZwYmw5aFpuUmxjbDlwYm14cGJtVmtYeTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWlkV2xzWkM4dUxpOWxlR0Z0Y0d4bGN5OWxlR0Z0Y0d4bE15OWpiMjUwY21GamRITXZaWGhoYlhCc1pTOUJhWEprY205d0xuTnZiQzVCYVhKa2NtOXdMbDluWlhSUWIzTmxhV1J2YmtGa1pISmxjM05BTXpJNkNpQWdJQ0JrYVdjZ013b2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJRDA5Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2dwdFlXbHVYMkZtZEdWeVgybHViR2x1WldSZkwyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJKMWFXeGtMeTR1TDJWNFlXMXdiR1Z6TDJWNFlXMXdiR1V6TDJOdmJuUnlZV04wY3k5bGVHRnRjR3hsTDBGcGNtUnliM0F1YzI5c0xrRnBjbVJ5YjNBdVgyTmhiR04xYkdGMFpWTmpiM0JsUURNM09nb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVgzTmpiM0JsSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUjFjQW9nSUNBZ1lubDBaV05mTVNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUQwOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUM2R1WVdKc1pVbHVkbUZzYVdSUGQyNWxjZ29nSUNBZ1kyRnNiSE4xWWlCZmRISmhibk5tWlhKUGQyNWxjbk5vYVhBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5SdmEyVnVJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU16VTZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3pNRGM0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lHSjFjbmtnTlFvS2JXRnBibDkzYUdsc1pWOTBiM0JBTXprNkNpQWdJQ0J3ZFhOb2FXNTBJREl3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTlFvZ0lDQWdZajRLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmZDJocGJHVkFOREVLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCa2FXY2dNUW9nSUNBZ1lpb0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCaUt3b2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ01USUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTBDaUFnSUNCaUt3b2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQm5aWFJpZVhSbENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0lqQXhNak0wTlRZM09EbGhZbU5rWldZaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpS3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCMWMyaHBiblFnTVRVS0lDQWdJQ1lLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0l3TVRJek5EVTJOemc1WVdKalpHVm1JZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnlaWEJzWVdObE13b2dJQ0FnWW5WeWVTQTBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNUW9nSUNBZ1lpc0tJQ0FnSUdKMWNua2dOUW9nSUNBZ1lpQnRZV2x1WDNkb2FXeGxYM1J2Y0VBek9Rb0tiV0ZwYmw5aFpuUmxjbDkzYUdsc1pVQTBNVG9LSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJREV6SUM4dklHMWxkR2h2WkNBaWFHRnphQ2gxYVc1ME1qVTJXekpkS1hWcGJuUTFNVElpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJREV6SUM4dklHMWxkR2h2WkNBaWFHRnphQ2gxYVc1ME1qVTJXekpkS1hWcGJuUTFNVElpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXNXNhVzVsWkY4dmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WW5WcGJHUXZMaTR2WlhoaGJYQnNaWE12WlhoaGJYQnNaVE12WTI5dWRISmhZM1J6TDJWNFlXMXdiR1V2UVdseVpISnZjQzV6YjJ3dVFXbHlaSEp2Y0M1ZlkyRnNZM1ZzWVhSbFUyTnZjR1ZBTXpjS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPVG9LSUNBZ0lIQjFjMmhwYm5RZ01URXhOREl5TWpBS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBMkNpQWdJQ0JpUFQwS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBek1Rb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWW5WeWVTQTBDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOHZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlluVnBiR1F2TGk0dlpYaGhiWEJzWlhNdlpYaGhiWEJzWlRNdlkyOXVkSEpoWTNSekwyVjRZVzF3YkdVdlFXbHlaSEp2Y0M1emIyd3VRV2x5WkhKdmNDNWZaMlYwVUc5elpXbGtiMjVCWkdSeVpYTnpRRE15Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU16RTZDaUFnSUNCaWVYUmxZMTh4SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWW5WeWVTQTBDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOHZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlluVnBiR1F2TGk0dlpYaGhiWEJzWlhNdlpYaGhiWEJzWlRNdlkyOXVkSEpoWTNSekwyVjRZVzF3YkdVdlFXbHlaSEp2Y0M1emIyd3VRV2x5WkhKdmNDNWZaMlYwVUc5elpXbGtiMjVCWkdSeVpYTnpRRE15Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHWTFOR1poTVdWaklEQjRNVGhrWWpSaU5qSWdNSGcxTm1Fd056TTNaU0F3ZURWaVlUTm1ZbVppSURCNE1tVXhZamt6T0dZZ01IZzJNR0V5T1RNMk5DQXdlREkyTkRWaE1EVTRJREI0TlRSa05EZG1OV1lnTUhoa01EVXlORE0yTUNBd2VHUXhZalZoTmpsa0lEQjRZakZpWW1Jd1lUZ2dNSGd6WlRKak5qRmxOU0F3ZUdVeE4ySmhabUkwSURCNE56TmtZMk0xTW1NZ01IaGtObUZtWW1aak5TQXdlRGhrWTJFeFpXSmlJQzh2SUcxbGRHaHZaQ0FpYzJWMFRXVnlhMnhsVW05dmRDaGllWFJsV3pNeVhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdmNHVnVVbVZuYVhOMGNtRjBhVzl1S0NsMmIybGtJaXdnYldWMGFHOWtJQ0pqYkc5elpWSmxaMmx6ZEhKaGRHbHZiaWdwZG05cFpDSXNJRzFsZEdodlpDQWliM0JsYmtOc1lXbHRLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmpiRzl6WlVOc1lXbHRLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJUWTI5d1pTZ3BkV2x1ZERVeE1pSXNJRzFsZEdodlpDQWljMlYwUTI5dVptbG5TV1FvWW5sMFpWc3pNbDBwZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwUTI5dVptbG5TV1FvWW5sMFpWc3pNbDBzWW5sMFpWc3pNbDBzWW5sMFpWdGRLV0o1ZEdWYk16SmRJaXdnYldWMGFHOWtJQ0pwYzFKbFoybHpkR1Z5WldRb1lXUmtjbVZ6Y3lsaWIyOXNJaXdnYldWMGFHOWtJQ0pqYkdGcGJTaDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRGhiTXpKZFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWIzZHVaWElvS1dGa1pISmxjM01pTENCdFpYUm9iMlFnSW5KbGJtOTFibU5sVDNkdVpYSnphR2x3S0NsMmIybGtJaXdnYldWMGFHOWtJQ0owY21GdWMyWmxjazkzYm1WeWMyaHBjQ2hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmpiM0JsS0NsMWFXNTBOVEV5SWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxUWld4bVVISnZiMllvWW5sMFpWdGRMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdmJsWmxjbWxtYVdOaGRHbHZibE4xWTJObGMzTW9ZbmwwWlZ0ZExHSjVkR1ZiWFNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYzJWMFRXVnlhMnhsVW05dmRDQnZjR1Z1VW1WbmFYTjBjbUYwYVc5dUlHTnNiM05sVW1WbmFYTjBjbUYwYVc5dUlHOXdaVzVEYkdGcGJTQmpiRzl6WlVOc1lXbHRJR2RsZEZOamIzQmxJSE5sZEVOdmJtWnBaMGxrSUdkbGRFTnZibVpwWjBsa0tETXBJR2x6VW1WbmFYTjBaWEpsWkNCamJHRnBiU0J2ZDI1bGNpQnlaVzV2ZFc1alpVOTNibVZ5YzJocGNDQjBjbUZ1YzJabGNrOTNibVZ5YzJocGNDQnpZMjl3WlNCMlpYSnBabmxUWld4bVVISnZiMllnYjI1V1pYSnBabWxqWVhScGIyNVRkV05qWlhOekNpQWdJQ0JsY25JS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZZblZwYkdRdkxpNHZaWGhoYlhCc1pYTXZaWGhoYlhCc1pUTXZZMjl1ZEhKaFkzUnpMMlY0WVcxd2JHVXZRV2x5WkhKdmNDNXpiMnd1U0dGemFHVnpMbVZtWm1samFXVnVkRXRsWTJOaGF6STFOaWhoT2lCaWVYUmxjeXdnWWpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwSVlYTm9aWE11WldabWFXTnBaVzUwUzJWalkyRnJNalUyT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JyWldOallXc3lOVFlLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWlkV2xzWkM4dUxpOWxlR0Z0Y0d4bGN5OWxlR0Z0Y0d4bE15OWpiMjUwY21GamRITXZaWGhoYlhCc1pTOUJhWEprY205d0xuTnZiQzVCYVhKa2NtOXdMbk5sZEUxbGNtdHNaVkp2YjNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJOWlhKcmJHVlNiMjkwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQmpZV3hzYzNWaUlGOWphR1ZqYTA5M2JtVnlDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWliV1Z5YTJ4bFVtOXZkQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T1RBd01EUmpNRFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wySjFhV3hrTHk0dUwyVjRZVzF3YkdWekwyVjRZVzF3YkdVekwyTnZiblJ5WVdOMGN5OWxlR0Z0Y0d4bEwwRnBjbVJ5YjNBdWMyOXNMa0ZwY21SeWIzQXViM0JsYmxKbFoybHpkSEpoZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTl3Wlc1U1pXZHBjM1J5WVhScGIyNDZDaUFnSUNCallXeHNjM1ZpSUY5amFHVmphMDkzYm1WeUNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKcGMxSmxaMmx6ZEhKaGRHbHZiazl3Wlc0aUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURjNVkyRXdNVEJrQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlluVnBiR1F2TGk0dlpYaGhiWEJzWlhNdlpYaGhiWEJzWlRNdlkyOXVkSEpoWTNSekwyVjRZVzF3YkdVdlFXbHlaSEp2Y0M1emIyd3VRV2x5WkhKdmNDNWpiRzl6WlZKbFoybHpkSEpoZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5zYjNObFVtVm5hWE4wY21GMGFXOXVPZ29nSUNBZ1kyRnNiSE4xWWlCZlkyaGxZMnRQZDI1bGNnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWFYTlNaV2RwYzNSeVlYUnBiMjVQY0dWdUlnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneU9EaGtOelUwWmdvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wySjFhV3hrTHk0dUwyVjRZVzF3YkdWekwyVjRZVzF3YkdVekwyTnZiblJ5WVdOMGN5OWxlR0Z0Y0d4bEwwRnBjbVJ5YjNBdWMyOXNMa0ZwY21SeWIzQXViM0JsYmtOc1lXbHRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYjNCbGJrTnNZV2x0T2dvZ0lDQWdZMkZzYkhOMVlpQmZZMmhsWTJ0UGQyNWxjZ29nSUNBZ1lubDBaV01nTnlBdkx5QWlhWE5EYkdGcGJVOXdaVzRpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREJoTVdNeFpqRTBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WW5WcGJHUXZMaTR2WlhoaGJYQnNaWE12WlhoaGJYQnNaVE12WTI5dWRISmhZM1J6TDJWNFlXMXdiR1V2UVdseVpISnZjQzV6YjJ3dVFXbHlaSEp2Y0M1amJHOXpaVU5zWVdsdFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMnh2YzJWRGJHRnBiVG9LSUNBZ0lHTmhiR3h6ZFdJZ1gyTm9aV05yVDNkdVpYSUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltbHpRMnhoYVcxUGNHVnVJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGtPV05rWXpCak53b2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMkoxYVd4a0x5NHVMMlY0WVcxd2JHVnpMMlY0WVcxd2JHVXpMMk52Ym5SeVlXTjBjeTlsZUdGdGNHeGxMMEZwY21SeWIzQXVjMjlzTGtGcGNtUnliM0F1WjJWMFUyTnZjR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUlRZMjl3WlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pmYzJOdmNHVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklGOXpZMjl3WlNCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURZMENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCd2RYTm9hVzUwSURZMENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWaklEVWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZZblZwYkdRdkxpNHZaWGhoYlhCc1pYTXZaWGhoYlhCc1pUTXZZMjl1ZEhKaFkzUnpMMlY0WVcxd2JHVXZRV2x5WkhKdmNDNXpiMnd1UVdseVpISnZjQzV6WlhSRGIyNW1hV2RKWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRU52Ym1acFowbGtPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCallXeHNjM1ZpSUY5amFHVmphMDkzYm1WeUNpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKMlpYSnBabWxqWVhScGIyNURiMjVtYVdkSlpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJKMWFXeGtMeTR1TDJWNFlXMXdiR1Z6TDJWNFlXMXdiR1V6TDJOdmJuUnlZV04wY3k5bGVHRnRjR3hsTDBGcGNtUnliM0F1YzI5c0xrRnBjbVJ5YjNBdVoyVjBRMjl1Wm1sblNXUW9NeWxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUkRiMjVtYVdkSlpDZ3pLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5abGNtbG1hV05oZEdsdmJrTnZibVpwWjBsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMlpYSnBabWxqWVhScGIyNURiMjVtYVdkSlpDQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZZblZwYkdRdkxpNHZaWGhoYlhCc1pYTXZaWGhoYlhCc1pUTXZZMjl1ZEhKaFkzUnpMMlY0WVcxd2JHVXZRV2x5WkhKdmNDNXpiMnd1UVdseVpISnZjQzVwYzFKbFoybHpkR1Z5WldSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBjMUpsWjJsemRHVnlaV1E2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01URWdMeThnSWw5eVpXZHBjM1JsY21Wa1ZYTmxja2xrWlc1MGFXWnBaWEp6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlluVnBiR1F2TGk0dlpYaGhiWEJzWlhNdlpYaGhiWEJzWlRNdlkyOXVkSEpoWTNSekwyVjRZVzF3YkdVdlFXbHlaSEp2Y0M1emIyd3VRV2x5WkhKdmNDNWpiR0ZwYlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnNZV2x0T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREVXhNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTlRFeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrUGdvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1selVtVm5hWE4wY21GMGFXOXVUM0JsYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYVhOU1pXZHBjM1J5WVhScGIyNVBjR1Z1SUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUZKbFoybHpkSEpoZEdsdmJrNXZkRU5zYjNObFpBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW1selEyeGhhVzFQY0dWdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCcGMwTnNZV2x0VDNCbGJpQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYkdGcGJVNXZkRTl3Wlc0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01UUWdMeThnSW1Oc1lXbHRaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRnNjbVZoWkhsRGJHRnBiV1ZrQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0pmY21WbmFYTjBaWEpsWkZWelpYSkpaR1Z1ZEdsbWFXVnljeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwVW1WbmFYTjBaWEpsWkFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdKOENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2EyVmpZMkZyTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW0xbGNtdHNaVkp2YjNRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHMWxjbXRzWlZKdmIzUWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvS1kyeGhhVzFmZDJocGJHVmZkRzl3UURJNkNpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJQzhLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmlQZ29nSUNBZ1lub2dZMnhoYVcxZllXWjBaWEpmZDJocGJHVkFOd29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNCaVBnb2dJQ0FnWW5vZ1kyeGhhVzFmZEdWeWJtRnllVjltWVd4elpVQTFDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCSVlYTm9aWE11WldabWFXTnBaVzUwUzJWalkyRnJNalUyQ2lBZ0lDQmlkWEo1SURFS0NtTnNZV2x0WDNSbGNtNWhjbmxmYldWeVoyVkFOam9LSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TVFvZ0lDQWdZaXNLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdZaUJqYkdGcGJWOTNhR2xzWlY5MGIzQkFNZ29LWTJ4aGFXMWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMU9nb2dJQ0FnWkdsbklERUtJQ0FnSUdOaGJHeHpkV0lnU0dGemFHVnpMbVZtWm1samFXVnVkRXRsWTJOaGF6STFOZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJR05zWVdsdFgzUmxjbTVoY25sZmJXVnlaMlZBTmdvS1kyeGhhVzFmWVdaMFpYSmZkMmhwYkdWQU56b0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaRkJ5YjI5bUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKamJHRnBiV1ZrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5SdmEyVnVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJ2YTJWdUlHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRZV1psUlZKRE1qQkdZV2xzWldSUGNHVnlZWFJwYjI0S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURSbFl6a3daVGsyQ2lBZ0lDQmthV2NnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlpZFdsc1pDOHVMaTlsZUdGdGNHeGxjeTlsZUdGdGNHeGxNeTlqYjI1MGNtRmpkSE12WlhoaGJYQnNaUzlCYVhKa2NtOXdMbk52YkM1QmFYSmtjbTl3TG05M2JtVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYjNkdVpYSTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVgyOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmYjNkdVpYSWdaWGhwYzNSekNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMkoxYVd4a0x5NHVMMlY0WVcxd2JHVnpMMlY0WVcxd2JHVXpMMk52Ym5SeVlXTjBjeTlsZUdGdGNHeGxMMEZwY21SeWIzQXVjMjlzTGtGcGNtUnliM0F1Y21WdWIzVnVZMlZQZDI1bGNuTm9hWEJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXNXZkVzVqWlU5M2JtVnljMmhwY0RvS0lDQWdJR05oYkd4emRXSWdYMk5vWldOclQzZHVaWElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNCallXeHNjM1ZpSUY5MGNtRnVjMlpsY2s5M2JtVnljMmhwY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWlkV2xzWkM4dUxpOWxlR0Z0Y0d4bGN5OWxlR0Z0Y0d4bE15OWpiMjUwY21GamRITXZaWGhoYlhCc1pTOUJhWEprY205d0xuTnZiQzVCYVhKa2NtOXdMblJ5WVc1elptVnlUM2R1WlhKemFHbHdXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEE2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHTmhiR3h6ZFdJZ1gyTm9aV05yVDNkdVpYSUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJRDA5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QzZHVZV0pzWlVsdWRtRnNhV1JQZDI1bGNnb2dJQ0FnWTJGc2JITjFZaUJmZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlluVnBiR1F2TGk0dlpYaGhiWEJzWlhNdlpYaGhiWEJzWlRNdlkyOXVkSEpoWTNSekwyVjRZVzF3YkdVdlFXbHlaSEp2Y0M1emIyd3VRV2x5WkhKdmNDNXpZMjl3WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmpiM0JsT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDl6WTI5d1pTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1gzTmpiM0JsSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWlkV2xzWkM4dUxpOWxlR0Z0Y0d4bGN5OWxlR0Z0Y0d4bE15OWpiMjUwY21GamRITXZaWGhoYlhCc1pTOUJhWEprY205d0xuTnZiQzVCYVhKa2NtOXdMblpsY21sbWVWTmxiR1pRY205dlpsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpsY21sbWVWTmxiR1pRY205dlpqb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkVSaGRHRkdiM0p0WVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNBOENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpFUmhkR0ZHYjNKdFlYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKMlpYSnBabWxqWVhScGIyNURiMjVtYVdkSlpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RtVnlhV1pwWTJGMGFXOXVRMjl1Wm1sblNXUWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWDNOamIzQmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmZjMk52Y0dVZ1pYaHBjM1J6Q2lBZ0lDQmlmQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREl3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pmYVdSbGJuUnBkSGxXWlhKcFptbGpZWFJwYjI1SWRXSldNaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dYMmxrWlc1MGFYUjVWbVZ5YVdacFkyRjBhVzl1U0hWaVZqSWdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobFl6STJNV0kxT1NBdkx5QnRaWFJvYjJRZ0luWmxjbWxtZVNoaWVYUmxXMTBzWW5sMFpWdGRLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlpZFdsc1pDOHVMaTlsZUdGdGNHeGxjeTlsZUdGdGNHeGxNeTlqYjI1MGNtRmpkSE12WlhoaGJYQnNaUzlCYVhKa2NtOXdMbk52YkM1QmFYSmtjbTl3TG05dVZtVnlhV1pwWTJGMGFXOXVVM1ZqWTJWemMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTl1Vm1WeWFXWnBZMkYwYVc5dVUzVmpZMlZ6Y3pvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbDlwWkdWdWRHbDBlVlpsY21sbWFXTmhkR2x2YmtoMVlsWXlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmZhV1JsYm5ScGRIbFdaWEpwWm1sallYUnBiMjVJZFdKV01pQmxlR2x6ZEhNS0lDQWdJQ0U5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNWhkWFJvYjNKcGVtVmtRMkZzYkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYVhOU1pXZHBjM1J5WVhScGIyNVBjR1Z1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJwYzFKbFoybHpkSEpoZEdsdmJrOXdaVzRnWlhocGMzUnpDaUFnSUNCaGMzTmxjblFnTHk4Z1VtVm5hWE4wY21GMGFXOXVUbTkwVDNCbGJnb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRGs0SURZMENpQWdJQ0J6YUdFeU5UWUtJQ0FnSUhCMWMyaGllWFJsY3lBaVgyNTFiR3hwWm1sbGNsUnZWWE5sY2tsa1pXNTBhV1pwWlhJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR0loUFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGSmxaMmx6ZEdWeVpXUk9kV3hzYVdacFpYSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRDQXpOQ0EyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdJOVBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUlZjMlZ5U1dSbGJuUnBabWxsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKZmNtVm5hWE4wWlhKbFpGVnpaWEpKWkdWdWRHbG1hV1Z5Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlZjMlZ5U1dSbGJuUnBabWxsY2tGc2NtVmhaSGxTWldkcGMzUmxjbVZrQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WVdRMllXTm1aRE1LSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5aWRXbHNaQzh1TGk5bGVHRnRjR3hsY3k5bGVHRnRjR3hsTXk5amIyNTBjbUZqZEhNdlpYaGhiWEJzWlM5QmFYSmtjbTl3TG5OdmJDNUJhWEprY205d0xsOWphR1ZqYTA5M2JtVnlLQ2tnTFQ0Z2RtOXBaRG9LWDJOb1pXTnJUM2R1WlhJNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpWDI5M2JtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmZiM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBaFBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTkzYm1GaWJHVlZibUYxZEdodmNtbDZaV1JCWTJOdmRXNTBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlluVnBiR1F2TGk0dlpYaGhiWEJzWlhNdlpYaGhiWEJzWlRNdlkyOXVkSEpoWTNSekwyVjRZVzF3YkdVdlFXbHlaSEp2Y0M1emIyd3VRV2x5WkhKdmNDNWZkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQW9ibVYzVDNkdVpYSTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGZkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQTZDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pmYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dYMjkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk15QXZMeUFpWDI5M2JtVnlJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPR0psTURBM09XTUtJQ0FnSUd4dlp3b2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZZblZwYkdRdkxpNHZaWGhoYlhCc1pYTXZaWGhoYlhCc1pUTXZZMjl1ZEhKaFkzUnpMMlY0WVcxd2JHVXZRV2x5WkhKdmNDNXpiMnd1UVdseVpISnZjQzVqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFBRWdBaVlQQUNBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVpmYzJOdmNHVUdYMjkzYm1WeUVtbHpVbVZuYVhOMGNtRjBhVzl1VDNCbGJnUVZIM3gxR2w5cFpHVnVkR2wwZVZabGNtbG1hV05oZEdsdmJraDFZbFl5QzJselEyeGhhVzFQY0dWdUZIWmxjbWxtYVdOaGRHbHZia052Ym1acFowbGtCWFJ2YTJWdUNtMWxjbXRzWlZKdmIzUWFYM0psWjJsemRHVnlaV1JWYzJWeVNXUmxiblJwWm1sbGNuTVFNREV5TXpRMU5qYzRPV0ZpWTJSbFpnU2ZVYXhqQjJOc1lXbHRaV1FpUndVeEdFQUJTU29vWnljR0tXY3JLV2NuQ1Nsbkp3b29aeWNFSW1jbkJ5Sm5Kd2dvWnpZYUFEWWFBa1VESndaTVp6SUlGa2xGQjRIc3lRSVdxRUVBK0NoRkJFc0RLUkpCQUJZaUZpcE1aekVBU1NrU0ZFU0lCSlluQ1VzQ1p5TkRnQ293ZUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQkZBeUlXUlFXQkZCWkxCYVZCQUdXQkNLOGxGa3NHU1U0RFN3R2pURXNCb0VzQ1RGQkpGWUVJQ1Z1QkRCWkxCS0JMQTB4UVNSV0JDQWxiU3dWTVZVbUJCQWduREV3aldFc0lUd05QQWwyQkF4WlBBNkJQQTB4UVNSV0JDQWxiVHdLQkR4b25ERXdqV0YxRkJJQUJBYUJGQlVML2tyRkxBNEVZVzRFR3NoQWlzaGtpc2dGSnNoZ25EYklhS0xJYXM3R0JCcklRSXJJWklySUJzaGduRGJJYUtMSWFzN1ErVndRQVF2OFVnY3lJcUFVV1N3YW9RUUFHS0VVRVF2NzVLVVVFUXY3ek1Sa1VSREVZUklJUUJQVlBvZXdFR050TFlnUldvSE4rQkZ1aisvc0VMaHVUandSZ29wTmtCQ1pGb0ZnRVZOUi9Yd1RRVWtOZ0JORzFwcDBFc2J1d3FBUStMR0hsQk9GN3I3UUVjOXpGTEFUV3I3L0ZCSTNLSHJzMkdnQ09FQUFkQURnQVNBQllBR2dBZUFDTkFKNEF4QURuQWNZQjBRSGFBZThDQkFLT0FJb0NBU1N2U1l2K1VFa1ZKQWtrV0V5TC8xQkpGU1FKSkZoUUFvazJHZ0ZKRlNRU1JJZ0M3eWNLU3dGbmdBU1FBRXdFVEZDd0kwT0lBdHduQkNObmdBUjV5Z0VOc0NORGlBTE1Kd1FpWjRBRUtJMTFUN0FqUTRnQ3ZDY0hJMmVBQkFvY0h4U3dJME9JQXF3bkJ5Sm5nQVRaemNESHNDTkRJaXBsUkVrVmdVQU9SSUZBcjZzbkJVeFFzQ05ETmhvQlNSVWtFa1NJQW44bkNFeG5JME0yR2dFVkpCSkVOaG9DRlNRU1JEWWFBMGtpV1NVSVRCVVNSQ0luQ0dWRUp3Vk1VTEFqUXpZYUFVa1ZKQkpFQVNjTFRGQytUQmNpVEU4Q1RZQUJBQ0pQQWxRbkJVeFFzQ05ETmhvQlJ3SVZnVUFTUkRZYUFrbE9Ba2tWZ1VBU1JEWWFBMGtpV1NRTEpRaExBUlVTUkNVaVdFNENJaWNFWlVRVVJDSW5CMlZFUkRFQUFTY09URkMrVEJjaVRFOENUUlJFTVFBQkp3dE1VTDVNRnlKTVR3Sk5SQ1N2U1U4RHF6RUFVRXhQQXF0UUFpSW5DbVZNVGdKRUloWk1Td01WSkFvV1N3S2xRUUEzZ1FpdlN3SlFTUldCQ0FsYlN3Uk1KQXNrV0VsTEFxVkJBQk5MQVV5SS9ueEZBVXNCZ0FFQm9FVUNRdi9IU3dHSS9tcEZBVUwvNjBsTEF4SkVNUUFCSnc1TVVDTVd2eUluQ1dWRkFVUWlSSUFFVHNrT2xrc0dVREVBVUVzRlVMQWpReUlyWlVRbkJVeFFzQ05EaUFGREtZZ0JTU05ETmhvQlNSVWtFa1NJQVRKSktSSVVSSWdCTkNORElpcGxSRWtWZ1VBT1JJRkFyNnNuQlV4UXNDTkROaG9CU1NKWkpRaExBUlVTUkZjQ0FEWWFBa2tpV1NVSVN3RVZFa1JYQWdCTEFSVWtEQlJFU1JXQlFBd1VSQ0luQ0dWRUpLOGlLbVZFcTRBZ0FnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJNVUU4RFVMRk1Ud0pRSWljR1pVU0JHRnVCQnJJUUlySVpJcklCc2hpQUJPd21HMW15R2t5eUdySWFzeU5ETmhvQlNTSlpKUWhMQVJVU1JEWWFBa2tpV1NVSVRCVVNSREVBSWljR1pVUVRGRVFpSndSbFJFUkpWMkpBQVlBYVgyNTFiR3hwWm1sbGNsUnZWWE5sY2tsa1pXNTBhV1pwWlhKTVVFbStLRTRDVFNJV1RFc0JxUlJFVHdKWElrQkpUd0tvRkVSSkFTY0xURkJKdmt3WElreFBBazBVUkVzQ3ZFaE9BcjhqRnIrQUJLMXF6OU93STBNaUsyVkVNUUFURkVTSmlnRUFJaXRsUlFGRUs0di9aNEFFaStBSG5MQ0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
