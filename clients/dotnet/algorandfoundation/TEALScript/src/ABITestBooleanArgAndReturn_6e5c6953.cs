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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestBooleanArgAndReturn_6e5c6953
{


    public class ABITestBooleanArgAndReturnProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestBooleanArgAndReturnProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<bool> BooleanArgAndReturn(bool a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 208, 229, 46 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BooleanArgAndReturn_Transactions(bool a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 208, 229, 46 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0Qm9vbGVhbkFyZ0FuZFJldHVybiIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiYm9vbGVhbkFyZ0FuZFJldHVybiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3MSJ9LHsicGMiOlsxLDIsMyw0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODcxIn0seyJwYyI6WzUsNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzEifSx7InBjIjpbN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzEifSx7InBjIjpbOCw5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3MSJ9LHsicGMiOlsxMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzEifSx7InBjIjpbMTEsMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODcxIn0seyJwYyI6WzEzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3MSJ9LHsicGMiOlsxNCwxNSwxNiwxNywxOCwxOSwyMCwyMSwyMiwyMywyNCwyNSwyNiwyNywyOCwyOSwzMCwzMSwzMiwzMywzNCwzNSwzNiwzNywzOCwzOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzEifSx7InBjIjpbNDBdLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3MSJ9LHsicGMiOls0MSw0Miw0Myw0NCw0NSw0Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzIifSx7InBjIjpbNDcsNDgsNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODcyIn0seyJwYyI6WzUwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3MiJ9LHsicGMiOls1MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzIifSx7InBjIjpbNTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODcyIn0seyJwYyI6WzUzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3MiJ9LHsicGMiOls1NF0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGEpIGZvciBib29sZWFuQXJnQW5kUmV0dXJuIG11c3QgYmUgYSBib29sIiwidGVhbCI6MzksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzIifSx7InBjIjpbNTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODcyIn0seyJwYyI6WzU2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3MiJ9LHsicGMiOls1Nyw1OCw1OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzIifSx7InBjIjpbNjAsNjEsNjJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODcyIn0seyJwYyI6WzYzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3MiJ9LHsicGMiOls2NCw2NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzIifSx7InBjIjpbNjZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODcyIn0seyJwYyI6WzY3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3MiJ9LHsicGMiOls2OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzIifSx7InBjIjpbNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODcyIn0seyJwYyI6WzcwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3MiJ9LHsicGMiOls3MSw3Miw3M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzIifSx7InBjIjpbNzQsNzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODczIn0seyJwYyI6Wzc2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3MiJ9LHsicGMiOls3N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzEifSx7InBjIjpbNzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODcxIn0seyJwYyI6Wzc5LDgwLDgxLDgyLDgzLDg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3MSJ9LHsicGMiOls4NSw4Niw4N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzEifSx7InBjIjpbODgsODksOTAsOTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODcxIn0seyJwYyI6WzkyXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6NzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzEifSx7InBjIjpbOTMsOTQsOTUsOTYsOTcsOThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODcxIn0seyJwYyI6Wzk5LDEwMCwxMDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODcxIn0seyJwYyI6WzEwMiwxMDMsMTA0LDEwNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzEifSx7InBjIjpbMTA2XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjgxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODcxIn1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeElEQUtDaTh2SUZSb2FYTWdWRVZCVENCM1lYTWdaMlZ1WlhKaGRHVmtJR0o1SUZSRlFVeFRZM0pwY0hRZ2RqQXVNVEEzTGpJS0x5OGdhSFIwY0hNNkx5OW5hWFJvZFdJdVkyOXRMMkZzWjI5eVlXNWtabTkxYm1SaGRHbHZiaTlVUlVGTVUyTnlhWEIwQ2dvdkx5QlVhR2x6SUdOdmJuUnlZV04wSUdseklHTnZiWEJzYVdGdWRDQjNhWFJvSUdGdVpDOXZjaUJwYlhCc1pXMWxiblJ6SUhSb1pTQm1iMnhzYjNkcGJtY2dRVkpEY3pvZ1d5QkJVa00wSUYwS0NpOHZJRlJvWlNCbWIyeHNiM2RwYm1jZ2RHVnVJR3hwYm1WeklHOW1JRlJGUVV3Z2FHRnVaR3hsSUdsdWFYUnBZV3dnY0hKdlozSmhiU0JtYkc5M0NpOHZJRlJvYVhNZ2NHRjBkR1Z5YmlCcGN5QjFjMlZrSUhSdklHMWhhMlVnYVhRZ1pXRnplU0JtYjNJZ1lXNTViMjVsSUhSdklIQmhjbk5sSUhSb1pTQnpkR0Z5ZENCdlppQjBhR1VnY0hKdlozSmhiU0JoYm1RZ1pHVjBaWEp0YVc1bElHbG1JR0VnYzNCbFkybG1hV01nWVdOMGFXOXVJR2x6SUdGc2JHOTNaV1FLTHk4Z1NHVnlaU3dnWVdOMGFXOXVJSEpsWm1WeWN5QjBieUIwYUdVZ1QyNURiMjF3YkdWMFpTQnBiaUJqYjIxaWFXNWhkR2x2YmlCM2FYUm9JSGRvWlhSb1pYSWdkR2hsSUdGd2NDQnBjeUJpWldsdVp5QmpjbVZoZEdWa0lHOXlJR05oYkd4bFpBb3ZMeUJGZG1WeWVTQndiM056YVdKc1pTQmhZM1JwYjI0Z1ptOXlJSFJvYVhNZ1kyOXVkSEpoWTNRZ2FYTWdjbVZ3Y21WelpXNTBaV1FnYVc0Z2RHaGxJSE4zYVhSamFDQnpkR0YwWlcxbGJuUUtMeThnU1dZZ2RHaGxJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdobElHTnZiblJ5WVdOMExDQnBkSE1nY21WemNHVmpkR2wyWlNCaWNtRnVZMmdnZDJsc2JDQmlaU0FpS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0lnZDJocFkyZ2dhblZ6ZENCamIyNTBZV2x1Y3lBaVpYSnlJZ3AwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9oQ25CMWMyaHBiblFnTmdvcUNuUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0t3cHpkMmwwWTJnZ0ttTmhiR3hmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS21OeVpXRjBaVjlPYjA5d0lDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQW9LS2s1UFZGOUpUVkJNUlUxRlRsUkZSRG9LQ1M4dklGUm9aU0J5WlhGMVpYTjBaV1FnWVdOMGFXOXVJR2x6SUc1dmRDQnBiWEJzWlcxbGJuUmxaQ0JwYmlCMGFHbHpJR052Ym5SeVlXTjBMaUJCY21VZ2VXOTFJSFZ6YVc1bklIUm9aU0JqYjNKeVpXTjBJRTl1UTI5dGNHeGxkR1UvSUVScFpDQjViM1VnYzJWMElIbHZkWElnWVhCd0lFbEVQd29KWlhKeUNnb3ZMeUJpYjI5c1pXRnVRWEpuUVc1a1VtVjBkWEp1S0dKdmIyd3BZbTl2YkFvcVlXSnBYM0p2ZFhSbFgySnZiMnhsWVc1QmNtZEJibVJTWlhSMWNtNDZDZ2t2THlCVWFHVWdRVUpKSUhKbGRIVnliaUJ3Y21WbWFYZ0tDWEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2dvSkx5OGdZVG9nWW05dmJBb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvSlpIVndDZ2xzWlc0S0NXbHVkR01nTUNBdkx5QXhDZ2s5UFFvS0NTOHZJR0Z5WjNWdFpXNTBJREFnS0dFcElHWnZjaUJpYjI5c1pXRnVRWEpuUVc1a1VtVjBkWEp1SUcxMWMzUWdZbVVnWVNCaWIyOXNDZ2xoYzNObGNuUUtDV2x1ZEdNZ01TQXZMeUF3Q2dsblpYUmlhWFFLQ2drdkx5QmxlR1ZqZFhSbElHSnZiMnhsWVc1QmNtZEJibVJTWlhSMWNtNG9ZbTl2YkNsaWIyOXNDZ2xqWVd4c2MzVmlJR0p2YjJ4bFlXNUJjbWRCYm1SU1pYUjFjbTRLQ1hCMWMyaGllWFJsY3lBd2VEQXdDZ2xwYm5SaklERWdMeThnTUFvSmRXNWpiM1psY2lBeUNnbHpaWFJpYVhRS0NXTnZibU5oZEFvSmJHOW5DZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QmliMjlzWldGdVFYSm5RVzVrVW1WMGRYSnVLR0U2SUdKdmIyeGxZVzRwT2lCaWIyOXNaV0Z1Q21KdmIyeGxZVzVCY21kQmJtUlNaWFIxY200NkNnbHdjbTkwYnlBeElERUtDZ2t2THlCMFpYTjBjeTlqYjI1MGNtRmpkSE12WVdKcExtRnNaMjh1ZEhNNk9EY3pDZ2t2THlCeVpYUjFjbTRnWVRzS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaE9pQmliMjlzWldGdUNnbHlaWFJ6ZFdJS0NpcGhZbWxmY205MWRHVmZZM0psWVhSbFFYQndiR2xqWVhScGIyNDZDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvcVkzSmxZWFJsWDA1dlQzQTZDZ2x3ZFhOb1lubDBaWE1nTUhoaU9EUTBOMkl6TmlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrSWdvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9KYldGMFkyZ2dLbUZpYVY5eWIzVjBaVjlqY21WaGRHVkJjSEJzYVdOaGRHbHZiZ29LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqY21WaGRHVWdUbTlQY0FvSlpYSnlDZ29xWTJGc2JGOU9iMDl3T2dvSmNIVnphR0o1ZEdWeklEQjRaalJrTUdVMU1tVWdMeThnYldWMGFHOWtJQ0ppYjI5c1pXRnVRWEpuUVc1a1VtVjBkWEp1S0dKdmIyd3BZbTl2YkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWW05dmJHVmhia0Z5WjBGdVpGSmxkSFZ5YmdvS0NTOHZJSFJvYVhNZ1kyOXVkSEpoWTNRZ1pHOWxjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MElIUm9aU0JuYVhabGJpQkJRa2tnYldWMGFHOWtJR1p2Y2lCallXeHNJRTV2VDNBS0NXVnljZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBeEdCU0JCZ3N4R1FpTkRBQTFBQUFBQUFBQUFBQUFBQUFuQUFBQUFBQUFBQUFBQUFDQUJCVWZmSFUyR2dGSkZTSVNSQ05UaUFBTGdBRUFJMDhDVkZDd0lrT0tBUUdMLzRraVE0QUV1RVI3TmpZYUFJNEIvL0VBZ0FUMDBPVXVOaG9BamdIL3Z3QT0iLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
