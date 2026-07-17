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

namespace Arc56.Generated.algorandfoundation.puya_ts.FieldDocMismatchContract_668543ae
{


    public class FieldDocMismatchContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FieldDocMismatchContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Object2E8A71Ec : AVMObjectType
            {
                public ulong X { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Object2E8A71Ec Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Object2E8A71Ec();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX = vX.ToValue();
                    if (valueX is ulong vXValue) { ret.X = vXValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Object2E8A71Ec);
                }
                public bool Equals(Object2E8A71Ec? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Object2E8A71Ec left, Object2E8A71Ec right)
                {
                    return EqualityComparer<Object2E8A71Ec>.Default.Equals(left, right);
                }
                public static bool operator !=(Object2E8A71Ec left, Object2E8A71Ec right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> Object2E8A71EC</param>
        public async Task<Structs.Object2E8A71Ec> Forward(Structs.Object2E8A71Ec a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 192, 113, 152 };

            var result = await base.CallApp(new List<object> { abiHandle, a }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Object2E8A71Ec.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Forward_Transactions(Structs.Object2E8A71Ec a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 192, 113, 152 };

            return await base.MakeTransactionList(new List<object> { abiHandle, a }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRmllbGREb2NNaXNtYXRjaENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDJFOEE3MUVDIjpbeyJuYW1lIjoieCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZm9yd2FyZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0KSIsInN0cnVjdCI6Ik9iamVjdDJFOEE3MUVDIiwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCkiLCJzdHJ1Y3QiOiJPYmplY3QyRThBNzFFQyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeENpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURFS0NtMWhhVzVmWW14dlkydEFNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZZbXBsWTNRdGNHRnpjM1JvY205MVoyZ3VZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVacFpXeGtSRzlqVFdsemJXRjBZMmhEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRFVLSUNBZ0lHSWdiV0ZwYmw5aFltbGZjbTkxZEdsdVowQXlDZ3B0WVdsdVgyRmlhVjl5YjNWMGFXNW5RREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiMkpxWldOMExYQmhjM04wYUhKdmRXZG9MbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCR2FXVnNaRVJ2WTAxcGMyMWhkR05vUTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3WVdNd056RTVPQ0F2THlCdFpYUm9iMlFnSW1admNuZGhjbVFvS0hWcGJuUTJOQ2twS0hWcGJuUTJOQ2tpQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlptOXlkMkZ5WkY5eWIzVjBaVUF6Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBMENncHRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTkRvS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURZS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyOWlhbVZqZEMxd1lYTnpkR2h5YjNWbmFDNWhiR2R2TG5Sek9qRTRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUm1sbGJHUkViMk5OYVhOdFlYUmphRU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ1pYSnlDZ3B0WVdsdVgyWnZjbmRoY21SZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2WW1wbFkzUXRjR0Z6YzNSb2NtOTFaMmd1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdUbTlQY0FvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHTmhiR3h6ZFdJZ1ptOXlkMkZ5WkFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Bb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2WW1wbFkzUXRjR0Z6YzNSb2NtOTFaMmd1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFWnBaV3hrUkc5alRXbHpiV0YwWTJoRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlCT2IwOXdDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWTJGc2JITjFZaUJmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjJKcVpXTjBMWEJoYzNOMGFISnZkV2RvTG1Gc1oyOHVkSE02T2tacFpXeGtSRzlqVFdsemJXRjBZMmhEYjI1MGNtRmpkQzVtYjNKM1lYSmtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWm05eWQyRnlaRG9LSUNBZ0lHSWdabTl5ZDJGeVpGOWliRzlqYTBBd0NncG1iM0ozWVhKa1gySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjJKcVpXTjBMWEJoYzNOMGFISnZkV2RvTG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjJKcVpXTjBMWEJoYzNOMGFISnZkV2RvTG1Gc1oyOHVkSE02T2tacFpXeGtSRzlqVFdsemJXRjBZMmhEYjI1MGNtRmpkQzVtYjNKM1lYSmtDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZZbXBsWTNRdGNHRnpjM1JvY205MVoyZ3VZV3huYnk1MGN6bzZSbWxsYkdSRWIyTk5hWE50WVhSamFFTnZiblJ5WVdOMExtWnZjbmRoY21Rb1lUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncDBaWE4wY3k5aGNIQnliM1poYkhNdmIySnFaV04wTFhCaGMzTjBhSEp2ZFdkb0xtRnNaMjh1ZEhNNk9rWnBaV3hrUkc5alRXbHpiV0YwWTJoRGIyNTBjbUZqZEM1bWIzSjNZWEprT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjlpYW1WamRDMXdZWE56ZEdoeWIzVm5hQzVoYkdkdkxuUnpPakU1TFRJd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lDOHZJR1p2Y25kaGNtUW9ZVG9nUkdWelkxQnlZV2x6WlNrNklFUmxjMk5FYVhOd1lYSmhaMlVnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dlltcGxZM1F0Y0dGemMzUm9jbTkxWjJndVlXeG5ieTUwY3pvNlJtbGxiR1JFYjJOTmFYTnRZWFJqYUVOdmJuUnlZV04wTG1admNuZGhjbVJmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMjlpYW1WamRDMXdZWE56ZEdoeWIzVm5hQzVoYkdkdkxuUnpPanBHYVdWc1pFUnZZMDFwYzIxaGRHTm9RMjl1ZEhKaFkzUXVabTl5ZDJGeVpGOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5aWFtVmpkQzF3WVhOemRHaHliM1ZuYUM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCeVpYUjFjbTRnWVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiMkpxWldOMExYQmhjM04wYUhKdmRXZG9MbUZzWjI4dWRITTZPa1pwWld4a1JHOWpUV2x6YldGMFkyaERiMjUwY21GamRDNWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVb0tTQXRQaUIyYjJsa09ncGZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVNkNpQWdJQ0JpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdDZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFGQ0FBQkNBQUF4R3lJVFFRQXBRZ0FBTmhvQWdBUUt3SEdZVHdHT0FRQUhRZ0FBUWdBQUFERVpJaEl4R0NJVEVFU0lBQkpDLyt3eEdTSVNNUmdpRWhCRWlBQWdJME5DQUFBMkdnR0lBQXlBQkJVZmZIVlBBVkN3STBPS0FRRkNBQUNMLzRsQ0FBQ0oiLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
