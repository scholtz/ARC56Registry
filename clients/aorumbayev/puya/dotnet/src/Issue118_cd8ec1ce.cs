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

namespace Arc56.Generated.aorumbayev.puya.Issue118_cd8ec1ce
{


    public class Issue118Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Issue118Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class VerifyReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public string Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VerifyReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new VerifyReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VerifyReturn);
                }
                public bool Equals(VerifyReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VerifyReturn left, VerifyReturn right)
                {
                    return EqualityComparer<VerifyReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(VerifyReturn left, VerifyReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="values"> </param>
        public async Task<Structs.VerifyReturn> Verify(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] values, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 102, 235, 98 };
            var valuesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); valuesAbi.From(values);

            var result = await base.CallApp(new List<object> { abiHandle, valuesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.VerifyReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Verify_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] values, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 102, 235, 98 };
            var valuesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); valuesAbi.From(values);

            return await base.MakeTransactionList(new List<object> { abiHandle, valuesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSXNzdWUxMTgiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVmVyaWZ5UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InZlcmlmeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsc3RyaW5nKSIsInN0cnVjdCI6IlZlcmlmeVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd3TURBeklEQjRNREF3TUFvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlwYzNOMVpWOHhNVGd1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nU1hOemRXVXhNVGdvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQTJDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGlZelkyWldJMk1pQXZMeUJ0WlhSb2IyUWdJblpsY21sbWVTaDFhVzUwTWpVMlcxMHBLR0p2YjJ3c2MzUnlhVzVuS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmZG1WeWFXWjVYM0p2ZFhSbFFETUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TURvS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YVhOemRXVmZNVEU0TG5CNU9qVUtJQ0FnSUM4dklHTnNZWE56SUVsemMzVmxNVEU0S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzWmxjbWxtZVY5eWIzVjBaVUF6T2dvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlwYzNOMVpWOHhNVGd1Y0hrNk5pMDNDaUFnSUNBdkx5QWpJSEpsWmpvZ2FIUjBjSE02THk5bmFYUm9kV0l1WTI5dEwyRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOXdkWGxoTDJsemMzVmxjeTh4TVRnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlwYzNOMVpWOHhNVGd1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nU1hOemRXVXhNVGdvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmFYTnpkV1ZmTVRFNExuQjVPall0TndvZ0lDQWdMeThnSXlCeVpXWTZJR2gwZEhCek9pOHZaMmwwYUhWaUxtTnZiUzloYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2Y0hWNVlTOXBjM04xWlhNdk1URTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhabGNtbG1lUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEEyT2dvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlwYzNOMVpWOHhNVGd1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nU1hOemRXVXhNVGdvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV5WldkeVpYTnphVzl1WDNSbGMzUnpMbWx6YzNWbFh6RXhPQzVKYzNOMVpURXhPQzUyWlhKcFpua29kbUZzZFdWek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNuWmxjbWxtZVRvS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YVhOemRXVmZNVEU0TG5CNU9qWXRPQW9nSUNBZ0x5OGdJeUJ5WldZNklHaDBkSEJ6T2k4dloybDBhSFZpTG1OdmJTOWhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZjSFY1WVM5cGMzTjFaWE12TVRFNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdkbVZ5YVdaNUtITmxiR1lzSUhaaGJIVmxjem9nUkhsdVlXMXBZMEZ5Y21GNVcxVkpiblF5TlRaZEtTQXRQaUJVZFhCc1pWdENiMjlzTENCVGRISnBibWRkT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwybHpjM1ZsWHpFeE9DNXdlVG81TFRFeENpQWdJQ0F2THlCMllXd3hJRDBnUW05dmJDZ0tJQ0FnSUM4dklDQWdJQ0JpYjI5c0tGUjRiaTV1ZFcxZllYQndYMkZ5WjNNcENpQWdJQ0F2THlBcElDQWpJSFZ6WlNCaElHNXZiaUJqYjI1emRHRnVkQ0IyWVd4MVpTQnpieUIwYUdVZ2NtVndaV0YwWldRZ1pYaHdjbVZ6YzJsdmJpQnBjeUJ1YjNRZ2MybHRjR3hwWm1sbFpBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJsemMzVmxYekV4T0M1d2VUb3hNQW9nSUNBZ0x5OGdZbTl2YkNoVWVHNHViblZ0WDJGd2NGOWhjbWR6S1FvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YVhOemRXVmZNVEU0TG5CNU9qa3RNVEVLSUNBZ0lDOHZJSFpoYkRFZ1BTQkNiMjlzS0FvZ0lDQWdMeThnSUNBZ0lHSnZiMndvVkhodUxtNTFiVjloY0hCZllYSm5jeWtLSUNBZ0lDOHZJQ2tnSUNNZ2RYTmxJR0VnYm05dUlHTnZibk4wWVc1MElIWmhiSFZsSUhOdklIUm9aU0J5WlhCbFlYUmxaQ0JsZUhCeVpYTnphVzl1SUdseklHNXZkQ0J6YVcxd2JHbG1hV1ZrQ2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YVhOemRXVmZNVEU0TG5CNU9qRXlDaUFnSUNBdkx5QnBaaUIyWVd4MVpYTXViR1Z1WjNSb0lDRTlJREk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lDRTlDaUFnSUNCaWVpQjJaWEpwWm5sZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMmx6YzNWbFh6RXhPQzV3ZVRveE13b2dJQ0FnTHk4Z2NtVjBkWEp1SUZSMWNHeGxLQ2gyWVd3eExDQlRkSEpwYm1jb0lpSXBLU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tkbVZ5YVdaNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YVhOemRXVmZNVEU0TG5CNU9qRTBDaUFnSUNBdkx5QnlaWFIxY200Z1ZIVndiR1VvS0haaGJERXNJRk4wY21sdVp5Z2lJaWtwS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01ETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUVtQWdJQUF3SUFBREViUVFBbmdBUzhadXRpTmhvQWpnRUFBaUpETVJrVVJERVlSRFlhQVlnQUZvQUVGUjk4ZFV4UXNDTkRNUmxBLytFeEdCUkVJME9LQVFHQUFRQWlNUnRVaS84aVdZRUNFMEVBQlNoUUtWQ0pLRkFwVUlrPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
