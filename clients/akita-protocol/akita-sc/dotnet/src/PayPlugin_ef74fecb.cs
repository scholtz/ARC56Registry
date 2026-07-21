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

namespace Arc56.Generated.akita_protocol.akita_sc.PayPlugin_ef74fecb
{


    public class PayPluginProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PayPluginProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class PayArgPayments : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PayArgPayments Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PayArgPayments();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PayArgPayments);
                }
                public bool Equals(PayArgPayments? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PayArgPayments left, PayArgPayments right)
                {
                    return EqualityComparer<PayArgPayments>.Default.Equals(left, right);
                }
                public static bool operator !=(PayArgPayments left, PayArgPayments right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="payments"> PayArgPayments</param>
        public async Task Pay(ulong wallet, bool rekeyBack, Structs.PayArgPayments[] payments, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 115, 132, 146 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var paymentsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PayArgPayments>(x => Structs.PayArgPayments.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; paymentsAbi.From(payments);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, paymentsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Pay_Transactions(ulong wallet, bool rekeyBack, Structs.PayArgPayments[] payments, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 115, 132, 146 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var paymentsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PayArgPayments>(x => Structs.PayArgPayments.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; paymentsAbi.From(payments);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, paymentsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGF5UGx1Z2luIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlBheUFyZ1BheW1lbnRzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJwYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVrZXlCYWNrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0KVtdIiwic3RydWN0IjoiUGF5QXJnUGF5bWVudHMiLCJuYW1lIjoicGF5bWVudHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1OF0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NV0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHNtYXJ0X2NvbnRyYWN0cy9hcmM1OC9wbHVnaW5zL3BheS90eXBlcy50czo6UGF5UGFyYW1zPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURRNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VHRjVVR3gxWjJsdUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1k1TnpNNE5Ea3lJQzh2SUcxbGRHaHZaQ0FpY0dGNUtIVnBiblEyTkN4aWIyOXNMQ2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRcFcxMHBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmY0dGNVgzSnZkWFJsUURNS0lDQWdJR1Z5Y2dvS2JXRnBibDl3WVhsZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJSEJoZVNoM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxDQnlaV3RsZVVKaFkyczZJR0p2YjJ4bFlXNHNJSEJoZVcxbGJuUnpPaUJRWVhsUVlYSmhiWE5iWFNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdJZ2NHRjVDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQmhlVkJzZFdkcGJpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvNmNtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmphem9nZFdsdWREWTBMQ0IzWVd4c1pYUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbkpsYTJWNVFXUmtjbVZ6Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TXpReENpQWdJQ0F2THlCbGVIQnZjblFnWm5WdVkzUnBiMjRnY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd2dkMkZzYkdWME9pQkJjSEJzYVdOaGRHbHZiaWs2SUVGalkyOTFiblFnZXdvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qTTBNZ29nSUNBZ0x5OGdhV1lnS0NGeVpXdGxlVUpoWTJzcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW01NklISmxhMlY1UVdSa2NtVnpjMTloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk16UXpDaUFnSUNBdkx5QnlaWFIxY200Z1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lISmxkSE4xWWdvS2NtVnJaWGxCWkdSeVpYTnpYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk16UTJDaUFnSUNBdkx5QnlaWFIxY200Z2QyRnNiR1YwTG1Ga1pISmxjM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1FXUmtjbVZ6Y3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Y0dGNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQmhlVkJzZFdkcGJpNXdZWGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwd1lYazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJSEJoZVNoM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxDQnlaV3RsZVVKaFkyczZJR0p2YjJ4bFlXNHNJSEJoZVcxbGJuUnpPaUJRWVhsUVlYSmhiWE5iWFNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSE4zWVhBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdORGdLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOGMyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZjR0Y1TDNSNWNHVnpMblJ6T2pwUVlYbFFZWEpoYlhNK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pJNE9Bb2dJQ0FnTHk4Z1FubDBaWE1vUVdKemRISmhZM1JCWTJOdmRXNTBSMnh2WW1Gc1UzUmhkR1ZMWlhselUzQmxibVJwYm1kQlpHUnlaWE56S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p6Y0dWdVpHbHVaMTloWkdSeVpYTnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lPRFl0TWpnNUNpQWdJQ0F2THlCamIyNXpkQ0JiYzNCbGJtUnBibWRCWkdSeVpYTnpRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZEN3S0lDQWdJQzh2SUNBZ1FubDBaWE1vUVdKemRISmhZM1JCWTJOdmRXNTBSMnh2WW1Gc1UzUmhkR1ZMWlhselUzQmxibVJwYm1kQlpHUnlaWE56S1FvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENCd1lYbHRaVzUwY3k1c1pXNW5kR2c3SUdrckt5a2dld29nSUNBZ2FXNTBZMTh3SUM4dklEQUtDbkJoZVY5M2FHbHNaVjkwYjNCQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMM0JoZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd0NpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z2NHRjViV1Z1ZEhNdWJHVnVaM1JvT3lCcEt5c3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lEd0tJQ0FnSUdKNklIQmhlVjloWm5SbGNsOTNhR2xzWlVBeE5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUdOdmJuTjBJSHNnY21WalpXbDJaWElzSUdGemMyVjBMQ0JoYlc5MWJuUWdmU0E5SUhCaGVXMWxiblJ6VzJsZE93b2dJQ0FnWkdsbklETUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURRNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdORGdLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHSjFjbmtnTVRBS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0J3ZFhOb2FXNTBJRFF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnYVdZZ0tHRnpjMlYwSUQwOVBTQXdLU0I3Q2lBZ0lDQmlibm9nY0dGNVgyVnNjMlZmWW05a2VVQTVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5DMHlNUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXdGxlVlJ2T2lCcElEd2dLSEJoZVcxbGJuUnpMbXhsYm1kMGFDQXRJREVwSUQ4Z1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOeklEb2djbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXl3Z2QyRnNiR1YwS1N3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnY21WclpYbFViem9nYVNBOElDaHdZWGx0Wlc1MGN5NXNaVzVuZEdnZ0xTQXhLU0EvSUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3lBNklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdScFp5QXhDaUFnSUNBK0NpQWdJQ0JpZWlCd1lYbGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMkNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LQ25CaGVWOTBaWEp1WVhKNVgyMWxjbWRsUURjNkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbGEyVjVWRzhLSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnWkdsbklEZ0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Y0dGNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXRNakFLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnJaWGxVYnpvZ2FTQThJQ2h3WVhsdFpXNTBjeTVzWlc1bmRHZ2dMU0F4S1NBL0lFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5QTZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQzB5TVFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQnlaV3RsZVZSdk9pQnBJRHdnS0hCaGVXMWxiblJ6TG14bGJtZDBhQ0F0SURFcElEOGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpJRG9nY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF5d2dkMkZzYkdWMEtTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LY0dGNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVRvZ2RXbHVkRFkwSUQwZ01Ec2dhU0E4SUhCaGVXMWxiblJ6TG14bGJtZDBhRHNnYVNzcktTQjdDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnY0dGNVgzZG9hV3hsWDNSdmNFQXlDZ3B3WVhsZmRHVnlibUZ5ZVY5bVlXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJSEpsYTJWNVZHODZJR2tnUENBb2NHRjViV1Z1ZEhNdWJHVnVaM1JvSUMwZ01Ta2dQeUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01nT2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBMQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmpZV3hzYzNWaUlISmxhMlY1UVdSa2NtVnpjd29nSUNBZ1lpQndZWGxmZEdWeWJtRnllVjl0WlhKblpVQTNDZ3B3WVhsZlpXeHpaVjlpYjJSNVFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU15MHpNUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUhKbFkyVnBkbVZ5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUJoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXdGxlVlJ2T2lCcElEd2dLSEJoZVcxbGJuUnpMbXhsYm1kMGFDQXRJREVwSUQ4Z1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOeklEb2djbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXl3Z2QyRnNiR1YwS1N3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnY21WclpYbFViem9nYVNBOElDaHdZWGx0Wlc1MGN5NXNaVzVuZEdnZ0xTQXhLU0EvSUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3lBNklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdScFp5QXhDaUFnSUNBK0NpQWdJQ0JpZWlCd1lYbGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1Rb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2dwd1lYbGZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1qb0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVnJaWGxVYndvZ0lDQWdaR2xuSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQmthV2NnTndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdaR2xuSURnS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNeTB6TUFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklISmxZMlZwZG1WeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQnlaV3RsZVZSdk9pQnBJRHdnS0hCaGVXMWxiblJ6TG14bGJtZDBhQ0F0SURFcElEOGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpJRG9nY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF5d2dkMkZzYkdWMEtTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNeTB6TVFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklISmxZMlZwZG1WeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQnlaV3RsZVZSdk9pQnBJRHdnS0hCaGVXMWxiblJ6TG14bGJtZDBhQ0F0SURFcElEOGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpJRG9nY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF5d2dkMkZzYkdWMEtTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1lpQndZWGxmWVdaMFpYSmZhV1pmWld4elpVQXhOQW9LY0dGNVgzUmxjbTVoY25sZlptRnNjMlZBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnY21WclpYbFViem9nYVNBOElDaHdZWGx0Wlc1MGN5NXNaVzVuZEdnZ0xTQXhLU0EvSUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3lBNklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tzQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaR2xuSURZS0lDQWdJR05oYkd4emRXSWdjbVZyWlhsQlpHUnlaWE56Q2lBZ0lDQmlJSEJoZVY5MFpYSnVZWEo1WDIxbGNtZGxRREV5Q2dwd1lYbGZZV1owWlhKZmQyaHBiR1ZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJ3WVhrb2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpd2djbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQ0J3WVhsdFpXNTBjem9nVUdGNVVHRnlZVzF6VzEwcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBQUV3TVJ0QkFCaUFCUGx6aEpJMkdnQ09BUUFCQURFWkZERVlFRVJDQUJreEdSUXhHQlFRUTRvQ0FZditRQUFETWdPSmkvOXlDRVNKSW9BQVNUWWFBVWtWZ1FnU1JCZEpOaG9DU1JVakVrUWlVMHcyR2dOSlRnSkpJbGxKVGdNa0M0RUNDRXdWRWtTQUVITndaVzVrYVc1blgyRmtaSEpsYzNObFNDSkpTd01NUVFDS1N3TlhBZ0JMQVNRTEpGaEpWd0FnUlFwSmdTQmJTVTRDUlFtQktGdEZDVUFBTkxGTEFpTUpTd0VOUVFBZk1nT3lJRXNIc2doTENMSUhTd0d5QUNPeUVDS3lBYk5KSXdoRkFVTC9yVXNFU3dhSS8xRkMvOW14U3dJakNVc0JEVUVBSHpJRHNpQkxCcklSU3dleUVrc0lzaFJMQWJJQWdRU3lFQ0t5QWJOQy84UkxCRXNHaVA4ZFF2L1pJME09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
