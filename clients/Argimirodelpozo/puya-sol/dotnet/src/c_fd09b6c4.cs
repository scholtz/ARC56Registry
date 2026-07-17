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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.c_fd09b6c4
{


    public class cProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public cProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task PostInit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> Set(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 101, 111, 29 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Set_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 101, 111, 29 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetLength(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 106, 42, 214 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetLength_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 106, 42, 214 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiYyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJfX3Bvc3RJbml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRMZW5ndGgiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1NTBdLCJlcnJvck1lc3NhZ2UiOiJfX3Bvc3RJbml0IGFscmVhZHkgY2FsbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM3LDE3M10sImVycm9yTWVzc2FnZSI6Im5vdCBwYXlhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZZWEp5WVhrdllubDBaWE5mYkdWdVozUm9YMjFsYldKbGNpNXpiMnd1WXk1aGNIQnliM1poYkY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREFnTVFvZ0lDQWdZbmwwWldOaWJHOWpheUFpWDE5amRHOXlYM0JsYm1ScGJtY2lJQ0prWVhSaElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z01UUUtJQ0FnSUhCMWMyaHBiblFnTkRBNU5nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnYzNSdmNtVWdOUW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdiRzloWkNBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURnd0NpQWdJQ0J5WlhCc1lXTmxNaUEyTkFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWDE5amRHOXlYM0JsYm1ScGJtY2lDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WW1Gall6UTVaVE1nTUhneU1qWTFObVl4WkNBd2VHSmpObUV5WVdRMklDOHZJRzFsZEdodlpDQWlYMTl3YjNOMFNXNXBkQ2dwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwS0NsaWIyOXNJaXdnYldWMGFHOWtJQ0puWlhSTVpXNW5kR2dvS1hWcGJuUXlOVFlpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMTlmY0c5emRFbHVhWFJmY205MWRHVkFOU0J0WVdsdVgzTmxkRjl5YjNWMFpVQTJJRzFoYVc1ZloyVjBUR1Z1WjNSb1gzSnZkWFJsUURjS0lDQWdJR1Z5Y2dvS2JXRnBibDluWlhSTVpXNW5kR2hmY205MWRHVkFOem9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRNS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRRNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbVJoZEdFaUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCd2IzQUtJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UTTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UUUtDbTFoYVc1ZmMyVjBYM0p2ZFhSbFFEWTZDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREU0Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREU1T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFk1Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0JpZFhKNUlERTFDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpNNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDRLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TlFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESTJPZ29nSUNBZ1pHbG5JREUxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ01UUUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJRDRLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5T0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESTVPZ29nSUNBZ1pHbG5JREUwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ01UTUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDRLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF6TVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFETXlPZ29nSUNBZ1pHbG5JREV6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ01USUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDRLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF6TkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFETTFPZ29nSUNBZ1pHbG5JREV5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ01URUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURVS0lDQWdJRDRLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF6TndvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFETTRPZ29nSUNBZ1pHbG5JREV4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ01UQUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJRDRLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEUXhPZ29nSUNBZ1pHbG5JREV3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ09Rb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTndvZ0lDQWdQZ29nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFF6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEzQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5EUTZDaUFnSUNCa2FXY2dPUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmlkWEo1SURnS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lENEtJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTBOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdPQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURRM09nb2dJQ0FnWkdsbklEZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1luVnllU0EzQ2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQTVDaUFnSUNBK0NpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5Ea0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEa0tDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUExTURvS0lDQWdJR1JwWnlBM0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKMWNua2dOZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUQ0S0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMU1nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01UQUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUExTXpvS0lDQWdJR1JwWnlBMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKMWNua2dOUW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ01URUtJQ0FnSUQ0S0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMU5Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01URUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUExTmpvS0lDQWdJR1JwWnlBMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKMWNua2dOQW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ01USUtJQ0FnSUQ0S0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMU9Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01USUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUExT1RvS0lDQWdJR1JwWnlBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKMWNua2dNd29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ01UTUtJQ0FnSUQ0S0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMk1Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01UTUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEyTWpvS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKMWNua2dNZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ01UUUtJQ0FnSUQ0S0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01UUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEyTlRvS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKMWNua2dNUW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ01UVUtJQ0FnSUQ0S0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMk53b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01UVUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEyT0RvS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEzTURvS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1SaGRHRWlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbVJoZEdFaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UZ3dDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyTnpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTmpnS0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTJORG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOalVLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMk1Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5qSUtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExT0RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTlRrS0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTFOVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOVFlLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMU1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5UTUtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwT1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTlRBS0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTBOam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFORGNLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME16b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5EUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTURvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTkRFS0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXpOem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNemdLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek5Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU16VUtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF6TVRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTXpJS0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlPRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNamtLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU5Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qWUtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TWpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZblZ5ZVNBeE5Rb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qTUtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyT1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTnpBS0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhPRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhPUW9LYldGcGJsOWZYM0J2YzNSSmJtbDBYM0p2ZFhSbFFEVTZDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmZYMk4wYjNKZmNHVnVaR2x1WnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWDE5d2IzTjBTVzVwZENCaGJISmxZV1I1SUdOaGJHeGxaQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlYMTlqZEc5eVgzQmxibVJwYm1jaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WVhKeVlYa3ZZbmwwWlhOZmJHVnVaM1JvWDIxbGJXSmxjaTV6YjJ3dVl5NWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQUFFbUFnNWZYMk4wYjNKZmNHVnVaR2x1WndSa1lYUmhJa2NPZ1lBZ3IwazFCVFVBTkFDQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNBWEVBMUFERVlRQUFGS0NObkkwTXhHUlJFTVJoRWdnTUV1c3hKNHdRaVpXOGRCTHhxS3RZMkdnQ09Bd0dvQUNVQUFRQXhGa0VBR3pFV0l3azRDQlJFS2IxSUZvRWdyNnVBQkJVZmZIVk1VTEFqUXlKQy8rY3hGa0VCZWpFV0l3azRDQlJFTVJ0QkFXZ3hHMEVCWERZYUFFVVBNUnNqRFVFQlN6WWFBVXNQVEZCRkRqRWJnUUlOUVFFMU5ob0NTdzVNVUVVTk1SdUJBdzFCQVI4MkdnTkxEVXhRUlF3eEc0RUVEVUVCQ1RZYUJFc01URkJGQ3pFYmdRVU5RUUR6TmhvRlN3dE1VRVVLTVJ1QkJnMUJBTjAyR2daTENreFFSUWt4RzRFSERVRUF4ellhQjBzSlRGQkZDREViZ1FnTlFRQ3hOaG9JU3doTVVFVUhNUnVCQ1ExQkFKczJHZ2xMQjB4UVJRWXhHNEVLRFVFQWhUWWFDa3NHVEZCRkJURWJnUXNOUVFCdk5ob0xTd1ZNVUVVRU1SdUJEQTFCQUZrMkdneExCRXhRUlFNeEc0RU5EVUVBUXpZYURVc0RURkJGQWpFYmdRNE5RUUF0TmhvT1N3Sk1VRVVCTVJ1QkR3MUJBQmMyR2c5TEFVeFFLYnhJS1V5L2dBVVZIM3gxZ0xBalF5S3ZRdi9uSXE5Qy85RWlyMEwvdXlLdlF2K2xJcTlDLzQ4aXIwTC9lU0t2UXY5aklxOUMvMDBpcjBML055S3ZRdjhoSXE5Qy93c2lyMEwrOVNLdlF2N2ZJcTlDL3NraXIwTCtzeUt2UlE5Qy9xSWlyMEwvbVNKQy9vZ29aRVFvSW1jalF3PT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
