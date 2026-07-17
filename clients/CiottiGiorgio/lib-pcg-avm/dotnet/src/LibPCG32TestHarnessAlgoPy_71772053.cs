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

namespace Arc56.Generated.CiottiGiorgio.lib_pcg_avm.LibPCG32TestHarnessAlgoPy_71772053
{


    public class LibPCG32TestHarnessAlgoPyProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LibPCG32TestHarnessAlgoPyProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTGliUENHMzJUZXN0SGFybmVzc0FsZ29QeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRfcGNnMzJfc2VxdWVuY2VfYXJjNF91aW50MzJfcmV0dXJuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbOF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MzIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb3dlcl9ib3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDMyIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXBwZXJfYm91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQxNiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxlbmd0aCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MzJbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BjZzMyX3NlcXVlbmNlX2FyYzRfdWludDE2X3JldHVybiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzhdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDE2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibG93ZXJfYm91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQxNiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVwcGVyX2JvdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsZW5ndGgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDE2W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wY2czMl9zZXF1ZW5jZV9hcmM0X3VpbnQ4X3JldHVybiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzhdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb3dlcl9ib3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1cHBlcl9ib3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDE2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVuZ3RoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ4W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJ1bnRpbWVfYXNzZXJ0c19wY2czMl9zdGFja19hcnJheSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJydW50aW1lX2Fzc2VydHNfcGNnMTZfc3RhY2tfYXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicnVudGltZV9hc3NlcnRzX3BjZzhfc3RhY2tfYXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicnVudGltZV9mYWlsdXJlX3N0YWNrX2J5dGVzbGljZV9vdmVyZmxvdyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ4OSw1NTcsNjI1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE2LDU2Niw1NzUsNTg0LDY1MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQxNiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5OCw1MDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MzIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzMsNjQxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjVdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJRGdnTUNBME1qazBPVFkzTWprMUlEWXpOalF4TXpZeU1qTTRORFkzT1RNd01EVWdNVFEwTWpZNU5UQTBNRGc0T0RrMk16UXdOd29nSUNBZ1lubDBaV05pYkc5amF5QXdlREUxTVdZM1l6YzFDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TUdNNE5EYzRabUlnTUhoaFpUYzRaVFpsTUNBd2VEZzVaRGRtTlRSaElEQjRNVE5pT1RVeVpEY2dNSGhrTWpBM01UWXlNeUF3ZUdNeU1tUXhPR1JtSURCNE5tTXdZalE0T1RnZ0x5OGdiV1YwYUc5a0lDSm5aWFJmY0dObk16SmZjMlZ4ZFdWdVkyVmZZWEpqTkY5MWFXNTBNekpmY21WMGRYSnVLR0o1ZEdWYk9GMHNkV2x1ZERNeUxIVnBiblF6TWl4MWFXNTBNVFlwZFdsdWRETXlXMTBpTENCdFpYUm9iMlFnSW1kbGRGOXdZMmN6TWw5elpYRjFaVzVqWlY5aGNtTTBYM1ZwYm5ReE5sOXlaWFIxY200b1lubDBaVnM0WFN4MWFXNTBNVFlzZFdsdWRERTJMSFZwYm5ReE5pbDFhVzUwTVRaYlhTSXNJRzFsZEdodlpDQWlaMlYwWDNCalp6TXlYM05sY1hWbGJtTmxYMkZ5WXpSZmRXbHVkRGhmY21WMGRYSnVLR0o1ZEdWYk9GMHNkV2x1ZERnc2RXbHVkRGdzZFdsdWRERTJLWFZwYm5RNFcxMGlMQ0J0WlhSb2IyUWdJbkoxYm5ScGJXVmZZWE56WlhKMGMxOXdZMmN6TWw5emRHRmphMTloY25KaGVTZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWNuVnVkR2x0WlY5aGMzTmxjblJ6WDNCalp6RTJYM04wWVdOclgyRnljbUY1S0NsMmIybGtJaXdnYldWMGFHOWtJQ0p5ZFc1MGFXMWxYMkZ6YzJWeWRITmZjR05uT0Y5emRHRmphMTloY25KaGVTZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWNuVnVkR2x0WlY5bVlXbHNkWEpsWDNOMFlXTnJYMko1ZEdWemJHbGpaVjl2ZG1WeVpteHZkeWdwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR2RsZEY5d1kyY3pNbDl6WlhGMVpXNWpaVjloY21NMFgzVnBiblF6TWw5eVpYUjFjbTRnWjJWMFgzQmpaek15WDNObGNYVmxibU5sWDJGeVl6UmZkV2x1ZERFMlgzSmxkSFZ5YmlCblpYUmZjR05uTXpKZmMyVnhkV1Z1WTJWZllYSmpORjkxYVc1ME9GOXlaWFIxY200Z2NuVnVkR2x0WlY5aGMzTmxjblJ6WDNCalp6TXlYM04wWVdOclgyRnljbUY1SUhKMWJuUnBiV1ZmWVhOelpYSjBjMTl3WTJjeE5sOXpkR0ZqYTE5aGNuSmhlU0J5ZFc1MGFXMWxYMkZ6YzJWeWRITmZjR05uT0Y5emRHRmphMTloY25KaGVTQnlkVzUwYVcxbFgyWmhhV3gxY21WZmMzUmhZMnRmWW5sMFpYTnNhV05sWDI5MlpYSm1iRzkzQ2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UUTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHeHBZbDl3WTJjdWNHTm5Nekl1Y0dObk16SmZhVzVwZENoelpXVmtPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3B3WTJjek1sOXBibWwwT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbHVkR01nTkNBdkx5QTJNelkwTVRNMk1qSXpPRFEyTnprek1EQTFDaUFnSUNCdGRXeDNDaUFnSUNCaWRYSjVJREVLSUNBZ0lHbHVkR01nTlNBdkx5QXhORFF5TmprMU1EUXdPRGc0T1RZek5EQTNDaUFnSUNCaFpHUjNDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdhVzUwWXlBMElDOHZJRFl6TmpReE16WXlNak00TkRZM09UTXdNRFVLSUNBZ0lHMTFiSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdhVzUwWXlBMUlDOHZJREUwTkRJMk9UVXdOREE0T0RnNU5qTTBNRGNLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYkdsaVgzQmpaeTV3WTJjek1pNWZYM0JqWnpNeVgySnZkVzVrWldSZmMyVnhkV1Z1WTJVb2MzUmhkR1U2SUhWcGJuUTJOQ3dnWW1sMFgzTnBlbVU2SUhWcGJuUTJOQ3dnYkc5M1pYSmZZbTkxYm1RNklIVnBiblEyTkN3Z2RYQndaWEpmWW05MWJtUTZJSFZwYm5RMk5Dd2diR1Z1WjNSb09pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Dd2dZbmwwWlhNNkNsOWZjR05uTXpKZlltOTFibVJsWkY5elpYRjFaVzVqWlRvS0lDQWdJSEJ5YjNSdklEVWdNZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCa2RYQnVJRFVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCaWFYUnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZbTU2SUY5ZmNHTm5NekpmWW05MWJtUmxaRjl6WlhGMVpXNWpaVjlpYjI5c1gzUnlkV1ZBTXdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQndkWE5vYVc1MElERTJDaUFnSUNBOVBRb2dJQ0FnWW01NklGOWZjR05uTXpKZlltOTFibVJsWkY5elpYRjFaVzVqWlY5aWIyOXNYM1J5ZFdWQU13b2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lub2dYMTl3WTJjek1sOWliM1Z1WkdWa1gzTmxjWFZsYm1ObFgySnZiMnhmWm1Gc2MyVkFOQW9LWDE5d1kyY3pNbDlpYjNWdVpHVmtYM05sY1hWbGJtTmxYMkp2YjJ4ZmRISjFaVUF6T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLQ2w5ZmNHTm5NekpmWW05MWJtUmxaRjl6WlhGMVpXNWpaVjlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQnphSElLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdabkpoYldWZlluVnllU0ExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHSnVlaUJmWDNCalp6TXlYMkp2ZFc1a1pXUmZjMlZ4ZFdWdVkyVmZaV3h6WlY5aWIyUjVRREV5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSnVlaUJmWDNCalp6TXlYMkp2ZFc1a1pXUmZjMlZ4ZFdWdVkyVmZaV3h6WlY5aWIyUjVRREV5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDZ3BmWDNCalp6TXlYMkp2ZFc1a1pXUmZjMlZ4ZFdWdVkyVmZabTl5WDJobFlXUmxja0E0T2dvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BBb2dJQ0FnWW5vZ1gxOXdZMmN6TWw5aWIzVnVaR1ZrWDNObGNYVmxibU5sWDJGbWRHVnlYMmxtWDJWc2MyVkFNalVLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ2FXNTBZeUEwSUM4dklEWXpOalF4TXpZeU1qTTRORFkzT1RNd01EVUtJQ0FnSUcxMWJIY0tJQ0FnSUdKMWNua2dNUW9nSUNBZ2FXNTBZeUExSUM4dklERTBOREkyT1RVd05EQTRPRGc1TmpNME1EY0tJQ0FnSUdGa1pIY0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCd2RYTm9hVzUwSURFNENpQWdJQ0J6YUhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdYZ29nSUNBZ2NIVnphR2x1ZENBeU53b2dJQ0FnYzJoeUNpQWdJQ0JwYm5Salh6TWdMeThnTkRJNU5EazJOekk1TlFvZ0lDQWdKZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCd2RYTm9hVzUwSURVNUNpQWdJQ0J6YUhJS0lDQWdJR1IxY0RJS0lDQWdJSE5vY2dvZ0lDQWdjM2RoY0FvZ0lDQWdmZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdGa1pIY0tJQ0FnSUdKMWNua2dNUW9nSUNBZ2NIVnphR2x1ZENBek1Rb2dJQ0FnSmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCemFHd0tJQ0FnSUdsdWRHTmZNeUF2THlBME1qazBPVFkzTWprMUNpQWdJQ0FtQ2lBZ0lDQjhDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCbWNtRnRaVjlrYVdjZ05nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEWUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDaUFnSUNCbWNtRnRaVjlpZFhKNUlDMDFDaUFnSUNCaUlGOWZjR05uTXpKZlltOTFibVJsWkY5elpYRjFaVzVqWlY5bWIzSmZhR1ZoWkdWeVFEZ0tDbDlmY0dObk16SmZZbTkxYm1SbFpGOXpaWEYxWlc1alpWOWhablJsY2w5cFpsOWxiSE5sUURJMU9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JtY21GdFpWOWthV2NnTmdvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1gxOXdZMmN6TWw5aWIzVnVaR1ZrWDNObGNYVmxibU5sWDJWc2MyVmZZbTlrZVVBeE1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5vZ1gxOXdZMmN6TWw5aWIzVnVaR1ZrWDNObGNYVmxibU5sWDJWc2MyVmZZbTlrZVVBeE5Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCemFHd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUQ0S0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJQzBLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9LWDE5d1kyY3pNbDlpYjNWdVpHVmtYM05sY1hWbGJtTmxYMkZtZEdWeVgybG1YMlZzYzJWQU1UVTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0IrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1lXUmtkd29nSUNBZ1luVnllU0F4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ0pnb2dJQ0FnYzNkaGNBb2dJQ0FnSlFvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDZ3BmWDNCalp6TXlYMkp2ZFc1a1pXUmZjMlZ4ZFdWdVkyVmZabTl5WDJobFlXUmxja0F4TmpvS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEd0tJQ0FnSUdKNklGOWZjR05uTXpKZlltOTFibVJsWkY5elpYRjFaVzVqWlY5aFpuUmxjbDlwWmw5bGJITmxRREkxQ2dwZlgzQmpaek15WDJKdmRXNWtaV1JmYzJWeGRXVnVZMlZmZDJocGJHVmZkRzl3UURFNE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JwYm5SaklEUWdMeThnTmpNMk5ERXpOakl5TXpnME5qYzVNekF3TlFvZ0lDQWdiWFZzZHdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JwYm5SaklEVWdMeThnTVRRME1qWTVOVEEwTURnNE9EazJNelF3TndvZ0lDQWdZV1JrZHdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJSEIxYzJocGJuUWdNVGdLSUNBZ0lITm9jZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCZUNpQWdJQ0J3ZFhOb2FXNTBJREkzQ2lBZ0lDQnphSElLSUNBZ0lHbHVkR05mTXlBdkx5QTBNamswT1RZM01qazFDaUFnSUNBbUNpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJSEIxYzJocGJuUWdOVGtLSUNBZ0lITm9jZ29nSUNBZ1pIVndNZ29nSUNBZ2MyaHlDaUFnSUNCemQyRndDaUFnSUNCK0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZV1JrZHdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0J3ZFhOb2FXNTBJRE14Q2lBZ0lDQW1DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSE5vYkFvZ0lDQWdhVzUwWTE4eklDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lDWUtJQ0FnSUh3S0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1BqMEtJQ0FnSUdKNklGOWZjR05uTXpKZlltOTFibVJsWkY5elpYRjFaVzVqWlY5aFpuUmxjbDlwWmw5bGJITmxRREl4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUNVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1puSmhiV1ZmWkdsbklEWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTJDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXROUW9nSUNBZ1lpQmZYM0JqWnpNeVgySnZkVzVrWldSZmMyVnhkV1Z1WTJWZlptOXlYMmhsWVdSbGNrQXhOZ29LWDE5d1kyY3pNbDlpYjNWdVpHVmtYM05sY1hWbGJtTmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qRTZDaUFnSUNCbWNtRnRaVjlpZFhKNUlDMDFDaUFnSUNCaUlGOWZjR05uTXpKZlltOTFibVJsWkY5elpYRjFaVzVqWlY5M2FHbHNaVjkwYjNCQU1UZ0tDbDlmY0dObk16SmZZbTkxYm1SbFpGOXpaWEYxWlc1alpWOWxiSE5sWDJKdlpIbEFNVFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCemFHd0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUMwS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdZaUJmWDNCalp6TXlYMkp2ZFc1a1pXUmZjMlZ4ZFdWdVkyVmZZV1owWlhKZmFXWmZaV3h6WlVBeE5Rb0tYMTl3WTJjek1sOWliM1Z1WkdWa1gzTmxjWFZsYm1ObFgySnZiMnhmWm1Gc2MyVkFORG9LSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaUlGOWZjR05uTXpKZlltOTFibVJsWkY5elpYRjFaVzVqWlY5aWIyOXNYMjFsY21kbFFEVUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YkdsaVgzQmpaek15WDNSbGMzUmZhR0Z5Ym1WemN5NWpiMjUwY21GamRDNU1hV0pRUTBjek1sUmxjM1JJWVhKdVpYTnpRV3huYjFCNUxtZGxkRjl3WTJjek1sOXpaWEYxWlc1alpWOWhjbU0wWDNWcGJuUXpNbDl5WlhSMWNtNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmNHTm5NekpmYzJWeGRXVnVZMlZmWVhKak5GOTFhVzUwTXpKZmNtVjBkWEp1T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNeklLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRE15Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF4TmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUhCalp6TXlYMmx1YVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1luUnZhUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpZEc5cENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1kyRnNiSE4xWWlCZlgzQmpaek15WDJKdmRXNWtaV1JmYzJWeGRXVnVZMlVLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNhV0pmY0dObk16SmZkR1Z6ZEY5b1lYSnVaWE56TG1OdmJuUnlZV04wTGt4cFlsQkRSek15VkdWemRFaGhjbTVsYzNOQmJHZHZVSGt1WjJWMFgzQmpaek15WDNObGNYVmxibU5sWDJGeVl6UmZkV2x1ZERFMlgzSmxkSFZ5Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjl3WTJjek1sOXpaWEYxWlc1alpWOWhjbU0wWDNWcGJuUXhObDl5WlhSMWNtNDZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReE5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRERTJDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdjR05uTXpKZmFXNXBkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpZEc5cENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWW5SdmFRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQndkWE5vYVc1MElERTJDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQmpiM1psY2lBMENpQWdJQ0JqWVd4c2MzVmlJRjlmY0dObk16SmZZbTkxYm1SbFpGOXpaWEYxWlc1alpRb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG14cFlsOXdZMmN6TWw5MFpYTjBYMmhoY201bGMzTXVZMjl1ZEhKaFkzUXVUR2xpVUVOSE16SlVaWE4wU0dGeWJtVnpjMEZzWjI5UWVTNW5aWFJmY0dObk16SmZjMlZ4ZFdWdVkyVmZZWEpqTkY5MWFXNTBPRjl5WlhSMWNtNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmNHTm5NekpmYzJWeGRXVnVZMlZmWVhKak5GOTFhVzUwT0Y5eVpYUjFjbTQ2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lEZytDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRGdLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwT0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTVRZS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyRnNiSE4xWWlCd1kyY3pNbDlwYm1sMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWW5SdmFRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JqYjNabGNpQTBDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQmpZV3hzYzNWaUlGOWZjR05uTXpKZlltOTFibVJsWkY5elpYRjFaVzVqWlFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbXhwWWw5d1kyY3pNbDkwWlhOMFgyaGhjbTVsYzNNdVkyOXVkSEpoWTNRdVRHbGlVRU5ITXpKVVpYTjBTR0Z5Ym1WemMwRnNaMjlRZVM1eWRXNTBhVzFsWDJGemMyVnlkSE5mY0dObk16SmZjM1JoWTJ0ZllYSnlZWGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweWRXNTBhVzFsWDJGemMyVnlkSE5mY0dObk16SmZjM1JoWTJ0ZllYSnlZWGs2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHTmhiR3h6ZFdJZ2NHTm5NekpmYVc1cGRBb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1ESXpDaUFnSUNCallXeHNjM1ZpSUY5ZmNHTm5NekpmWW05MWJtUmxaRjl6WlhGMVpXNWpaUW9nSUNBZ2NHOXdiaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxteHBZbDl3WTJjek1sOTBaWE4wWDJoaGNtNWxjM011WTI5dWRISmhZM1F1VEdsaVVFTkhNekpVWlhOMFNHRnlibVZ6YzBGc1oyOVFlUzV5ZFc1MGFXMWxYMkZ6YzJWeWRITmZjR05uTVRaZmMzUmhZMnRmWVhKeVlYbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5ZFc1MGFXMWxYMkZ6YzJWeWRITmZjR05uTVRaZmMzUmhZMnRmWVhKeVlYazZDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdOaGJHeHpkV0lnY0dObk16SmZhVzVwZEFvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5TURRM0NpQWdJQ0JqWVd4c2MzVmlJRjlmY0dObk16SmZZbTkxYm1SbFpGOXpaWEYxWlc1alpRb2dJQ0FnY0c5d2JpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG14cFlsOXdZMmN6TWw5MFpYTjBYMmhoY201bGMzTXVZMjl1ZEhKaFkzUXVUR2xpVUVOSE16SlVaWE4wU0dGeWJtVnpjMEZzWjI5UWVTNXlkVzUwYVcxbFgyRnpjMlZ5ZEhOZmNHTm5PRjl6ZEdGamExOWhjbkpoZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSjFiblJwYldWZllYTnpaWEowYzE5d1kyYzRYM04wWVdOclgyRnljbUY1T2dvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmpZV3hzYzNWaUlIQmpaek15WDJsdWFYUUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUXdPVFFLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXdZMmN6TWw5aWIzVnVaR1ZrWDNObGNYVmxibU5sQ2lBZ0lDQndiM0J1SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXViR2xpWDNCalp6TXlYM1JsYzNSZmFHRnlibVZ6Y3k1amIyNTBjbUZqZEM1TWFXSlFRMGN6TWxSbGMzUklZWEp1WlhOelFXeG5iMUI1TG5KMWJuUnBiV1ZmWm1GcGJIVnlaVjl6ZEdGamExOWllWFJsYzJ4cFkyVmZiM1psY21ac2IzZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5ZFc1MGFXMWxYMlpoYVd4MWNtVmZjM1JoWTJ0ZllubDBaWE5zYVdObFgyOTJaWEptYkc5M09nb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR0o2WlhKdkNpQWdJQ0JqWVd4c2MzVmlJSEJqWnpNeVgybHVhWFFLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEF5TkFvZ0lDQWdZMkZzYkhOMVlpQmZYM0JqWnpNeVgySnZkVzVrWldSZmMyVnhkV1Z1WTJVS0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFHQVFnQS8vLy8vdyt0L3RYazFJWDlxRmpQZ3A2NzcrL2VnaFFtQVFRVkgzeDFNUnRCQUVBeEdSUkVNUmhFZ2djRURJUjQrd1N1ZU9iZ0JJblg5VW9FRTdsUzF3VFNCeFlqQk1JdEdOOEViQXRJbURZYUFJNEhBWG9CdmdJQ0FrTUNWZ0pwQW5zQU1Sa1VNUmdVRUVPS0FRR0wveFVqRWtTTC94Y2tJUVFkUlFFaEJSNUZBUjVGQVNFRUhVVUJJUVVlUlFHSmlnVUNnQUJIQll2L0ZrbVRnUkFPUkZjR0FvdjhJeEpBQUJDTC9JRVFFa0FBQ0l2OGdTQVNRUUVlSWtTTC9JRURrVW1NQVNOTUNZd0ZpLzFBQUdDTC9rQUFXeVNNQTRzRGkvOE1RUUJIaS9zaEJCMUZBU0VGSGtVQmkvdUJFcEdMK3h1Qkc1RWxHb3Y3Z1R1UlNwRk1IQ0llUlFHQkh4cFBBa3lRSlJvWkZvc0Zpd0ZZaXdaTVVJd0dpd01pQ0l3RGpQdEMvN0dMKzRzR2pBR01BSW1ML2tFQWtvditJZzFFSW92OGtJditEVVNML2lJSmkvME5SSXYraS8wSmpBQ0xBRWtjSWg1RkFTVWFUQmlNQkNTTUE0c0RpLzhNUWYrOWkvc2hCQjFGQVNFRkhrVUJpL3VCRXBHTCt4dUJHNUVsR292N2dUdVJTcEZNSENJZVJRR0JIeHBQQWt5UUpSb1pTWXdDaXdRUFFRQWZpd0tMQUJpTC9RZ1dpd1dMQVZpTEJreFFqQWFMQXlJSWpBT00rMEwvb0l6N1F2K2pJb3Y4a0VraUNZdjlEVVNML1FtTUFFTC9keVJDL3Q4MkdnRkpGU01TUkRZYUFra1ZnUVFTUkRZYUEwa1ZnUVFTUkRZYUJFa1ZnUUlTUkU4RGlQNW5Ud01YVHdNWFR3TVhUd09CSUU0RVRnU0kvbmhGQVNoTVVMQWlRellhQVVrVkl4SkVOaG9DU1JXQkFoSkVOaG9EU1JXQkFoSkVOaG9FU1JXQkFoSkVUd09JL2lOUEF4ZFBBeGRQQXhkUEE0RVFUZ1JPQklqK05FVUJLRXhRc0NKRE5ob0JTUlVqRWtRMkdnSkpGU0lTUkRZYUEwa1ZJaEpFTmhvRVNSV0JBaEpFVHdPSS9lRlBBeGRQQXhkUEF4ZFBBeU5PQkU0RWlQM3pSUUVvVEZDd0lrTWpyNGo5d1lFZ0pFbUIvd2VJL2R4R0FpSkRJNitJL2E2QkVDUkpnZjhQaVAzSlJnSWlReU92aVAyYkl5UkpnZjRmaVAyM1JnSWlReU92aVAySmdTQWtTWUdBQ0lqOXBFWUNJa009IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
