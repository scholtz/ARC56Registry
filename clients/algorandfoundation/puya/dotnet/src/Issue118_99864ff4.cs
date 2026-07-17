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

namespace Arc56.Generated.algorandfoundation.puya.Issue118_99864ff4
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSXNzdWUxMTgiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVmVyaWZ5UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InZlcmlmeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsc3RyaW5nKSIsInN0cnVjdCI6IlZlcmlmeVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50MjU2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJRElLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd3TURBek1EQXdNQW9nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXBjM04xWlY4eE1UZ3VjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdTWE56ZFdVeE1UZ29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFEVUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHSmpOalpsWWpZeUlDOHZJRzFsZEdodlpDQWlkbVZ5YVdaNUtIVnBiblF5TlRaYlhTa29ZbTl2YkN4emRISnBibWNwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDkyWlhKcFpubGZjbTkxZEdWQU13b2dJQ0FnWlhKeUNncHRZV2x1WDNabGNtbG1lVjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXBjM04xWlY4eE1UZ3VjSGs2TmkwM0NpQWdJQ0F2THlBaklISmxaam9nYUhSMGNITTZMeTluYVhSb2RXSXVZMjl0TDJGc1oyOXlZVzVrWm05MWJtUmhkR2x2Ymk5d2RYbGhMMmx6YzNWbGN5OHhNVGdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JpSUhabGNtbG1lUW9LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBMU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxuSmxaM0psYzNOcGIyNWZkR1Z6ZEhNdWFYTnpkV1ZmTVRFNExrbHpjM1ZsTVRFNExuWmxjbWxtZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVRvS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YVhOemRXVmZNVEU0TG5CNU9qWXROd29nSUNBZ0x5OGdJeUJ5WldZNklHaDBkSEJ6T2k4dloybDBhSFZpTG1OdmJTOWhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZjSFY1WVM5cGMzTjFaWE12TVRFNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWRESTFOajRLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZhWE56ZFdWZk1URTRMbkI1T2pFd0NpQWdJQ0F2THlCaWIyOXNLRlI0Ymk1dWRXMWZZWEJ3WDJGeVozTXBDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJsemMzVmxYekV4T0M1d2VUbzVMVEV4Q2lBZ0lDQXZMeUIyWVd3eElEMGdRbTl2YkNnS0lDQWdJQzh2SUNBZ0lDQmliMjlzS0ZSNGJpNXVkVzFmWVhCd1gyRnlaM01wQ2lBZ0lDQXZMeUFwSUNBaklIVnpaU0JoSUc1dmJpQmpiMjV6ZEdGdWRDQjJZV3gxWlNCemJ5QjBhR1VnY21Wd1pXRjBaV1FnWlhod2NtVnpjMmx2YmlCcGN5QnViM1FnYzJsdGNHeHBabWxsWkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXBjM04xWlY4eE1UZ3VjSGs2TVRJS0lDQWdJQzh2SUdsbUlIWmhiSFZsY3k1c1pXNW5kR2dnSVQwZ01qb0tJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FoUFFvZ0lDQWdZbm9nZG1WeWFXWjVYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5cGMzTjFaVjh4TVRndWNIazZNVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQlVkWEJzWlNnb2RtRnNNU3dnVTNSeWFXNW5LQ0lpS1NrcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNekF3TURBS0lDQWdJR052Ym1OaGRBb0tkbVZ5YVdaNVgyRm1kR1Z5WDJsdWJHbHVaV1JmZEdWemRGOWpZWE5sY3k1eVpXZHlaWE56YVc5dVgzUmxjM1J6TG1semMzVmxYekV4T0M1SmMzTjFaVEV4T0M1MlpYSnBabmxBTkRvS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YVhOemRXVmZNVEU0TG5CNU9qWXROd29nSUNBZ0x5OGdJeUJ5WldZNklHaDBkSEJ6T2k4dloybDBhSFZpTG1OdmJTOWhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZjSFY1WVM5cGMzTjFaWE12TVRFNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2dwMlpYSnBabmxmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXBjM04xWlY4eE1UZ3VjSGs2TVRRS0lDQWdJQzh2SUhKbGRIVnliaUJVZFhCc1pTZ29kbUZzTVN3Z1UzUnlhVzVuS0NJaUtTa3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TXpBd01EQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXBjM04xWlY4eE1UZ3VjSGs2TmkwM0NpQWdJQ0F2THlBaklISmxaam9nYUhSMGNITTZMeTluYVhSb2RXSXVZMjl0TDJGc1oyOXlZVzVrWm05MWJtUmhkR2x2Ymk5d2RYbGhMMmx6YzNWbGN5OHhNVGdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHSWdkbVZ5YVdaNVgyRm1kR1Z5WDJsdWJHbHVaV1JmZEdWemRGOWpZWE5sY3k1eVpXZHlaWE56YVc5dVgzUmxjM1J6TG1semMzVmxYekV4T0M1SmMzTjFaVEV4T0M1MlpYSnBabmxBTkFvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBQUltQVFRQUF3QUFNUnRCQUJpQUJMeG02MkkyR2dDT0FRQUJBREVaRkRFWUVFUkNBQWd4R1JReEdCUVFRellhQVVraVdVbUJJQXNqQ0U4Q0ZSSkVNUnNpRTRBQkFDSlBBbFJNSXhOQkFBNG9VSUFFRlI5OGRVeFFzSUVCUXloUVF2L3YiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
