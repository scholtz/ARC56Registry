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

namespace Arc56.Generated.algorandfoundation.puya_ts.CommaOperatorTest_50c1079f
{


    public class CommaOperatorTestProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CommaOperatorTestProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        public class Events
        {
            public class EventEvent
            {
                public static readonly byte[] Selector = new byte[4] { 216, 223, 130, 113 };
                public const string Signature = "Event(uint8,uint8)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte V { get; set; }
                public byte Acc { get; set; }

                public static EventEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new EventEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vV = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vV.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueV = vV.ToValue();
                    if (valueV is byte vVValue) { ret.V = vVValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAcc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vAcc.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAcc = vAcc.ToValue();
                    if (valueAcc is byte vAccValue) { ret.Acc = vAccValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<byte> EmitEmitAdd(byte a, byte b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 242, 205, 189 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Byte();
            returnValueObj.Decode(lastLogReturnData);
            return ReverseIfLittleEndian(lastLogReturnData)[0];

        }

        public async Task<List<Transaction>> EmitEmitAdd_Transactions(byte a, byte b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 242, 205, 189 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29tbWFPcGVyYXRvclRlc3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiZW1pdEVtaXRBZGQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InYiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjYyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbOTQsMTAyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzUsMTYxLDE4Ml0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURnZ053b2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VDQXdlR1E0WkdZNE1qY3hDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFERUtDbTFoYVc1ZllteHZZMnRBTVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjIxdFlTMXZjR1Z5WVhSdmNpNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHTnNZWE56SUVOdmJXMWhUM0JsY21GMGIzSlVaWE4wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQWhQUW9nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTlFvZ0lDQWdZaUJ0WVdsdVgyRmlhVjl5YjNWMGFXNW5RRElLQ20xaGFXNWZZV0pwWDNKdmRYUnBibWRBTWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjIxdFlTMXZjR1Z5WVhSdmNpNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHTnNZWE56SUVOdmJXMWhUM0JsY21GMGIzSlVaWE4wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T1RkbU1tTmtZbVFnTHk4Z2JXVjBhRzlrSUNKbGJXbDBSVzFwZEVGa1pDaDFhVzUwT0N4MWFXNTBPQ2wxYVc1ME9DSUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlsYldsMFJXMXBkRUZrWkY5eWIzVjBaVUF6Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBMENncHRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTkRvS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURZS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyTnZiVzFoTFc5d1pYSmhkRzl5TG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWTJ4aGMzTWdRMjl0YldGUGNHVnlZWFJ2Y2xSbGMzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCbGNuSUtDbTFoYVc1ZlpXMXBkRVZ0YVhSQlpHUmZjbTkxZEdWQU16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5amIyMXRZUzF2Y0dWeVlYUnZjaTVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Z0YVhSRmJXbDBRV1JrS0dFNklGVnBiblE0TENCaU9pQlZhVzUwT0NrNklGVnBiblE0SUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlCT2IwOXdDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWTJGc2JITjFZaUJsYldsMFJXMXBkRUZrWkFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Bb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjIxdFlTMXZjR1Z5WVhSdmNpNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHTnNZWE56SUVOdmJXMWhUM0JsY21GMGIzSlVaWE4wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SUU1dlQzQUtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JqWVd4c2MzVmlJRjlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjIxdFlTMXZjR1Z5WVhSdmNpNWhiR2R2TG5Sek9qcERiMjF0WVU5d1pYSmhkRzl5VkdWemRDNWxiV2wwUlcxcGRFRmtaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21WdGFYUkZiV2wwUVdSa09nb2dJQ0FnWWlCbGJXbDBSVzFwZEVGa1pGOWliRzlqYTBBd0NncGxiV2wwUlcxcGRFRmtaRjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyTnZiVzFoTFc5d1pYSmhkRzl5TG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlcxcGRFVnRhWFJCWkdRb1lUb2dWV2x1ZERnc0lHSTZJRlZwYm5RNEtUb2dWV2x1ZERnZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTRDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRGdLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOdmJXMWhMVzl3WlhKaGRHOXlMbUZzWjI4dWRITTZPa052YlcxaFQzQmxjbUYwYjNKVVpYTjBMbVZ0YVhSRmJXbDBRV1JrQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjIxdFlTMXZjR1Z5WVhSdmNpNWhiR2R2TG5Sek9qcERiMjF0WVU5d1pYSmhkRzl5VkdWemRDNWxiV2wwUlcxcGRFRmtaQ2hoT2lCaWVYUmxjeXdnWWpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WTI5dGJXRXRiM0JsY21GMGIzSXVZV3huYnk1MGN6bzZRMjl0YldGUGNHVnlZWFJ2Y2xSbGMzUXVaVzFwZEVWdGFYUkJaR1E2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMjl0YldFdGIzQmxjbUYwYjNJdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCbGJXbDBSVzFwZEVGa1pDaGhPaUJWYVc1ME9Dd2dZam9nVldsdWREZ3BPaUJWYVc1ME9DQjdDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMk52YlcxaExXOXdaWEpoZEc5eUxtRnNaMjh1ZEhNNk9rTnZiVzFoVDNCbGNtRjBiM0pVWlhOMExtVnRhWFJGYldsMFFXUmtYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWpiMjF0WVMxdmNHVnlZWFJ2Y2k1aGJHZHZMblJ6T2pwRGIyMXRZVTl3WlhKaGRHOXlWR1Z6ZEM1bGJXbDBSVzFwZEVGa1pGOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOdmJXMWhMVzl3WlhKaGRHOXlMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJR1Z0YVhROFJYWmxiblErS0hzZ1lXTmpPaUJ1WlhjZ1ZXbHVkRGdvS0hKbGN5QXJQU0JoTG1GelZXbHVkRFkwS0NrcEtTd2dkam9nWVNCOUtTd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOdmJXMWhMVzl3WlhKaGRHOXlMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdiR1YwSUhKbGN6b2dkV2x1ZERZMElEMGdNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5amIyMXRZUzF2Y0dWeVlYUnZjaTVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJsYldsMFBFVjJaVzUwUGloN0lHRmpZem9nYm1WM0lGVnBiblE0S0NoeVpYTWdLejBnWVM1aGMxVnBiblEyTkNncEtTa3NJSFk2SUdFZ2ZTa3NDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbWwwYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHpJQzh2SURjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUcxbGRHaHZaQ0FpUlhabGJuUW9kV2x1ZERnc2RXbHVkRGdwSWdvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyTnZiVzFoTFc5d1pYSmhkRzl5TG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUdWdGFYUThSWFpsYm5RK0tIc2dZV05qT2lCdVpYY2dWV2x1ZERnb0tISmxjeUFyUFNCaUxtRnpWV2x1ZERZMEtDa3BLU3dnZGpvZ1lpQjlLU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1luUnZhUW9nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR0pwZEd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNeUF2THlBM0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlCdFpYUm9iMlFnSWtWMlpXNTBLSFZwYm5RNExIVnBiblE0S1NJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWpiMjF0WVMxdmNHVnlZWFJ2Y2k1aGJHZHZMblJ6T2pFeExURTFDaUFnSUNBdkx5QnlaWFIxY200Z2JtVjNJRlZwYm5RNEtDZ0tJQ0FnSUM4dklDQWdaVzFwZER4RmRtVnVkRDRvZXlCaFkyTTZJRzVsZHlCVmFXNTBPQ2dvY21WeklDczlJR0V1WVhOVmFXNTBOalFvS1NrcExDQjJPaUJoSUgwcExBb2dJQ0FnTHk4Z0lDQmxiV2wwUEVWMlpXNTBQaWg3SUdGall6b2dibVYzSUZWcGJuUTRLQ2h5WlhNZ0t6MGdZaTVoYzFWcGJuUTJOQ2dwS1Nrc0lIWTZJR0lnZlNrc0NpQWdJQ0F2THlBZ0lISmxjd29nSUNBZ0x5OGdLU2tLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1ltbDBiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eklDOHZJRGNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk52YlcxaExXOXdaWEpoZEc5eUxtRnNaMjh1ZEhNNk9rTnZiVzFoVDNCbGNtRjBiM0pVWlhOMExsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlNncElDMCtJSFp2YVdRNkNsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlRvS0lDQWdJR0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxYMkpzYjJOclFEQUtDbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpWOWliRzlqYTBBd09nb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBSUJ5WUNBQVRZMzRKeFFnQUFRZ0FBTVJzakUwRUFLVUlBQURZYUFJQUVsL0xOdlU4QmpnRUFCMElBQUVJQUFBQXhHU01TTVJnakV4QkVpQUFTUXYvc01Sa2pFakVZSXhJUVJJZ0FhU0pEUWdBQU5ob0JTUlVpRWtRMkdnSkpGU0lTUklnQURJQUVGUjk4ZFU4QlVMQWlRNG9DQVVJQUFJditGeU1JU1JaSmt5UU9SQ1VpV0NpTC9sQlBBVkFwVHdGUXNJdi9Gd2hKRmttVEpBNUVKU0pZS0l2L1VFOEJVQ2xQQVZDd0ZrbVRKQTVFSlNKWWlVSUFBSWs9IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IkV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
