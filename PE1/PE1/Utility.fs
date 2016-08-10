namespace Program

module Utility =

    let multiplyListLong list = Seq.fold (fun acc elem -> acc * elem) 1L list

    let multiplyList list = Seq.fold (fun acc elem -> acc * elem) 1 list

