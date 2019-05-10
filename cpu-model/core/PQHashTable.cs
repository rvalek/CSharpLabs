using System;
using System.Collections.Generic;

namespace cpu_model.core {
    internal class PQHashTable<TEntity> : PriorityQueue<TEntity> where TEntity : IComparable {
        private LinkedList<TEntity>[] body;
        private int topPriority = -1;
        public new int Count {
            get {
                base.Count();
                return Count;
            }
            private set {
            }
        }

        public PQHashTable(int lowestPriority, int highestPriority) {
            int size = 1 + lowestPriority - highestPriority;
            body = new LinkedList<TEntity>[size];
        }

        public override void Put(TEntity e) {
            base.Put(e);

            int index = e.GetHashCode() % body.Length;

            if (body[index] == null) {
                body[index] = new LinkedList<TEntity>();
            }

            body[index].AddFirst(e);

            topPriority = index > topPriority ? index : topPriority;
            Count += 1;
        }

        public override TEntity Item() {
            return body[topPriority].Last.Value;
        }

        public override void Clear() {
            base.Clear();

            for (int i = body.Length; i >= 0; i -= 1) {
                body[i] = null;
            }
            topPriority = -1;

            Count = 0;
        }

        public override void Remove() {
            base.Remove();

            if (body[topPriority].Count > 1) {
                body[topPriority].RemoveLast();
            } else {
                body[topPriority] = null;

                topPriority = findCurrentTop();
            }

            Count -= 1;
        }

        private int findCurrentTop() {
            for (int i = body.Length; i >= 0; i -= 1) {
                if (body[i] != null) {
                    return i;
                }
            }

            return -1;
        }


        public override TEntity[] ToArray() {
            throw new NotImplementedException();
        }
    }
}
