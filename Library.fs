namespace FSharp.AsyncUtil

module Async =
  let inline map mapping task = async {
    let! res = task
    return mapping res
  }

  let inline bind binding task = async {
    let! res = task
    return! binding res
  }

  let inline sync task = 
    task
    |> Async.RunSynchronously