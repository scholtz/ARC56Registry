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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.FormatterTest_46fdf48b
{


    //
    //  @title FormatterTest
    // @notice Test contract that wraps Formatter library functions for puya-sol compilation testing.
    //
    public class FormatterTestProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FormatterTestProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///@notice Test numAsciiToUint: ASCII code → digit value
        ///</summary>
        /// <param name="numAscii"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> TestNumAsciiToUint(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 numAscii, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 174, 178, 92 };

            var result = await base.SimApp(new List<object> { abiHandle, numAscii }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> TestNumAsciiToUint_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 numAscii, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 174, 178, 92 };

            return await base.MakeTransactionList(new List<object> { abiHandle, numAscii }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice Test parseDatePart: numeric string → uint
        ///</summary>
        /// <param name="value"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> TestParseDatePart(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 31, 15, 253 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.SimApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> TestParseDatePart_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 31, 15, 253 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice Test substring extraction
        ///</summary>
        /// <param name="str"> </param>
        /// <param name="start"> </param>
        /// <param name="end"> </param>
        public async Task<string> TestSubstring(string str, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 224, 57, 169 };
            var strAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); strAbi.From(str);

            var result = await base.SimApp(new List<object> { abiHandle, strAbi, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> TestSubstring_Transactions(string str, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 start, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 224, 57, 169 };
            var strAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); strAbi.From(str);

            return await base.MakeTransactionList(new List<object> { abiHandle, strAbi, start, end }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice Test isLeapYear
        ///</summary>
        /// <param name="year"> </param>
        public async Task<bool> TestIsLeapYear(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 year, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 197, 85, 42 };

            var result = await base.SimApp(new List<object> { abiHandle, year }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestIsLeapYear_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 year, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 197, 85, 42 };

            return await base.MakeTransactionList(new List<object> { abiHandle, year }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice Test toTimestamp: (year, month, day) → Unix timestamp
        ///</summary>
        /// <param name="year"> </param>
        /// <param name="month"> </param>
        /// <param name="day"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> TestToTimestamp(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 year, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 month, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 day, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 60, 245, 129 };

            var result = await base.SimApp(new List<object> { abiHandle, year, month, day }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> TestToTimestamp_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 year, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 month, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 day, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 60, 245, 129 };

            return await base.MakeTransactionList(new List<object> { abiHandle, year, month, day }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice Test formatDate: YYMMDD → "DD-MM-YY"
        ///</summary>
        /// <param name="date"> </param>
        public async Task<string> TestFormatDate(string date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 133, 102, 224 };
            var dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dateAbi.From(date);

            var result = await base.SimApp(new List<object> { abiHandle, dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> TestFormatDate_Transactions(string date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 133, 102, 224 };
            var dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dateAbi.From(date);

            return await base.MakeTransactionList(new List<object> { abiHandle, dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRm9ybWF0dGVyVGVzdCIsImRlc2MiOiIgQHRpdGxlIEZvcm1hdHRlclRlc3RcbiBAbm90aWNlIFRlc3QgY29udHJhY3QgdGhhdCB3cmFwcyBGb3JtYXR0ZXIgbGlicmFyeSBmdW5jdGlvbnMgZm9yIHB1eWEtc29sIGNvbXBpbGF0aW9uIHRlc3RpbmcuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3ROdW1Bc2NpaVRvVWludCIsImRlc2MiOiJAbm90aWNlIFRlc3QgbnVtQXNjaWlUb1VpbnQ6IEFTQ0lJIGNvZGUg4oaSIGRpZ2l0IHZhbHVlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudW1Bc2NpaSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RQYXJzZURhdGVQYXJ0IiwiZGVzYyI6IkBub3RpY2UgVGVzdCBwYXJzZURhdGVQYXJ0OiBudW1lcmljIHN0cmluZyDihpIgdWludCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RTdWJzdHJpbmciLCJkZXNjIjoiQG5vdGljZSBUZXN0IHN1YnN0cmluZyBleHRyYWN0aW9uIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0ciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0SXNMZWFwWWVhciIsImRlc2MiOiJAbm90aWNlIFRlc3QgaXNMZWFwWWVhciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoieWVhciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RUb1RpbWVzdGFtcCIsImRlc2MiOiJAbm90aWNlIFRlc3QgdG9UaW1lc3RhbXA6ICh5ZWFyLCBtb250aCwgZGF5KSDihpIgVW5peCB0aW1lc3RhbXAiLCJhcmdzIjpbeyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InllYXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtb250aCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RGb3JtYXREYXRlIiwiZGVzYyI6IkBub3RpY2UgVGVzdCBmb3JtYXREYXRlOiBZWU1NREQg4oaSIFwiREQtTU0tWVlcIiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzg3MV0sImVycm9yTWVzc2FnZSI6IkludmFsaWREYXRlTGVuZ3RoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQ3LDc2Nyw5MDcsOTIzXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZERheVJhbmdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTAxLDUwNyw4NzksODk1XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZE1vbnRoUmFuZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzYsMTg1LDQ4Miw0OTFdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkWWVhclJhbmdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjgxLDY5Miw3MDAsNzA0LDcwOCw3MTIsNzE2LDcyMCw3MjQsNzI3LDczMCw3NjQsODM3XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzQsMzcwLDg1MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MiwzNzgsODU4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0OCwzODksMzk3LDQyMiw0NTAsNDYxLDQ3MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ1MTIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTcsMjk4LDgyMV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZZblZwYkdRdkxpNHZaWGhoYlhCc1pYTXZjMlZzWmw5bVpXRjBkWEpsY3k5amIyNTBjbUZqZEhNdlRURXdYMFp2Y20xaGRIUmxjbFJsYzNRdWMyOXNMa1p2Y20xaGRIUmxjbFJsYzNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURZMElEQWdPQ0F4T1Rjd0lEZzJOREF3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSWpFaUlEQjRNREVnTUhnS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE5qSmhaV0l5TldNZ01IZzRNekZtTUdabVpDQXdlRGcyWlRBek9XRTVJREI0WlRkak5UVTFNbUVnTUhnM1pqTmpaalU0TVNBd2VEVTVPRFUyTm1Vd0lDOHZJRzFsZEdodlpDQWlkR1Z6ZEU1MWJVRnpZMmxwVkc5VmFXNTBLSFZwYm5RMU1USXBkV2x1ZERVeE1pSXNJRzFsZEdodlpDQWlkR1Z6ZEZCaGNuTmxSR0YwWlZCaGNuUW9jM1J5YVc1bktYVnBiblExTVRJaUxDQnRaWFJvYjJRZ0luUmxjM1JUZFdKemRISnBibWNvYzNSeWFXNW5MSFZwYm5RMU1USXNkV2x1ZERVeE1pbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luUmxjM1JKYzB4bFlYQlpaV0Z5S0hWcGJuUTFNVElwWW05dmJDSXNJRzFsZEdodlpDQWlkR1Z6ZEZSdlZHbHRaWE4wWVcxd0tIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5S1hWcGJuUTFNVElpTENCdFpYUm9iMlFnSW5SbGMzUkdiM0p0WVhSRVlYUmxLSE4wY21sdVp5bHpkSEpwYm1jaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQjBaWE4wVG5WdFFYTmphV2xVYjFWcGJuUWdkR1Z6ZEZCaGNuTmxSR0YwWlZCaGNuUWdkR1Z6ZEZOMVluTjBjbWx1WnlCMFpYTjBTWE5NWldGd1dXVmhjaUIwWlhOMFZHOVVhVzFsYzNSaGJYQWdkR1Z6ZEVadmNtMWhkRVJoZEdVS0lDQWdJR1Z5Y2dvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWlkV2xzWkM4dUxpOWxlR0Z0Y0d4bGN5OXpaV3htWDJabFlYUjFjbVZ6TDJOdmJuUnlZV04wY3k5Tk1UQmZSbTl5YldGMGRHVnlWR1Z6ZEM1emIyd3VSbTl5YldGMGRHVnlMbk4xWW5OMGNtbHVaeWh6ZEhJNklHSjVkR1Z6TENCemRHRnlkRWx1WkdWNE9pQmllWFJsY3l3Z1pXNWtTVzVrWlhnNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1JtOXliV0YwZEdWeUxuTjFZbk4wY21sdVp6b0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaUxRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2dwR2IzSnRZWFIwWlhJdWMzVmljM1J5YVc1blgzZG9hV3hsWDNSdmNFQXhPZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWp3S0lDQWdJR0o2SUVadmNtMWhkSFJsY2k1emRXSnpkSEpwYm1kZllXWjBaWEpmZDJocGJHVkFNd29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpTFFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBeENpQWdJQ0JpS3dvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQmlJRVp2Y20xaGRIUmxjaTV6ZFdKemRISnBibWRmZDJocGJHVmZkRzl3UURFS0NrWnZjbTFoZEhSbGNpNXpkV0p6ZEhKcGJtZGZZV1owWlhKZmQyaHBiR1ZBTXpvS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWlkV2xzWkM4dUxpOWxlR0Z0Y0d4bGN5OXpaV3htWDJabFlYUjFjbVZ6TDJOdmJuUnlZV04wY3k5Tk1UQmZSbTl5YldGMGRHVnlWR1Z6ZEM1emIyd3VSbTl5YldGMGRHVnlMbWx6VEdWaGNGbGxZWElvZVdWaGNqb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tSbTl5YldGMGRHVnlMbWx6VEdWaGNGbGxZWEk2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdsdWRHTWdOQ0F2THlBeE9UY3dDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJK0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpGbGxZWEpTWVc1blpRb2dJQ0FnY0hWemFHbHVkQ0F5TVRBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0k4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkZsbFlYSlNZVzVuWlFvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOM1lYQUtJQ0FnSUdJbENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpSVQwS0lDQWdJR0o2SUVadmNtMWhkSFJsY2k1cGMweGxZWEJaWldGeVgyVnNjMlZmWW05a2VVQTFDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ3BHYjNKdFlYUjBaWEl1YVhOTVpXRndXV1ZoY2w5bGJITmxYMkp2WkhsQU5Ub0tJQ0FnSUhCMWMyaHBiblFnTVRBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE4zWVhBS0lDQWdJR0lsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1lpRTlDaUFnSUNCaWVpQkdiM0p0WVhSMFpYSXVhWE5NWldGd1dXVmhjbDlsYkhObFgySnZaSGxBTndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvS1JtOXliV0YwZEdWeUxtbHpUR1ZoY0ZsbFlYSmZaV3h6WlY5aWIyUjVRRGM2Q2lBZ0lDQndkWE5vYVc1MElEUXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemQyRndDaUFnSUNCaUpRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0loUFFvZ0lDQWdZbm9nUm05eWJXRjBkR1Z5TG1selRHVmhjRmxsWVhKZlpXeHpaVjlpYjJSNVFEa0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDa1p2Y20xaGRIUmxjaTVwYzB4bFlYQlpaV0Z5WDJWc2MyVmZZbTlrZVVBNU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlpZFdsc1pDOHVMaTlsZUdGdGNHeGxjeTl6Wld4bVgyWmxZWFIxY21WekwyTnZiblJ5WVdOMGN5OU5NVEJmUm05eWJXRjBkR1Z5VkdWemRDNXpiMnd1Um05eWJXRjBkR1Z5VkdWemRDNTBaWE4wVG5WdFFYTmphV2xVYjFWcGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFRuVnRRWE5qYVdsVWIxVnBiblE2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMU1USUtJQ0FnSUhCMWMyaHBiblFnTkRnS0lDQWdJR2wwYjJJS0lDQWdJR0l0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEWTBDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdOalFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5aWRXbHNaQzh1TGk5bGVHRnRjR3hsY3k5elpXeG1YMlpsWVhSMWNtVnpMMk52Ym5SeVlXTjBjeTlOTVRCZlJtOXliV0YwZEdWeVZHVnpkQzV6YjJ3dVJtOXliV0YwZEdWeVZHVnpkQzUwWlhOMFVHRnljMlZFWVhSbFVHRnlkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUlFZWEp6WlVSaGRHVlFZWEowT2dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCaWJub2dkR1Z6ZEZCaGNuTmxSR0YwWlZCaGNuUmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFJ2WWdvS2RHVnpkRkJoY25ObFJHRjBaVkJoY25SZllXWjBaWEpmYVc1c2FXNWxaRjh2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZZblZwYkdRdkxpNHZaWGhoYlhCc1pYTXZjMlZzWmw5bVpXRjBkWEpsY3k5amIyNTBjbUZqZEhNdlRURXdYMFp2Y20xaGRIUmxjbFJsYzNRdWMyOXNMa1p2Y20xaGRIUmxjaTV3WVhKelpVUmhkR1ZRWVhKMFFEYzZDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURZMENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z05qUUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tkR1Z6ZEZCaGNuTmxSR0YwWlZCaGNuUmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VBb2dJQ0FnWW5WeWVTQXpDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW5WeWVTQTBDZ3AwWlhOMFVHRnljMlZFWVhSbFVHRnlkRjkzYUdsc1pWOTBiM0JBTkRvS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURRS0lDQWdJR0krQ2lBZ0lDQmllaUIwWlhOMFVHRnljMlZFWVhSbFVHRnlkRjloWm5SbGNsOTNhR2xzWlVBMkNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR2RsZEdKNWRHVUtJQ0FnSUhCMWMyaHBiblFnTkRnS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTFDaUFnSUNCaUtnb2dJQ0FnWWlzS0lDQWdJR0oxY25rZ05Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXhDaUFnSUNCaUt3b2dJQ0FnWW5WeWVTQTBDaUFnSUNCaUlIUmxjM1JRWVhKelpVUmhkR1ZRWVhKMFgzZG9hV3hsWDNSdmNFQTBDZ3AwWlhOMFVHRnljMlZFWVhSbFVHRnlkRjloWm5SbGNsOTNhR2xzWlVBMk9nb2dJQ0FnWkdsbklESUtJQ0FnSUdJZ2RHVnpkRkJoY25ObFJHRjBaVkJoY25SZllXWjBaWEpmYVc1c2FXNWxaRjh2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZZblZwYkdRdkxpNHZaWGhoYlhCc1pYTXZjMlZzWmw5bVpXRjBkWEpsY3k5amIyNTBjbUZqZEhNdlRURXdYMFp2Y20xaGRIUmxjbFJsYzNRdWMyOXNMa1p2Y20xaGRIUmxjaTV3WVhKelpVUmhkR1ZRWVhKMFFEY0tDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WW5WcGJHUXZMaTR2WlhoaGJYQnNaWE12YzJWc1psOW1aV0YwZFhKbGN5OWpiMjUwY21GamRITXZUVEV3WDBadmNtMWhkSFJsY2xSbGMzUXVjMjlzTGtadmNtMWhkSFJsY2xSbGMzUXVkR1Z6ZEZOMVluTjBjbWx1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JUZFdKemRISnBibWM2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREVXhNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTlRFeUNpQWdJQ0JqWVd4c2MzVmlJRVp2Y20xaGRIUmxjaTV6ZFdKemRISnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJKMWFXeGtMeTR1TDJWNFlXMXdiR1Z6TDNObGJHWmZabVZoZEhWeVpYTXZZMjl1ZEhKaFkzUnpMMDB4TUY5R2IzSnRZWFIwWlhKVVpYTjBMbk52YkM1R2IzSnRZWFIwWlhKVVpYTjBMblJsYzNSSmMweGxZWEJaWldGeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEVselRHVmhjRmxsWVhJNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTFNVElLSUNBZ0lHTmhiR3h6ZFdJZ1JtOXliV0YwZEdWeUxtbHpUR1ZoY0ZsbFlYSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZZblZwYkdRdkxpNHZaWGhoYlhCc1pYTXZjMlZzWmw5bVpXRjBkWEpsY3k5amIyNTBjbUZqZEhNdlRURXdYMFp2Y20xaGRIUmxjbFJsYzNRdWMyOXNMa1p2Y20xaGRIUmxjbFJsYzNRdWRHVnpkRlJ2VkdsdFpYTjBZVzF3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRlJ2VkdsdFpYTjBZVzF3T2dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUEyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOVEV5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREVXhNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTJOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5URXlDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqSURRZ0x5OGdNVGszTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURJS0lDQWdJR0krQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkZsbFlYSlNZVzVuWlFvZ0lDQWdjSFZ6YUdsdWRDQXlNVEF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdJOENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpGbGxZWEpTWVc1blpRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUdJK0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpFMXZiblJvVW1GdVoyVUtJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJR2wwYjJJS0lDQWdJR0krQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkUxdmJuUm9VbUZ1WjJVS0lDQWdJR2x1ZEdNZ05DQXZMeUF4T1Rjd0NncDBaWE4wVkc5VWFXMWxjM1JoYlhCZmQyaHBiR1ZmZEc5d1FESTZDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTVDaUFnSUNCa2FXY2dOZ29nSUNBZ1lqd0tJQ0FnSUdKNklIUmxjM1JVYjFScGJXVnpkR0Z0Y0Y5aFpuUmxjbDkzYUdsc1pVQTNDaUFnSUNCa2FXY2dOd29nSUNBZ1kyRnNiSE4xWWlCR2IzSnRZWFIwWlhJdWFYTk1aV0Z3V1dWaGNnb2dJQ0FnWW5vZ2RHVnpkRlJ2VkdsdFpYTjBZVzF3WDJWc2MyVmZZbTlrZVVBMUNpQWdJQ0J3ZFhOb2FXNTBJRE14TmpJeU5EQXdDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNd29nSUNBZ1lpc0tJQ0FnSUdKMWNua2dNd29LZEdWemRGUnZWR2x0WlhOMFlXMXdYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUIwWlhOMFZHOVVhVzFsYzNSaGJYQmZkMmhwYkdWZmRHOXdRRElLQ25SbGMzUlViMVJwYldWemRHRnRjRjlsYkhObFgySnZaSGxBTlRvS0lDQWdJSEIxYzJocGJuUWdNekUxTXpZd01EQUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXpDaUFnSUNCaUt3b2dJQ0FnWW5WeWVTQXpDaUFnSUNCaUlIUmxjM1JVYjFScGJXVnpkR0Z0Y0Y5aFpuUmxjbDlwWmw5bGJITmxRRFlLQ25SbGMzUlViMVJwYldWemRHRnRjRjloWm5SbGNsOTNhR2xzWlVBM09nb2dJQ0FnY0hWemFHbHVkQ0F6TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREZtTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdKMWNua2dOd29nSUNBZ1pHbG5JRFVLSUNBZ0lHTmhiR3h6ZFdJZ1JtOXliV0YwZEdWeUxtbHpUR1ZoY0ZsbFlYSUtJQ0FnSUdKNklIUmxjM1JVYjFScGJXVnpkR0Z0Y0Y5bGJITmxYMkp2WkhsQU9Rb2dJQ0FnY0hWemFHbHVkQ0F5T1FvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURjS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJRGdnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRYSjVJRGNLQ25SbGMzUlViMVJwYldWemRHRnRjRjloWm5SbGNsOXBabDlsYkhObFFERXdPZ29nSUNBZ1pHbG5JRFlLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEpsY0d4aFkyVXlJREUySUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2NIVnphR2x1ZENBek1Bb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUhKbGNHeGhZMlV5SURJMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURJS0lDQWdJSEpsY0d4aFkyVXlJRE15SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JREVLSUNBZ0lISmxjR3hoWTJVeUlEUXdJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklESUtJQ0FnSUhKbGNHeGhZMlV5SURRNElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURJS0lDQWdJSEpsY0d4aFkyVXlJRFUySUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JREVLSUNBZ0lISmxjR3hoWTJVeUlEWTBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklESUtJQ0FnSUhKbGNHeGhZMlV5SURjeUlDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdPREFnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBNE9DQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBNENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmlQQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1JFWVhsU1lXNW5aUW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdKNlpYSnZDaUFnSUNCa2FXY2dPQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpTFFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZajRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuWmhiR2xrUkdGNVVtRnVaMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaWRYSjVJREVLQ25SbGMzUlViMVJwYldWemRHRnRjRjkzYUdsc1pWOTBiM0JBTVRFNkNpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBMUNpQWdJQ0JpUEFvZ0lDQWdZbm9nZEdWemRGUnZWR2x0WlhOMFlXMXdYMkZtZEdWeVgzZG9hV3hsUURFekNpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmthV2NnT0FvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFVnTHk4Z09EWTBNREFLSUNBZ0lDb0tJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTBDaUFnSUNCaUt3b2dJQ0FnWW5WeWVTQTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUhSbGMzUlViMVJwYldWemRHRnRjRjkzYUdsc1pWOTBiM0JBTVRFS0NuUmxjM1JVYjFScGJXVnpkR0Z0Y0Y5aFpuUmxjbDkzYUdsc1pVQXhNem9LSUNBZ0lHUnBaeUF6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZaTBLSUNBZ0lHbHVkR01nTlNBdkx5QTROalF3TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZaW9LSUNBZ0lHUnBaeUF6Q2lBZ0lDQmlLd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh4SUM4dklEWTBDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDblJsYzNSVWIxUnBiV1Z6ZEdGdGNGOWxiSE5sWDJKdlpIbEFPVG9LSUNBZ0lIQjFjMmhwYm5RZ01qZ0tJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTNDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBNElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JpSUhSbGMzUlViMVJwYldWemRHRnRjRjloWm5SbGNsOXBabDlsYkhObFFERXdDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJKMWFXeGtMeTR1TDJWNFlXMXdiR1Z6TDNObGJHWmZabVZoZEhWeVpYTXZZMjl1ZEhKaFkzUnpMMDB4TUY5R2IzSnRZWFIwWlhKVVpYTjBMbk52YkM1R2IzSnRZWFIwWlhKVVpYTjBMblJsYzNSR2IzSnRZWFJFWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEVadmNtMWhkRVJoZEdVNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnSVQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa1JHRjBaVXhsYm1kMGFBb2dJQ0FnWlhoMGNtRmpkQ0EwSURFS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpTVNJS0lDQWdJR0krQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkUxdmJuUm9VbUZ1WjJVS0lDQWdJR0o1ZEdWalh6RWdMeThnSWpFaUNpQWdJQ0E5UFFvZ0lDQWdZbm9nZEdWemRFWnZjbTFoZEVSaGRHVmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0ExSURFS0lDQWdJSEIxYzJoaWVYUmxjeUFpTWlJS0lDQWdJR0krQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkUxdmJuUm9VbUZ1WjJVS0NuUmxjM1JHYjNKdFlYUkVZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEWWdNUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqTWlDaUFnSUNCaVBnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUkVZWGxTWVc1blpRb2dJQ0FnY0hWemFHSjVkR1Z6SUNJeklnb2dJQ0FnUFQwS0lDQWdJR0o2SUhSbGMzUkdiM0p0WVhSRVlYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTnlBeENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNJeElnb2dJQ0FnWWo0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa1JHRjVVbUZ1WjJVS0NuUmxjM1JHYjNKdFlYUkVZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdSbTl5YldGMGRHVnlMbk4xWW5OMGNtbHVad29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ013b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQkdiM0p0WVhSMFpYSXVjM1ZpYzNSeWFXNW5DaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ1JtOXliV0YwZEdWeUxuTjFZbk4wY21sdVp3b2dJQ0FnY0hWemFHSjVkR1Z6SUNJdElnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlMU0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WW5WcGJHUXZMaTR2WlhoaGJYQnNaWE12YzJWc1psOW1aV0YwZFhKbGN5OWpiMjUwY21GamRITXZUVEV3WDBadmNtMWhkSFJsY2xSbGMzUXVjMjlzTGtadmNtMWhkSFJsY2xSbGMzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBR0FVQUFDTElQZ0tNRkpnUUVGUjk4ZFFFeEFRRUFNUmhBQUFJaVF6RVpGRVF4R0VTQ0JnUmlyckpjQklNZkQvMEVodUE1cVFUbnhWVXFCSDg4OVlFRVdZVm00RFlhQUk0R0FKb0F0QUVXQVVnQllBTDFBSW9EQVNXdlNZdi9pLzZoVUVrVkpRbGJyNHYraXdLTC82UkJBQzJMQWttTC9xR0xBRWxQQWxCSkZTVUpXMHhMQWxCSkZTVUpXNHY5VENKWWl3Rk9BbDJNQVNxZ2pBSkMvOHVMQVl3QWlZb0JBU0VFRm92L3BSUkVnYlFRRm92L3BCUkVnUVFXaS85TXFpUVdTVTRDcVVFQUF5Uk1pWUZrRm92L1RLcUxBS2xCQUFNaVRJbUJrQU1XaS85TXFvc0FxVUVBQXlSTWlTSk1pVFlhQVVrVkl4SkVnVEFXb1VrVkl3NUVJNityS0V4UXNDSkRKRWsyR2dGSkpGbUJBZ2hMQVJVU1JGY0NBRWtWU1VBQUVDUVdTUlVqRGtRanI2c29URkN3SWtNclJRTWtGa1VFU1JaTEJLVkJBQ1VscjBzRVNVNENVRWtWSlFsYlN3Tk1WWUV3Q1JhQkNoWkxCYU9nUlFRcW9FVUVRdi9UU3dKQy83azJHZ0ZKSkZtQkFnaExBUlVTUkZjQ0FEWWFBa2tWSXhKRU5ob0RTUlVqRWtTSS9zZEpGUlpYQmdKTVVDaE1VTEFpUXpZYUFVa1ZJeEpFaVA3OGdBRUFKRThDVkNoTVVMQWlReVJIQWpZYUFVY0NGU01TUkRZYUFrbE9Ba2tWSXhKRU5ob0RTVTRERlNNU1JDdE9BaUVFRmtzQ3BSUkVnYlFRRms4Q3BCUkVJaFpKVGdKTEFhVVVSSUVNRnFVVVJDRUVTUlpKUlFsTEJxUkJBQ2xMQjRqK21FRUFFNEdBaW9vUEZrc0RvRVVEU1NJSVJRRkMvOXFCZ09lRUR4WkxBNkJGQTBMLzZvRWZGa1VKZ0dBQUFBQUFBQUFBSHdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJGQjBzRmlQNEdRUUNjZ1IwV1N3ZE1YQWhGQjBzR1N3bEpUZ0pjRUlFZUZreExBVndZU3dKY0lFc0JYQ2hMQWx3d1N3SmNPRXNCWEVCTEFseElURnhRVEZ4WVNVVUlTd1JKVGdKTEJFbE9BcVFVUkNXdlN3aFBBcUZRU1JVbENWc2xDeVZZcFJSRUlrVUJTUlpMQmFSQkFCcEhBaUlKU3doTUpRdGJJUVVMRmtzRW9FVUVJZ2hGQVVMLzNrc0RTd0toSVFVV28wc0RvRWtWSXc1RUk2K3JLRXhRc0NKRGdSd1dTd2RNWEFoRkIwTC9ZVFlhQVVjQ0pGbUJBZ2hMQVJVU1JFbFhBZ0JKVGdJVmdRWVRGRVJYQkFGSkthVVVSQ2tTUVFBTFN3RlhCUUdBQVRLbEZFUkxBVmNHQVVtQUFUT2xGRVNBQVRNU1FRQUpTd0ZYQndFcHBSUkVKQmFCQWhaTEFrbE9BMDhDU3dLSS9LdUJCQlpMQTA4RFN3S0kvSitCQmhaUEJFOERUd0tJL0pPQUFTMVFURkNBQVMxUVRGQkpGUlpYQmdKTVVDaE1VTEFpUXc9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
