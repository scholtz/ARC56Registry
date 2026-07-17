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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestOpcodeParamFromObject_b1e0d9f3
{


    public class ABITestOpcodeParamFromObjectProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestOpcodeParamFromObjectProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> OpcodeParamFromObject(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 247, 3, 51 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> OpcodeParamFromObject_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 247, 3, 51 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0T3Bjb2RlUGFyYW1Gcm9tT2JqZWN0IiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJvcGNvZGVQYXJhbUZyb21PYmplY3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDY1In0seyJwYyI6WzEsMiwzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA2NSJ9LHsicGMiOls0LDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA2NSJ9LHsicGMiOls2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwNjUifSx7InBjIjpbNyw4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwNjUifSx7InBjIjpbOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDY1In0seyJwYyI6WzEwLDExXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwNjUifSx7InBjIjpbMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA2NSJ9LHsicGMiOlsxMywxNCwxNSwxNiwxNywxOCwxOSwyMCwyMSwyMiwyMywyNCwyNSwyNiwyNywyOCwyOSwzMCwzMSwzMiwzMywzNCwzNSwzNiwzNywzOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDY1In0seyJwYyI6WzM5XSwiZXJyb3JNZXNzYWdlIjoiVGhlIHJlcXVlc3RlZCBhY3Rpb24gaXMgbm90IGltcGxlbWVudGVkIGluIHRoaXMgY29udHJhY3QuIEFyZSB5b3UgdXNpbmcgdGhlIGNvcnJlY3QgT25Db21wbGV0ZT8gRGlkIHlvdSBzZXQgeW91ciBhcHAgSUQ/IiwidGVhbCI6MjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDY1In0seyJwYyI6WzQwLDQxLDQyLDQzLDQ0LDQ1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwNjYifSx7InBjIjpbNDYsNDcsNDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA2NiJ9LHsicGMiOls0OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDY2In0seyJwYyI6WzUwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwNjYifSx7InBjIjpbNTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA2NiJ9LHsicGMiOls1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDY2In0seyJwYyI6WzUzLDU0LDU1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwNjYifSx7InBjIjpbNTYsNTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA2NiJ9LHsicGMiOls1OCw1OSw2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDY3In0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwNjcifSx7InBjIjpbNjIsNjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA2NyJ9LHsicGMiOls2NCw2NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDY5In0seyJwYyI6WzY2LDY3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwNjYifSx7InBjIjpbNjhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA2NiJ9LHsicGMiOls2OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDY1In0seyJwYyI6WzcwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwNjUifSx7InBjIjpbNzEsNzIsNzMsNzQsNzUsNzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA2NSJ9LHsicGMiOls3Nyw3OCw3OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDY1In0seyJwYyI6WzgwLDgxLDgyLDgzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwNjUifSx7InBjIjpbODRdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjo2OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwNjUifSx7InBjIjpbODUsODYsODcsODgsODksOTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA2NSJ9LHsicGMiOls5MSw5Miw5M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDY1In0seyJwYyI6Wzk0LDk1LDk2LDk3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwNjUifSx7InBjIjpbOThdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBOb09wIiwidGVhbCI6NzcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDY1In1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeENnb3ZMeUJVYUdseklGUkZRVXdnZDJGeklHZGxibVZ5WVhSbFpDQmllU0JVUlVGTVUyTnlhWEIwSUhZd0xqRXdOeTR5Q2k4dklHaDBkSEJ6T2k4dloybDBhSFZpTG1OdmJTOWhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZWRVZCVEZOamNtbHdkQW9LTHk4Z1ZHaHBjeUJqYjI1MGNtRmpkQ0JwY3lCamIyMXdiR2xoYm5RZ2QybDBhQ0JoYm1RdmIzSWdhVzF3YkdWdFpXNTBjeUIwYUdVZ1ptOXNiRzkzYVc1bklFRlNRM002SUZzZ1FWSkROQ0JkQ2dvdkx5QlVhR1VnWm05c2JHOTNhVzVuSUhSbGJpQnNhVzVsY3lCdlppQlVSVUZNSUdoaGJtUnNaU0JwYm1sMGFXRnNJSEJ5YjJkeVlXMGdabXh2ZHdvdkx5QlVhR2x6SUhCaGRIUmxjbTRnYVhNZ2RYTmxaQ0IwYnlCdFlXdGxJR2wwSUdWaGMza2dabTl5SUdGdWVXOXVaU0IwYnlCd1lYSnpaU0IwYUdVZ2MzUmhjblFnYjJZZ2RHaGxJSEJ5YjJkeVlXMGdZVzVrSUdSbGRHVnliV2x1WlNCcFppQmhJSE53WldOcFptbGpJR0ZqZEdsdmJpQnBjeUJoYkd4dmQyVmtDaTh2SUVobGNtVXNJR0ZqZEdsdmJpQnlaV1psY25NZ2RHOGdkR2hsSUU5dVEyOXRjR3hsZEdVZ2FXNGdZMjl0WW1sdVlYUnBiMjRnZDJsMGFDQjNhR1YwYUdWeUlIUm9aU0JoY0hBZ2FYTWdZbVZwYm1jZ1kzSmxZWFJsWkNCdmNpQmpZV3hzWldRS0x5OGdSWFpsY25rZ2NHOXpjMmxpYkdVZ1lXTjBhVzl1SUdadmNpQjBhR2x6SUdOdmJuUnlZV04wSUdseklISmxjSEpsYzJWdWRHVmtJR2x1SUhSb1pTQnpkMmwwWTJnZ2MzUmhkR1Z0Wlc1MENpOHZJRWxtSUhSb1pTQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvWlNCamIyNTBjbUZqZEN3Z2FYUnpJSEpsYzNCbFkzUnBkbVVnWW5KaGJtTm9JSGRwYkd3Z1ltVWdJaXBPVDFSZlNVMVFURVZOUlU1VVJVUWlJSGRvYVdOb0lHcDFjM1FnWTI5dWRHRnBibk1nSW1WeWNpSUtkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJUXB3ZFhOb2FXNTBJRFlLS2dwMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lzS2MzZHBkR05vSUNwallXeHNYMDV2VDNBZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BqY21WaGRHVmZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUUtDaXBPVDFSZlNVMVFURVZOUlU1VVJVUTZDZ2t2THlCVWFHVWdjbVZ4ZFdWemRHVmtJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdocGN5QmpiMjUwY21GamRDNGdRWEpsSUhsdmRTQjFjMmx1WnlCMGFHVWdZMjl5Y21WamRDQlBia052YlhCc1pYUmxQeUJFYVdRZ2VXOTFJSE5sZENCNWIzVnlJR0Z3Y0NCSlJEOEtDV1Z5Y2dvS0x5OGdiM0JqYjJSbFVHRnlZVzFHY205dFQySnFaV04wS0NsaFpHUnlaWE56Q2lwaFltbGZjbTkxZEdWZmIzQmpiMlJsVUdGeVlXMUdjbTl0VDJKcVpXTjBPZ29KTHk4Z1ZHaGxJRUZDU1NCeVpYUjFjbTRnY0hKbFptbDRDZ2x3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvS0NTOHZJR1Y0WldOMWRHVWdiM0JqYjJSbFVHRnlZVzFHY205dFQySnFaV04wS0NsaFpHUnlaWE56Q2dsallXeHNjM1ZpSUc5d1kyOWtaVkJoY21GdFJuSnZiVTlpYW1WamRBb0pZMjl1WTJGMENnbHNiMmNLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJRzl3WTI5a1pWQmhjbUZ0Um5KdmJVOWlhbVZqZENncE9pQkJaR1J5WlhOekNtOXdZMjlrWlZCaGNtRnRSbkp2YlU5aWFtVmpkRG9LQ1hCeWIzUnZJREFnTVFvS0NTOHZJRkIxYzJnZ1pXMXdkSGtnWW5sMFpYTWdZV1owWlhJZ2RHaGxJR1p5WVcxbElIQnZhVzUwWlhJZ2RHOGdjbVZ6WlhKMlpTQnpjR0ZqWlNCbWIzSWdiRzlqWVd3Z2RtRnlhV0ZpYkdWekNnbHdkWE5vWW5sMFpYTWdNSGdLQ2drdkx5QjBaWE4wY3k5amIyNTBjbUZqZEhNdllXSnBMbUZzWjI4dWRITTZNVEEyTndvSkx5OGdZVG9nZXlCdGVVRndjRG9nUVhCd1NVUWdmU0E5SUhzZ2JYbEJjSEE2SUhSb2FYTXVZWEJ3SUgwS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1eklEQUtDV2wwYjJJS0NXWnlZVzFsWDJKMWNua2dNQ0F2THlCaE9pQjdJRzE1UVhCd09pQkJjSEJKUkNCOUNnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMkZpYVM1aGJHZHZMblJ6T2pFd05qa0tDUzh2SUhKbGRIVnliaUIwYUdsekxtRndjQzVoWkdSeVpYTnpPd29KWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtDZ2t2THlCelpYUWdkR2hsSUhOMVluSnZkWFJwYm1VZ2NtVjBkWEp1SUhaaGJIVmxDZ2xtY21GdFpWOWlkWEo1SURBS0NYSmxkSE4xWWdvS0ttRmlhVjl5YjNWMFpWOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJqb0tDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUjFjbTRLQ2lwamNtVmhkR1ZmVG05UGNEb0tDWEIxYzJoaWVYUmxjeUF3ZUdJNE5EUTNZak0ySUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b0tYWnZhV1FpQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDZ2x0WVhSamFDQXFZV0pwWDNKdmRYUmxYMk55WldGMFpVRndjR3hwWTJGMGFXOXVDZ29KTHk4Z2RHaHBjeUJqYjI1MGNtRmpkQ0JrYjJWeklHNXZkQ0JwYlhCc1pXMWxiblFnZEdobElHZHBkbVZ1SUVGQ1NTQnRaWFJvYjJRZ1ptOXlJR055WldGMFpTQk9iMDl3Q2dsbGNuSUtDaXBqWVd4c1gwNXZUM0E2Q2dsd2RYTm9ZbmwwWlhNZ01IZzNPV1kzTURNek15QXZMeUJ0WlhSb2IyUWdJbTl3WTI5a1pWQmhjbUZ0Um5KdmJVOWlhbVZqZENncFlXUmtjbVZ6Y3lJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmYjNCamIyUmxVR0Z5WVcxR2NtOXRUMkpxWldOMENnb0pMeThnZEdocGN5QmpiMjUwY21GamRDQmtiMlZ6SUc1dmRDQnBiWEJzWlcxbGJuUWdkR2hsSUdkcGRtVnVJRUZDU1NCdFpYUm9iMlFnWm05eUlHTmhiR3dnVG05UGNBb0paWEp5IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFCQVRFWUZJRUdDekVaQ0kwTUFDNEFBQUFBQUFBQUFBQUFBQ0FBQUFBQUFBQUFBQUFBQUlBRUZSOThkWWdBQkZDd0lrT0tBQUdBQURZeUFCYU1BRElLakFDSklrT0FCTGhFZXpZMkdnQ09BZi94QUlBRWVmY0RNellhQUk0Qi84WUEiLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
