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

namespace Arc56.Generated.akita_protocol.akita_sc.MockUnlimitedPayPlugin_d5e4832a
{


    //
    // Test-only payment plugin with PayPlugin's `pay` ABI and no grant policy, as PayPlugin was before
    //policies. Wallet tests use it where any global grant that moves funds will do; PayPlugin itself
    //refuses a global grant without an execution key or a policy.
    //
    public class MockUnlimitedPayPluginProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockUnlimitedPayPluginProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja1VubGltaXRlZFBheVBsdWdpbiIsImRlc2MiOiJUZXN0LW9ubHkgcGF5bWVudCBwbHVnaW4gd2l0aCBQYXlQbHVnaW4ncyBgcGF5YCBBQkkgYW5kIG5vIGdyYW50IHBvbGljeSwgYXMgUGF5UGx1Z2luIHdhcyBiZWZvcmVcbnBvbGljaWVzLiBXYWxsZXQgdGVzdHMgdXNlIGl0IHdoZXJlIGFueSBnbG9iYWwgZ3JhbnQgdGhhdCBtb3ZlcyBmdW5kcyB3aWxsIGRvOyBQYXlQbHVnaW4gaXRzZWxmXG5yZWZ1c2VzIGEgZ2xvYmFsIGdyYW50IHdpdGhvdXQgYW4gZXhlY3V0aW9uIGtleSBvciBhIHBvbGljeS4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUGF5QXJnUGF5bWVudHMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InBheSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCx1aW50NjQpW10iLCJzdHJ1Y3QiOiJQYXlBcmdQYXltZW50cyIsIm5hbWUiOiJwYXltZW50cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEzMl0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJOYXRoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExXSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNThdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTRdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHNtYXJ0X2NvbnRyYWN0cy9hcmM1OC9wbHVnaW5zL3BheS90eXBlcy50czo6UGF5UGFyYW1zPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURRNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZkVzVzYVcxcGRHVmtMWEJoZVMxd2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMXZZMnRWYm14cGJXbDBaV1JRWVhsUWJIVm5hVzRnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU5Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpqazNNemcwT1RJZ0x5OGdiV1YwYUc5a0lDSndZWGtvZFdsdWREWTBMR0p2YjJ3c0tHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ2xiWFNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOXdZWGxmY205MWRHVkFNd29nSUNBZ1pYSnlDZ3B0WVdsdVgzQmhlVjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNWdWJHbHRhWFJsWkMxd1lYa3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklIQmhlU2gzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1TENCeVpXdGxlVUpoWTJzNklHSnZiMnhsWVc0c0lIQmhlVzFsYm5Sek9pQlFZWGxRWVhKaGJYTmJYU2s2SUhadmFXUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR0lnY0dGNUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzVnViR2x0YVhSbFpDMXdZWGt0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCTmIyTnJWVzVzYVcxcGRHVmtVR0Y1VUd4MVoybHVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012ZFc1c2FXMXBkR1ZrTFhCaGVTMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXOWphMVZ1YkdsdGFYUmxaRkJoZVZCc2RXZHBiaTV3WVhsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdZWGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmRXNXNhVzFwZEdWa0xYQmhlUzF3YkhWbmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdjR0Y1S0hkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd2djR0Y1YldWdWRITTZJRkJoZVZCaGNtRnRjMXRkS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVZbTl2YkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdjM2RoY0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHbHVkR05mTWlBdkx5QTBPQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4emJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXdZWGt2ZEhsd1pYTXVkSE02T2xCaGVWQmhjbUZ0Y3o0S0lDQWdJQzh2SUM0dUx5NHVMMjV2WkdWZmJXOWtkV3hsY3k5QVlXdHBkR0V0Y0hKdmRHOWpiMnd2Y0d4MVoybHVMMloxYm1OMGFXOXVjeTUwY3pveU1Rb2dJQ0FnTHk4Z1FubDBaWE1vUVZKRE5UaGZVMUJGVGtSSlRrZGZRVVJFVWtWVFUxOUxSVmtwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbk53Wlc1a2FXNW5YMkZrWkhKbGMzTWlDaUFnSUNBdkx5QXVMaTh1TGk5dWIyUmxYMjF2WkhWc1pYTXZRR0ZyYVhSaExYQnliM1J2WTI5c0wzQnNkV2RwYmk5bWRXNWpkR2x2Ym5NdWRITTZNVGt0TWpJS0lDQWdJQzh2SUdOdmJuTjBJRnR6Y0dWdVpHbHVaMEZrWkhKbGMzTkNlWFJsYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3lnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwTEFvZ0lDQWdMeThnSUNCQ2VYUmxjeWhCVWtNMU9GOVRVRVZPUkVsT1IxOUJSRVJTUlZOVFgwdEZXU2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z0xpNHZMaTR2Ym05a1pWOXRiMlIxYkdWekwwQmhhMmwwWVMxd2NtOTBiMk52YkM5d2JIVm5hVzR2Wm5WdVkzUnBiMjV6TG5Sek9qTTVDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvYzJWdVpHVnlMbUYxZEdoQlpHUnlaWE56SUQwOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3Z1FWSkROVGhmUlZKU1gxQk1WVWRKVGw5T1QxUmZRVlZVU0Y5QlJFUlNLUW9nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUkJkWFJvUVdSa2Nnb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQndZWGxmWVdaMFpYSmZZWE56WlhKMFFERTVDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KT1lYUm9JZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnljazVoZEdnS0NuQmhlVjloWm5SbGNsOWhjM05sY25SQU1UazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012ZFc1c2FXMXBkR1ZrTFhCaGVTMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNRHNnYVNBOElIQmhlVzFsYm5SekxteGxibWQwYURzZ2FTc3JLU0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9LY0dGNVgzZG9hV3hsWDNSdmNFQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNWdWJHbHRhWFJsWkMxd1lYa3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQndZWGx0Wlc1MGN5NXNaVzVuZEdnN0lHa3JLeWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2djR0Y1WDJGbWRHVnlYM2RvYVd4bFFERXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012ZFc1c2FXMXBkR1ZrTFhCaGVTMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z1kyOXVjM1FnZXlCeVpXTmxhWFpsY2l3Z1lYTnpaWFFzSUdGdGIzVnVkQ0I5SUQwZ2NHRjViV1Z1ZEhOYmFWMEtJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklEUTRDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTkRnS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhCMWMyaHBiblFnTkRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JqYjNabGNpQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012ZFc1c2FXMXBkR1ZrTFhCaGVTMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z1kyOXVjM1FnY21WclpYbFVieUE5SUdrZ1BDQW9jR0Y1YldWdWRITXViR1Z1WjNSb0lDMGdNU2tnUHlCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNZ09pQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yTENCM1lXeHNaWFFwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUR3S0lDQWdJR0o2SUhCaGVWOTBaWEp1WVhKNVgyWmhiSE5sUURVS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29LY0dGNVgzUmxjbTVoY25sZmJXVnlaMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OTFibXhwYldsMFpXUXRjR0Y1TFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJwWmlBb1lYTnpaWFFnUFQwOUlEQXBJSHNLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmlibm9nY0dGNVgyVnNjMlZmWW05a2VVQTVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzVnViR2x0YVhSbFpDMXdZWGt0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJR2wwZUc0dWNHRjViV1Z1ZENoN0lITmxibVJsY2l3Z2NtVmpaV2wyWlhJc0lHRnRiM1Z1ZEN3Z2NtVnJaWGxVYnlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWld0bGVWUnZDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2dwd1lYbGZZV1owWlhKZmFXWmZaV3h6WlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTkxYm14cGJXbDBaV1F0Y0dGNUxYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z2NHRjViV1Z1ZEhNdWJHVnVaM1JvT3lCcEt5c3BJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpSUhCaGVWOTNhR2xzWlY5MGIzQkFNZ29LY0dGNVgyVnNjMlZmWW05a2VVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNWdWJHbHRhWFJsWkMxd1lYa3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua0tJQ0FnSUM4dklHbDBlRzR1WVhOelpYUlVjbUZ1YzJabGNpaDdJSE5sYm1SbGNpd2dZWE56WlhSU1pXTmxhWFpsY2pvZ2NtVmpaV2wyWlhJc0lHRnpjMlYwUVcxdmRXNTBPaUJoYlc5MWJuUXNJSGhtWlhKQmMzTmxkRG9nWVhOelpYUXNJSEpsYTJWNVZHOGdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVnJaWGxVYndvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCa2FXY2dNZ29nSUNBZ2FYUjRibDltYVdWc1pDQlRaVzVrWlhJS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdZaUJ3WVhsZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvS2NHRjVYM1JsY201aGNubGZabUZzYzJWQU5Ub0tJQ0FnSUM4dklDNHVMeTR1TDI1dlpHVmZiVzlrZFd4bGN5OUFZV3RwZEdFdGNISnZkRzlqYjJ3dmNHeDFaMmx1TDJaMWJtTjBhVzl1Y3k1MGN6b3hORFFLSUNBZ0lDOHZJR2xtSUNnaGNtVnJaWGxDWVdOcktTQjdDaUFnSUNCa2FXY2dOd29nSUNBZ1ltNTZJSEJoZVY5aFpuUmxjbDlwWmw5bGJITmxRREUxQ2lBZ0lDQXZMeUF1TGk4dUxpOXViMlJsWDIxdlpIVnNaWE12UUdGcmFYUmhMWEJ5YjNSdlkyOXNMM0JzZFdkcGJpOW1kVzVqZEdsdmJuTXVkSE02TVRRMUNpQWdJQ0F2THlCeVpYUjFjbTRnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdJZ2NHRjVYM1JsY201aGNubGZiV1Z5WjJWQU5nb0tjR0Y1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFU2Q2lBZ0lDQXZMeUF1TGk4dUxpOXViMlJsWDIxdlpIVnNaWE12UUdGcmFYUmhMWEJ5YjNSdlkyOXNMM0JzZFdkcGJpOW1kVzVqZEdsdmJuTXVkSE02TVRRM0NpQWdJQ0F2THlCeVpYUjFjbTRnZDJGc2JHVjBMbUZrWkhKbGMzTUtJQ0FnSUdScFp5QTRDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCQlpHUnlaWE56Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnWlhocGMzUnpDaUFnSUNCaUlIQmhlVjkwWlhKdVlYSjVYMjFsY21kbFFEWUtDbkJoZVY5aFpuUmxjbDkzYUdsc1pVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5MWJteHBiV2wwWldRdGNHRjVMWEJzZFdkcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QndZWGtvZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2Yml3Z2NtVnJaWGxDWVdOck9pQmliMjlzWldGdUxDQndZWGx0Wlc1MGN6b2dVR0Y1VUdGeVlXMXpXMTBwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFRQXdNUnRCQUJpQUJQbHpoSkkyR2dDT0FRQUJBREVaRkRFWUVFUkNBQWd4R1JReEdCUVFRellhQVVrVmdRZ1NSQmRKTmhvQ1NSVWlFa1FqVTB3MkdnTkpUZ0pKSTFsSlRnTWtDNEVDQ0V3VkVrU0FFSE53Wlc1a2FXNW5YMkZrWkhKbGMzTmxTRWxPQW5NQ1JESUtFa0FBRDRBTFJWSlNPbVZ5Y2s1aGRHaXdBQ05KU3dJTVFRQjVTd05YQWdCTEFVbE9BaVFMSkZoSlZ3QWdUZ1JKZ1NCYlRnT0JLRnRPQTBzRUlna01RUUJBTWdOTEFrQUFIVThDU0xHeUlFeXlDRThDc2dkTEFySUFJcklRSTdJQnN5SUlRdit1c2JJZ1RMSVJUTElTVHdLeUZFc0NzZ0NCQkxJUUk3SUJzMEwvMzBzSFFBQUZNZ05DLzdoTENISUlSRUwvc0NKRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
