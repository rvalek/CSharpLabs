using System;
using System.Diagnostics.Contracts;

namespace cpu_model.core {

    /// <summary>
    /// Абстрактный класс PriorityQueue{T} задает контейнер с доступом FIFO:
    /// Операции:
    /// создание Create: -> PriorityQueue{T}
    /// запросы:
    /// Item: PriorityQueue{T} -> T
    /// Empty: PriorityQueue{T} -> bool
    /// Count: PriorityQueue{T} -> int
    /// команды:
    /// Put: PriorityQueue{T} * T -> PriorityQueue{T}
    /// Remove: PriorityQueue{T} -> PriorityQueue{T}
    /// Clear: PriorityQueue{T} -> PriorityQueue{T}
    /// Аксиомы:
    /// Empty(Create)= true
    /// Далее q: PriorityQueue{T}, t: T
    /// Empty(Put(q, t)) = false
    /// Item(Put(q, t)) = t, если Empty(q) = true, и Item(q), если Empty(q) = false
    /// Remove(Put(q,t)) = Create, если Empty(q) = true, и Put(Remove(q), t), если
    /// Empty(q) = false
    /// Empty(Clear) = true
    /// </summary>
    /// 
    internal abstract class PriorityQueue<T> where T : IComparable {
        /// <summary>
        /// require: !empty();
        /// </summary>
        /// <returns>самый приоритетный</returns>
        [Pure]
        public virtual T Item() {
            Contract.Requires<QueueException>(!Empty(), "Нарушение контракта: попытка чтения из пустой очереди.");
            return default(T);
        }

        /// <summary>
        /// require: !empty();
        /// ensure: удален 1 элемент с самым высоким приоритетом
        /// </summary>
        public virtual void Remove() {
            Contract.Requires<QueueException>(!Empty(), "Нарушение контракта: попытка удаления из пустой очереди.");
            Contract.Ensures(Count() == Contract.OldValue<int>(Count()) - 1);
        }

        /// <param name="t"></param>
        public virtual void Put(T t) {
            Contract.Ensures(Count() == Contract.OldValue<int>(Count()) + 1);
        }

        /// <returns>true если очередь пуста, иначе false </returns>
        [Pure]
        public bool Empty() {
            return Count() == 0;
        }

        /// <returns>размер очереди</returns>
        [Pure]
        public virtual int Count() {
            Contract.Ensures(0 <= Contract.Result<int>());
            return default(int);
        }

        /// <summary>
        /// ensure: очередь пуста
        /// </summary>
        public virtual void Clear() {
            Contract.Ensures(Empty());
        }

        /// <summary>
        /// вспомогательный метод для отображения и просмотра очереди
        /// </summary>
        /// <returns>содержимое очереди в виде массива</returns>
        public abstract T[] ToArray();
    }

    // class PriorityQueue
    /// <summary>
    /// исключение возникает при нарушении контракта
    /// Класс содержит два конструктора
    /// </summary>
    public class QueueException : Exception {
        // Конструкторы, имеющиеся в базовом классе
        /// <summary>
        /// конструктор без параметра
        /// </summary>
        public QueueException() : base() { }

        /// <summary>
        /// конструктор с параметром
        /// </summary>
        public QueueException(string msg) : base(msg) { }
    }
}
