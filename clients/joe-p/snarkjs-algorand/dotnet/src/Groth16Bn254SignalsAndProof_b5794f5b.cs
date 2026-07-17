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

namespace Arc56.Generated.joe_p.snarkjs_algorand.Groth16Bn254SignalsAndProof_b5794f5b
{


    public class Groth16Bn254SignalsAndProofProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Groth16Bn254SignalsAndProofProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Groth16Bn254Proof : AVMObjectType
            {
                public byte[] PiA { get; set; }

                public byte[] PiB { get; set; }

                public byte[] PiC { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    vPiA.From(PiA);
                    ret.AddRange(vPiA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[128]");
                    vPiB.From(PiB);
                    ret.AddRange(vPiB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    vPiC.From(PiC);
                    ret.AddRange(vPiC.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Groth16Bn254Proof Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Groth16Bn254Proof();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vPiA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePiA = vPiA.ToValue();
                    if (valuePiA is byte[] vPiAValue) { ret.PiA = vPiAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[128]");
                    count = vPiB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePiB = vPiB.ToValue();
                    if (valuePiB is byte[] vPiBValue) { ret.PiB = vPiBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vPiC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePiC = vPiC.ToValue();
                    if (valuePiC is byte[] vPiCValue) { ret.PiC = vPiCValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Groth16Bn254Proof);
                }
                public bool Equals(Groth16Bn254Proof? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Groth16Bn254Proof left, Groth16Bn254Proof right)
                {
                    return EqualityComparer<Groth16Bn254Proof>.Default.Equals(left, right);
                }
                public static bool operator !=(Groth16Bn254Proof left, Groth16Bn254Proof right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="signals"> </param>
        /// <param name="proof"> Groth16Bn254Proof</param>
        public async Task SignalsAndProof(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.Groth16Bn254Proof proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 78, 208, 193 };
            var signalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); signalsAbi.From(signals);

            var result = await base.CallApp(new List<object> { abiHandle, signalsAbi, proof }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SignalsAndProof_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.Groth16Bn254Proof proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 78, 208, 193 };
            var signalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); signalsAbi.From(signals);

            return await base.MakeTransactionList(new List<object> { abiHandle, signalsAbi, proof }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3JvdGgxNkJuMjU0U2lnbmFsc0FuZFByb29mIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ikdyb3RoMTZCbjI1NFByb29mIjpbeyJuYW1lIjoicGlfYSIsInR5cGUiOiJieXRlWzY0XSJ9LHsibmFtZSI6InBpX2IiLCJ0eXBlIjoiYnl0ZVsxMjhdIn0seyJuYW1lIjoicGlfYyIsInR5cGUiOiJieXRlWzY0XSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzaWduYWxzQW5kUHJvb2YiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NltdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmFscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKGJ5dGVbNjRdLGJ5dGVbMTI4XSxieXRlWzY0XSkiLCJzdHJ1Y3QiOiJHcm90aDE2Qm4yNTRQcm9vZiIsIm5hbWUiOiJwcm9vZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDI1Nj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBjb250cmFjdHMvZ3JvdGgxNl9ibjI1NC5hbGdvLnRzOjpHcm90aDE2Qm4yNTRQcm9vZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJqSTFORjkyWlhKcFptbGxjaTVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1IzSnZkR2d4TmtKdU1qVTBVMmxuYm1Gc2MwRnVaRkJ5YjI5bUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFUwTkdWa01HTXhJQzh2SUcxbGRHaHZaQ0FpYzJsbmJtRnNjMEZ1WkZCeWIyOW1LSFZwYm5ReU5UWmJYU3dvWW5sMFpWczJORjBzWW5sMFpWc3hNamhkTEdKNWRHVmJOalJkS1NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOXphV2R1WVd4elFXNWtVSEp2YjJaZmNtOTFkR1ZBTXdvZ0lDQWdaWEp5Q2dwdFlXbHVYM05wWjI1aGJITkJibVJRY205dlpsOXliM1YwWlVBek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFJmZG1WeWFXWnBaWEl1WVd4bmJ5NTBjem8yTWkwMk5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhOcFoyNWhiSE5CYm1SUWNtOXZaaWdLSUNBZ0lDOHZJQ0FnYzJsbmJtRnNjem9nVUhWaWJHbGpVMmxuYm1Gc2N5d0tJQ0FnSUM4dklDQWdjSEp2YjJZNklFZHliM1JvTVRaQ2JqSTFORkJ5YjI5bUxBb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN2ZRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHSWdjMmxuYm1Gc2MwRnVaRkJ5YjI5bUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUExT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW00eU5UUmZkbVZ5YVdacFpYSXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVkeWIzUm9NVFpDYmpJMU5GTnBaMjVoYkhOQmJtUlFjbTl2WmlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW00eU5UUmZkbVZ5YVdacFpYSXVZV3huYnk1MGN6bzZSM0p2ZEdneE5rSnVNalUwVTJsbmJtRnNjMEZ1WkZCeWIyOW1Mbk5wWjI1aGJITkJibVJRY205dlpsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5wWjI1aGJITkJibVJRY205dlpqb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnVNalUwWDNabGNtbG1hV1Z5TG1Gc1oyOHVkSE02TmpJdE5qVUtJQ0FnSUM4dklIQjFZbXhwWXlCemFXZHVZV3h6UVc1a1VISnZiMllvQ2lBZ0lDQXZMeUFnSUhOcFoyNWhiSE02SUZCMVlteHBZMU5wWjI1aGJITXNDaUFnSUNBdkx5QWdJSEJ5YjI5bU9pQkhjbTkwYURFMlFtNHlOVFJRY205dlppd0tJQ0FnSUM4dklDazZJSFp2YVdRZ2UzMEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkREkxTmo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXlOVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnVNalUwTG1Gc1oyOHVkSE02T2tkeWIzUm9NVFpDYmpJMU5GQnliMjltQ2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3pFYlFRQVlnQVJVVHREQk5ob0FqZ0VBQVFBeEdSUXhHQkJFUWdBSU1Sa1VNUmdVRUVNMkdnRkpnUUJaZ1NBTGdRSUlUQlVTUkRZYUFoV0JnQUlTUklFQlF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
