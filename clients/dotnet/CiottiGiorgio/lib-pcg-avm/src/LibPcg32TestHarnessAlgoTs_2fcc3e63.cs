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

namespace Arc56.Generated.CiottiGiorgio.lib_pcg_avm.LibPcg32TestHarnessAlgoTs_2fcc3e63
{


    public class LibPcg32TestHarnessAlgoTsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LibPcg32TestHarnessAlgoTsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="seed"> </param>
        /// <param name="lower_bound"> </param>
        /// <param name="upper_bound"> </param>
        /// <param name="length"> </param>
        public async Task<uint[]> GetPcg32SequenceArc4Uint32Return(byte[] seed, uint lower_bound, uint upper_bound, ushort length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 132, 120, 251 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(8, "byte"); seedAbi.From(seed);
            var lower_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); lower_boundAbi.From(lower_bound);
            var upper_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); upper_boundAbi.From(upper_bound);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lengthAbi.From(length);

            var result = await base.CallApp(new List<object> { abiHandle, seedAbi, lower_boundAbi, upper_boundAbi, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> GetPcg32SequenceArc4Uint32Return_Transactions(byte[] seed, uint lower_bound, uint upper_bound, ushort length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 132, 120, 251 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(8, "byte"); seedAbi.From(seed);
            var lower_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); lower_boundAbi.From(lower_bound);
            var upper_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); upper_boundAbi.From(upper_bound);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lengthAbi.From(length);

            return await base.MakeTransactionList(new List<object> { abiHandle, seedAbi, lower_boundAbi, upper_boundAbi, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="seed"> </param>
        /// <param name="lower_bound"> </param>
        /// <param name="upper_bound"> </param>
        /// <param name="length"> </param>
        public async Task<ushort[]> GetPcg32SequenceArc4Uint16Return(byte[] seed, ushort lower_bound, ushort upper_bound, ushort length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 120, 230, 224 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(8, "byte"); seedAbi.From(seed);
            var lower_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lower_boundAbi.From(lower_bound);
            var upper_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); upper_boundAbi.From(upper_bound);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lengthAbi.From(length);

            var result = await base.CallApp(new List<object> { abiHandle, seedAbi, lower_boundAbi, upper_boundAbi, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> GetPcg32SequenceArc4Uint16Return_Transactions(byte[] seed, ushort lower_bound, ushort upper_bound, ushort length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 120, 230, 224 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(8, "byte"); seedAbi.From(seed);
            var lower_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lower_boundAbi.From(lower_bound);
            var upper_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); upper_boundAbi.From(upper_bound);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lengthAbi.From(length);

            return await base.MakeTransactionList(new List<object> { abiHandle, seedAbi, lower_boundAbi, upper_boundAbi, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="seed"> </param>
        /// <param name="lower_bound"> </param>
        /// <param name="upper_bound"> </param>
        /// <param name="length"> </param>
        public async Task<byte[]> GetPcg32SequenceArc4Uint8Return(byte[] seed, byte lower_bound, byte upper_bound, ushort length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 215, 245, 74 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(8, "byte"); seedAbi.From(seed);
            var lower_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); lower_boundAbi.From(lower_bound);
            var upper_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); upper_boundAbi.From(upper_bound);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lengthAbi.From(length);

            var result = await base.CallApp(new List<object> { abiHandle, seedAbi, lower_boundAbi, upper_boundAbi, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetPcg32SequenceArc4Uint8Return_Transactions(byte[] seed, byte lower_bound, byte upper_bound, ushort length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 215, 245, 74 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(8, "byte"); seedAbi.From(seed);
            var lower_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); lower_boundAbi.From(lower_bound);
            var upper_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); upper_boundAbi.From(upper_bound);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lengthAbi.From(length);

            return await base.MakeTransactionList(new List<object> { abiHandle, seedAbi, lower_boundAbi, upper_boundAbi, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RuntimeAssertsPcg32StackArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 185, 82, 215 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RuntimeAssertsPcg32StackArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 185, 82, 215 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RuntimeAssertsPcg16StackArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 7, 22, 35 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RuntimeAssertsPcg16StackArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 7, 22, 35 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RuntimeAssertsPcg8StackArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 45, 24, 223 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RuntimeAssertsPcg8StackArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 45, 24, 223 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RuntimeFailureStackBytesliceOverflow(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 11, 72, 152 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RuntimeFailureStackBytesliceOverflow_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 11, 72, 152 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTGliUGNnMzJUZXN0SGFybmVzc0FsZ29UcyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRfcGNnMzJfc2VxdWVuY2VfYXJjNF91aW50MzJfcmV0dXJuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbOF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MzIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb3dlcl9ib3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDMyIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXBwZXJfYm91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQxNiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxlbmd0aCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MzJbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BjZzMyX3NlcXVlbmNlX2FyYzRfdWludDE2X3JldHVybiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzhdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDE2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibG93ZXJfYm91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQxNiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVwcGVyX2JvdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsZW5ndGgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDE2W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wY2czMl9zZXF1ZW5jZV9hcmM0X3VpbnQ4X3JldHVybiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzhdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb3dlcl9ib3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1cHBlcl9ib3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDE2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVuZ3RoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ4W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJ1bnRpbWVfYXNzZXJ0c19wY2czMl9zdGFja19hcnJheSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJydW50aW1lX2Fzc2VydHNfcGNnMTZfc3RhY2tfYXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicnVudGltZV9hc3NlcnRzX3BjZzhfc3RhY2tfYXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicnVudGltZV9mYWlsdXJlX3N0YWNrX2J5dGVzbGljZV9vdmVyZmxvdyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI0LDY4OCw3NTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgOD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NTAsNjk2LDcwNCw3MTIsNzc0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDE2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjMzLDY0Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQzMiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1OCw3NjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50OCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0E0SURBZ01pQTJNelkwTVRNMk1qSXpPRFEyTnprek1EQTFJREUwTkRJMk9UVXdOREE0T0RnNU5qTTBNRGNnTkRJNU5EazJOekk1TlFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURBd01HRWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFMENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEQmpPRFEzT0daaUlEQjRZV1UzT0dVMlpUQWdNSGc0T1dRM1pqVTBZU0F3ZURFellqazFNbVEzSURCNFpESXdOekUyTWpNZ01IaGpNakprTVRoa1ppQXdlRFpqTUdJME9EazRJQzh2SUcxbGRHaHZaQ0FpWjJWMFgzQmpaek15WDNObGNYVmxibU5sWDJGeVl6UmZkV2x1ZERNeVgzSmxkSFZ5YmloaWVYUmxXemhkTEhWcGJuUXpNaXgxYVc1ME16SXNkV2x1ZERFMktYVnBiblF6TWx0ZElpd2diV1YwYUc5a0lDSm5aWFJmY0dObk16SmZjMlZ4ZFdWdVkyVmZZWEpqTkY5MWFXNTBNVFpmY21WMGRYSnVLR0o1ZEdWYk9GMHNkV2x1ZERFMkxIVnBiblF4Tml4MWFXNTBNVFlwZFdsdWRERTJXMTBpTENCdFpYUm9iMlFnSW1kbGRGOXdZMmN6TWw5elpYRjFaVzVqWlY5aGNtTTBYM1ZwYm5RNFgzSmxkSFZ5YmloaWVYUmxXemhkTEhWcGJuUTRMSFZwYm5RNExIVnBiblF4TmlsMWFXNTBPRnRkSWl3Z2JXVjBhRzlrSUNKeWRXNTBhVzFsWDJGemMyVnlkSE5mY0dObk16SmZjM1JoWTJ0ZllYSnlZWGtvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkoxYm5ScGJXVmZZWE56WlhKMGMxOXdZMmN4Tmw5emRHRmphMTloY25KaGVTZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWNuVnVkR2x0WlY5aGMzTmxjblJ6WDNCalp6aGZjM1JoWTJ0ZllYSnlZWGtvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkoxYm5ScGJXVmZabUZwYkhWeVpWOXpkR0ZqYTE5aWVYUmxjMnhwWTJWZmIzWmxjbVpzYjNjb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCblpYUmZjR05uTXpKZmMyVnhkV1Z1WTJWZllYSmpORjkxYVc1ME16SmZjbVYwZFhKdUlHZGxkRjl3WTJjek1sOXpaWEYxWlc1alpWOWhjbU0wWDNWcGJuUXhObDl5WlhSMWNtNGdaMlYwWDNCalp6TXlYM05sY1hWbGJtTmxYMkZ5WXpSZmRXbHVkRGhmY21WMGRYSnVJSEoxYm5ScGJXVmZZWE56WlhKMGMxOXdZMmN6TWw5emRHRmphMTloY25KaGVTQnlkVzUwYVcxbFgyRnpjMlZ5ZEhOZmNHTm5NVFpmYzNSaFkydGZZWEp5WVhrZ2NuVnVkR2x0WlY5aGMzTmxjblJ6WDNCalp6aGZjM1JoWTJ0ZllYSnlZWGtnY25WdWRHbHRaVjltWVdsc2RYSmxYM04wWVdOclgySjVkR1Z6YkdsalpWOXZkbVZ5Wm14dmR3b2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TkRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQWdKaVlnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdiR2xpWDNCalp5OXdZMmN6TWk1aGJHZHZMblJ6T2pwd1kyY3pNa2x1YVhRb2MyVmxaRG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LY0dObk16SkpibWwwT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbHVkR01nTkNBdkx5QTJNelkwTVRNMk1qSXpPRFEyTnprek1EQTFDaUFnSUNCdGRXeDNDaUFnSUNCaWRYSjVJREVLSUNBZ0lHbHVkR01nTlNBdkx5QXhORFF5TmprMU1EUXdPRGc0T1RZek5EQTNDaUFnSUNCaFpHUjNDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdhVzUwWXlBMElDOHZJRFl6TmpReE16WXlNak00TkRZM09UTXdNRFVLSUNBZ0lHMTFiSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdhVzUwWXlBMUlDOHZJREUwTkRJMk9UVXdOREE0T0RnNU5qTTBNRGNLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYkdsaVgzQmpaeTl3WTJjek1pNWhiR2R2TG5Sek9qcHdZMmN6TWxKaGJtUnZiU2h6ZEdGMFpUb2dkV2x1ZERZMExDQnNiM2RsY2tKdmRXNWtPaUIxYVc1ME5qUXNJSFZ3Y0dWeVFtOTFibVE2SUhWcGJuUTJOQ3dnYkdWdVozUm9PaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3B3WTJjek1sSmhibVJ2YlRvS0lDQWdJSEJ5YjNSdklEUWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5ZmNHTm5NekpDYjNWdVpHVmtVMlZ4ZFdWdVkyVUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURnS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREJoQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2JHbGlYM0JqWnk5d1kyY3pNaTVoYkdkdkxuUnpPanB3WTJjeE5sSmhibVJ2YlNoemRHRjBaVG9nZFdsdWREWTBMQ0JzYjNkbGNrSnZkVzVrT2lCMWFXNTBOalFzSUhWd2NHVnlRbTkxYm1RNklIVnBiblEyTkN3Z2JHVnVaM1JvT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwd1kyY3hObEpoYm1SdmJUb0tJQ0FnSUhCeWIzUnZJRFFnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQndkWE5vYVc1MElERTJJQzh2SURFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOWZjR05uTXpKQ2IzVnVaR1ZrVTJWeGRXVnVZMlVLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lEZ0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXlDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lITjNZWEFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURCaENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdiR2xpWDNCalp5OXdZMmN6TWk1aGJHZHZMblJ6T2pwd1kyYzRVbUZ1Wkc5dEtITjBZWFJsT2lCMWFXNTBOalFzSUd4dmQyVnlRbTkxYm1RNklIVnBiblEyTkN3Z2RYQndaWEpDYjNWdVpEb2dkV2x1ZERZMExDQnNaVzVuZEdnNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNuQmpaemhTWVc1a2IyMDZDaUFnSUNCd2NtOTBieUEwSURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDE5d1kyY3pNa0p2ZFc1a1pXUlRaWEYxWlc1alpRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnT0FvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNR0VLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCc2FXSmZjR05uTDNCalp6TXlMbUZzWjI4dWRITTZPbDlmY0dObk16SkNiM1Z1WkdWa1UyVnhkV1Z1WTJVb2MzUmhkR1U2SUhWcGJuUTJOQ3dnWW1sMFUybDZaVG9nZFdsdWREWTBMQ0JzYjNkbGNrSnZkVzVrT2lCMWFXNTBOalFzSUhWd2NHVnlRbTkxYm1RNklIVnBiblEyTkN3Z2JHVnVaM1JvT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwZlgzQmpaek15UW05MWJtUmxaRk5sY1hWbGJtTmxPZ29nSUNBZ2NISnZkRzhnTlNBeENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR1IxY0c0Z053b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRFkxTlRNMklDOHZJRFkxTlRNMkNpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlhWFJzWlc0S0lDQWdJSEIxYzJocGJuUWdNVFlnTHk4Z01UWUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZbTU2SUY5ZmNHTm5NekpDYjNWdVpHVmtVMlZ4ZFdWdVkyVmZZbTl2YkY5MGNuVmxRRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2NIVnphR2x1ZENBeE5pQXZMeUF4TmdvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJmWDNCalp6TXlRbTkxYm1SbFpGTmxjWFZsYm1ObFgySnZiMnhmZEhKMVpVQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaWVpQmZYM0JqWnpNeVFtOTFibVJsWkZObGNYVmxibU5sWDJKdmIyeGZabUZzYzJWQU5Bb0tYMTl3WTJjek1rSnZkVzVrWldSVFpYRjFaVzVqWlY5aWIyOXNYM1J5ZFdWQU16b0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENncGZYM0JqWnpNeVFtOTFibVJsWkZObGNYVmxibU5sWDJKdmIyeGZiV1Z5WjJWQU5Ub0tJQ0FnSUdGemMyVnlkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCd2RYTm9hVzUwSURNZ0x5OGdNd29nSUNBZ2MyaHlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJSE4zWVhBS0lDQWdJQzBLSUNBZ0lHWnlZVzFsWDJKMWNua2dOd29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaWJub2dYMTl3WTJjek1rSnZkVzVrWldSVFpYRjFaVzVqWlY5bGJITmxYMkp2WkhsQU1URUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW01NklGOWZjR05uTXpKQ2IzVnVaR1ZrVTJWeGRXVnVZMlZmWld4elpWOWliMlI1UURFeENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29LWDE5d1kyY3pNa0p2ZFc1a1pXUlRaWEYxWlc1alpWOTNhR2xzWlY5MGIzQkFPRG9LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUR3S0lDQWdJR0o2SUY5ZmNHTm5NekpDYjNWdVpHVmtVMlZ4ZFdWdVkyVmZZV1owWlhKZmFXWmZaV3h6WlVBeU5Bb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR05oYkd4emRXSWdYMTl3WTJjek1sVnVZbTkxYm1SbFpGSmhibVJ2YlFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ1pYaDBjbUZqZENBNElEZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBM0NpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdaeVlXMWxYMlJwWnlBNENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ09Bb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEUUtJQ0FnSUdJZ1gxOXdZMmN6TWtKdmRXNWtaV1JUWlhGMVpXNWpaVjkzYUdsc1pWOTBiM0JBT0FvS1gxOXdZMmN6TWtKdmRXNWtaV1JUWlhGMVpXNWpaVjloWm5SbGNsOXBabDlsYkhObFFESTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ09Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQmhDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NsOWZjR05uTXpKQ2IzVnVaR1ZrVTJWeGRXVnVZMlZmWld4elpWOWliMlI1UURFeE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZWlCZlgzQmpaek15UW05MWJtUmxaRk5sY1hWbGJtTmxYMlZzYzJWZlltOWtlVUF4TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0J6YUd3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lDMEtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb0tYMTl3WTJjek1rSnZkVzVrWldSVFpYRjFaVzVqWlY5aFpuUmxjbDlwWmw5bGJITmxRREUwT2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHUjFjQW9nSUNBZ2Znb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0ZrWkhjS0lDQWdJR0oxY25rZ01Rb2dJQ0FnYVc1MFl5QTJJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJQ1lLSUNBZ0lITjNZWEFLSUNBZ0lDVUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTlFvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LQ2w5ZmNHTm5NekpDYjNWdVpHVmtVMlZ4ZFdWdVkyVmZkMmhwYkdWZmRHOXdRREUxT2dvZ0lDQWdabkpoYldWZlpHbG5JRFVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BBb2dJQ0FnWW5vZ1gxOXdZMmN6TWtKdmRXNWtaV1JUWlhGMVpXNWpaVjloWm5SbGNsOXBabDlsYkhObFFESTBDZ3BmWDNCalp6TXlRbTkxYm1SbFpGTmxjWFZsYm1ObFgzZG9hV3hsWDNSdmNFQXhOem9LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCallXeHNjM1ZpSUY5ZmNHTm5NekpWYm1KdmRXNWtaV1JTWVc1a2IyMEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lHWnlZVzFsWDJScFp5QTJDaUFnSUNBK1BRb2dJQ0FnWW5vZ1gxOXdZMmN6TWtKdmRXNWtaV1JUWlhGMVpXNWpaVjkzYUdsc1pWOTBiM0JBTVRjS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ0pRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOd29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dPQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRGdLSUNBZ0lHWnlZVzFsWDJScFp5QTFDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0ExQ2lBZ0lDQmlJRjlmY0dObk16SkNiM1Z1WkdWa1UyVnhkV1Z1WTJWZmQyaHBiR1ZmZEc5d1FERTFDZ3BmWDNCalp6TXlRbTkxYm1SbFpGTmxjWFZsYm1ObFgyVnNjMlZmWW05a2VVQXhNem9LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUhOb2JBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnTFFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQmlJRjlmY0dObk16SkNiM1Z1WkdWa1UyVnhkV1Z1WTJWZllXWjBaWEpmYVdaZlpXeHpaVUF4TkFvS1gxOXdZMmN6TWtKdmRXNWtaV1JUWlhGMVpXNWpaVjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdZaUJmWDNCalp6TXlRbTkxYm1SbFpGTmxjWFZsYm1ObFgySnZiMnhmYldWeVoyVkFOUW9LQ2k4dklHeHBZbDl3WTJjdmNHTm5Nekl1WVd4bmJ5NTBjem82WDE5d1kyY3pNbFZ1WW05MWJtUmxaRkpoYm1SdmJTaHpkR0YwWlRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1gxOXdZMmN6TWxWdVltOTFibVJsWkZKaGJtUnZiVG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5SaklEUWdMeThnTmpNMk5ERXpOakl5TXpnME5qYzVNekF3TlFvZ0lDQWdiWFZzZHdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JwYm5SaklEVWdMeThnTVRRME1qWTVOVEEwTURnNE9EazJNelF3TndvZ0lDQWdZV1JrZHdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdNVGdnTHk4Z01UZ0tJQ0FnSUhOb2Nnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JlQ2lBZ0lDQndkWE5vYVc1MElESTNJQzh2SURJM0NpQWdJQ0J6YUhJS0lDQWdJR2x1ZEdNZ05pQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQW1DaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnTlRrZ0x5OGdOVGtLSUNBZ0lITm9jZ29nSUNBZ1pIVndNZ29nSUNBZ2MyaHlDaUFnSUNCemQyRndDaUFnSUNCK0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZV1JrZHdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0J3ZFhOb2FXNTBJRE14SUM4dklETXhDaUFnSUNBbUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lITm9iQW9nSUNBZ2FXNTBZeUEySUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUNZS0lDQWdJSHdLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwWWw5d1kyY3pNbDkwWlhOMFgyaGhjbTVsYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRHbGlVR05uTXpKVVpYTjBTR0Z5Ym1WemMwRnNaMjlVY3k1blpYUmZjR05uTXpKZmMyVnhkV1Z1WTJWZllYSmpORjkxYVc1ME16SmZjbVYwZFhKdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNCalp6TXlYM05sY1hWbGJtTmxYMkZ5WXpSZmRXbHVkRE15WDNKbGRIVnliam9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z09ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z05Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTXpJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNeklLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTVRZS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyRnNiSE4xWWlCd1kyY3pNa2x1YVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1luUnZhUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpZEc5cENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHTmhiR3h6ZFdJZ2NHTm5NekpTWVc1a2IyMEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBZbDl3WTJjek1sOTBaWE4wWDJoaGNtNWxjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VEdsaVVHTm5NekpVWlhOMFNHRnlibVZ6YzBGc1oyOVVjeTVuWlhSZmNHTm5NekpmYzJWeGRXVnVZMlZmWVhKak5GOTFhVzUwTVRaZmNtVjBkWEp1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYM0JqWnpNeVgzTmxjWFZsYm1ObFgyRnlZelJmZFdsdWRERTJYM0psZEhWeWJqb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTVRZS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyRnNiSE4xWWlCd1kyY3pNa2x1YVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1luUnZhUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpZEc5cENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHTmhiR3h6ZFdJZ2NHTm5NVFpTWVc1a2IyMEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBZbDl3WTJjek1sOTBaWE4wWDJoaGNtNWxjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VEdsaVVHTm5NekpVWlhOMFNHRnlibVZ6YzBGc1oyOVVjeTVuWlhSZmNHTm5NekpmYzJWeGRXVnVZMlZmWVhKak5GOTFhVzUwT0Y5eVpYUjFjbTViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZjR05uTXpKZmMyVnhkV1Z1WTJWZllYSmpORjkxYVc1ME9GOXlaWFIxY200NkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERnS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME9Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXhOZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqWVd4c2MzVmlJSEJqWnpNeVNXNXBkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpZEc5cENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWW5SdmFRb2dJQ0FnWTJGc2JITjFZaUJ3WTJjNFVtRnVaRzl0Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVdKZmNHTm5NekpmZEdWemRGOW9ZWEp1WlhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9reHBZbEJqWnpNeVZHVnpkRWhoY201bGMzTkJiR2R2VkhNdWNuVnVkR2x0WlY5aGMzTmxjblJ6WDNCalp6TXlYM04wWVdOclgyRnljbUY1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NuVnVkR2x0WlY5aGMzTmxjblJ6WDNCalp6TXlYM04wWVdOclgyRnljbUY1T2dvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmpZV3hzYzNWaUlIQmpaek15U1c1cGRBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNREl3SUM4dklERXdNakFLSUNBZ0lHTmhiR3h6ZFdJZ2NHTm5NekpTWVc1a2IyMEtJQ0FnSUhCdmNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVdKZmNHTm5NekpmZEdWemRGOW9ZWEp1WlhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9reHBZbEJqWnpNeVZHVnpkRWhoY201bGMzTkJiR2R2VkhNdWNuVnVkR2x0WlY5aGMzTmxjblJ6WDNCalp6RTJYM04wWVdOclgyRnljbUY1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NuVnVkR2x0WlY5aGMzTmxjblJ6WDNCalp6RTJYM04wWVdOclgyRnljbUY1T2dvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmpZV3hzYzNWaUlIQmpaek15U1c1cGRBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXlNRFF4SUM4dklESXdOREVLSUNBZ0lHTmhiR3h6ZFdJZ2NHTm5NVFpTWVc1a2IyMEtJQ0FnSUhCdmNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVdKZmNHTm5NekpmZEdWemRGOW9ZWEp1WlhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9reHBZbEJqWnpNeVZHVnpkRWhoY201bGMzTkJiR2R2VkhNdWNuVnVkR2x0WlY5aGMzTmxjblJ6WDNCalp6aGZjM1JoWTJ0ZllYSnlZWGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweWRXNTBhVzFsWDJGemMyVnlkSE5mY0dObk9GOXpkR0ZqYTE5aGNuSmhlVG9LSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCaWVtVnlid29nSUNBZ1kyRnNiSE4xWWlCd1kyY3pNa2x1YVhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05EQTRNaUF2THlBME1EZ3lDaUFnSUNCallXeHNjM1ZpSUhCalp6aFNZVzVrYjIwS0lDQWdJSEJ2Y0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhV0pmY0dObk16SmZkR1Z6ZEY5b1lYSnVaWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2t4cFlsQmpaek15VkdWemRFaGhjbTVsYzNOQmJHZHZWSE11Y25WdWRHbHRaVjltWVdsc2RYSmxYM04wWVdOclgySjVkR1Z6YkdsalpWOXZkbVZ5Wm14dmQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkoxYm5ScGJXVmZabUZwYkhWeVpWOXpkR0ZqYTE5aWVYUmxjMnhwWTJWZmIzWmxjbVpzYjNjNkNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZbnBsY204S0lDQWdJR05oYkd4emRXSWdjR05uTXpKSmJtbDBDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV3TWpJZ0x5OGdNVEF5TWdvZ0lDQWdZMkZzYkhOMVlpQndZMmN6TWxKaGJtUnZiUW9nSUNBZ2NHOXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFIQVFnQUFxMysxZVRVaGYyb1dNK0NucnZ2Nzk2Q0ZQLy8vLzhQSmdJQ0FBb0VGUjk4ZFRFYlFRQkFNUmtVUkRFWVJJSUhCQXlFZVBzRXJuam00QVNKMS9WS0JCTzVVdGNFMGdjV0l3VENMUmpmQkd3TFNKZzJHZ0NPQndIOUFqMENld0s1QXNrQzJRTHBBREVaRkRFWUZCQkVJa09LQVFHTC94VWpFa1NML3hja0lRUWRSUUVoQlI1RkFSNUZBU0VFSFVVQklRVWVSUUdKaWdRQmkveUJJSXY5aS82TC80Z0Fha2xYQUFoTEFTTlpTd0lWVHdOT0FsSlhBZ0JNS0ZCTVVJbUtCQUdML0lFUWkvMkwvb3YvaUFCQlNWY0FDRXNCSTFsTEFoVlBBMDRDVWxjQ0FFd29VRXhRaVlvRUFZdjhJNHY5aS82TC80Z0FHVWxYQUFoTEFTTlpTd0lWVHdOT0FsSlhBZ0JNS0ZCTVVJbUtCUUdBQUVjSGkvK0JnSUFFREVTTC94WkprNEVRRGtSWEJnS0wvQ01TUUFBUWkveUJFQkpBQUFpTC9JRWdFa0VBNGlKRWkveUJBNUZKakFFalRBbU1CNHY5UUFCS2kvNUFBRVVrakFTTCs0d0Rpd1NML3d4QkFDR0xBNGdBdVVra1c0d0RWd2dJaXdlTEFWaUxDRXhRakFpTEJDSUlqQVJDLzllTCt4YUxDRWtWRmxjR0FreFFUQ2hRVEZDTUFJbUwva0VBYkl2K0lnMUVJb3Y4a0l2K0RVU0wvaUlKaS8wTlJJditpLzBKakFDTEFFa2NJaDVGQVNFR0drd1lqQVlrakFXTCs0d0Rpd1dML3d4Qi82eUxBNGdBUkVra1c0d0RJMXRKakFLTEJnOUIvK3VMQW9zQUdJdjlDQmFMQjRzQldJc0lURkNNQ0lzRklnaU1CVUwveGlLTC9KQkpJZ21ML1ExRWkvMEpqQUJDLzUwa1F2OGJpZ0VCaS84aEJCMUZBU0VGSGtVQmkvK0JFcEdML3h1Qkc1RWhCaHFMLzRFN2tVcVJUQndpSGtVQmdSOGFUd0pNa0NFR0dobE1Ga3dXVUlrMkdnRkpGU01TUkRZYUFra1ZnUVFTUkRZYUEwa1ZnUVFTUkRZYUJFa1ZKUkpFVHdPSS9lZFBBeGRQQXhkUEF4ZUkvZ0JKSTFsTEFSVlNLVXhRc0NKRE5ob0JTUlVqRWtRMkdnSkpGU1VTUkRZYUEwa1ZKUkpFTmhvRVNSVWxFa1JQQTRqOXFVOERGMDhERjA4REY0ajk2MGtqV1VzQkZWSXBURkN3SWtNMkdnRkpGU01TUkRZYUFra1ZJaEpFTmhvRFNSVWlFa1EyR2dSSkZTVVNSRThEaVAxclR3TVhUd01YVHdNWGlQM1dTU05aU3dFVlVpbE1VTEFpUXlPdmlQMU5KRW1CL0FlSS9XcElJa01qcjRqOVBTUkpnZmtQaVAyRFNDSkRJNitJL1Mwa1NZSHlINGo5bkVnaVF5T3ZpUDBkSkVtQi9nZUkvVHBJSWtNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
