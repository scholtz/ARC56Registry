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

namespace Arc56.Generated.swanandi_bhende.mercator.Escrow_b06d1b7c
{


    //
    // Escrow settlement tracking for x402 micropayments.
    //    
    //    State:
    //        registry_app_id: Global reference to AgentRegistry app (UInt64).
    //        unlocked_listings: BoxMap(listing_id => UnlockRecord) recording buyer access grants.
    //    
    //    Purpose: Immutable on-chain proof that buyer paid for and accessed specific listing.
    //    
    //
    public class EscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class UnlockRecord : AVMObjectType
            {
                public Algorand.Address Buyer { get; set; }

                public bool Unlocked { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vBuyer.From(Buyer);
                    ret.AddRange(vBuyer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnlocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vUnlocked.From(Unlocked);
                    ret.AddRange(vUnlocked.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static UnlockRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new UnlockRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBuyer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBuyer = vBuyer.ToValue();
                    if (valueBuyer is Algorand.Address vBuyerValue) { ret.Buyer = vBuyerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnlocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vUnlocked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUnlocked = vUnlocked.ToValue();
                    if (valueUnlocked is bool vUnlockedValue) { ret.Unlocked = vUnlockedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as UnlockRecord);
                }
                public bool Equals(UnlockRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(UnlockRecord left, UnlockRecord right)
                {
                    return EqualityComparer<UnlockRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(UnlockRecord left, UnlockRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Record buyer access after x402 payment confirmed on-chain.
        ///Purpose: Post-payment gate. Called by post_payment_flow after x402 tx confirmed + indexed. Atomically validates that **transaction sender is the buyer** (prevents spoofing).
        ///Actions: 1. Assert op.Txn.sender == buyer.native (confirms caller is buyer's wallet). 2. Store UnlockRecord in boxes: {buyer, unlocked=True}. 3. Return True to signal success.
        ///</summary>
        /// <param name="buyer">Algorand wallet address of the buyer (must match tx sender). </param>
        /// <param name="listing_id">InsightListing ID that buyer paid for. </param>
        public async Task<bool> ReleaseAfterPayment(Algorand.Address buyer, ulong listing_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 99, 19, 83 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);

            var result = await base.CallApp(new List<object> { abiHandle, buyerAbi, listing_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ReleaseAfterPayment_Transactions(Algorand.Address buyer, ulong listing_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 99, 19, 83 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, buyerAbi, listing_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93IiwiZGVzYyI6IkVzY3JvdyBzZXR0bGVtZW50IHRyYWNraW5nIGZvciB4NDAyIG1pY3JvcGF5bWVudHMuXG4gICAgXG4gICAgU3RhdGU6XG4gICAgICAgIHJlZ2lzdHJ5X2FwcF9pZDogR2xvYmFsIHJlZmVyZW5jZSB0byBBZ2VudFJlZ2lzdHJ5IGFwcCAoVUludDY0KS5cbiAgICAgICAgdW5sb2NrZWRfbGlzdGluZ3M6IEJveE1hcChsaXN0aW5nX2lkID0+IFVubG9ja1JlY29yZCkgcmVjb3JkaW5nIGJ1eWVyIGFjY2VzcyBncmFudHMuXG4gICAgXG4gICAgUHVycG9zZTogSW1tdXRhYmxlIG9uLWNoYWluIHByb29mIHRoYXQgYnV5ZXIgcGFpZCBmb3IgYW5kIGFjY2Vzc2VkIHNwZWNpZmljIGxpc3RpbmcuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlVubG9ja1JlY29yZCI6W3sibmFtZSI6ImJ1eWVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJ1bmxvY2tlZCIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InJlbGVhc2VfYWZ0ZXJfcGF5bWVudCIsImRlc2MiOiJSZWNvcmQgYnV5ZXIgYWNjZXNzIGFmdGVyIHg0MDIgcGF5bWVudCBjb25maXJtZWQgb24tY2hhaW4uXG5QdXJwb3NlOiBQb3N0LXBheW1lbnQgZ2F0ZS4gQ2FsbGVkIGJ5IHBvc3RfcGF5bWVudF9mbG93IGFmdGVyIHg0MDIgdHggY29uZmlybWVkICsgaW5kZXhlZC4gQXRvbWljYWxseSB2YWxpZGF0ZXMgdGhhdCAqKnRyYW5zYWN0aW9uIHNlbmRlciBpcyB0aGUgYnV5ZXIqKiAocHJldmVudHMgc3Bvb2ZpbmcpLlxuQWN0aW9uczogMS4gQXNzZXJ0IG9wLlR4bi5zZW5kZXIgPT0gYnV5ZXIubmF0aXZlIChjb25maXJtcyBjYWxsZXIgaXMgYnV5ZXIncyB3YWxsZXQpLiAyLiBTdG9yZSBVbmxvY2tSZWNvcmQgaW4gYm94ZXM6IHtidXllciwgdW5sb2NrZWQ9VHJ1ZX0uIDMuIFJldHVybiBUcnVlIHRvIHNpZ25hbCBzdWNjZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnV5ZXIiLCJkZXNjIjoiQWxnb3JhbmQgd2FsbGV0IGFkZHJlc3Mgb2YgdGhlIGJ1eWVyIChtdXN0IG1hdGNoIHR4IHNlbmRlcikuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsaXN0aW5nX2lkIiwiZGVzYyI6Ikluc2lnaHRMaXN0aW5nIElEIHRoYXQgYnV5ZXIgcGFpZCBmb3IuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUcnVlIGlmIHVubG9jayByZWNvcmRlZCBzdWNjZXNzZnVsbHkuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNDVdLCJlcnJvck1lc3NhZ2UiOiJCdXllciBtdXN0IGJlIHJlZ2lzdGVyZWQgaW4gQWdlbnRSZWdpc3RyeSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0XSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUgYnV5ZXIgY2FuIHJlbGVhc2UgYWZ0ZXIgcGF5bWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMl0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGxvZyB2YWx1ZSBpcyBub3QgdGhlIHJlc3VsdCBvZiBhbiBBQkkgcmV0dXJuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODgsOTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlZ2lzdHJ5X2FwcF9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFS0lDQWdJR0o1ZEdWallteHZZMnNnSW5KbFoybHpkSEo1WDJGd2NGOXBaQ0lLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qTTNDaUFnSUNBdkx5QmpiR0Z6Y3lCRmMyTnliM2NvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRRGNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0V5TmpNeE16VXpJQzh2SUcxbGRHaHZaQ0FpY21Wc1pXRnpaVjloWm5SbGNsOXdZWGx0Wlc1MEtHRmtaSEpsYzNNc2RXbHVkRFkwS1dKdmIyd2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgzSmxiR1ZoYzJWZllXWjBaWEpmY0dGNWJXVnVkRjl5YjNWMFpVQTFDaUFnSUNCbGNuSUtDbTFoYVc1ZmNtVnNaV0Z6WlY5aFpuUmxjbDl3WVhsdFpXNTBYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OWxjMk55YjNjdmMyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUlISmxiR1ZoYzJWZllXWjBaWEpmY0dGNWJXVnVkQW9LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBM09nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WlhOamNtOTNMbU52Ym5SeVlXTjBMa1Z6WTNKdmR5NXlaV3hsWVhObFgyRm1kR1Z5WDNCaGVXMWxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXeGxZWE5sWDJGbWRHVnlYM0JoZVcxbGJuUTZDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OWxjMk55YjNjdmMyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OWxjMk55YjNjdmMyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvNE5DMDROUW9nSUNBZ0x5OGdJeUJRYjNOMExYQmhlVzFsYm5RZ2NtVnNaV0Z6WlNCd1lYUm9PaUJpZFhsbGNpQmthWEpsWTNSc2VTQmpZV3hzY3lCbGMyTnliM2NnWVdaMFpYSWdjR0Y1YldWdWRDQmpiMjVtYVhKdFlYUnBiMjR1Q2lBZ0lDQXZMeUJoYzNObGNuUWdiM0F1VkhodUxuTmxibVJsY2lBOVBTQmlkWGxsY2k1dVlYUnBkbVVzSUNKUGJteDVJSFJvWlNCaWRYbGxjaUJqWVc0Z2NtVnNaV0Z6WlNCaFpuUmxjaUJ3WVhsdFpXNTBJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlIUm9aU0JpZFhsbGNpQmpZVzRnY21Wc1pXRnpaU0JoWm5SbGNpQndZWGx0Wlc1MENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5bGMyTnliM2N2YzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG80TnkwNE9Bb2dJQ0FnTHk4Z0l5QlBjSFJwYjI1aGJHeDVJR05vWldOcklHSjFlV1Z5SUdseklISmxaMmx6ZEdWeVpXUWdhVzRnUVdkbGJuUlNaV2RwYzNSeWVTQW9hV1lnY21WbmFYTjBjbmxmWVhCd1gybGtJR2x6SUhObGRDa0tJQ0FnSUM4dklHbG1JSE5sYkdZdWNtVm5hWE4wY25sZllYQndYMmxrTG5aaGJIVmxJQ0U5SUZWSmJuUTJOQ2d3S1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p5WldkcGMzUnllVjloY0hCZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21WbmFYTjBjbmxmWVhCd1gybGtJR1Y0YVhOMGN3b2dJQ0FnWW5vZ2NtVnNaV0Z6WlY5aFpuUmxjbDl3WVhsdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2T0RrdE9UTUtJQ0FnSUM4dklHbHpYM0psWjJsemRHVnlaV1FzSUhSNGJpQTlJR0Z5WXpRdVlXSnBYMk5oYkd4YllYSmpOQzVDYjI5c1hTZ0tJQ0FnSUM4dklDQWdJQ0FpYVhOZmNtVm5hWE4wWlhKbFpDaGhaR1J5WlhOektXSnZiMndpTEFvZ0lDQWdMeThnSUNBZ0lHSjFlV1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxelpXeG1MbkpsWjJsemRISjVYMkZ3Y0Y5cFpDNTJZV3gxWlN3S0lDQWdJQzh2SUNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qa3lDaUFnSUNBdkx5QmhjSEJmYVdROWMyVnNaaTV5WldkcGMzUnllVjloY0hCZmFXUXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY21WbmFYTjBjbmxmWVhCd1gybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5KbFoybHpkSEo1WDJGd2NGOXBaQ0JsZUdsemRITUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZaWE5qY205M0wzTnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk9Ea3RPVE1LSUNBZ0lDOHZJR2x6WDNKbFoybHpkR1Z5WldRc0lIUjRiaUE5SUdGeVl6UXVZV0pwWDJOaGJHeGJZWEpqTkM1Q2IyOXNYU2dLSUNBZ0lDOHZJQ0FnSUNBaWFYTmZjbVZuYVhOMFpYSmxaQ2hoWkdSeVpYTnpLV0p2YjJ3aUxBb2dJQ0FnTHk4Z0lDQWdJR0oxZVdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5cFpEMXpaV3htTG5KbFoybHpkSEo1WDJGd2NGOXBaQzUyWVd4MVpTd0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEa3hPV013TW1SbUlDOHZJRzFsZEdodlpDQWlhWE5mY21WbmFYTjBaWEpsWkNoaFpHUnlaWE56S1dKdmIyd2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQnNiMmNnZG1Gc2RXVWdhWE1nYm05MElIUm9aU0J5WlhOMWJIUWdiMllnWVc0Z1FVSkpJSEpsZEhWeWJnb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5bGMyTnliM2N2YzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG81TkFvZ0lDQWdMeThnWVhOelpYSjBJR2x6WDNKbFoybHpkR1Z5WldRc0lDSkNkWGxsY2lCdGRYTjBJR0psSUhKbFoybHpkR1Z5WldRZ2FXNGdRV2RsYm5SU1pXZHBjM1J5ZVNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJRUoxZVdWeUlHMTFjM1FnWW1VZ2NtVm5hWE4wWlhKbFpDQnBiaUJCWjJWdWRGSmxaMmx6ZEhKNUNncHlaV3hsWVhObFgyRm1kR1Z5WDNCaGVXMWxiblJmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZaWE5qY205M0wzTnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk9UWXRPVGtLSUNBZ0lDOHZJSE5sYkdZdWRXNXNiMk5yWldSZmJHbHpkR2x1WjNOYmJHbHpkR2x1WjE5cFpGMGdQU0JWYm14dlkydFNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdZblY1WlhJOVluVjVaWElzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXNiMk5yWldROVlYSmpOQzVDYjI5c0tGUnlkV1VwTEFvZ0lDQWdMeThnS1FvZ0lDQWdaR2xuSURFS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJWelkzSnZkeTl6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPams0Q2lBZ0lDQXZMeUIxYm14dlkydGxaRDFoY21NMExrSnZiMndvVkhKMVpTa3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzRNQW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZaWE5qY205M0wzTnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk9UWXRPVGtLSUNBZ0lDOHZJSE5sYkdZdWRXNXNiMk5yWldSZmJHbHpkR2x1WjNOYmJHbHpkR2x1WjE5cFpGMGdQU0JWYm14dlkydFNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdZblY1WlhJOVluVjVaWElzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXNiMk5yWldROVlYSmpOQzVDYjI5c0tGUnlkV1VwTEFvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5bGMyTnliM2N2YzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG81TmdvZ0lDQWdMeThnYzJWc1ppNTFibXh2WTJ0bFpGOXNhWE4wYVc1bmMxdHNhWE4wYVc1blgybGtYU0E5SUZWdWJHOWphMUpsWTI5eVpDZ0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEYzFObVUyWXpabU5qTTJZZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12WlhOamNtOTNMM050WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZPVFl0T1RrS0lDQWdJQzh2SUhObGJHWXVkVzVzYjJOclpXUmZiR2x6ZEdsdVozTmJiR2x6ZEdsdVoxOXBaRjBnUFNCVmJteHZZMnRTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnWW5WNVpYSTlZblY1WlhJc0NpQWdJQ0F2THlBZ0lDQWdkVzVzYjJOclpXUTlZWEpqTkM1Q2IyOXNLRlJ5ZFdVcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZaWE5qY205M0wzTnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBQUVtQVE5eVpXZHBjM1J5ZVY5aGNIQmZhV1F4RzBFQUdJQUVvbU1UVXpZYUFJNEJBQUVBTVJrVU1SZ1FSRUlBQ0RFWkZERVlGQkJETmhvQlJ3SVZnU0FTUkRZYUFrbE9BaFdCQ0JKRU1RQVNSQ0lvWlVSQkFEYXhJaWhsUkxJWWdBU1JuQUxmc2hwTEFiSWFnUWF5RUNLeUFiTzBQa2xYQUFTQUJCVWZmSFVTUkZjRUFFa1ZJeEpFZ0FFQUUwUkxBWUFCZ0ZDQUJuVnViRzlqYTBzQ1VFeS9nQVVWSDN4MWdMQWpRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
