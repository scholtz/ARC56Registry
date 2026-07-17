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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.ControlFlow_6df31762
{


    //
    // ControlFlow Contract
    //
    //This contract demonstrates various control flow operations in Algorand smart contracts.
    //It shows how to use:
    //- If/else statements
    //- For loops
    //- Switch statements (equivalent to Python's match)
    //- While loops
    //
    //The contract implements the same functionality as its Python counterpart
    //in python-examples/smart_contracts/control_flow/contract.py
    //
    public class ControlFlowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ControlFlowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Determines if an account is rich based on its balance
        ///</summary>
        /// <param name="accountBalance">The account balance to check </param>
        public async Task<string> IsRich(ulong accountBalance, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 8, 47, 123 };
            var accountBalanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); accountBalanceAbi.From(accountBalance);

            var result = await base.SimApp(new List<object> { abiHandle, accountBalanceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> IsRich_Transactions(ulong accountBalance, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 8, 47, 123 };
            var accountBalanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); accountBalanceAbi.From(accountBalance);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountBalanceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Determines if a number is even or odd
        ///</summary>
        /// <param name="number">The number to check </param>
        public async Task<string> IsEven(ulong number, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 251, 126, 241 };
            var numberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numberAbi.From(number);

            var result = await base.SimApp(new List<object> { abiHandle, numberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> IsEven_Transactions(ulong number, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 251, 126, 241 };
            var numberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numberAbi.From(number);

            return await base.MakeTransactionList(new List<object> { abiHandle, numberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Demonstrates different types of for loops
        ///</summary>
        public async Task<ulong[]> ForLoop(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 43, 166, 104 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> ForLoop_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 43, 166, 104 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the day of the week based on a numeric input
        ///</summary>
        /// <param name="date">A number from 0-6 representing a day of the week </param>
        public async Task<string> GetDay(ulong date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 172, 106, 94 };
            var dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dateAbi.From(date);

            var result = await base.SimApp(new List<object> { abiHandle, dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetDay_Transactions(ulong date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 172, 106, 94 };
            var dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dateAbi.From(date);

            return await base.MakeTransactionList(new List<object> { abiHandle, dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculates the minimum balance requirement (MBR) increase for box storage
        ///based on different box size categories.
        ///</summary>
        /// <param name="boxSizeLabel">The category of box size as a string label. Valid values:
        ///'xs' (8B), 'sm' (64B), 'md' (256B), 'lg' (1KB), 'max' (32KB) </param>
        /// <param name="boxName">The name of the box (used to calculate name length) </param>
        public async Task<ulong> CalculateBoxStorageCost(string boxSizeLabel, string boxName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 194, 188, 87 };
            var boxSizeLabelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); boxSizeLabelAbi.From(boxSizeLabel);
            var boxNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); boxNameAbi.From(boxName);

            var result = await base.SimApp(new List<object> { abiHandle, boxSizeLabelAbi, boxNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateBoxStorageCost_Transactions(string boxSizeLabel, string boxName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 194, 188, 87 };
            var boxSizeLabelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); boxSizeLabelAbi.From(boxSizeLabel);
            var boxNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); boxNameAbi.From(boxName);

            return await base.MakeTransactionList(new List<object> { abiHandle, boxSizeLabelAbi, boxNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Demonstrates while loop with continue and break statements
        ///</summary>
        public async Task<ulong> Loop(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 42, 38, 84 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Loop_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 42, 38, 84 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJvbEZsb3ciLCJkZXNjIjoiQ29udHJvbEZsb3cgQ29udHJhY3RcblxuVGhpcyBjb250cmFjdCBkZW1vbnN0cmF0ZXMgdmFyaW91cyBjb250cm9sIGZsb3cgb3BlcmF0aW9ucyBpbiBBbGdvcmFuZCBzbWFydCBjb250cmFjdHMuXG5JdCBzaG93cyBob3cgdG8gdXNlOlxuLSBJZi9lbHNlIHN0YXRlbWVudHNcbi0gRm9yIGxvb3BzXG4tIFN3aXRjaCBzdGF0ZW1lbnRzIChlcXVpdmFsZW50IHRvIFB5dGhvbidzIG1hdGNoKVxuLSBXaGlsZSBsb29wc1xuXG5UaGUgY29udHJhY3QgaW1wbGVtZW50cyB0aGUgc2FtZSBmdW5jdGlvbmFsaXR5IGFzIGl0cyBQeXRob24gY291bnRlcnBhcnRcbmluIHB5dGhvbi1leGFtcGxlcy9zbWFydF9jb250cmFjdHMvY29udHJvbF9mbG93L2NvbnRyYWN0LnB5IiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImlzUmljaCIsImRlc2MiOiJEZXRlcm1pbmVzIGlmIGFuIGFjY291bnQgaXMgcmljaCBiYXNlZCBvbiBpdHMgYmFsYW5jZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50QmFsYW5jZSIsImRlc2MiOiJUaGUgYWNjb3VudCBiYWxhbmNlIHRvIGNoZWNrIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IkEgc3RyaW5nIGRlc2NyaWJpbmcgdGhlIGFjY291bnQncyB3ZWFsdGggc3RhdHVzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc0V2ZW4iLCJkZXNjIjoiRGV0ZXJtaW5lcyBpZiBhIG51bWJlciBpcyBldmVuIG9yIG9kZCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudW1iZXIiLCJkZXNjIjoiVGhlIG51bWJlciB0byBjaGVjayIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJcIkV2ZW5cIiBpZiB0aGUgbnVtYmVyIGlzIGV2ZW4sIFwiT2RkXCIgb3RoZXJ3aXNlIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmb3JMb29wIiwiZGVzYyI6IkRlbW9uc3RyYXRlcyBkaWZmZXJlbnQgdHlwZXMgb2YgZm9yIGxvb3BzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjoiQW4gYXJyYXkgb2YgdWludDY0IHZhbHVlcyBpbiByZXZlcnNlZCBvcmRlciJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0RGF5IiwiZGVzYyI6IlJldHVybnMgdGhlIGRheSBvZiB0aGUgd2VlayBiYXNlZCBvbiBhIG51bWVyaWMgaW5wdXQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0ZSIsImRlc2MiOiJBIG51bWJlciBmcm9tIDAtNiByZXByZXNlbnRpbmcgYSBkYXkgb2YgdGhlIHdlZWsiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIG5hbWUgb2YgdGhlIGRheSwgb3IgXCJJbnZhbGlkIGRheVwiIGlmIG91dCBvZiByYW5nZSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsY3VsYXRlQm94U3RvcmFnZUNvc3QiLCJkZXNjIjoiQ2FsY3VsYXRlcyB0aGUgbWluaW11bSBiYWxhbmNlIHJlcXVpcmVtZW50IChNQlIpIGluY3JlYXNlIGZvciBib3ggc3RvcmFnZVxuYmFzZWQgb24gZGlmZmVyZW50IGJveCBzaXplIGNhdGVnb3JpZXMuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJveFNpemVMYWJlbCIsImRlc2MiOiJUaGUgY2F0ZWdvcnkgb2YgYm94IHNpemUgYXMgYSBzdHJpbmcgbGFiZWwuIFZhbGlkIHZhbHVlczpcbid4cycgKDhCKSwgJ3NtJyAoNjRCKSwgJ21kJyAoMjU2QiksICdsZycgKDFLQiksICdtYXgnICgzMktCKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm94TmFtZSIsImRlc2MiOiJUaGUgbmFtZSBvZiB0aGUgYm94ICh1c2VkIHRvIGNhbGN1bGF0ZSBuYW1lIGxlbmd0aCkiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIE1CUiBpbmNyZWFzZSBpbiBtaWNyb0FsZ29zLCBvciAwIGlmIGludmFsaWQgc2l6ZSBsYWJlbCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9vcCIsImRlc2MiOiJEZW1vbnN0cmF0ZXMgd2hpbGUgbG9vcCB3aXRoIGNvbnRpbnVlIGFuZCBicmVhayBzdGF0ZW1lbnRzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBudW1iZXIgb2YgaXRlcmF0aW9ucyBwZXJmb3JtZWQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwOV0sImVycm9yTWVzc2FnZSI6IlN1bSBvZiByZXZlcnNlZCBhcnJheSBzaG91bGQgYmUgNiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyN10sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjcwLDMzNl0sImVycm9yTWVzc2FnZSI6Im1heCBhcnJheSBsZW5ndGggZXhjZWVkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRGdnTWdvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSURCNE1EQXdNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUdWNGNHOXlkQ0JrWldaaGRXeDBJR05zWVhOeklFTnZiblJ5YjJ4R2JHOTNJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFekNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHVm1NRGd5WmpkaUlEQjRPVFJtWWpkbFpqRWdNSGczTWpKaVlUWTJPQ0F3ZURkbVlXTTJZVFZsSURCNFl6bGpNbUpqTlRjZ01IaG1PREpoTWpZMU5DQXZMeUJ0WlhSb2IyUWdJbWx6VW1samFDaDFhVzUwTmpRcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKcGMwVjJaVzRvZFdsdWREWTBLWE4wY21sdVp5SXNJRzFsZEdodlpDQWlabTl5VEc5dmNDZ3BkV2x1ZERZMFcxMGlMQ0J0WlhSb2IyUWdJbWRsZEVSaGVTaDFhVzUwTmpRcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKallXeGpkV3hoZEdWQ2IzaFRkRzl5WVdkbFEyOXpkQ2h6ZEhKcGJtY3NjM1J5YVc1bktYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWJHOXZjQ2dwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYVhOU2FXTm9JR2x6UlhabGJpQm1iM0pNYjI5d0lHZGxkRVJoZVNCallXeGpkV3hoZEdWQ2IzaFRkRzl5WVdkbFEyOXpkQ0JzYjI5d0NpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV6T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBOdmJuUnliMnhHYkc5M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklHVjRjRzl5ZENCa1pXWmhkV3gwSUdOc1lYTnpJRU52Ym5SeWIyeEdiRzkzSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200Z0x5OGdiMjRnWlhKeWIzSTZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQWdKaVlnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2dvS0x5OGdZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tOdmJuUnliMnhHYkc5M0xtbHpVbWxqYUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHpVbWxqYURvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBMVEkxQ2lBZ0lDQXZMeUJBY21WaFpHOXViSGtLSUNBZ0lDOHZJSEIxWW14cFl5QnBjMUpwWTJnb1lXTmpiM1Z1ZEVKaGJHRnVZMlU2SUhWcGJuUTJOQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlEYjI1MGNtOXNSbXh2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCcFppQW9ZV05qYjNWdWRFSmhiR0Z1WTJVZ1BpQXhNREF3S1NCN0NpQWdJQ0J3ZFhOb2FXNTBJREV3TURBZ0x5OGdNVEF3TUFvZ0lDQWdQZ29nSUNBZ1lub2dhWE5TYVdOb1gyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRMjl1ZEhKdmJFWnNiM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnY21WMGRYSnVJQ2RVYUdseklHRmpZMjkxYm5RZ2FYTWdjbWxqYUNFbkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWxSb2FYTWdZV05qYjNWdWRDQnBjeUJ5YVdOb0lTSUtDbWx6VW1samFGOWhablJsY2w5cGJteHBibVZrWDJOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcERiMjUwY205c1JteHZkeTVwYzFKcFkyaEFOam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlEYjI1MGNtOXNSbXh2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMExUSTFDaUFnSUNBdkx5QkFjbVZoWkc5dWJIa0tJQ0FnSUM4dklIQjFZbXhwWXlCcGMxSnBZMmdvWVdOamIzVnVkRUpoYkdGdVkyVTZJSFZwYm5RMk5DazZJSE4wY21sdVp5QjdDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0thWE5TYVdOb1gyVnNjMlZmWW05a2VVQXpPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUgwZ1pXeHpaU0JwWmlBb1lXTmpiM1Z1ZEVKaGJHRnVZMlVnUGlBeE1EQXBJSHNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1EQWdMeThnTVRBd0NpQWdJQ0ErQ2lBZ0lDQmllaUJwYzFKcFkyaGZaV3h6WlY5aWIyUjVRRFVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlEYjI1MGNtOXNSbXh2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCeVpYUjFjbTRnSjFSb2FYTWdZV05qYjNWdWRDQnBjeUJrYjJsdVp5QjNaV3hzTGljS0lDQWdJSEIxYzJoaWVYUmxjeUFpVkdocGN5QmhZMk52ZFc1MElHbHpJR1J2YVc1bklIZGxiR3d1SWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBOdmJuUnliMnhHYkc5M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qUXRNalVLSUNBZ0lDOHZJRUJ5WldGa2IyNXNlUW9nSUNBZ0x5OGdjSFZpYkdsaklHbHpVbWxqYUNoaFkyTnZkVzUwUW1Gc1lXNWpaVG9nZFdsdWREWTBLVG9nYzNSeWFXNW5JSHNLSUNBZ0lHSWdhWE5TYVdOb1gyRm1kR1Z5WDJsdWJHbHVaV1JmWTI5dWRISmhZM1J6TDBOdmJuUnliMnhHYkc5M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rTnZiblJ5YjJ4R2JHOTNMbWx6VW1samFFQTJDZ3BwYzFKcFkyaGZaV3h6WlY5aWIyUjVRRFU2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UTI5dWRISnZiRVpzYjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUNkVWFHbHpJR0ZqWTI5MWJuUWdhWE1nY0c5dmNpQTZLQ2NLSUNBZ0lIQjFjMmhpZVhSbGN5QWlWR2hwY3lCaFkyTnZkVzUwSUdseklIQnZiM0lnT2lnaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOQzB5TlFvZ0lDQWdMeThnUUhKbFlXUnZibXg1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhWE5TYVdOb0tHRmpZMjkxYm5SQ1lXeGhibU5sT2lCMWFXNTBOalFwT2lCemRISnBibWNnZXdvZ0lDQWdZaUJwYzFKcFkyaGZZV1owWlhKZmFXNXNhVzVsWkY5amIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRMjl1ZEhKdmJFWnNiM2N1YVhOU2FXTm9RRFlLQ2dvdkx5QmpiMjUwY21GamRITXZRMjl1ZEhKdmJFWnNiM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UTI5dWRISnZiRVpzYjNjdWFYTkZkbVZ1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FYTkZkbVZ1T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBOdmJuUnliMnhHYkc5M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ESXRORE1LSUNBZ0lDOHZJRUJ5WldGa2IyNXNlUW9nSUNBZ0x5OGdjSFZpYkdsaklHbHpSWFpsYmlodWRXMWlaWEk2SUhWcGJuUTJOQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UTI5dWRISnZiRVpzYjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1MWJXSmxjaUFsSURJZ1BUMDlJREFnUHlBblJYWmxiaWNnT2lBblQyUmtKd29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNVS0lDQWdJR0p1ZWlCcGMwVjJaVzVmZEdWeWJtRnllVjltWVd4elpVQXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVjJaVzRpQ2dwcGMwVjJaVzVmZEdWeWJtRnllVjl0WlhKblpVQTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRJdE5ETUtJQ0FnSUM4dklFQnlaV0ZrYjI1c2VRb2dJQ0FnTHk4Z2NIVmliR2xqSUdselJYWmxiaWh1ZFcxaVpYSTZJSFZwYm5RMk5DazZJSE4wY21sdVp5QjdDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0thWE5GZG1WdVgzUmxjbTVoY25sZlptRnNjMlZBTXpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTBDaUFnSUNBdkx5QnlaWFIxY200Z2JuVnRZbVZ5SUNVZ01pQTlQVDBnTUNBL0lDZEZkbVZ1SnlBNklDZFBaR1FuQ2lBZ0lDQndkWE5vWW5sMFpYTWdJazlrWkNJS0lDQWdJR0lnYVhORmRtVnVYM1JsY201aGNubGZiV1Z5WjJWQU5Bb0tDaTh2SUdOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcERiMjUwY205c1JteHZkeTVtYjNKTWIyOXdXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWm05eVRHOXZjRG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdSMWNHNGdOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUd4bGRDQnVkVzFpWlhKek9pQjFhVzUwTmpSYlhTQTlJRnRkQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR2wwWlcwZ2IyWWdkWEpoYm1kbEtEUXBLU0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9LWm05eVRHOXZjRjltYjNKZmFHVmhaR1Z5UURJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPUW9nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0JwZEdWdElHOW1JSFZ5WVc1blpTZzBLU2tnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnTkFvZ0lDQWdQQW9nSUNBZ1lub2dabTl5VEc5dmNGOWhablJsY2w5bWIzSkFOUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUc1MWJXSmxjbk1nUFNCYkxpNHViblZ0WW1WeWN5d2dhWFJsYlYwS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRZ0x5OGdiMjRnWlhKeWIzSTZJRzFoZUNCaGNuSmhlU0JzWlc1bmRHZ2daWGhqWldWa1pXUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDOEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQmlkWEo1SURNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR2wwWlcwZ2IyWWdkWEpoYm1kbEtEUXBLU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlHWnZja3h2YjNCZlptOXlYMmhsWVdSbGNrQXlDZ3BtYjNKTWIyOXdYMkZtZEdWeVgyWnZja0ExT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBOdmJuUnliMnhHYkc5M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdiblZ0SUc5bUlHNTFiV0psY25NcElIc0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdKMWNua2dPQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKMWNua2dOZ29nSUNBZ1pHbG5JRElLSUNBZ0lHSjFjbmtnT1FvS1ptOXlURzl2Y0Y5bWIzSmZhR1ZoWkdWeVFEWTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRMjl1ZEhKdmJFWnNiM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCdWRXMGdiMllnYm5WdFltVnljeWtnZXdvZ0lDQWdaR2xuSURVS0lDQWdJR1JwWnlBNENpQWdJQ0E4Q2lBZ0lDQmllaUJtYjNKTWIyOXdYMkZtZEdWeVgyWnZja0E1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRMjl1ZEhKdmJFWnNiM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTUFvZ0lDQWdMeThnY21WMlpYSnpaV1FnUFNCYmJuVnRMQ0F1TGk1eVpYWmxjbk5sWkYwS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHTnZibU5oZENBdkx5QnZiaUJsY25KdmNqb2diV0Y0SUdGeWNtRjVJR3hsYm1kMGFDQmxlR05sWldSbFpBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0x3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lHSjFjbmtnTVRBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJRFlLSUNBZ0lHSWdabTl5VEc5dmNGOW1iM0pmYUdWaFpHVnlRRFlLQ21admNreHZiM0JmWVdaMFpYSmZabTl5UURrNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdiR1YwSUhOMWJUb2dkV2x1ZERZMElEMGdNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKMWNua2dOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2JuVnRJRzltSUhKbGRtVnljMlZrS1NCN0NpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JpZFhKNUlEY0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZFhKNUlEVUtDbVp2Y2t4dmIzQmZabTl5WDJobFlXUmxja0F4TURvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJRzUxYlNCdlppQnlaWFpsY25ObFpDa2dld29nSUNBZ1pHbG5JRFFLSUNBZ0lHUnBaeUEzQ2lBZ0lDQThDaUFnSUNCaWVpQm1iM0pNYjI5d1gyRm1kR1Z5WDJadmNrQXhNd29nSUNBZ1pHbG5JRGdLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dOUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJ6ZFcwZ0t6MGdiblZ0Q2lBZ0lDQmthV2NnTlFvZ0lDQWdLd29nSUNBZ1luVnllU0ExQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTFDaUFnSUNCaUlHWnZja3h2YjNCZlptOXlYMmhsWVdSbGNrQXhNQW9LWm05eVRHOXZjRjloWm5SbGNsOW1iM0pBTVRNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNQW9nSUNBZ0x5OGdZWE56WlhKMEtITjFiU0E5UFQwZ05pd2dKMU4xYlNCdlppQnlaWFpsY25ObFpDQmhjbkpoZVNCemFHOTFiR1FnWW1VZ05pY3BDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR2x1ZENBMklDOHZJRFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1UzVnRJRzltSUhKbGRtVnljMlZrSUdGeWNtRjVJSE5vYjNWc1pDQmlaU0EyQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UTI5dWRISnZiRVpzYjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU15MDFOQW9nSUNBZ0x5OGdRSEpsWVdSdmJteDVDaUFnSUNBdkx5QndkV0pzYVdNZ1ptOXlURzl2Y0NncE9pQjFhVzUwTmpSYlhTQjdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUdScFp5QTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEYjI1MGNtOXNSbXh2ZHk1blpYUkVZWGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUkVZWGs2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UTI5dWRISnZiRVpzYjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1pMDVNd29nSUNBZ0x5OGdRSEpsWVdSdmJteDVDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBSR0Y1S0dSaGRHVTZJSFZwYm5RMk5DazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsxQ2lBZ0lDQXZMeUJqWVhObElGVnBiblEyTkNneEtUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBOdmJuUnliMnhHYkc5M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UVXRPVFlLSUNBZ0lDOHZJR05oYzJVZ1ZXbHVkRFkwS0RFcE9nb2dJQ0FnTHk4Z0lDQnlaWFIxY200Z0owMXZibVJoZVNjS0lDQWdJR0o2SUdkbGRFUmhlVjloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdKMDF2Ym1SaGVTY0tJQ0FnSUhCMWMyaGllWFJsY3lBaVRXOXVaR0Y1SWdvS1oyVjBSR0Y1WDJGbWRHVnlYMmx1YkdsdVpXUmZZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tOdmJuUnliMnhHYkc5M0xtZGxkRVJoZVVBeU5Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt5TFRrekNpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSRVlYa29aR0YwWlRvZ2RXbHVkRFkwS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwblpYUkVZWGxmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RjS0lDQWdJQzh2SUdOaGMyVWdWV2x1ZERZMEtESXBPZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnUFQwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazNMVGs0Q2lBZ0lDQXZMeUJqWVhObElGVnBiblEyTkNneUtUb0tJQ0FnSUM4dklDQWdjbVYwZFhKdUlDZFVkV1Z6WkdGNUp3b2dJQ0FnWW5vZ1oyVjBSR0Y1WDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RnS0lDQWdJQzh2SUhKbGRIVnliaUFuVkhWbGMyUmhlU2NLSUNBZ0lIQjFjMmhpZVhSbGN5QWlWSFZsYzJSaGVTSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt5TFRrekNpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSRVlYa29aR0YwWlRvZ2RXbHVkRFkwS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR0lnWjJWMFJHRjVYMkZtZEdWeVgybHViR2x1WldSZlkyOXVkSEpoWTNSekwwTnZiblJ5YjJ4R2JHOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa052Ym5SeWIyeEdiRzkzTG1kbGRFUmhlVUF5TkFvS1oyVjBSR0Y1WDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlEYjI1MGNtOXNSbXh2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prNUNpQWdJQ0F2THlCallYTmxJRlZwYm5RMk5DZ3pLVG9LSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeklDOHZJRE1LSUNBZ0lEMDlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRMjl1ZEhKdmJFWnNiM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81T1MweE1EQUtJQ0FnSUM4dklHTmhjMlVnVldsdWREWTBLRE1wT2dvZ0lDQWdMeThnSUNCeVpYUjFjbTRnSjFkbFpHNWxjMlJoZVNjS0lDQWdJR0o2SUdkbGRFUmhlVjloWm5SbGNsOXBabDlsYkhObFFERXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRMjl1ZEhKdmJFWnNiM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURBS0lDQWdJQzh2SUhKbGRIVnliaUFuVjJWa2JtVnpaR0Y1SndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pYWldSdVpYTmtZWGtpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UTI5dWRISnZiRVpzYjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1pMDVNd29nSUNBZ0x5OGdRSEpsWVdSdmJteDVDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBSR0Y1S0dSaGRHVTZJSFZwYm5RMk5DazZJSE4wY21sdVp5QjdDaUFnSUNCaUlHZGxkRVJoZVY5aFpuUmxjbDlwYm14cGJtVmtYMk52Ym5SeVlXTjBjeTlEYjI1MGNtOXNSbXh2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRGIyNTBjbTlzUm14dmR5NW5aWFJFWVhsQU1qUUtDbWRsZEVSaGVWOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZiblJ5YjJ4R2JHOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF4Q2lBZ0lDQXZMeUJqWVhObElGVnBiblEyTkNnMEtUb0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklEUUtJQ0FnSUQwOUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNREV0TVRBeUNpQWdJQ0F2THlCallYTmxJRlZwYm5RMk5DZzBLVG9LSUNBZ0lDOHZJQ0FnY21WMGRYSnVJQ2RVYUhWeWMyUmhlU2NLSUNBZ0lHSjZJR2RsZEVSaGVWOWhablJsY2w5cFpsOWxiSE5sUURFekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRElLSUNBZ0lDOHZJSEpsZEhWeWJpQW5WR2gxY25Oa1lYa25DaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsUm9kWEp6WkdGNUlnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZiblJ5YjJ4R2JHOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVEl0T1RNS0lDQWdJQzh2SUVCeVpXRmtiMjVzZVFvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEVSaGVTaGtZWFJsT2lCMWFXNTBOalFwT2lCemRISnBibWNnZXdvZ0lDQWdZaUJuWlhSRVlYbGZZV1owWlhKZmFXNXNhVzVsWkY5amIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRMjl1ZEhKdmJFWnNiM2N1WjJWMFJHRjVRREkwQ2dwblpYUkVZWGxmWVdaMFpYSmZhV1pmWld4elpVQXhNem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlEYjI1MGNtOXNSbXh2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd013b2dJQ0FnTHk4Z1kyRnpaU0JWYVc1ME5qUW9OU2s2Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05TQXZMeUExQ2lBZ0lDQTlQUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBekxURXdOQW9nSUNBZ0x5OGdZMkZ6WlNCVmFXNTBOalFvTlNrNkNpQWdJQ0F2THlBZ0lISmxkSFZ5YmlBblJuSnBaR0Y1SndvZ0lDQWdZbm9nWjJWMFJHRjVYMkZtZEdWeVgybG1YMlZzYzJWQU1UWUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TkFvZ0lDQWdMeThnY21WMGRYSnVJQ2RHY21sa1lYa25DaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrWnlhV1JoZVNJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa3lMVGt6Q2lBZ0lDQXZMeUJBY21WaFpHOXViSGtLSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJFWVhrb1pHRjBaVG9nZFdsdWREWTBLVG9nYzNSeWFXNW5JSHNLSUNBZ0lHSWdaMlYwUkdGNVgyRm1kR1Z5WDJsdWJHbHVaV1JmWTI5dWRISmhZM1J6TDBOdmJuUnliMnhHYkc5M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rTnZiblJ5YjJ4R2JHOTNMbWRsZEVSaGVVQXlOQW9LWjJWMFJHRjVYMkZtZEdWeVgybG1YMlZzYzJWQU1UWTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRMjl1ZEhKdmJFWnNiM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURVS0lDQWdJQzh2SUdOaGMyVWdWV2x1ZERZMEtEWXBPZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdOZ29nSUNBZ1BUMEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TlMweE1EWUtJQ0FnSUM4dklHTmhjMlVnVldsdWREWTBLRFlwT2dvZ0lDQWdMeThnSUNCeVpYUjFjbTRnSjFOaGRIVnlaR0Y1SndvZ0lDQWdZbm9nWjJWMFJHRjVYMkZtZEdWeVgybG1YMlZzYzJWQU1Ua0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnY21WMGRYSnVJQ2RUWVhSMWNtUmhlU2NLSUNBZ0lIQjFjMmhpZVhSbGN5QWlVMkYwZFhKa1lYa2lDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRMjl1ZEhKdmJFWnNiM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TWkwNU13b2dJQ0FnTHk4Z1FISmxZV1J2Ym14NUNpQWdJQ0F2THlCd2RXSnNhV01nWjJWMFJHRjVLR1JoZEdVNklIVnBiblEyTkNrNklITjBjbWx1WnlCN0NpQWdJQ0JpSUdkbGRFUmhlVjloWm5SbGNsOXBibXhwYm1Wa1gyTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEYjI1MGNtOXNSbXh2ZHk1blpYUkVZWGxBTWpRS0NtZGxkRVJoZVY5aFpuUmxjbDlwWmw5bGJITmxRREU1T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBOdmJuUnliMnhHYkc5M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTNDaUFnSUNBdkx5QmpZWE5sSUZWcGJuUTJOQ2czS1RvS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTNJQzh2SURjS0lDQWdJRDA5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UTI5dWRISnZiRVpzYjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EY3RNVEE0Q2lBZ0lDQXZMeUJqWVhObElGVnBiblEyTkNnM0tUb0tJQ0FnSUM4dklDQWdjbVYwZFhKdUlDZFRkVzVrWVhrbkNpQWdJQ0JpZWlCblpYUkVZWGxmWVdaMFpYSmZhV1pmWld4elpVQXlNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNENpQWdJQ0F2THlCeVpYUjFjbTRnSjFOMWJtUmhlU2NLSUNBZ0lIQjFjMmhpZVhSbGN5QWlVM1Z1WkdGNUlnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZiblJ5YjJ4R2JHOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVEl0T1RNS0lDQWdJQzh2SUVCeVpXRmtiMjVzZVFvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEVSaGVTaGtZWFJsT2lCMWFXNTBOalFwT2lCemRISnBibWNnZXdvZ0lDQWdZaUJuWlhSRVlYbGZZV1owWlhKZmFXNXNhVzVsWkY5amIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRMjl1ZEhKdmJFWnNiM2N1WjJWMFJHRjVRREkwQ2dwblpYUkVZWGxmWVdaMFpYSmZhV1pmWld4elpVQXlNam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlEYjI1MGNtOXNSbXh2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUNkSmJuWmhiR2xrSUdSaGVTY0tJQ0FnSUhCMWMyaGllWFJsY3lBaVNXNTJZV3hwWkNCa1lYa2lDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRMjl1ZEhKdmJFWnNiM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TWkwNU13b2dJQ0FnTHk4Z1FISmxZV1J2Ym14NUNpQWdJQ0F2THlCd2RXSnNhV01nWjJWMFJHRjVLR1JoZEdVNklIVnBiblEyTkNrNklITjBjbWx1WnlCN0NpQWdJQ0JpSUdkbGRFUmhlVjloWm5SbGNsOXBibXhwYm1Wa1gyTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEYjI1MGNtOXNSbXh2ZHk1blpYUkVZWGxBTWpRS0Nnb3ZMeUJqYjI1MGNtRmpkSE12UTI5dWRISnZiRVpzYjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlEyOXVkSEp2YkVac2IzY3VZMkZzWTNWc1lYUmxRbTk0VTNSdmNtRm5aVU52YzNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpZV3hqZFd4aGRHVkNiM2hUZEc5eVlXZGxRMjl6ZERvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOUzB4TWpZS0lDQWdJQzh2SUVCeVpXRmtiMjVzZVFvZ0lDQWdMeThnY0hWaWJHbGpJR05oYkdOMWJHRjBaVUp2ZUZOMGIzSmhaMlZEYjNOMEtHSnZlRk5wZW1WTVlXSmxiRG9nYzNSeWFXNW5MQ0JpYjNoT1lXMWxPaUJ6ZEhKcGJtY3BPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNZ29nSUNBZ0x5OGdZMjl1YzNRZ1ltOTRUbUZ0WlV4bGJtZDBhRG9nZFdsdWREWTBJRDBnUW5sMFpYTW9ZbTk0VG1GdFpTa3ViR1Z1WjNSb0NpQWdJQ0JzWlc0S0lDQWdJSE4zWVhBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpPQW9nSUNBZ0x5OGdZMkZ6WlNBbmVITW5PZ29nSUNBZ2NIVnphR0o1ZEdWeklDSjRjeUlLSUNBZ0lEMDlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRMjl1ZEhKdmJFWnNiM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpndE1UUXdDaUFnSUNBdkx5QmpZWE5sSUNkNGN5YzZDaUFnSUNBdkx5QWdJR0p2ZUZOcGVtVWdQU0E0SUM4dklEZ2dZbmwwWlhNZ0tHVnViM1ZuYUNCbWIzSWdZU0IxYVc1ME5qUXBDaUFnSUNBdkx5QWdJR0p5WldGckNpQWdJQ0JpZWlCallXeGpkV3hoZEdWQ2IzaFRkRzl5WVdkbFEyOXpkRjloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6T1FvZ0lDQWdMeThnWW05NFUybDZaU0E5SURnZ0x5OGdPQ0JpZVhSbGN5QW9aVzV2ZFdkb0lHWnZjaUJoSUhWcGJuUTJOQ2tLSUNBZ0lHbHVkR05mTWlBdkx5QTRDZ3BqWVd4amRXeGhkR1ZDYjNoVGRHOXlZV2RsUTI5emRGOWliRzlqYTBBeE9Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTlFvZ0lDQWdMeThnWTI5dWMzUWdiV0p5U1c1amNtVmhjMlU2SUhWcGJuUTJOQ0E5SUdKaGMyVkRiM04wSUNzZ1lubDBaVlZ1YVhSRGIzTjBJQ29nS0dKdmVFNWhiV1ZNWlc1bmRHZ2dLeUJpYjNoVGFYcGxLUW9nSUNBZ1pHbG5JREVLSUNBZ0lDc0tJQ0FnSUhCMWMyaHBiblFnTkRBd0lDOHZJRFF3TUFvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeU5UQXdJQzh2SURJMU1EQUtJQ0FnSUNzS0NtTmhiR04xYkdGMFpVSnZlRk4wYjNKaFoyVkRiM04wWDJGbWRHVnlYMmx1YkdsdVpXUmZZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tOdmJuUnliMnhHYkc5M0xtTmhiR04xYkdGMFpVSnZlRk4wYjNKaFoyVkRiM04wUURFNU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZiblJ5YjJ4R2JHOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkxTFRFeU5nb2dJQ0FnTHk4Z1FISmxZV1J2Ym14NUNpQWdJQ0F2THlCd2RXSnNhV01nWTJGc1kzVnNZWFJsUW05NFUzUnZjbUZuWlVOdmMzUW9ZbTk0VTJsNlpVeGhZbVZzT2lCemRISnBibWNzSUdKdmVFNWhiV1U2SUhOMGNtbHVaeWs2SUhWcGJuUTJOQ0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwallXeGpkV3hoZEdWQ2IzaFRkRzl5WVdkbFEyOXpkRjloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRMjl1ZEhKdmJFWnNiM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRJS0lDQWdJQzh2SUdOaGMyVWdKM050SnpvS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5OdElnb2dJQ0FnUFQwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBNaTB4TkRRS0lDQWdJQzh2SUdOaGMyVWdKM050SnpvS0lDQWdJQzh2SUNBZ1ltOTRVMmw2WlNBOUlEWTBJQzh2SURZMElHSjVkR1Z6Q2lBZ0lDQXZMeUFnSUdKeVpXRnJDaUFnSUNCaWVpQmpZV3hqZFd4aGRHVkNiM2hUZEc5eVlXZGxRMjl6ZEY5aFpuUmxjbDlwWmw5bGJITmxRRGNLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlEYjI1MGNtOXNSbXh2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME13b2dJQ0FnTHk4Z1ltOTRVMmw2WlNBOUlEWTBJQzh2SURZMElHSjVkR1Z6Q2lBZ0lDQndkWE5vYVc1MElEWTBJQzh2SURZMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORFFLSUNBZ0lDOHZJR0p5WldGckNpQWdJQ0JpSUdOaGJHTjFiR0YwWlVKdmVGTjBiM0poWjJWRGIzTjBYMkpzYjJOclFERTRDZ3BqWVd4amRXeGhkR1ZDYjNoVGRHOXlZV2RsUTI5emRGOWhablJsY2w5cFpsOWxiSE5sUURjNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORFlLSUNBZ0lDOHZJR05oYzJVZ0oyMWtKem9LSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbTFrSWdvZ0lDQWdQVDBLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlEYjI1MGNtOXNSbXh2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME5pMHhORGdLSUNBZ0lDOHZJR05oYzJVZ0oyMWtKem9LSUNBZ0lDOHZJQ0FnWW05NFUybDZaU0E5SURJMU5pQXZMeUF5TlRZZ1lubDBaWE1LSUNBZ0lDOHZJQ0FnWW5KbFlXc0tJQ0FnSUdKNklHTmhiR04xYkdGMFpVSnZlRk4wYjNKaFoyVkRiM04wWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlEYjI1MGNtOXNSbXh2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME53b2dJQ0FnTHk4Z1ltOTRVMmw2WlNBOUlESTFOaUF2THlBeU5UWWdZbmwwWlhNS0lDQWdJSEIxYzJocGJuUWdNalUySUM4dklESTFOZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMME52Ym5SeWIyeEdiRzkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRNENpQWdJQ0F2THlCaWNtVmhhd29nSUNBZ1lpQmpZV3hqZFd4aGRHVkNiM2hUZEc5eVlXZGxRMjl6ZEY5aWJHOWphMEF4T0FvS1kyRnNZM1ZzWVhSbFFtOTRVM1J2Y21GblpVTnZjM1JmWVdaMFpYSmZhV1pmWld4elpVQXhNRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlEYjI1MGNtOXNSbXh2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU1Bb2dJQ0FnTHk4Z1kyRnpaU0FuYkdjbk9nb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaGllWFJsY3lBaWJHY2lDaUFnSUNBOVBRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZiblJ5YjJ4R2JHOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV3TFRFMU1nb2dJQ0FnTHk4Z1kyRnpaU0FuYkdjbk9nb2dJQ0FnTHk4Z0lDQmliM2hUYVhwbElEMGdNVEF5TkNBdkx5QXhTMElLSUNBZ0lDOHZJQ0FnWW5KbFlXc0tJQ0FnSUdKNklHTmhiR04xYkdGMFpVSnZlRk4wYjNKaFoyVkRiM04wWDJGbWRHVnlYMmxtWDJWc2MyVkFNVE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlEYjI1MGNtOXNSbXh2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU1Rb2dJQ0FnTHk4Z1ltOTRVMmw2WlNBOUlERXdNalFnTHk4Z01VdENDaUFnSUNCd2RYTm9hVzUwSURFd01qUWdMeThnTVRBeU5Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZiblJ5YjJ4R2JHOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV5Q2lBZ0lDQXZMeUJpY21WaGF3b2dJQ0FnWWlCallXeGpkV3hoZEdWQ2IzaFRkRzl5WVdkbFEyOXpkRjlpYkc5amEwQXhPQW9LWTJGc1kzVnNZWFJsUW05NFUzUnZjbUZuWlVOdmMzUmZZV1owWlhKZmFXWmZaV3h6WlVBeE16b0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTkFvZ0lDQWdMeThnWTJGelpTQW5iV0Y0SnpvS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb1lubDBaWE1nSW0xaGVDSUtJQ0FnSUQwOUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVFF0TVRVMkNpQWdJQ0F2THlCallYTmxJQ2R0WVhnbk9nb2dJQ0FnTHk4Z0lDQmliM2hUYVhwbElEMGdNekl3TURBZ0x5OGdNekpMUWlBb1kyeHZjMlVnZEc4Z2JXRjRJR0ZzYkc5M1pXUXBDaUFnSUNBdkx5QWdJR0p5WldGckNpQWdJQ0JpZWlCallXeGpkV3hoZEdWQ2IzaFRkRzl5WVdkbFEyOXpkRjloWm5SbGNsOXBabDlsYkhObFFERTJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRMjl1ZEhKdmJFWnNiM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRVS0lDQWdJQzh2SUdKdmVGTnBlbVVnUFNBek1qQXdNQ0F2THlBek1rdENJQ2hqYkc5elpTQjBieUJ0WVhnZ1lXeHNiM2RsWkNrS0lDQWdJSEIxYzJocGJuUWdNekl3TURBZ0x5OGdNekl3TURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5RGIyNTBjbTlzUm14dmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFOZ29nSUNBZ0x5OGdZbkpsWVdzS0lDQWdJR0lnWTJGc1kzVnNZWFJsUW05NFUzUnZjbUZuWlVOdmMzUmZZbXh2WTJ0QU1UZ0tDbU5oYkdOMWJHRjBaVUp2ZUZOMGIzSmhaMlZEYjNOMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRZNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOakFLSUNBZ0lDOHZJSEpsZEhWeWJpQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZiblJ5YjJ4R2JHOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkxTFRFeU5nb2dJQ0FnTHk4Z1FISmxZV1J2Ym14NUNpQWdJQ0F2THlCd2RXSnNhV01nWTJGc1kzVnNZWFJsUW05NFUzUnZjbUZuWlVOdmMzUW9ZbTk0VTJsNlpVeGhZbVZzT2lCemRISnBibWNzSUdKdmVFNWhiV1U2SUhOMGNtbHVaeWs2SUhWcGJuUTJOQ0I3Q2lBZ0lDQmlJR05oYkdOMWJHRjBaVUp2ZUZOMGIzSmhaMlZEYjNOMFgyRm1kR1Z5WDJsdWJHbHVaV1JmWTI5dWRISmhZM1J6TDBOdmJuUnliMnhHYkc5M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rTnZiblJ5YjJ4R2JHOTNMbU5oYkdOMWJHRjBaVUp2ZUZOMGIzSmhaMlZEYjNOMFFERTVDZ29LTHk4Z1kyOXVkSEpoWTNSekwwTnZiblJ5YjJ4R2JHOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa052Ym5SeWIyeEdiRzkzTG14dmIzQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BzYjI5d09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZiblJ5YjJ4R2JHOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGM0Q2lBZ0lDQXZMeUJzWlhRZ2JuVnRPaUIxYVc1ME5qUWdQU0F4TUFvZ0lDQWdjSFZ6YUdsdWRDQXhNQ0F2THlBeE1Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZiblJ5YjJ4R2JHOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGM1Q2lBZ0lDQXZMeUJzWlhRZ2JHOXZjRU52ZFc1ME9pQjFhVzUwTmpRZ1BTQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb0tiRzl2Y0Y5M2FHbHNaVjkwYjNCQU1qb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TVMweE9UUUtJQ0FnSUM4dklIZG9hV3hsSUNodWRXMGdQaUF3S1NCN0NpQWdJQ0F2THlBZ0lHbG1JQ2h1ZFcwZ1BpQTFLU0I3Q2lBZ0lDQXZMeUFnSUNBZ2JuVnRJQzA5SURFS0lDQWdJQzh2SUNBZ0lDQnNiMjl3UTI5MWJuUWdLejBnTVFvZ0lDQWdMeThnSUNBZ0lHTnZiblJwYm5WbENpQWdJQ0F2THlBZ0lIMEtJQ0FnSUM4dklBb2dJQ0FnTHk4Z0lDQnVkVzBnTFQwZ01nb2dJQ0FnTHk4Z0lDQnNiMjl3UTI5MWJuUWdLejBnTVFvZ0lDQWdMeThnQ2lBZ0lDQXZMeUFnSUdsbUlDaHVkVzBnUFQwOUlERXBJSHNLSUNBZ0lDOHZJQ0FnSUNCaWNtVmhhd29nSUNBZ0x5OGdJQ0I5Q2lBZ0lDQXZMeUI5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbm9nYkc5dmNGOWliRzlqYTBBeE1Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZiblJ5YjJ4R2JHOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd5Q2lBZ0lDQXZMeUJwWmlBb2JuVnRJRDRnTlNrZ2V3b2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTlNBdkx5QTFDaUFnSUNBK0NpQWdJQ0JpZWlCc2IyOXdYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZiblJ5YjJ4R2JHOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd6Q2lBZ0lDQXZMeUJ1ZFcwZ0xUMGdNUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JpZFhKNUlESUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TkFvZ0lDQWdMeThnYkc5dmNFTnZkVzUwSUNzOUlERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBOdmJuUnliMnhHYkc5M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzFDaUFnSUNBdkx5QmpiMjUwYVc1MVpRb2dJQ0FnWWlCc2IyOXdYM2RvYVd4bFgzUnZjRUF5Q2dwc2IyOXdYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0T0FvZ0lDQWdMeThnYm5WdElDMDlJRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlETUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0T1FvZ0lDQWdMeThnYkc5dmNFTnZkVzUwSUNzOUlERUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlEyOXVkSEp2YkVac2IzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVEVLSUNBZ0lDOHZJR2xtSUNodWRXMGdQVDA5SURFcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZbm9nYkc5dmNGOTNhR2xzWlY5MGIzQkFNZ29LYkc5dmNGOWliRzlqYTBBeE1Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiMjUwY205c1JteHZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTmkweE56Y0tJQ0FnSUM4dklFQnlaV0ZrYjI1c2VRb2dJQ0FnTHk4Z2NIVmliR2xqSUd4dmIzQW9LVG9nZFdsdWREWTBJSHNLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBSUFpWUNCQlVmZkhVQ0FBRXhHMEVBT1RFWkZFUXhHRVNDQmdUdkNDOTdCSlQ3ZnZFRWNpdW1hQVIvckdwZUJNbkN2RmNFK0NvbVZEWWFBSTRHQUFrQWZRQ2lBVk1COWdKbEFERVpGREVZRkJCRE5ob0JGMG1CNkFjTlFRQWxnQlZVYUdseklHRmpZMjkxYm5RZ2FYTWdjbWxqYUNGSkZSWlhCZ0pNVUNoTVVMQWlRMG1CWkExQkFDQ0FHMVJvYVhNZ1lXTmpiM1Z1ZENCcGN5QmtiMmx1WnlCM1pXeHNMa0wveTRBWFZHaHBjeUJoWTJOdmRXNTBJR2x6SUhCdmIzSWdPaWhDLzY4MkdnRVhKUmhBQUJTQUJFVjJaVzVKRlJaWEJnSk1VQ2hNVUxBaVE0QURUMlJrUXYvcUk0QUFSd1NBQWdBQVNTTkpnUVFNUVFBalJ3SVdLVXhRVndJQVN3Tk1VRWxYQWdBVkpBb1dWd1lDWEFCRkF5SUlSUUZDLzlaTEFTTlpSUWdqUlFaTEFrVUpTd1ZMQ0F4QkFDMUxBVmNDQUVzR1NVNENKQXNrV0NsTVVFc0tWd0lBVUVsWEFnQVZKQW9XVndZQ1hBQkZDaUlJUlFaQy84c2pSUVJMQ0NOWlJRY2pSUVZMQkVzSERFRUFHVXNJVndJQVN3VkpUZ0lrQzF0TEJRaEZCU0lJUlFWQy85OUxBNEVHRWtRb1N3bFFzQ0pETmhvQkYwa2lFa0VBRm9BR1RXOXVaR0Y1U1JVV1Z3WUNURkFvVEZDd0lrTkpKUkpCQUF5QUIxUjFaWE5rWVhsQy8rQkpnUU1TUVFBT2dBbFhaV1J1WlhOa1lYbEMvOHRKZ1FRU1FRQU5nQWhVYUhWeWMyUmhlVUwvdDBtQkJSSkJBQXVBQmtaeWFXUmhlVUwvcFVtQkJoSkJBQTJBQ0ZOaGRIVnlaR0Y1UXYrUlNZRUhFa0VBQzRBR1UzVnVaR0Y1UXY5L2dBdEpiblpoYkdsa0lHUmhlVUwvYnpZYUFWY0NBRWsyR2dKWEFnQVZUSUFDZUhNU1FRQVRKRXNCQ0lHUUF3dUJ4Qk1JRmloTVVMQWlRMHNCZ0FKemJSSkJBQVdCUUVMLzMwc0JnQUp0WkJKQkFBYUJnQUpDLzg5TEFZQUNiR2NTUVFBR2dZQUlRdisvU3dHQUEyMWhlQkpCQUFlQmdQb0JRdit0STBML3RJRUtJMHNCUVFBb1N3R0JCUTFCQUE1TEFTSUpSUUpKSWdoRkFVTC81VXNCSlFsSlJRTkxBU0lJUlFJaUVrSC8wMGtXS0V4UXNDSkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjowLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
