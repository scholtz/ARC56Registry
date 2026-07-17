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

namespace Arc56.Generated.aorumbayev.puya.Greeter_68bdcff6
{


    public class GreeterProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GreeterProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Bootstrap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 107, 98, 145 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 107, 98, 145 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task LogGreetings(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 251, 93, 72 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogGreetings_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 251, 93, 72 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3JlZXRlciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJib290c3RyYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2dfZ3JlZXRpbmdzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNThdLCJlcnJvck1lc3NhZ2UiOiJBUkM0IHByZWZpeCBpcyB2YWxpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyLDc3XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA3XSwiZXJyb3JNZXNzYWdlIjoiYWxyZWFkeSBib290c3RyYXBwZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1LDgwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNSwyMTksMjI4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5oZWxsb19hcHAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1sdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k1ak1tTXVSM0psWlhSbGNpNWZYMkZzWjI5d2VWOWxiblJ5ZVhCdmFXNTBYM2RwZEdoZmFXNXBkQ2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTmdvZ0lDQWdZbmwwWldOaWJHOWpheUFpYUdWc2JHOWZZWEJ3SWlBd2VERTFNV1kzWXpjMUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WXpKakxuQjVPamdLSUNBZ0lDOHZJSE5sYkdZdWFHVnNiRzlmWVhCd0lEMGdRWEJ3YkdsallYUnBiMjRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYUdWc2JHOWZZWEJ3SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklHbHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWpNbU11Y0hrNk5nb2dJQ0FnTHk4Z1kyeGhjM01nUjNKbFpYUmxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFEY0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzNPRFppTmpJNU1TQXdlRE16Wm1JMVpEUTRJQzh2SUcxbGRHaHZaQ0FpWW05dmRITjBjbUZ3S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW14dloxOW5jbVZsZEdsdVozTW9jM1J5YVc1bktYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMkp2YjNSemRISmhjRjl5YjNWMFpVQTFJRzFoYVc1ZmJHOW5YMmR5WldWMGFXNW5jMTl5YjNWMFpVQTJDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT1RvS0lDQWdJQzh2SUdsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5ak1tTXVjSGs2TmdvZ0lDQWdMeThnWTJ4aGMzTWdSM0psWlhSbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlzYjJkZlozSmxaWFJwYm1kelgzSnZkWFJsUURZNkNpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5Ndll6SmpMbkI1T2pJekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WXpKakxuQjVPallLSUNBZ0lDOHZJR05zWVhOeklFZHlaV1YwWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJR2x1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqTW1NdWNIazZNak1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUd4dloxOW5jbVZsZEdsdVozTUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltOXZkSE4wY21Gd1gzSnZkWFJsUURVNkNpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5Ndll6SmpMbkI1T2pFd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHSnZiM1J6ZEhKaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFOem9LSUNBZ0lDOHZJR2x1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqTW1NdWNIazZOZ29nSUNBZ0x5OGdZMnhoYzNNZ1IzSmxaWFJsY2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBNUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TG1NeVl5NUhjbVZsZEdWeUxtSnZiM1J6ZEhKaGNDZ3BJQzArSUhWcGJuUTJORG9LWW05dmRITjBjbUZ3T2dvZ0lDQWdMeThnYVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJNeVl5NXdlVG94TWdvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCelpXeG1MbWhsYkd4dlgyRndjQ3dnSW1Gc2NtVmhaSGtnWW05dmRITjBjbUZ3Y0dWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1obGJHeHZYMkZ3Y0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNW9aV3hzYjE5aGNIQWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV3h5WldGa2VTQmliMjkwYzNSeVlYQndaV1FLSUNBZ0lDOHZJR2x1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqTW1NdWNIazZNVFF0TVRnS0lDQWdJQzh2SUdsMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c0tBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0hKdmRtRnNYM0J5YjJkeVlXMDlRbmwwWlhNdVpuSnZiVjlvWlhnb1NFVk1URTlmVjA5U1RFUmZRVkJRVWs5V1FVeGZTRVZZS1N3S0lDQWdJQzh2SUNBZ0lDQmpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRQVWhGVEV4UFgxZFBVa3hFWDBOTVJVRlNMQW9nSUNBZ0x5OGdLUW9nSUNBZ0x5OGdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5Ndll6SmpMbkI1T2pFMkNpQWdJQ0F2THlCamJHVmhjbDl6ZEdGMFpWOXdjbTluY21GdFBVaEZURXhQWDFkUFVreEVYME5NUlVGU0xBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1HRTRNVEF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRVR0ZuWlhNS0lDQWdJQzh2SUdsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5ak1tTXVjSGs2TVRVS0lDQWdJQzh2SUdGd2NISnZkbUZzWDNCeWIyZHlZVzA5UW5sMFpYTXVabkp2YlY5b1pYZ29TRVZNVEU5ZlYwOVNURVJmUVZCUVVrOVdRVXhmU0VWWUtTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQmhNakF3TVRBeE16RXhZalF4TURBeU5qZ3dNRFF3TW1KbFkyVXhNVE0yTVdFd01EaGxNREV3TURBeE1EQXpNVEU1TVRRME5ETXhNVGcwTkRNMk1XRXdNVGc0TURBeE5UZ3dNRFF4TlRGbU4yTTNOVFJqTlRCaU1ESXlORE16TVRFNU1UUTBORE14TVRneE5EUTBNakkwTXpoaE1ERXdNVGhpWm1ZMU56QXlNREE0TURBM05EZzJOVFpqTm1NMlpqSmpNakEwWXpVd05Ea3hOVEUyTlRjd05qQXdOR00xTURnNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NISnZkbUZzVUhKdlozSmhiVkJoWjJWekNpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5Ndll6SmpMbkI1T2pFMENpQWdJQ0F2THlCcGRIaHVMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JDZ0tJQ0FnSUdsdWRHTmZNaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5ak1tTXVjSGs2TVRRdE1UZ0tJQ0FnSUM4dklHbDBlRzR1UVhCd2JHbGpZWFJwYjI1RFlXeHNLQW9nSUNBZ0x5OGdJQ0FnSUdGd2NISnZkbUZzWDNCeWIyZHlZVzA5UW5sMFpYTXVabkp2YlY5b1pYZ29TRVZNVEU5ZlYwOVNURVJmUVZCUVVrOVdRVXhmU0VWWUtTd0tJQ0FnSUM4dklDQWdJQ0JqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0UFVoRlRFeFBYMWRQVWt4RVgwTk1SVUZTTEFvZ0lDQWdMeThnS1FvZ0lDQWdMeThnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk15WXk1d2VUb3hNd29nSUNBZ0x5OGdjMlZzWmk1b1pXeHNiMTloY0hBZ1BTQW9DaUFnSUNCaWVYUmxZMTh3SUM4dklDSm9aV3hzYjE5aGNIQWlDaUFnSUNBdkx5QnBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZekpqTG5CNU9qRTBMVEU1Q2lBZ0lDQXZMeUJwZEhodUxrRndjR3hwWTJGMGFXOXVRMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQmhjSEJ5YjNaaGJGOXdjbTluY21GdFBVSjVkR1Z6TG1aeWIyMWZhR1Y0S0VoRlRFeFBYMWRQVWt4RVgwRlFVRkpQVmtGTVgwaEZXQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJUMUlSVXhNVDE5WFQxSk1SRjlEVEVWQlVpd0tJQ0FnSUM4dklDa0tJQ0FnSUM4dklDNXpkV0p0YVhRb0tRb2dJQ0FnTHk4Z0xtTnlaV0YwWldSZllYQndDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WXpKakxuQjVPakV6TFRJd0NpQWdJQ0F2THlCelpXeG1MbWhsYkd4dlgyRndjQ0E5SUNnS0lDQWdJQzh2SUNBZ0lDQnBkSGh1TGtGd2NHeHBZMkYwYVc5dVEyRnNiQ2dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZWEJ3Y205MllXeGZjSEp2WjNKaGJUMUNlWFJsY3k1bWNtOXRYMmhsZUNoSVJVeE1UMTlYVDFKTVJGOUJVRkJTVDFaQlRGOUlSVmdwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0UFVoRlRFeFBYMWRQVWt4RVgwTk1SVUZTTEFvZ0lDQWdMeThnSUNBZ0lDa0tJQ0FnSUM4dklDQWdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lDOHZJQ0FnSUNBdVkzSmxZWFJsWkY5aGNIQUtJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZekpqTG5CNU9qSXhDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVvWld4c2IxOWhjSEF1YVdRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pvWld4c2IxOWhjSEFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFHVnNiRzlmWVhCd0lHVjRhWE4wY3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRGOWpZWE5sY3k1cGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5NdVl6SmpMa2R5WldWMFpYSXViRzluWDJkeVpXVjBhVzVuY3lodVlXMWxPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tiRzluWDJkeVpXVjBhVzVuY3pvS0lDQWdJQzh2SUdsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5ak1tTXVjSGs2TWpNdE1qUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdiRzluWDJkeVpXVjBhVzVuY3loelpXeG1MQ0J1WVcxbE9pQmhjbU0wTGxOMGNtbHVaeWtnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2FXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTXlZeTV3ZVRveU5TMHlPQW9nSUNBZ0x5OGdhR1ZzYkc5ZlkyRnNiQ0E5SUdsMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c0tBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5cFpEMXpaV3htTG1obGJHeHZYMkZ3Y0N3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmWVhKbmN6MG9ZWEpqTkM1aGNtTTBYM05wWjI1aGRIVnlaU2dpYUdWc2JHOG9jM1J5YVc1bktYTjBjbWx1WnlJcExDQnVZVzFsS1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJR2x1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqTW1NdWNIazZNallLSUNBZ0lDOHZJR0Z3Y0Y5cFpEMXpaV3htTG1obGJHeHZYMkZ3Y0N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pvWld4c2IxOWhjSEFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFHVnNiRzlmWVhCd0lHVjRhWE4wY3dvZ0lDQWdMeThnYVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJNeVl5NXdlVG95TndvZ0lDQWdMeThnWVhCd1gyRnlaM005S0dGeVl6UXVZWEpqTkY5emFXZHVZWFIxY21Vb0ltaGxiR3h2S0hOMGNtbHVaeWx6ZEhKcGJtY2lLU3dnYm1GdFpTa3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNbUpsWTJVeE1TQXZMeUJ0WlhSb2IyUWdJbWhsYkd4dktITjBjbWx1WnlsemRISnBibWNpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WXpKakxuQjVPakkxQ2lBZ0lDQXZMeUJvWld4c2IxOWpZV3hzSUQwZ2FYUjRiaTVCY0hCc2FXTmhkR2x2YmtOaGJHd29DaUFnSUNCcGJuUmpYeklnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5Ndll6SmpMbkI1T2pJMUxUSTRDaUFnSUNBdkx5Qm9aV3hzYjE5allXeHNJRDBnYVhSNGJpNUJjSEJzYVdOaGRHbHZia05oYkd3b0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJsa1BYTmxiR1l1YUdWc2JHOWZZWEJ3TEFvZ0lDQWdMeThnSUNBZ0lHRndjRjloY21kelBTaGhjbU0wTG1GeVl6UmZjMmxuYm1GMGRYSmxLQ0pvWld4c2J5aHpkSEpwYm1jcGMzUnlhVzVuSWlrc0lHNWhiV1VwTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ0x5OGdhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk15WXk1d2VUb3lPUW9nSUNBZ0x5OGdaM0psWlhScGJtY2dQU0JoY21NMExsTjBjbWx1Wnk1bWNtOXRYMnh2Wnlob1pXeHNiMTlqWVd4c0xteGhjM1JmYkc5bktRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTkFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFRlNRelFnY0hKbFptbDRJR2x6SUhaaGJHbGtDaUFnSUNBdkx5QnBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZekpqTG5CNU9qTXdDaUFnSUNBdkx5QnNiMmNvSWtobGJHeHZWMjl5YkdRZ2NtVjBkWEp1WldRNklDSXNJR2R5WldWMGFXNW5MbTVoZEdsMlpTa0tJQ0FnSUdWNGRISmhZM1FnTmlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWtobGJHeHZWMjl5YkdRZ2NtVjBkWEp1WldRNklDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBQUVHSmdJSmFHVnNiRzlmWVhCd0JCVWZmSFV4R0VBQUF5Z2laekViUVFBM2dnSUVlR3Rpa1FReisxMUlOaG9BamdJQUVRQUNJa014R1JSRU1SaEVOaG9CaUFDVkkwTXhHUlJFTVJoRWlBQVNGaWxNVUxBalF6RVpRUC9aTVJnVVJDTkRJaWhsUkJSRXNZQURDb0VCc2tLQVZRb2dBUUV4RzBFQUpvQUVBcjdPRVRZYUFJNEJBQUVBTVJrVVJERVlSRFlhQVlnQUZZQUVGUjk4ZFV4UXNDSkRNUmtVUkRFWUZFUWlRNG9CQVl2L1Z3SUFnQWRJWld4c2J5d2dURkJKRlJaWEJnQk1VSW15UUNTeUVDS3lBYk1vdEQxbklpaGxSSW1LQVFDeElpaGxSSUFFQXI3T0ViSWFpLyt5R3JJWUpMSVFJcklCczdRK1NWY0FCQ2tTUkZjR0FJQVZTR1ZzYkc5WGIzSnNaQ0J5WlhSMWNtNWxaRG9nVEZDd2lRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
