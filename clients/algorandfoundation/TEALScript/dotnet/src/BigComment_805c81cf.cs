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

namespace Arc56.Generated.algorandfoundation.TEALScript.BigComment_805c81cf
{


    public class BigCommentProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BigCommentProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> LoremIpsum(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 22, 47, 172 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> LoremIpsum_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 22, 47, 172 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJCaWdDb21tZW50IiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJsb3JlbUlwc3VtIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaWdfY29tbWVudC5hbGdvLnRzOjMifSx7InBjIjpbMSwyLDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaWdfY29tbWVudC5hbGdvLnRzOjMifSx7InBjIjpbMzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmlnX2NvbW1lbnQuYWxnby50czozIn0seyJwYyI6WzQwLDQxLDQyLDQzLDQ0LDQ1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpZ19jb21tZW50LmFsZ28udHM6MyJ9LHsicGMiOls0Niw0Nyw0OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaWdfY29tbWVudC5hbGdvLnRzOjMifSx7InBjIjpbNTIsNTMsNTRdLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpZ19jb21tZW50LmFsZ28udHM6MyJ9LHsicGMiOls1OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaWdfY29tbWVudC5hbGdvLnRzOjYifSx7InBjIjpbNjEsNjIsNjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmlnX2NvbW1lbnQuYWxnby50czo2In0seyJwYyI6WzY0LDY1LDY2LDY3LDY4LDY5LDcwLDcxLDcyLDczLDc0LDc1LDc2LDc3LDc4LDc5LDgwLDgxLDgyLDgzLDg0LDg1LDg2LDg3LDg4LDg5LDkwLDkxLDkyLDkzLDk0LDk1LDk2LDk3LDk4LDk5LDEwMCwxMDEsMTAyLDEwMywxMDQsMTA1LDEwNiwxMDcsMTA4LDEwOSwxMTAsMTExLDExMiwxMTMsMTE0LDExNSwxMTYsMTE3LDExOCwxMTksMTIwLDEyMSwxMjIsMTIzLDEyNCwxMjUsMTI2LDEyNywxMjgsMTI5LDEzMCwxMzEsMTMyLDEzMywxMzQsMTM1LDEzNiwxMzcsMTM4LDEzOSwxNDAsMTQxLDE0MiwxNDMsMTQ0LDE0NSwxNDYsMTQ3LDE0OCwxNDksMTUwLDE1MSwxNTIsMTUzLDE1NCwxNTUsMTU2LDE1NywxNTgsMTU5LDE2MCwxNjEsMTYyLDE2MywxNjQsMTY1LDE2NiwxNjcsMTY4LDE2OSwxNzAsMTcxLDE3MiwxNzMsMTc0LDE3NSwxNzYsMTc3LDE3OCwxNzksMTgwLDE4MSwxODIsMTgzLDE4NCwxODUsMTg2LDE4NywxODgsMTg5LDE5MCwxOTEsMTkyLDE5MywxOTQsMTk1LDE5NiwxOTcsMTk4LDE5OSwyMDAsMjAxLDIwMiwyMDMsMjA0LDIwNSwyMDYsMjA3LDIwOCwyMDksMjEwLDIxMSwyMTIsMjEzLDIxNCwyMTUsMjE2LDIxNywyMTgsMjE5LDIyMCwyMjEsMjIyLDIyMywyMjQsMjI1LDIyNiwyMjcsMjI4LDIyOSwyMzAsMjMxLDIzMiwyMzMsMjM0LDIzNSwyMzYsMjM3LDIzOCwyMzksMjQwLDI0MSwyNDIsMjQzLDI0NCwyNDUsMjQ2LDI0NywyNDgsMjQ5LDI1MCwyNTEsMjUyLDI1MywyNTQsMjU1LDI1NiwyNTcsMjU4LDI1OSwyNjAsMjYxLDI2MiwyNjMsMjY0LDI2NSwyNjYsMjY3LDI2OCwyNjksMjcwLDI3MSwyNzIsMjczLDI3NCwyNzUsMjc2LDI3NywyNzgsMjc5LDI4MCwyODEsMjgyLDI4MywyODQsMjg1LDI4NiwyODcsMjg4LDI4OSwyOTAsMjkxLDI5MiwyOTMsMjk0LDI5NSwyOTYsMjk3LDI5OCwyOTksMzAwLDMwMSwzMDIsMzAzLDMwNCwzMDUsMzA2LDMwNywzMDgsMzA5LDMxMCwzMTEsMzEyLDMxMywzMTQsMzE1LDMxNiwzMTcsMzE4LDMxOSwzMjAsMzIxLDMyMiwzMjMsMzI0LDMyNSwzMjYsMzI3LDMyOCwzMjksMzMwLDMzMSwzMzIsMzMzLDMzNCwzMzUsMzM2LDMzNywzMzgsMzM5LDM0MCwzNDEsMzQyLDM0MywzNDQsMzQ1LDM0NiwzNDcsMzQ4LDM0OSwzNTAsMzUxLDM1MiwzNTMsMzU0LDM1NSwzNTYsMzU3LDM1OCwzNTksMzYwLDM2MSwzNjIsMzYzLDM2NCwzNjUsMzY2LDM2NywzNjgsMzY5LDM3MCwzNzEsMzcyLDM3MywzNzQsMzc1LDM3NiwzNzcsMzc4LDM3OSwzODAsMzgxLDM4MiwzODMsMzg0LDM4NSwzODYsMzg3LDM4OCwzODksMzkwLDM5MSwzOTIsMzkzLDM5NCwzOTUsMzk2LDM5NywzOTgsMzk5LDQwMCw0MDEsNDAyLDQwMyw0MDQsNDA1LDQwNiw0MDcsNDA4LDQwOSw0MTAsNDExLDQxMiw0MTMsNDE0LDQxNSw0MTYsNDE3LDQxOCw0MTksNDIwLDQyMSw0MjIsNDIzLDQyNCw0MjUsNDI2LDQyNyw0MjgsNDI5LDQzMCw0MzEsNDMyLDQzMyw0MzQsNDM1LDQzNiw0MzcsNDM4LDQzOSw0NDAsNDQxLDQ0Miw0NDMsNDQ0LDQ0NSw0NDYsNDQ3LDQ0OCw0NDksNDUwLDQ1MSw0NTIsNDUzLDQ1NCw0NTUsNDU2LDQ1Nyw0NTgsNDU5LDQ2MCw0NjEsNDYyLDQ2Myw0NjQsNDY1LDQ2Niw0NjcsNDY4LDQ2OSw0NzAsNDcxLDQ3Miw0NzMsNDc0LDQ3NSw0NzYsNDc3LDQ3OCw0NzksNDgwLDQ4MSw0ODIsNDgzLDQ4NCw0ODUsNDg2LDQ4Nyw0ODgsNDg5LDQ5MCw0OTEsNDkyLDQ5Myw0OTQsNDk1LDQ5Niw0OTcsNDk4LDQ5OSw1MDAsNTAxLDUwMiw1MDMsNTA0LDUwNSw1MDYsNTA3LDUwOCw1MDksNTEwLDUxMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaWdfY29tbWVudC5hbGdvLnRzOjYifSx7InBjIjpbNTEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpZ19jb21tZW50LmFsZ28udHM6NiJ9LHsicGMiOls1MTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmlnX2NvbW1lbnQuYWxnby50czo2In0seyJwYyI6WzUxNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaWdfY29tbWVudC5hbGdvLnRzOjYifV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDbWx1ZEdOaWJHOWpheUF4Q2dvS0NuUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpRUtjSFZ6YUdsdWRDQTJDaW9LZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29yQ25OM2FYUmphQ0FxWTJGc2JGOU9iMDl3SUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFZM0psWVhSbFgwNXZUM0FnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUNnb3FUazlVWDBsTlVFeEZUVVZPVkVWRU9nb0paWEp5Q2dvcVlXSnBYM0p2ZFhSbFgyeHZjbVZ0U1hCemRXMDZDZ2x3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvS0NXTmhiR3h6ZFdJZ2JHOXlaVzFKY0hOMWJRb0paSFZ3Q2dsc1pXNEtDV2wwYjJJS0NXVjRkSEpoWTNRZ05pQXlDZ2x6ZDJGd0NnbGpiMjVqWVhRS0NXTnZibU5oZEFvSmJHOW5DZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dwc2IzSmxiVWx3YzNWdE9nb0pjSEp2ZEc4Z01DQXhDZ29KY0hWemFHSjVkR1Z6SURCNE5HTTJaamN5TmpVMlpESXdOamszTURjek56VTJaREl3TmpRMlpqWmpObVkzTWpJd056TTJPVGMwTWpBMk1UWmtOalUzTkRKak1qQTJNelptTm1VM016WTFOak0zTkRZMU56UTNOVGN5TWpBMk1UWTBOamszTURZNU56TTJNelk1Tm1VMk56SXdOalUyWXpZNU56UXlZekl3TnpNMk5UWTBNakEyTkRabU1qQTJOVFk1TnpVM016WmtObVkyTkRJd056UTJOVFprTnpBMlpqY3lNakEyT1RabE5qTTJPVFkwTmprMk5EYzFObVUzTkRJd056VTNOREl3Tm1NMk1UWXlObVkzTWpZMU1qQTJOVGMwTWpBMk5EWm1ObU0yWmpjeU5qVXlNRFprTmpFMk56WmxOakV5TURZeE5tTTJPVGN4TnpVMk1USmxNakExTlRjME1qQTJOVFpsTmprMlpESXdOakUyTkRJd05tUTJPVFpsTmprMlpESXdOelkyTlRabE5qazJNVFprTW1NeU1EY3hOelUyT1Rjek1qQTJaVFptTnpNM05EY3lOelUyTkRJd05qVTNPRFkxTnpJMk16WTVOelEyTVRjME5qazJaalpsTWpBM05UWmpObU0yTVRaa05qTTJaakl3Tm1NMk1UWXlObVkzTWpZNU56TXlNRFpsTmprM016WTVNakEzTlRjME1qQTJNVFpqTmprM01UYzFOamszTURJd05qVTNPREl3TmpVMk1USXdOak0yWmpaa05tUTJaalkwTm1ZeU1EWXpObVkyWlRjek5qVTNNVGMxTmpFM05ESmxNakEwTkRjMU5qazNNekl3TmpFM05UYzBOalV5TURZNU56STNOVGN5TmpVeU1EWTBObVkyWXpabU56SXlNRFk1Tm1VeU1EY3lOalUzTURjeU5qVTJPRFkxTm1VMk5EWTFOekkyT1RjME1qQTJPVFpsTWpBM05qWm1ObU0zTlRjd056UTJNVGMwTmpVeU1EYzJOalUyWXpZNU56UXlNRFkxTnpNM016WTFNakEyTXpZNU5tTTJZemMxTm1ReU1EWTBObVkyWXpabU56STJOVEl3TmpVM05USXdOalkzTlRZM05qazJNVGMwTWpBMlpUYzFObU0yWXpZeE1qQTNNRFl4TnpJMk9UWXhOelEzTlRjeU1tVXlNRFExTnpnMk16WTFOekEzTkRZMU56VTNNakl3TnpNMk9UWmxOelF5TURabU5qTTJNell4TmpVMk16WXhOelF5TURZek56VTNNRFk1TmpRMk1UYzBOakUzTkRJd05tVTJaalpsTWpBM01EY3lObVkyT1RZME5qVTJaVGMwTW1NeU1EY3pOelUyWlRjME1qQTJPVFpsTWpBMk16YzFObU0zTURZeE1qQTNNVGMxTmpreU1EWm1OalkyTmpZNU5qTTJPVFl4TWpBMk5EWTFOek0yTlRjeU56VTJaVGMwTWpBMlpEWm1ObU0yWXpZNU56UXlNRFl4Tm1VMk9UWmtNakEyT1RZME1qQTJOVGN6TnpReU1EWmpOakUyTWpabU56STNOVFprTW1VZ0x5OGdJa3h2Y21WdElHbHdjM1Z0SUdSdmJHOXlJSE5wZENCaGJXVjBMQ0JqYjI1elpXTjBaWFIxY2lCaFpHbHdhWE5qYVc1bklHVnNhWFFzSUhObFpDQmtieUJsYVhWemJXOWtJSFJsYlhCdmNpQnBibU5wWkdsa2RXNTBJSFYwSUd4aFltOXlaU0JsZENCa2IyeHZjbVVnYldGbmJtRWdZV3hwY1hWaExpQlZkQ0JsYm1sdElHRmtJRzFwYm1sdElIWmxibWxoYlN3Z2NYVnBjeUJ1YjNOMGNuVmtJR1Y0WlhKamFYUmhkR2x2YmlCMWJHeGhiV052SUd4aFltOXlhWE1nYm1semFTQjFkQ0JoYkdseGRXbHdJR1Y0SUdWaElHTnZiVzF2Wkc4Z1kyOXVjMlZ4ZFdGMExpQkVkV2x6SUdGMWRHVWdhWEoxY21VZ1pHOXNiM0lnYVc0Z2NtVndjbVZvWlc1a1pYSnBkQ0JwYmlCMmIyeDFjSFJoZEdVZ2RtVnNhWFFnWlhOelpTQmphV3hzZFcwZ1pHOXNiM0psSUdWMUlHWjFaMmxoZENCdWRXeHNZU0J3WVhKcFlYUjFjaTRnUlhoalpYQjBaWFZ5SUhOcGJuUWdiMk5qWVdWallYUWdZM1Z3YVdSaGRHRjBJRzV2YmlCd2NtOXBaR1Z1ZEN3Z2MzVnVkQ0JwYmlCamRXeHdZU0J4ZFdrZ2IyWm1hV05wWVNCa1pYTmxjblZ1ZENCdGIyeHNhWFFnWVc1cGJTQnBaQ0JsYzNRZ2JHRmliM0oxYlM0aUNnbHlaWFJ6ZFdJS0NpcGhZbWxmY205MWRHVmZZM0psWVhSbFFYQndiR2xqWVhScGIyNDZDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvcVkzSmxZWFJsWDA1dlQzQTZDZ2x3ZFhOb1lubDBaWE1nTUhoaU9EUTBOMkl6TmlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrSWdvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9KYldGMFkyZ2dLbUZpYVY5eWIzVjBaVjlqY21WaGRHVkJjSEJzYVdOaGRHbHZiZ29LQ1dWeWNnb0tLbU5oYkd4ZlRtOVBjRG9LQ1hCMWMyaGllWFJsY3lBd2VEZ3hNVFl5Wm1GaklDOHZJRzFsZEdodlpDQWliRzl5WlcxSmNITjFiU2dwYzNSeWFXNW5JZ29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb0piV0YwWTJnZ0ttRmlhVjl5YjNWMFpWOXNiM0psYlVsd2MzVnRDZ29KWlhKeSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQkFURVlGSUVHQ3pFWkNJME1BZW9BQUFBQUFBQUFBQUFBQWR3QUFBQUFBQUFBQUFBQUFJQUVGUjk4ZFlnQURFa1ZGbGNHQWt4UVVMQWlRNG9BQVlDOUEweHZjbVZ0SUdsd2MzVnRJR1J2Ykc5eUlITnBkQ0JoYldWMExDQmpiMjV6WldOMFpYUjFjaUJoWkdsd2FYTmphVzVuSUdWc2FYUXNJSE5sWkNCa2J5QmxhWFZ6Ylc5a0lIUmxiWEJ2Y2lCcGJtTnBaR2xrZFc1MElIVjBJR3hoWW05eVpTQmxkQ0JrYjJ4dmNtVWdiV0ZuYm1FZ1lXeHBjWFZoTGlCVmRDQmxibWx0SUdGa0lHMXBibWx0SUhabGJtbGhiU3dnY1hWcGN5QnViM04wY25Wa0lHVjRaWEpqYVhSaGRHbHZiaUIxYkd4aGJXTnZJR3hoWW05eWFYTWdibWx6YVNCMWRDQmhiR2x4ZFdsd0lHVjRJR1ZoSUdOdmJXMXZaRzhnWTI5dWMyVnhkV0YwTGlCRWRXbHpJR0YxZEdVZ2FYSjFjbVVnWkc5c2IzSWdhVzRnY21Wd2NtVm9aVzVrWlhKcGRDQnBiaUIyYjJ4MWNIUmhkR1VnZG1Wc2FYUWdaWE56WlNCamFXeHNkVzBnWkc5c2IzSmxJR1YxSUdaMVoybGhkQ0J1ZFd4c1lTQndZWEpwWVhSMWNpNGdSWGhqWlhCMFpYVnlJSE5wYm5RZ2IyTmpZV1ZqWVhRZ1kzVndhV1JoZEdGMElHNXZiaUJ3Y205cFpHVnVkQ3dnYzNWdWRDQnBiaUJqZFd4d1lTQnhkV2tnYjJabWFXTnBZU0JrWlhObGNuVnVkQ0J0YjJ4c2FYUWdZVzVwYlNCcFpDQmxjM1FnYkdGaWIzSjFiUzZKSWtPQUJMaEVlelkyR2dDT0FmL3hBSUFFZ1JZdnJEWWFBSTRCL2dvQSIsImNsZWFyIjoiQ3c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiN2I2MDdjZTQifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
