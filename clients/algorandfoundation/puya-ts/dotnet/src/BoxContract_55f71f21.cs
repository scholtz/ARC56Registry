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

namespace Arc56.Generated.algorandfoundation.puya_ts.BoxContract_55f71f21
{


    public class BoxContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BoxContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ReadEnumsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ReadEnumsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ReadEnumsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReadEnumsReturn);
                }
                public bool Equals(ReadEnumsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReadEnumsReturn left, ReadEnumsReturn right)
                {
                    return EqualityComparer<ReadEnumsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(ReadEnumsReturn left, ReadEnumsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task StoreEnums(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 108, 109, 66 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StoreEnums_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 108, 109, 66 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.ReadEnumsReturn> ReadEnums(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 24, 108, 247 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ReadEnumsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReadEnums_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 24, 108, 247 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQm94Q29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUmVhZEVudW1zUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoic3RvcmVfZW51bXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVhZF9lbnVtcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJSZWFkRW51bXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE2NCwxNzUsMTgyLDE4N10sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklDSnZZMkVpSUNKMGVHNGlDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFERUtDbTFoYVc1ZllteHZZMnRBTVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndFpXNTFiUzFqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQ2IzaERiMjUwY21GamRDQmxlSFJsYm1SeklHRnlZelF1UTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQWhQUW9nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBT1FvZ0lDQWdZaUJ0WVdsdVgyRmlhVjl5YjNWMGFXNW5RRElLQ20xaGFXNWZZV0pwWDNKdmRYUnBibWRBTWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndFpXNTFiUzFqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQ2IzaERiMjUwY21GamRDQmxlSFJsYm1SeklHRnlZelF1UTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SUU1dlQzQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU53b2dJQ0FnWWlCdFlXbHVYMk5oYkd4ZlRtOVBjRUF6Q2dwdFlXbHVYMk5oYkd4ZlRtOVBjRUF6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxbGJuVnRMV052Ym5SeVlXTjBMbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVKdmVFTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1lYSmpOQzVEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhtTWpaak5tUTBNaUF2THlCdFpYUm9iMlFnSW5OMGIzSmxYMlZ1ZFcxektDbDJiMmxrSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WldZeE9EWmpaamNnTHk4Z2JXVjBhRzlrSUNKeVpXRmtYMlZ1ZFcxektDa29kV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHMWhkR05vSUcxaGFXNWZjM1J2Y21WZlpXNTFiWE5mY205MWRHVkFOQ0J0WVdsdVgzSmxZV1JmWlc1MWJYTmZjbTkxZEdWQU5Rb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOZ29LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEWTZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTRDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFd0NncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFdWdWRXMHRZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUW05NFEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCaGNtTTBMa052Ym5SeVlXTjBJSHNLSUNBZ0lHVnljZ29LYldGcGJsOXlaV0ZrWDJWdWRXMXpYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMV1Z1ZFcwdFkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2JtRnRaVG9nSjNKbFlXUmZaVzUxYlhNbklIMHBDaUFnSUNCallXeHNjM1ZpSUhKbFlXUkZiblZ0Y3dvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5nb0tiV0ZwYmw5emRHOXlaVjlsYm5WdGMxOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMWxiblZ0TFdOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnYm1GdFpUb2dKM04wYjNKbFgyVnVkVzF6SnlCOUtRb2dJQ0FnWTJGc2JITjFZaUJ6ZEc5eVpVVnVkVzF6Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBMkNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEYzZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTRDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBNU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMWxiblZ0TFdOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFSnZlRU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdZWEpqTkM1RGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdOaGJHeHpkV0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMWxiblZ0TFdOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tKdmVFTnZiblJ5WVdOMExuTjBiM0psUlc1MWJYTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZEc5eVpVVnVkVzF6T2dvZ0lDQWdZaUJ6ZEc5eVpVVnVkVzF6WDJKc2IyTnJRREFLQ25OMGIzSmxSVzUxYlhOZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndFpXNTFiUzFqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJRzVoYldVNklDZHpkRzl5WlY5bGJuVnRjeWNnZlNrS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzFsYm5WdExXTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSnZlRU52Ym5SeVlXTjBMbk4wYjNKbFJXNTFiWE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMV1Z1ZFcwdFkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtOTRRMjl1ZEhKaFkzUXVjbVZoWkVWdWRXMXpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WaFpFVnVkVzF6T2dvZ0lDQWdZaUJ5WldGa1JXNTFiWE5mWW14dlkydEFNQW9LY21WaFpFVnVkVzF6WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFdWdWRXMHRZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dibUZ0WlRvZ0ozSmxZV1JmWlc1MWJYTW5JSDBwQ2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RaVzUxYlMxamIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQ2IzaERiMjUwY21GamRDNXlaV0ZrUlc1MWJYTUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzFsYm5WdExXTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSnZlRU52Ym5SeVlXTjBMbk4wYjNKbFJXNTFiWE1vS1NBdFBpQjJiMmxrT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExXVnVkVzB0WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UW05NFEyOXVkSEpoWTNRdWMzUnZjbVZGYm5WdGN6b0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMWxiblZ0TFdOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tKdmVFTnZiblJ5WVdOMExuTjBiM0psUlc1MWJYTmZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzFsYm5WdExXTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSnZlRU52Ym5SeVlXTjBMbk4wYjNKbFJXNTFiWE5mWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Wlc1MWJTMWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QjBhR2x6TG05allTNTJZV3gxWlNBOUlFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVQzQjBTVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMV1Z1ZFcwdFkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCdlkyRWdQU0JDYjNnOFQyNURiMjF3YkdWMFpVRmpkR2x2Ymo0b2V5QnJaWGs2SUVKNWRHVnpLQ2R2WTJFbktTQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWliMk5oSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxbGJuVnRMV052Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJSFJvYVhNdWIyTmhMblpoYkhWbElEMGdUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNVBjSFJKYmdvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFdWdWRXMHRZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdkR2hwY3k1MGVHNHVkbUZzZFdVZ1BTQlVjbUZ1YzJGamRHbHZibFI1Y0dVdVFYQndiR2xqWVhScGIyNURZV3hzQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RaVzUxYlMxamIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUhSNGJpQTlJRUp2ZUR4VWNtRnVjMkZqZEdsdmJsUjVjR1UrS0hzZ2EyVjVPaUJDZVhSbGN5Z25kSGh1SnlrZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUjRiaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Wlc1MWJTMWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QjBhR2x6TG5SNGJpNTJZV3gxWlNBOUlGUnlZVzV6WVdOMGFXOXVWSGx3WlM1QmNIQnNhV05oZEdsdmJrTmhiR3dLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzFsYm5WdExXTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSnZlRU52Ym5SeVlXTjBMbkpsWVdSRmJuVnRjeWdwSUMwK0lHSjVkR1Z6T2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExXVnVkVzB0WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UW05NFEyOXVkSEpoWTNRdWNtVmhaRVZ1ZFcxek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMWxiblZ0TFdOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRdE1UVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lHNWhiV1U2SUNkeVpXRmtYMlZ1ZFcxekp5QjlLUW9nSUNBZ0x5OGdjSFZpYkdsaklISmxZV1JGYm5WdGN5Z3BPaUJVZFhCc1pUeHlaV0ZrYjI1c2VTQmJWV2x1ZERZMExDQlZhVzUwTmpSZFBpQjdDaUFnSUNCd2NtOTBieUF3SURFS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxbGJuVnRMV052Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0p2ZUVOdmJuUnlZV04wTG5KbFlXUkZiblZ0YzE5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExXVnVkVzB0WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UW05NFEyOXVkSEpoWTNRdWNtVmhaRVZ1ZFcxelgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExXVnVkVzB0WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmdvZ0lDQWdMeThnWVhOelpYSjBLRzl3TGtKdmVDNW5aWFFvUW5sMFpYTW9KMjlqWVNjcEtWc3dYU0E5UFQwZ2IzQXVhWFJ2WWloMGFHbHpMbTlqWVM1MllXeDFaU2twQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2WTJFaUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFdWdWRXMHRZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QnZZMkVnUFNCQ2IzZzhUMjVEYjIxd2JHVjBaVUZqZEdsdmJqNG9leUJyWlhrNklFSjVkR1Z6S0NkdlkyRW5LU0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYjJOaElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMWxiblZ0TFdOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUdGemMyVnlkQ2h2Y0M1Q2IzZ3VaMlYwS0VKNWRHVnpLQ2R2WTJFbktTbGJNRjBnUFQwOUlHOXdMbWwwYjJJb2RHaHBjeTV2WTJFdWRtRnNkV1VwS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR0owYjJrS0lDQWdJR2wwYjJJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndFpXNTFiUzFqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJoYzNObGNuUW9iM0F1UW05NExtZGxkQ2hDZVhSbGN5Z25kSGh1SnlrcFd6QmRJRDA5UFNCdmNDNXBkRzlpS0hSb2FYTXVkSGh1TG5aaGJIVmxLU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblI0YmlJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Wlc1MWJTMWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklIUjRiaUE5SUVKdmVEeFVjbUZ1YzJGamRHbHZibFI1Y0dVK0tIc2dhMlY1T2lCQ2VYUmxjeWduZEhodUp5a2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblI0YmlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndFpXNTFiUzFqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJoYzNObGNuUW9iM0F1UW05NExtZGxkQ2hDZVhSbGN5Z25kSGh1SnlrcFd6QmRJRDA5UFNCdmNDNXBkRzlpS0hSb2FYTXVkSGh1TG5aaGJIVmxLU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFdWdWRXMHRZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QnZZMkVnUFNCQ2IzZzhUMjVEYjIxd2JHVjBaVUZqZEdsdmJqNG9leUJyWlhrNklFSjVkR1Z6S0NkdlkyRW5LU0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYjJOaElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMWxiblZ0TFdOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1ZIVndiR1VvYm1WM0lGVnBiblEyTkNoMGFHbHpMbTlqWVM1MllXeDFaU2tzSUc1bGR5QlZhVzUwTmpRb2RHaHBjeTUwZUc0dWRtRnNkV1VwS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR0owYjJrS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndFpXNTFiUzFqYjI1MGNtRmpkQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJSFI0YmlBOUlFSnZlRHhVY21GdWMyRmpkR2x2YmxSNWNHVStLSHNnYTJWNU9pQkNlWFJsY3lnbmRIaHVKeWtnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SNGJpSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RaVzUxYlMxamIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lGUjFjR3hsS0c1bGR5QlZhVzUwTmpRb2RHaHBjeTV2WTJFdWRtRnNkV1VwTENCdVpYY2dWV2x1ZERZMEtIUm9hWE11ZEhodUxuWmhiSFZsS1NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JpZEc5cENpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMV1Z1ZFcwdFkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtOTRRMjl1ZEhKaFkzUXVYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbEtDa2dMVDRnZG05cFpEb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbE9nb2dJQ0FnWWlCZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNQW9LWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxYMkpzYjJOclFEQTZDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFFbUFnTnZZMkVEZEhodVFnQUFRZ0FBTVJzaUUwRUFRa0lBQURFWkloSkVNUmdpRTBFQU1FSUFBRFlhQUlBRThteHRRb0FFN3hoczkwOENqZ0lBRUFBS1FnQUFRZ0FBUWdBQUFJZ0FJMEwvODRnQUZVTC83VUwvN1RFWkloSXhHQ0lTRUVTSUFGNGpRMElBQUlnQUZDTkRRZ0FBaUFBZGdBUVZIM3gxVHdGUXNDTkRRZ0FBSXhZb1R3Ry9nUVlXS1U4QnY0bUtBQUZDQUFBb3ZrNEJLTDVFRnhZU1JDbStUZ0VwdmtRWEZoSkVLTDVFRnhZcHZrUVhGb0FBVHdKUVR3RlFqQUNKUWdBQWlRPT0iLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
