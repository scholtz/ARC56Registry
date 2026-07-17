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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper25_f05a8a8d
{


    //
    // Helper contract 25 for PoolManager
    //
    public class PoolManager__Helper25Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PoolManager__Helper25Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_packed"> </param>
        public async Task<ulong> Slot0LibraryTick(byte[] _packed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 203, 56, 139 };
            var _packedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _packedAbi.From(_packed);

            var result = await base.SimApp(new List<object> { abiHandle, _packedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Slot0LibraryTick_Transactions(byte[] _packed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 203, 56, 139 };
            var _packedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _packedAbi.From(_packed);

            return await base.MakeTransactionList(new List<object> { abiHandle, _packedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice performs a hook call using the given calldata on the given hook that doesn't return a delta
        /// @return result The complete data returned by the hook
        ///</summary>
        /// <param name="self"> </param>
        /// <param name="data"> </param>
        public async Task<byte[]> HooksCallHook(Algorand.Address self, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 241, 138, 71 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, selfAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> HooksCallHook_Transactions(Algorand.Address self, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 241, 138, 71 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, selfAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice bubble up the revert message returned by a call and revert with a wrapped ERC-7751 error
        /// @dev this method can be vulnerable to revert data bombs
        ///</summary>
        /// <param name="revertingContract"> </param>
        /// <param name="revertingFunctionSelector"> </param>
        /// <param name="additionalContext"> </param>
        public async Task CustomRevertBubbleUpAndRevertWith(Algorand.Address revertingContract, byte[] revertingFunctionSelector, byte[] additionalContext, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 165, 69, 249 };
            var revertingContractAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); revertingContractAbi.From(revertingContract);
            var revertingFunctionSelectorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); revertingFunctionSelectorAbi.From(revertingFunctionSelector);
            var additionalContextAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); additionalContextAbi.From(additionalContext);

            var result = await base.SimApp(new List<object> { abiHandle, revertingContractAbi, revertingFunctionSelectorAbi, additionalContextAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CustomRevertBubbleUpAndRevertWith_Transactions(Algorand.Address revertingContract, byte[] revertingFunctionSelector, byte[] additionalContext, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 165, 69, 249 };
            var revertingContractAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); revertingContractAbi.From(revertingContract);
            var revertingFunctionSelectorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); revertingFunctionSelectorAbi.From(revertingFunctionSelector);
            var additionalContextAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); additionalContextAbi.From(additionalContext);

            return await base.MakeTransactionList(new List<object> { abiHandle, revertingContractAbi, revertingFunctionSelectorAbi, additionalContextAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="result"> </param>
        public async Task<byte[]> ParseBytesParseSelector(byte[] result, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 223, 14, 25 };
            var resultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); resultAbi.From(result);

            var result = await base.SimApp(new List<object> { abiHandle, resultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> ParseBytesParseSelector_Transactions(byte[] result, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 223, 14, 25 };
            var resultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); resultAbi.From(result);

            return await base.MakeTransactionList(new List<object> { abiHandle, resultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task LockLock(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 188, 128, 245 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LockLock_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 188, 128, 245 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="currency"> </param>
        /// <param name="other"> </param>
        public async Task<bool> Equals(Algorand.Address currency, Algorand.Address other, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 202, 149, 58 };
            var currencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); currencyAbi.From(currency);
            var otherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); otherAbi.From(other);

            var result = await base.SimApp(new List<object> { abiHandle, currencyAbi, otherAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Equals_Transactions(Algorand.Address currency, Algorand.Address other, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 202, 149, 58 };
            var currencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); currencyAbi.From(currency);
            var otherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); otherAbi.From(other);

            return await base.MakeTransactionList(new List<object> { abiHandle, currencyAbi, otherAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="o"> </param>
        /// <param name="p"> </param>
        /// <param name="s"> </param>
        public async Task Init(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 110, 249, 137 };
            var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

            var result = await base.CallApp(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Init_Transactions(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 110, 249, 137 };
            var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

            return await base.MakeTransactionList(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9vbE1hbmFnZXJfX0hlbHBlcjI1IiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCAyNSBmb3IgUG9vbE1hbmFnZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiU2xvdDBMaWJyYXJ5LnRpY2siLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfcGFja2VkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJIb29rcy5jYWxsSG9vayIsImRlc2MiOiJAbm90aWNlIHBlcmZvcm1zIGEgaG9vayBjYWxsIHVzaW5nIHRoZSBnaXZlbiBjYWxsZGF0YSBvbiB0aGUgZ2l2ZW4gaG9vayB0aGF0IGRvZXNuJ3QgcmV0dXJuIGEgZGVsdGFcbiBAcmV0dXJuIHJlc3VsdCBUaGUgY29tcGxldGUgZGF0YSByZXR1cm5lZCBieSB0aGUgaG9vayIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IkN1c3RvbVJldmVydC5idWJibGVVcEFuZFJldmVydFdpdGgiLCJkZXNjIjoiQG5vdGljZSBidWJibGUgdXAgdGhlIHJldmVydCBtZXNzYWdlIHJldHVybmVkIGJ5IGEgY2FsbCBhbmQgcmV2ZXJ0IHdpdGggYSB3cmFwcGVkIEVSQy03NzUxIGVycm9yXG4gQGRldiB0aGlzIG1ldGhvZCBjYW4gYmUgdnVsbmVyYWJsZSB0byByZXZlcnQgZGF0YSBib21icyIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmV2ZXJ0aW5nQ29udHJhY3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXZlcnRpbmdGdW5jdGlvblNlbGVjdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkaXRpb25hbENvbnRleHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJQYXJzZUJ5dGVzLnBhcnNlU2VsZWN0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzdWx0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiTG9jay5sb2NrIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVxdWFscyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3VycmVuY3kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvdGhlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9faW5pdF9fIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4NzZdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IGFscmVhZHkgaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzUsNDY0LDU2Miw2MzksNzAzLDc3NF0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogbXVzdCBiZSBjYWxsZWQgaW4gZ3JvdXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODksNDc4LDU3Niw2NTMsNzE3LDc4OF0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogc2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzgyLDQ3MSw1NjksNjQ2LDcxMCw3ODFdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHVuYXV0aG9yaXplZCBjYWxsZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDQsNDkzLDU5MSw2NjgsNzMyLDgwM10sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBjaHVuayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxNSw1MDQsNjAyLDY3OSw3NDMsODE0XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB3cm9uZyBwcmV2IG1ldGhvZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0NCw2MTksODYyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUxLDYyNiw4NjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY1LDQzOCw1MzQsNzU2LDc2NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDMsNTUyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODQ1LDg1NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0LDI4MF0sImVycm9yTWVzc2FnZSI6InJldmVydCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjakkxTGw5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZktDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURFZ01pQXdJRE15Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p2SWlBaWNDSWdJbk1pSURCNElEQjRNVFV4Wmpkak56VWdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abU1EQXdNREF3SURCNFptWm1abVptQ2lBZ0lDQmlJRjlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGtOMWMzUnZiVkpsZG1WeWRDNWlkV0ppYkdWVmNFRnVaRkpsZG1WeWRGZHBkR2dvY21WMlpYSjBhVzVuUTI5dWRISmhZM1E2SUdKNWRHVnpMQ0J5WlhabGNuUnBibWRHZFc1amRHbHZibE5sYkdWamRHOXlPaUJpZVhSbGN5d2dZV1JrYVhScGIyNWhiRU52Ym5SbGVIUTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncERkWE4wYjIxU1pYWmxjblF1WW5WaVlteGxWWEJCYm1SU1pYWmxjblJYYVhSb09nb2dJQ0FnY0hKdmRHOGdNeUF3Q2lBZ0lDQmxjbklnTHk4Z2NtVjJaWEowQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGtodmIydHpMbU5oYkd4SWIyOXJLSE5sYkdZNklHSjVkR1Z6TENCa1lYUmhPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDa2h2YjJ0ekxtTmhiR3hJYjI5ck9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlQW9nSUNBZ1kyRnNiSE4xWWlCRGRYTjBiMjFTWlhabGNuUXVZblZpWW14bFZYQkJibVJTWlhabGNuUlhhWFJvQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0Q2lBZ0lDQmpZV3hzYzNWaUlFTjFjM1J2YlZKbGRtVnlkQzV5WlhabGNuUlhhWFJvQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0TUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xreHZZMnN1Ykc5amF5Z3BJQzArSUhadmFXUTZDa3h2WTJzdWJHOWphem9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREJrT1dOaE9HSXdObVZtWWpGak16WXdZMkkzTkRSaU16bG1NV0kwTlRrMVlUZGpOMkZtWW1NeFpERmxNRGszTVdVd1pETmlOV1ppWlRVMlpqaGpOMkVLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGdLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHRnljMlZDZVhSbGN5NXdZWEp6WlZObGJHVmpkRzl5S0hKbGMzVnNkRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BRWVhKelpVSjVkR1Z6TG5CaGNuTmxVMlZzWldOMGIzSTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVRiRzkwTUV4cFluSmhjbmt1ZEdsamF5aGZjR0ZqYTJWa09pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncFRiRzkwTUV4cFluSmhjbmt1ZEdsamF6b0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWk4S0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EZ3dNREF3TUFvZ0lDQWdZaThLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF5Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCa2RYQUtJQ0FnSUdKNklGTnNiM1F3VEdsaWNtRnllUzUwYVdOclgzUmxjbTVoY25sZlptRnNjMlZBTWdvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abU1EQXdNREF3Q2lBZ0lDQmlmQW9LVTJ4dmREQk1hV0p5WVhKNUxuUnBZMnRmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWW5vZ1UyeHZkREJNYVdKeVlYSjVMblJwWTJ0ZmRHVnlibUZ5ZVY5bVlXeHpaVUExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1lubDBaV01nTlNBdkx5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1Zd01EQXdNREFLSUNBZ0lHSjhDZ3BUYkc5ME1FeHBZbkpoY25rdWRHbGphMTkwWlhKdVlYSjVYMjFsY21kbFFEWTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdMUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LVTJ4dmREQk1hV0p5WVhKNUxuUnBZMnRmZEdWeWJtRnllVjltWVd4elpVQTFPZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IaG1abVptWm1ZS0lDQWdJR0ltQ2lBZ0lDQmlJRk5zYjNRd1RHbGljbUZ5ZVM1MGFXTnJYM1JsY201aGNubGZiV1Z5WjJWQU5nb0tVMnh2ZERCTWFXSnlZWEo1TG5ScFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhobVptWm1abVlLSUNBZ0lHSW1DaUFnSUNCaUlGTnNiM1F3VEdsaWNtRnllUzUwYVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTXdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1bGNYVmhiSE1vWTNWeWNtVnVZM2s2SUdKNWRHVnpMQ0J2ZEdobGNqb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0taWEYxWVd4ek9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BUMEtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVEZFhOMGIyMVNaWFpsY25RdWNtVjJaWEowVjJsMGFDZ3hLU2h6Wld4bFkzUnZjam9nWW5sMFpYTXBJQzArSUhadmFXUTZDa04xYzNSdmJWSmxkbVZ5ZEM1eVpYWmxjblJYYVhSb09nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQmxjbklnTHk4Z2NtVjJaWEowQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJeU5TNWZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYeWdwSUMwK0lIVnBiblEyTkRvS1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxODZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2dYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTlmWDE5aVlYSmxYMk55WldGMFpWOWZRREV6Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhsTldOaU16ZzRZaUF3ZURRNVpqRTRZVFEzSURCNE9EUmhOVFExWmprZ01IZzBNbVJtTUdVeE9TQXdlRGhpWW1NNE1HWTFJREI0WW1KallUazFNMkVnTUhoaE9UWmxaams0T1NBdkx5QnRaWFJvYjJRZ0lsTnNiM1F3VEdsaWNtRnllUzUwYVdOcktHSjVkR1ZiTXpKZEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVNHOXZhM011WTJGc2JFaHZiMnNvWVdSa2NtVnpjeXhpZVhSbFcxMHBZbmwwWlZ0ZElpd2diV1YwYUc5a0lDSkRkWE4wYjIxU1pYWmxjblF1WW5WaVlteGxWWEJCYm1SU1pYWmxjblJYYVhSb0tHRmtaSEpsYzNNc1lubDBaVnMwWFN4aWVYUmxXelJkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbEJoY25ObFFubDBaWE11Y0dGeWMyVlRaV3hsWTNSdmNpaGllWFJsVzEwcFlubDBaVnMwWFNJc0lHMWxkR2h2WkNBaVRHOWpheTVzYjJOcktDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKbGNYVmhiSE1vWVdSa2NtVnpjeXhoWkdSeVpYTnpLV0p2YjJ3aUxDQnRaWFJvYjJRZ0lsOWZhVzVwZEY5ZktIVnBiblEyTkN4MWFXNTBOalFzWW5sMFpWdGRLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pJMUxsTnNiM1F3VEdsaWNtRnllUzUwYVdOclczSnZkWFJwYm1kZElDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TWpVdVNHOXZhM011WTJGc2JFaHZiMnRiY205MWRHbHVaMTBnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSXlOUzVEZFhOMGIyMVNaWFpsY25RdVluVmlZbXhsVlhCQmJtUlNaWFpsY25SWGFYUm9XM0p2ZFhScGJtZGRJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU1qVXVVR0Z5YzJWQ2VYUmxjeTV3WVhKelpWTmxiR1ZqZEc5eVczSnZkWFJwYm1kZElDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TWpVdVRHOWpheTVzYjJOclczSnZkWFJwYm1kZElDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TWpVdVpYRjFZV3h6VzNKdmRYUnBibWRkSUY5ZmFXNXBkRjlmQ2lBZ0lDQmxjbklLQ2w5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZlgxOWZZbUZ5WlY5amNtVmhkR1ZmWDBBeE16b0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEl5TlM1VGJHOTBNRXhwWW5KaGNua3VkR2xqYTF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TWpVdVUyeHZkREJNYVdKeVlYSjVMblJwWTJ0YmNtOTFkR2x1WjEwNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEl5TlM1VGJHOTBNRXhwWW5KaGNua3VkR2xqYTF0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHZHNiMkpoYkNCSGNtOTFjRk5wZW1VS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2JYVnpkQ0JpWlNCallXeHNaV1FnYVc0Z1ozSnZkWEFLSUNBZ0lHZDBlRzRnTUNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCMWJtRjFkR2h2Y21sNlpXUWdZMkZzYkdWeUNpQWdJQ0JuZEhodUlEQWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2MyVnVaR1Z5SUcxcGMyMWhkR05vQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlNalV1VTJ4dmREQk1hV0p5WVhKNUxuUnBZMnRiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdZMmgxYm1zS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk5oSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJRzFsZEdodlpBb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJeU5TNVRiRzkwTUV4cFluSmhjbmt1ZEdsamExdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdVMnh2ZERCTWFXSnlZWEo1TG5ScFkyc0tJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TWpVdVNHOXZhM011WTJGc2JFaHZiMnRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjakkxTGtodmIydHpMbU5oYkd4SWIyOXJXM0p2ZFhScGJtZGRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjakkxTGtodmIydHpMbU5oYkd4SWIyOXJXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnWjJ4dlltRnNJRWR5YjNWd1UybDZaUW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ0ZFhOMElHSmxJR05oYkd4bFpDQnBiaUJuY205MWNBb2dJQ0FnWjNSNGJpQXdJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSFZ1WVhWMGFHOXlhWHBsWkNCallXeHNaWElLSUNBZ0lHZDBlRzRnTUNCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ6Wlc1a1pYSWdiV2x6YldGMFkyZ0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJeU5TNUliMjlyY3k1allXeHNTRzl2YTF0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJqYUhWdWF3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1YzJFZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSGR5YjI1bklIQnlaWFlnYldWMGFHOWtDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqSTFMa2h2YjJ0ekxtTmhiR3hJYjI5clczSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJR1IxY0RJS0lDQWdJR05oYkd4emRXSWdTRzl2YTNNdVkyRnNiRWh2YjJzS0lDQWdJR1IxY0FvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqSTFMa04xYzNSdmJWSmxkbVZ5ZEM1aWRXSmliR1ZWY0VGdVpGSmxkbVZ5ZEZkcGRHaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqSTFMa04xYzNSdmJWSmxkbVZ5ZEM1aWRXSmliR1ZWY0VGdVpGSmxkbVZ5ZEZkcGRHaGJjbTkxZEdsdVoxMDZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRFErQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBMFBnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pJMUxrTjFjM1J2YlZKbGRtVnlkQzVpZFdKaWJHVlZjRUZ1WkZKbGRtVnlkRmRwZEdoYmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQm5iRzlpWVd3Z1IzSnZkWEJUYVhwbENpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklHMTFjM1FnWW1VZ1kyRnNiR1ZrSUdsdUlHZHliM1Z3Q2lBZ0lDQm5kSGh1SURBZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2RXNWhkWFJvYjNKcGVtVmtJR05oYkd4bGNnb2dJQ0FnWjNSNGJpQXdJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklITmxibVJsY2lCdGFYTnRZWFJqYUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjakkxTGtOMWMzUnZiVkpsZG1WeWRDNWlkV0ppYkdWVmNFRnVaRkpsZG1WeWRGZHBkR2hiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdZMmgxYm1zS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk5oSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJRzFsZEdodlpBb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJeU5TNURkWE4wYjIxU1pYWmxjblF1WW5WaVlteGxWWEJCYm1SU1pYWmxjblJYYVhSb1czSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUdOaGJHeHpkV0lnUTNWemRHOXRVbVYyWlhKMExtSjFZbUpzWlZWd1FXNWtVbVYyWlhKMFYybDBhQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TWpVdVVHRnljMlZDZVhSbGN5NXdZWEp6WlZObGJHVmpkRzl5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEl5TlM1UVlYSnpaVUo1ZEdWekxuQmhjbk5sVTJWc1pXTjBiM0piY205MWRHbHVaMTA2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pJMUxsQmhjbk5sUW5sMFpYTXVjR0Z5YzJWVFpXeGxZM1J2Y2x0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHZHNiMkpoYkNCSGNtOTFjRk5wZW1VS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2JYVnpkQ0JpWlNCallXeHNaV1FnYVc0Z1ozSnZkWEFLSUNBZ0lHZDBlRzRnTUNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCMWJtRjFkR2h2Y21sNlpXUWdZMkZzYkdWeUNpQWdJQ0JuZEhodUlEQWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2MyVnVaR1Z5SUcxcGMyMWhkR05vQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlNalV1VUdGeWMyVkNlWFJsY3k1d1lYSnpaVk5sYkdWamRHOXlXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCM2NtOXVaeUJ3Y21WMklHTm9kVzVyQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQnRaWFJvYjJRS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TWpVdVVHRnljMlZDZVhSbGN5NXdZWEp6WlZObGJHVmpkRzl5VzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCUVlYSnpaVUo1ZEdWekxuQmhjbk5sVTJWc1pXTjBiM0lLSUNBZ0lHUjFjQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU1qVXVURzlqYXk1c2IyTnJXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSXlOUzVNYjJOckxteHZZMnRiY205MWRHbHVaMTA2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlNalV1VEc5amF5NXNiMk5yVzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCdGRYTjBJR0psSUdOaGJHeGxaQ0JwYmlCbmNtOTFjQW9nSUNBZ1ozUjRiaUF3SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhWdVlYVjBhRzl5YVhwbFpDQmpZV3hzWlhJS0lDQWdJR2QwZUc0Z01DQlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCelpXNWtaWElnYldsemJXRjBZMmdLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSXlOUzVNYjJOckxteHZZMnRiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdZMmgxYm1zS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk5oSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJRzFsZEdodlpBb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJeU5TNU1iMk5yTG14dlkydGJjbTkxZEdsdVoxMWZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnWTJGc2JITjFZaUJNYjJOckxteHZZMnNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pJMUxtVnhkV0ZzYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TWpVdVpYRjFZV3h6VzNKdmRYUnBibWRkT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSXlOUzVsY1hWaGJITmJjbTkxZEdsdVoxMWZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0JuYkc5aVlXd2dSM0p2ZFhCVGFYcGxDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJRzExYzNRZ1ltVWdZMkZzYkdWa0lHbHVJR2R5YjNWd0NpQWdJQ0JuZEhodUlEQWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkVzVoZFhSb2IzSnBlbVZrSUdOaGJHeGxjZ29nSUNBZ1ozUjRiaUF3SUZObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSE5sYm1SbGNpQnRhWE50WVhSamFBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pJMUxtVnhkV0ZzYzF0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJqYUhWdWF3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1YzJFZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSGR5YjI1bklIQnlaWFlnYldWMGFHOWtDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqSTFMbVZ4ZFdGc2MxdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JrZFhBeUNpQWdJQ0JqWVd4c2MzVmlJR1Z4ZFdGc2N3b2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSXlOUzVmWDJsdWFYUmZYMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2w5ZmFXNXBkRjlmT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCaGJISmxZV1I1SUdsdWFYUnBZV3hwZW1Wa0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdklnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjakkxTG1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBUUlBSUNZSEFXOEJjQUZ6QUFRVkgzeDFJUC8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vQUFBQUEvLy8vMElBM0lvREFBQ0tBZ0dML292L0s0ai84U3VJQU1XQUFZQ0pnQ0FObktpd2J2c2NOZ3kzUkxPZkcwV1ZwOGV2dkIwZUNYSGcwN1g3NVcrTWVpdG5pWW9CQVN1SmlnRUJKSUVJcjR2L2dDQUFBQUFBQUFBQUFBQUFBQUVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUtKSmdDQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUFBQUtLQUFRS3FLNmxKUVFBc2l3SW5CYXVMQVV4UWpBQ0xBMEVBRklzQ0p3V3Jpd0ZNVUJXQkNBbUxBRXhiakFDSml3SW5CcXhDLyttTEFpY0dyRUwvMFlvQ0FZditpLzhTaVlvQkFBQXhHMEVBUURFWkZFUXhHRVNDQndUbHl6aUxCRW54aWtjRWhLVkYrUVJDM3c0WkJJdThnUFVFdThxVk9nU3Bidm1KTmhvQWpnY0FDUUJTQUxJQkNRRlpBWkFCNkFBeEdSUXhHQlFRUXpZYUFVa1ZKUkpFS0dSQkFDMHlCQ01QUkRNQUdDaGtFa1F6QUFBeEFCSkVLV1JCQUJVeEZpSUpPQmdwWkJKRU1SWWlDVGthQUNwa0VrUkppUDdhRmtrMUFDY0VURkN3SWtNMkdnRkpGU1VTUkRZYUFra2tXU01JU3dFVkVrUlhBZ0FvWkVFQUxUSUVJdzlFTXdBWUtHUVNSRE1BQURFQUVrUXBaRUVBRlRFV0lnazRHQ2xrRWtReEZpSUpPUm9BS21RU1JFcUkva1JKTlFCSkZSWlhCZ0pNVUNjRVRGQ3dJa00yR2dGSkZTVVNSRFlhQWtrVmdRUVNSRFlhQTBrVmdRUVNSQ2hrUVFBdE1nUWpEMFF6QUJnb1pCSkVNd0FBTVFBU1JDbGtRUUFWTVJZaUNUZ1lLV1FTUkRFV0lnazVHZ0FxWkJKRVN3SkxBa3NDaVAzWklrTTJHZ0ZKSkZrakNFc0JGUkpFVndJQUtHUkJBQzB5QkNNUFJETUFHQ2hrRWtRekFBQXhBQkpFS1dSQkFCVXhGaUlKT0JncFpCSkVNUllpQ1RrYUFDcGtFa1JKaVAzTlNUVUFKd1JNVUxBaVF5aGtRUUF0TWdRakQwUXpBQmdvWkJKRU13QUFNUUFTUkNsa1FRQVZNUllpQ1RnWUtXUVNSREVXSWdrNUdnQXFaQkpFaVAxcElrTTJHZ0ZKRlNVU1JEWWFBa2tWSlJKRUtHUkJBQzB5QkNNUFJETUFHQ2hrRWtRekFBQXhBQkpFS1dSQkFCVXhGaUlKT0JncFpCSkVNUllpQ1RrYUFDcGtFa1JLaVAzWlNSWTFBSUFCQUNSUEFsUW5CRXhRc0NKRE5ob0JTUldCQ0JKRUZ6WWFBa2tWZ1FnU1JCYzJHZ05KSkZrakNFc0JGUkpFVndJQUtHUVVSQ2hQQTJjcFR3Sm5La3huSWtNPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
