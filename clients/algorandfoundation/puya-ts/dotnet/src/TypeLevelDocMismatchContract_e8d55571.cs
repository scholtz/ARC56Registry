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

namespace Arc56.Generated.algorandfoundation.puya_ts.TypeLevelDocMismatchContract_e8d55571
{


    public class TypeLevelDocMismatchContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TypeLevelDocMismatchContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHlwZUxldmVsRG9jTWlzbWF0Y2hDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJPYmplY3QyRThBNzFFQyI6W3sibmFtZSI6IngiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImZvcndhcmQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCkiLCJzdHJ1Y3QiOiJPYmplY3QyRThBNzFFQyIsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQpIiwic3RydWN0IjoiT2JqZWN0MkU4QTcxRUMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFERUtDbTFoYVc1ZllteHZZMnRBTVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2WW1wbFkzUXRjR0Z6YzNSb2NtOTFaMmd1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGUjVjR1ZNWlhabGJFUnZZMDFwYzIxaGRHTm9RMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTFDaUFnSUNCaUlHMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU1nb0tiV0ZwYmw5aFltbGZjbTkxZEdsdVowQXlPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyOWlhbVZqZEMxd1lYTnpkR2h5YjNWbmFDNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVkhsd1pVeGxkbVZzUkc5alRXbHpiV0YwWTJoRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURCaFl6QTNNVGs0SUM4dklHMWxkR2h2WkNBaVptOXlkMkZ5WkNnb2RXbHVkRFkwS1Nrb2RXbHVkRFkwS1NJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2JXRjBZMmdnYldGcGJsOW1iM0ozWVhKa1gzSnZkWFJsUURNS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEUUtDbTFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBME9nb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU5nb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiMkpxWldOMExYQmhjM04wYUhKdmRXZG9MbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVWVYQmxUR1YyWld4RWIyTk5hWE50WVhSamFFTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnWlhKeUNncHRZV2x1WDJadmNuZGhjbVJmY205MWRHVkFNem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZZbXBsWTNRdGNHRnpjM1JvY205MVoyZ3VZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhaaGJHbGtZWFJsUlc1amIyUnBibWM2SUNkMWJuTmhabVV0WkdsellXSnNaV1FuSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdOaGJHeHpkV0lnWm05eWQyRnlaQW9nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTkFvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZZbXBsWTNRdGNHRnpjM1JvY205MVoyZ3VZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZSNWNHVk1aWFpsYkVSdlkwMXBjMjFoZEdOb1EyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdOaGJHeHpkV0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5aWFtVmpkQzF3WVhOemRHaHliM1ZuYUM1aGJHZHZMblJ6T2pwVWVYQmxUR1YyWld4RWIyTk5hWE50WVhSamFFTnZiblJ5WVdOMExtWnZjbmRoY21SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG1iM0ozWVhKa09nb2dJQ0FnWWlCbWIzSjNZWEprWDJKc2IyTnJRREFLQ21admNuZGhjbVJmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZZbXBsWTNRdGNHRnpjM1JvY205MVoyZ3VZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhaaGJHbGtZWFJsUlc1amIyUnBibWM2SUNkMWJuTmhabVV0WkdsellXSnNaV1FuSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZZbXBsWTNRdGNHRnpjM1JvY205MVoyZ3VZV3huYnk1MGN6bzZWSGx3WlV4bGRtVnNSRzlqVFdsemJXRjBZMmhEYjI1MGNtRmpkQzVtYjNKM1lYSmtDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZZbXBsWTNRdGNHRnpjM1JvY205MVoyZ3VZV3huYnk1MGN6bzZWSGx3WlV4bGRtVnNSRzlqVFdsemJXRjBZMmhEYjI1MGNtRmpkQzVtYjNKM1lYSmtLR0U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LZEdWemRITXZZWEJ3Y205MllXeHpMMjlpYW1WamRDMXdZWE56ZEdoeWIzVm5hQzVoYkdkdkxuUnpPanBVZVhCbFRHVjJaV3hFYjJOTmFYTnRZWFJqYUVOdmJuUnlZV04wTG1admNuZGhjbVE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiMkpxWldOMExYQmhjM04wYUhKdmRXZG9MbUZzWjI4dWRITTZNek10TXpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ0x5OGdabTl5ZDJGeVpDaGhPaUJFWlhOalVISmhhWE5sS1RvZ1JHVnpZMVI1Y0dWTVpYWmxiQ0I3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5aWFtVmpkQzF3WVhOemRHaHliM1ZuYUM1aGJHZHZMblJ6T2pwVWVYQmxUR1YyWld4RWIyTk5hWE50WVhSamFFTnZiblJ5WVdOMExtWnZjbmRoY21SZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5aWFtVmpkQzF3WVhOemRHaHliM1ZuYUM1aGJHZHZMblJ6T2pwVWVYQmxUR1YyWld4RWIyTk5hWE50WVhSamFFTnZiblJ5WVdOMExtWnZjbmRoY21SZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2WW1wbFkzUXRjR0Z6YzNSb2NtOTFaMmd1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnY21WMGRYSnVJR0VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyOWlhbVZqZEMxd1lYTnpkR2h5YjNWbmFDNWhiR2R2TG5Sek9qcFVlWEJsVEdWMlpXeEViMk5OYVhOdFlYUmphRU52Ym5SeVlXTjBMbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpTZ3BJQzArSUhadmFXUTZDbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpUb0tJQ0FnSUdJZ1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsWDJKc2IyTnJRREFLQ2w5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdPZ29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FBRkNBQUJDQUFBeEd5SVRRUUFwUWdBQU5ob0FnQVFLd0hHWVR3R09BUUFIUWdBQVFnQUFBREVaSWhJeEdDSVRFRVNJQUJKQy8rd3hHU0lTTVJnaUVoQkVpQUFnSTBOQ0FBQTJHZ0dJQUF5QUJCVWZmSFZQQVZDd0kwT0tBUUZDQUFDTC80bENBQUNKIiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
